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
    public partial class FRM_Connection : Form
    {
        private GestionDeStock db;
        private Form frmenu;
        //classe
        BL.CLS_Connexion c = new BL.CLS_Connexion();
        public FRM_Connection(Form menu)
        {
            InitializeComponent();
            this.frmenu = menu;
            db = new GestionDeStock();
        }
        //pour valide le choinx 
        String testObligatoire()
        {
            if (btntext.Text == "Nom d'utilisateur"|| btntext.Text == "")
            {
                return "entre votre Nom";
            }
            if (btnMotedepass.Text == "Mot De Passe" || btnMotedepass.Text == "")
            {
                return "entre votre Mot de passe";
            }
            return null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnquitte_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (btntext.Text == "Nom d'utilisateur")
            {
                btntext.Text = "";
                btntext.ForeColor = Color.WhiteSmoke;
            }
        }

        private void btnMotedepass_Enter(object sender, EventArgs e)
        {
            if (btnMotedepass.Text== "Mot De Passe")
            {
                btnMotedepass.Text = "";
                btnMotedepass.UseSystemPasswordChar = false;
                btnMotedepass.PasswordChar = '*';
                btnMotedepass.ForeColor = Color.WhiteSmoke;
            }
        }

        private void btntext_Leave(object sender, EventArgs e)
        {
            if (btntext.Text == "")
            {
                btntext.Text = "Nom d'utilisateur";
                btnMotedepass.UseSystemPasswordChar = true;
                btntext.ForeColor = Color.WhiteSmoke;
            }
        }

        private void btnMotedepass_Leave(object sender, EventArgs e)
        {
            if (btnMotedepass.Text == "")
            {
                btnMotedepass.Text = "Mot De Passe";
                btnMotedepass.ForeColor = Color.WhiteSmoke;
            }
        }

        private void btnConnecter_Click(object sender, EventArgs e)
        {
            if (testObligatoire()==null)
            {
                if (c.ConnexionValide(db, btntext.Text, btnMotedepass.Text) == true)
                {
                    MessageBox.Show("connexion a reussi","connexion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    (frmenu as FRM_Menu ).activeform();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("connexion a echoue", "connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else
            {
                MessageBox.Show(testObligatoire(),"obligatoire",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
