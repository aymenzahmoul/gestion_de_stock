using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeStock.PL
{
    public partial class User_liste_Produit : UserControl
    {
        private static User_liste_Produit UserProduit;
        private GestionDeStock db;
        public static User_liste_Produit instance
        {
            get
            {
                if (UserProduit == null)
                {
                    UserProduit = new User_liste_Produit();
                }
                return UserProduit;
            }
        }
        public User_liste_Produit()
        {
            InitializeComponent();
            db = new GestionDeStock();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void User_liste_Produit_Load(object sender, EventArgs e)
        {

        }

        private void btnsuprimer_Click(object sender, EventArgs e)
        {

        }

        private void txtrecherche_TextChanged(object sender, EventArgs e)
        {
            if (txtrecherche.Text == "Recherche")
            {
                txtrecherche.Text = "";
                txtrecherche.ForeColor = Color.Black;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            PL.FRM_Ajoute_Produit frmproduit = new FRM_Ajoute_Produit();
            frmproduit.ShowDialog();
        }

        private void btnmodifer_Click(object sender, EventArgs e)
        {
            PL.FRM_Ajoute_Produit frmproduit = new FRM_Ajoute_Produit();
            /*  if (verifie() == null)
              {
                  for (int i = 0; i < dvgproduit .Rows.Count; i++)
                  {
                      if ((bool)dvgclient.Rows[i].Cells[0].Value == true)
                      {
                          frmproduit.IDselect = (int)dvgclient.Rows[i].Cells[1].Value;
                          frmproduit.btnName.Text = dvgclient.Rows[i].Cells[2].Value.ToString();
                          frmproduit.tbnPrenom.Text = dvgclient.Rows[i].Cells[3].Value.ToString();
                          frmproduit.btnAdresse.Text = dvgclient.Rows[i].Cells[4].Value.ToString();
                          frmproduit.btnEmail.Text = dvgclient.Rows[i].Cells[5].Value.ToString();
                          frmproduit.btnTelephone.Text = dvgclient.Rows[i].Cells[6].Value.ToString();
                          frmproduit.btnPays.Text = dvgclient.Rows[i].Cells[7].Value.ToString();
                          frmproduit.btnVille.Text = dvgclient.Rows[i].Cells[8].Value.ToString();
                      }
                  }
            */
            frmproduit.labtitre.Text = "Modifier Produit";
            frmproduit.btnActualise.Visible = false;
            frmproduit.ShowDialog(); 
            }
 /*           else
            {
                MessageBox.Show(verifie(), "selectionn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
    }
