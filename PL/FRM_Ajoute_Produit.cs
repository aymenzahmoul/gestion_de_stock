using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using GestionDeStock.BL;
using System.Diagnostics.Eventing.Reader;

namespace GestionDeStock.PL
{
    public partial class FRM_Ajoute_Produit : Form
    {
        private GestionDeStock db;
        private UserControl userProduit;
            public FRM_Ajoute_Produit(UserControl user)
        {
            InitializeComponent();
            db = new GestionDeStock();
            this.userProduit = user;    
            Categorie.DataSource = db.Categories.ToList();
            Categorie.DisplayMember = "Nom_Categorie";
            Categorie.ValueMember = "ID_Categorie";
        }   
        string textObligatoire()
        {
            if (tbnNom.Text == "" || tbnNom.Text == "Nom Produit")
            {
                return "entre le nom de produit";
            }
            if (btnQuantite.Text == "" || btnQuantite.Text == "Quantite")
            {
                return "entre le quantite  produit";
            }
            if (btnPrix.Text == "" || btnPrix.Text == "Prix")
            {
                return "entre le prix";
            }
            if (Categorie.Text == "")
            {
                return "entre le categorie";
            }
            return null;
        }
        private void FRM_Ajoute_Produit_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbnNom_Enter(object sender, EventArgs e)
        {
            if (tbnNom.Text == "Nom Produit")
            {
                tbnNom.Text = "";
                tbnNom.ForeColor = Color.White;
            }
        }

        private void tbnNom_Leave(object sender, EventArgs e)
        {
            if (tbnNom.Text == "")
            {
                tbnNom.Text = "Nom Produit";
                tbnNom.ForeColor = Color.Silver;
            }
        }

        private void btnQuantite_Enter(object sender, EventArgs e)
        {
            if (btnQuantite.Text == "Quantite")
            {
                btnQuantite.Text = "";
                btnQuantite.ForeColor = Color.White;
            }
        }

        private void btnQuantite_Leave(object sender, EventArgs e)
        {
            if (btnQuantite.Text == "")
            {
                btnQuantite.Text = "Quantite";
                btnQuantite.ForeColor = Color.Silver;
            }
        }

        private void btnPrix_Enter(object sender, EventArgs e)
        {
            if (btnPrix.Text == "Prix")
            {
                btnPrix.Text = "";
                btnPrix.ForeColor = Color.White;
            }
        }

        private void btnPrix_Leave(object sender, EventArgs e)
        {
            if (btnPrix.Text == "")
            {
                btnPrix.Text = "Prix";
                btnPrix.ForeColor = Color.Silver;
            }
        }

        private void btnquitte_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnParcourie_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "|*.JPG.*.PNG;*.GIF;*.BMP";
            if (open.ShowDialog() == DialogResult.OK)
            {
                btnPicture.Image = Image.FromFile(open.FileName);
            }
        }

        private void btnActualise_Click(object sender, EventArgs e)
        {
            tbnNom.Text = "Nom Produit"; tbnNom.ForeColor = Color.White;
            btnQuantite.Text = "Quantite"; btnQuantite.ForeColor = Color.White;
            btnPrix.Text = "Prix"; btnPrix.ForeColor = Color.White;
            Categorie.Text = "";
            btnPicture.Image = null;
        }

        private void btnQuantite_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnQuantite_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnPrix_KeyPress(object sender, KeyPressEventArgs e)
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
        public int idproduit;
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (textObligatoire() != null)
            {
                MessageBox.Show(textObligatoire(), "obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                if (labtitre.Text=="Ajouter Produit")
                {
                    BL.CLS_produit produits = new BL.CLS_produit();
                    MemoryStream m = new MemoryStream();
                    btnPicture.Image.Save(m, btnPicture.Image.RawFormat);
                    Byte[] bytimage = m.ToArray();
                    if (produits.Ajoute_Produit(tbnNom.Text,int.Parse(btnQuantite.Text), btnPrix.Text, bytimage,Convert.ToInt32 (Categorie.SelectedValue))==true)
                    {
                        MessageBox.Show("produit ajoute avec succee !!", "Ajoute",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (userProduit as User_liste_Produit).actualuserdvg();
                    }else
                    {
                        MessageBox.Show("produit existe ", "Ajoute", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    
                    MemoryStream m = new MemoryStream();
                    btnPicture.Image.Save(m, btnPicture.Image.RawFormat);
                    Byte[] bytimage = m.ToArray();
                    BL.CLS_produit clsproduits = new BL.CLS_produit();
                    DialogResult RS = MessageBox.Show("voulez vous vraiment modifie ", "modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (RS == DialogResult.Yes)
                    {
                        clsproduits.Modifier_Produit(idproduit, tbnNom.Text, int.Parse(btnQuantite.Text), btnPrix.Text, bytimage, Convert.ToInt32(Categorie.SelectedValue));
                        MessageBox.Show("produit modifie avec succee !!", "modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (userProduit as User_liste_Produit).actualuserdvg();
                        Close();
                       
                    }
                    else
                    {
                        MessageBox.Show("modification annule", "modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
        }
    }
}
