using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GestionDeStock.PL
{
    public partial class user_list_client : UserControl
    {
        private static user_list_client UserClient;
        private GestionDeStock db;
        public static user_list_client instance
        {
            get
            {
                if (UserClient == null)
                {
                    UserClient = new user_list_client();
                }
                return UserClient;
            }
        }

        public user_list_client()
        {
            InitializeComponent();
            db = new GestionDeStock();
            txtrecherche.Enabled = false;
        }

        public void actualise()
        {
            db = new GestionDeStock();
            dvgclient.Rows.Clear();
            foreach(var s in db.Clients)
            {
                dvgclient.Rows.Add(false, s.ID_Client, s.Nom_client, s.Prenom_client, s.Adresse_client, s.Email_client, s.Telephone_client ,s.Pays_client, s.Ville_client);
            }
        }
        public string verifie()
        {
                int nb = 0;
                for(int i = 0; i < dvgclient.Rows.Count; i++)
                {
                    if ((bool)dvgclient.Rows[i].Cells[0].Value == true)
                    {
                        nb++;
                    }
                }
                if (nb == 0)
                {
                    return "selectionne le client ";
                }
                if (nb >1)
                {
                    return "selectionne une seul client   ";
                }
                return null;
         }
           
        
        private void user_list_client_Load(object sender, EventArgs e)
        {
            actualise();

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtrecherche.Text == "Recherche")
            {
                txtrecherche.Text = "";
                txtrecherche.ForeColor = Color.Black;
            }
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            PL.FRM_Ajoute_Modifie_client frmclient = new FRM_Ajoute_Modifie_client(this);
            frmclient.ShowDialog();
        }
       
        private void btnmodifer_Click(object sender, EventArgs e)
        {
            PL.FRM_Ajoute_Modifie_client frmclient = new FRM_Ajoute_Modifie_client(this);
            if (verifie() == null)
            {
                for (int i = 0; i < dvgclient.Rows.Count; i++)
                {
                    if ((bool)dvgclient.Rows[i].Cells[0].Value == true)
                    {
                        frmclient.IDselect = (int)dvgclient.Rows[i].Cells[1].Value;
                        frmclient.btnName.Text = dvgclient.Rows[i].Cells[2].Value.ToString();
                        frmclient.tbnPrenom.Text = dvgclient.Rows[i].Cells[3].Value.ToString();
                        frmclient.btnAdresse.Text = dvgclient.Rows[i].Cells[4].Value.ToString();
                        frmclient.btnEmail.Text = dvgclient.Rows[i].Cells[5].Value.ToString();
                        frmclient.btnTelephone.Text = dvgclient.Rows[i].Cells[6].Value.ToString();
                        frmclient.btnPays.Text = dvgclient.Rows[i].Cells[7].Value.ToString();
                        frmclient.btnVille.Text = dvgclient.Rows[i].Cells[8].Value.ToString();
                    }
                }
                    
                frmclient.labtitre.Text = "Modifier client";
                frmclient.btnActualise.Visible = false;
                frmclient.ShowDialog();
            }
            else
            {
                MessageBox.Show(verifie(), "selectionn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsuprimer_Click(object sender, EventArgs e)
        {
            BL.CLS_Client client = new BL.CLS_Client();
            int select = 0;
            for (int i = 0; i < dvgclient.Rows.Count; i++)
            {
                if ((bool)dvgclient.Rows[i].Cells[0].Value == true)
                {
                    select++;
                }
                if (select == 0)
                {
                    MessageBox.Show("aucun client selection", "selection", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    DialogResult R =
                        MessageBox.Show("voulez vous vriement supprimer", "supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (R == DialogResult.Yes)
                    {
                        for (int j = 0; j < dvgclient.Rows.Count; j++)
                        {
                            if ((bool)dvgclient.Rows[j].Cells[0].Value == true)
                            {
                                client.supprime(int.Parse(dvgclient.Rows[j].Cells[1].Value.ToString()));
                            }
                        }
                        actualise();
                        MessageBox.Show("client supprimer", "supprimer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    }else
                    {
                        MessageBox.Show("supprimer et annuler", "supprimer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void txtrecherche_TextChanged(object sender, EventArgs e)
        {
            db = new GestionDeStock();
            var listerecherche=db.Clients.ToList();
            if (txtrecherche.Text != "")
            {
                switch (combrecherche.Text) {
                    case "Nom":
                        listerecherche= listerecherche.Where(s=>s.Nom_client.IndexOf(txtrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList(); 
                        break;
                    case "Prenom":
                        listerecherche = listerecherche.Where(s => s.Prenom_client.IndexOf(txtrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Adresse":
                        listerecherche = listerecherche.Where(s => s.Adresse_client.IndexOf(txtrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Email":
                        listerecherche = listerecherche.Where(s => s.Email_client.IndexOf(txtrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    
                    case "Telephone":
                        listerecherche = listerecherche.Where(s => s.Telephone_client.IndexOf(txtrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Pays":
                        listerecherche = listerecherche.Where(s => s.Pays_client.IndexOf(txtrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Ville":
                        listerecherche = listerecherche.Where(s => s.Ville_client.IndexOf(txtrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                }
            }
            dvgclient.Rows.Clear();
            

            foreach (var item in listerecherche)
            {
                dvgclient.Rows.Add(false, item.ID_Client, item.Nom_client, item.Prenom_client, item.Adresse_client, item.Telephone_client, item.Email_client, item.Pays_client, item.Ville_client);
            }


       
        }

        private void dvgclient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void combrecherche_SelectedIndexChanged(object sender, EventArgs e)
        {
            //activie le textbx de recherche
            txtrecherche.Enabled = true;
            txtrecherche.Text = "";
        }
    }
}
