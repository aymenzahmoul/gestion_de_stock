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
    public partial class FRM_Menu : Form
    {
        public FRM_Menu()
        {
            InitializeComponent();
            panel1.Size = new Size(283, 759);
            pnlparametre.Visible = false;
        }
        //deactive
        public void deactiveform()
        {
            btnclient.Enabled = false;
            btncategorie.Enabled = false;
            button4.Enabled = false;
            btnproduit.Enabled = false;
            btnutilisateur.Enabled = false;
            btncopie.Enabled = false;
            btnrestaurer.Enabled = false;
            btndeconnecter.Enabled = false;
            pnlbut.Enabled = false;
            connecter.Enabled = true;
        }
        //activie
        public void activeform()
        {
            btnclient.Enabled = true;
            btncategorie.Enabled = true;
            button4.Enabled = true;
            btnproduit.Enabled = true;
            btnutilisateur.Enabled = true;
            btncopie.Enabled = true;
            btnrestaurer.Enabled = true;
            btndeconnecter.Enabled = true;
            pnlbut.Enabled = true;
            connecter.Enabled = false;
            pnlparametre.Visible = false;
        }
        private void FRM_Menu_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            pnlbut.Top = btnclient.Top;
            if (!pnlfichier.Controls.Contains(user_list_client.instance))
            {
                pnlfichier.Controls.Add(user_list_client.instance);
                user_list_client.instance.Dock = DockStyle.Fill;
                user_list_client.instance.BringToFront();
            }
            else
                user_list_client.instance.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pnlbut.Top = btnproduit.Top;

            if (!pnlfichier.Controls.Contains(User_liste_Produit.Instance))
            {
                pnlfichier.Controls.Add(User_liste_Produit.Instance);
                User_liste_Produit.Instance.Dock = DockStyle.Fill;
                User_liste_Produit.Instance.BringToFront();
            }
            else
            {
                User_liste_Produit.Instance.BringToFront();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pnlbut.Top = button4.Top;
            if (!pnlfichier.Controls.Contains(User_list_Commande.Instance))
            {
                pnlfichier.Controls.Add(User_list_Commande.Instance);
                User_list_Commande.Instance.Dock = DockStyle.Fill;
                User_list_Commande.Instance.BringToFront();
            }
            else
            {
                User_list_Commande.Instance.BringToFront();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 283)
            {
                panel1.Size = new Size(104, 759);

            }
            else
            {
                panel1.Size = new Size(283, 759);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pnlbut.Top = btncategorie.Top;


            if (!pnlfichier.Controls.Contains(USER_list_Categorie.Instance))
            {
                pnlfichier.Controls.Add(USER_list_Categorie.Instance);
                USER_list_Categorie.Instance.Dock = DockStyle.Fill;
                USER_list_Categorie.Instance.BringToFront();
            }
            else
            {
                USER_list_Categorie.Instance.BringToFront();
            }
        }

        private void btnutilisateur_Click(object sender, EventArgs e)
        {
            pnlbut.Top = btnutilisateur.Top;
        }

        private void btnparametre_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnparametre_Click_1(object sender, EventArgs e)
        {
            pnlparametre.Size = new Size(414, 164);
            pnlparametre.Visible = !pnlparametre.Visible;
        }

        private void connecter_Click(object sender, EventArgs e)
        {
            FRM_Connection frm_c = new FRM_Connection(this);
            frm_c.ShowDialog();
        }

        private void btndeconnecter_Click(object sender, EventArgs e)
        {
            deactiveform();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pnlparametre_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlfichier_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
