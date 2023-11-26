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
    public partial class FRM_Ajoute_Modifie_client : Form
    {
        private UserControl urclient;
        public FRM_Ajoute_Modifie_client(UserControl userC) 
        {
            InitializeComponent();
            this.urclient = userC;
        }

        string textObligatoire()
        {
            if(btnName.Text==""|| btnName.Text == "Nom de client")
            {
                return "entre le nom de client";
            }
            if (tbnPrenom.Text == "" || tbnPrenom.Text == "Prenom de client")
            {
                return "entre le prenom de client";
            }
            if (btnTelephone.Text == "" || btnTelephone.Text == "Telephone")
            {
                return "entre le Telephone de client";
            }
            return null;
        }
        private void btnquitte_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnName_Enter(object sender, EventArgs e)
        {
            if (btnName.Text== "Nom de client")
            {
                btnName.Text = "";
                btnName.ForeColor = Color.White;
            }
        }

        private void btnName_Leave(object sender, EventArgs e)
        {
            if (btnName.Text == "")
            {
                btnName.Text = "Nom de client";
                btnName.ForeColor = Color.Silver;
            }
        }

        private void tbnPrenom_Enter(object sender, EventArgs e)
        {
            if (tbnPrenom.Text == "Prenom de client")
            {
                tbnPrenom.Text = "";
                tbnPrenom.ForeColor = Color.White;
            }
        }

        private void tbnPrenom_Leave(object sender, EventArgs e)
        {
            if (tbnPrenom.Text == "")
            {
                tbnPrenom.Text = "Prenom de client";
                tbnPrenom.ForeColor = Color.Silver;
            }
        }

        private void btnAdresse_Enter(object sender, EventArgs e)
        {
            if (btnAdresse.Text == "Adresse")
            {
                btnAdresse.Text = "";
                btnAdresse.ForeColor = Color.White;
            }

        }

        private void btnAdresse_Leave(object sender, EventArgs e)
        {
            if (btnAdresse.Text == "")
            {
                btnAdresse.Text = "Adresse";
                btnAdresse.ForeColor = Color.Silver;
            }
        }

        private void btnTelephone_Enter(object sender, EventArgs e)
        {
            if (btnTelephone.Text == "Telephone")
            {
                btnTelephone.Text = "";
                btnTelephone.ForeColor = Color.White;
            }

        }

        private void btnTelephone_Leave(object sender, EventArgs e)
        {
            if (btnTelephone.Text == "")
            {
                btnTelephone.Text = "Telephone";
                btnTelephone.ForeColor = Color.Silver;
            }
        }

        private void btnEmail_Enter(object sender, EventArgs e)
        {
            if (btnEmail.Text == "Email")
            {
                btnEmail.Text = "";
                btnEmail.ForeColor = Color.White;
            }
        }

        private void btnEmail_Leave(object sender, EventArgs e)
        {
            if (btnEmail.Text == "")
            {
                btnEmail.Text = "Email";
                btnEmail.ForeColor = Color.Silver;
            }
        }

        private void btnPays_Enter(object sender, EventArgs e)
        {
            if (btnPays.Text == "Pays")
            {
                btnPays.Text = "";
                btnPays.ForeColor = Color.White;
            }
        }

        private void btnPays_Leave(object sender, EventArgs e)
        {
            if (btnPays.Text == "")
            {
                btnPays.Text = "Pays";
                btnPays.ForeColor = Color.Silver;
            }
        }

        private void btnVille_Enter(object sender, EventArgs e)
        {
            if (btnVille.Text == "Ville")
            {
                btnVille.Text = "";
                btnVille.ForeColor = Color.White;
            }
        }

        private void btnVille_Leave(object sender, EventArgs e)
        {
            if (btnVille.Text == "")
            {
                btnVille.Text = "Ville";
                btnVille.ForeColor = Color.Silver;
            }
        }

        private void btnTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }
        public int IDselect;
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (textObligatoire()!=null)
            {
                MessageBox.Show(textObligatoire(),"Obligatoire", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            if (labtitre.Text=="Ajouter Client")
            {
                BL.CLS_Client clclient = new BL.CLS_Client();
                if (clclient.Ajoute_client(btnName.Text, tbnPrenom.Text, btnAdresse.Text ,btnEmail.Text, btnTelephone.Text , btnPays.Text, btnVille.Text) == true)
                {
                    MessageBox.Show("client ajouter avec succes","Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    (urclient as user_list_client).actualise();
                }
                else
                {

                    MessageBox.Show("le nom et prenom deja existe", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                BL.CLS_Client clclient = new BL.CLS_Client();
               
                DialogResult R = MessageBox.Show("voulez vous vraiment modifier le client ", "modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R== DialogResult.Yes)
                {
                    clclient.modifie_client(IDselect, btnName.Text, tbnPrenom.Text, btnAdresse.Text, btnEmail.Text, btnTelephone.Text, btnPays.Text, btnVille.Text);
                    (urclient as user_list_client).actualise();
                    MessageBox.Show(" client modifier avec succes ", "modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("modification annule ", "modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnActualise_Click(object sender, EventArgs e)
        {
            btnName.Text = "Nom de client";btnName.ForeColor = Color.White;
            tbnPrenom.Text = "Prenom de client"; tbnPrenom.ForeColor = Color.White;
            btnAdresse.Text = "Adresse"; btnAdresse.ForeColor = Color.White;
            btnEmail.Text = "Email"; btnEmail.ForeColor = Color.White;
            btnTelephone.Text = "Telephone"; btnTelephone.ForeColor = Color.White;
            btnPays.Text = "Pays"; btnPays.ForeColor = Color.White;
            btnVille.Text = "Ville"; btnVille.ForeColor = Color.White;
        }

        private void FRM_Ajoute_Modifie_client_Load(object sender, EventArgs e)
        {

        }

        private void btnName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
