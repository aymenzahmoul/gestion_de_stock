using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using static System.Net.Mime.MediaTypeNames;

namespace GestionDeStock.PL
{
    public partial class User_liste_Produit : UserControl
    {
        private static User_liste_Produit UserProduit;
        private GestionDeStock db;
        public static User_liste_Produit Instance
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
        public void actualuserdvg()
        {
            db = new GestionDeStock();
            dvgproduit.Rows.Clear();
            Categorie Cat = new Categorie();
            foreach (var lis in db.Produits)
            {
                Cat = db.Categories.SingleOrDefault(s => s.ID_Categorie == lis.ID_Categorie);
                if (Cat != null)
                {
                    dvgproduit.Rows.Add(false, lis.ID_Produit, lis.Nom_Produit, lis.Prix_Produit, lis.Quantite_Produit, Cat.Nom_Categorie);
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void User_liste_Produit_Load(object sender, EventArgs e)
        {
            actualuserdvg();
        }
        public string verifie()
        {
            int nb = 0;
            for (int i = 0; i < dvgproduit.Rows.Count; i++)
            {
                if ((bool)dvgproduit.Rows[i].Cells[0].Value == true)
                {
                    nb++;
                }
            }
            if (nb == 0)
            {
                return "selectionne le produit ";
            }
            if (nb > 1)
            {
                return "selectionne une seul produit   ";
            }
            return null;
        }
            
        
        private void btnsuprimer_Click(object sender, EventArgs e)
        {
           if (verifie()== "selectionne le produit ")
            {
                MessageBox.Show(verifie(), "suppresion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult RS = MessageBox.Show("voulez vous vraiment supprime ", "suppresion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (RS == DialogResult.Yes)
                {
                    for (int i = 0; i < dvgproduit.Rows.Count; i++)
                    {
                        if ((bool)dvgproduit.Rows[i].Cells[0].Value == true)
                        {
                            if ((bool)dvgproduit.Rows[i].Cells[0].Value == true)
                            {
                                BL.CLS_produit cLs_Produit = new BL.CLS_produit();
                                int idselect = (int)dvgproduit.Rows[i].Cells[0].Value;
                                cLs_Produit.supprimer_produit(idselect);
                            }
                        }
                    }
                    actualuserdvg();
                    MessageBox.Show("produit supprime ", "suppresion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("suppression annule ", "suppresion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                
            }
        }

        private void txtrecherche_TextChanged(object sender, EventArgs e)
        {
        
            db = new GestionDeStock();
            var listerecherche = db.Produits.ToList();
           
            listerecherche = listerecherche.Where(s => s.Nom_Produit.IndexOf(txtrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
            dvgproduit.Rows.Clear();
            Categorie cat = new Categorie();

            foreach (var item in listerecherche)
            {
                cat = db.Categories.SingleOrDefault(s => s.ID_Categorie == item.ID_Categorie);
                dvgproduit.Rows.Add(false, item.ID_Produit,item.Nom_Produit,item.Quantite_Produit,item.Prix_Produit,cat.Nom_Categorie);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            PL.FRM_Ajoute_Produit frmproduit = new FRM_Ajoute_Produit(this);
            frmproduit.ShowDialog();
        }


        private void btnmodifer_Click(object sender, EventArgs e)
        {       
            Produit pr = new Produit();

            if (verifie() != null)
            {
                MessageBox.Show(verifie(), "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                PL.FRM_Ajoute_Produit frmproduits = new FRM_Ajoute_Produit(this);
                frmproduits.labtitre.Text = "Modifier Produit";
                frmproduits.btnActualise.Visible = false;
                for (int i = 0; i < dvgproduit.Rows.Count; i++)
                {
                    if ((bool)dvgproduit.Rows[i].Cells[0].Value == true)
                    {
                        int myselect = (int)dvgproduit.Rows[i].Cells[1].Value;
                        pr=db.Produits.SingleOrDefault(s=>s.ID_Produit == myselect);
                        if (pr != null)
                        {

                            frmproduits.idproduit = (int)dvgproduit.Rows[i].Cells[1].Value;
                            frmproduits.Categorie.Text = dvgproduit.Rows[i].Cells[5].Value.ToString();
                            frmproduits.tbnNom.Text = dvgproduit.Rows[i].Cells[2].Value.ToString();
                            frmproduits.btnQuantite.Text = dvgproduit.Rows[i].Cells[3].Value.ToString();

                            frmproduits.btnPrix.Text = dvgproduit.Rows[i].Cells[4].Value.ToString();
                            MemoryStream ms = new MemoryStream(pr.Image_Produit);
                            frmproduits.btnPicture.Image = Image.FromStream(ms);
                        }  
                    }
                }
                frmproduits.ShowDialog();
            }


        }
       

        private void imprimer_tout_Click(object sender, EventArgs e)
        {
           
            db = new GestionDeStock();
            try
            {
                RAP.FRM_REPPORT fRM_REPPORT = new RAP.FRM_REPPORT();
                var listeproduit = db.Produits.ToList();
                fRM_REPPORT.RPAffiche.LocalReport.ReportEmbeddedResource = "GestionDeStock.RAP.RPT_LISTES_PRODUITS.rdlc";

                fRM_REPPORT.RPAffiche.LocalReport.DataSources.Add(new ReportDataSource("Databaseproduit", listeproduit));

                ReportParameter data = new ReportParameter("Data", DateTime.Now.ToString());
                fRM_REPPORT.RPAffiche.LocalReport.SetParameters(new ReportParameter[] { data });
                fRM_REPPORT.RPAffiche.RefreshReport();
                fRM_REPPORT.ShowDialog();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

        private void sauvgarder_Click(object sender, EventArgs e)
        {

        }

        private void imprimer_PR_Click(object sender, EventArgs e)
        {
            int idselect = 0;
            string Nomcategorie=null;
            RAP.FRM_REPPORT fRM_REPPORT = new RAP.FRM_REPPORT();
            Produit pr = new Produit();
            if (verifie() != null)
            {
                MessageBox.Show(verifie(), "imprimer produit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int j = 0; j < dvgproduit.Rows.Count; j++)
                {
                    if ((bool)dvgproduit.Rows[j].Cells[0].Value == true)
                    {
                         idselect = (int)dvgproduit.Rows[j].Cells[1].Value;
                         Nomcategorie= dvgproduit.Rows[j].Cells[5].Value.ToString();
                    }
                }
                pr = db.Produits.SingleOrDefault(s => s.ID_Produit == idselect);

                if (pr != null)
               {
                         fRM_REPPORT.RPAffiche.LocalReport.ReportEmbeddedResource = "GestionDeStock.RAP.RPT_Produit.rdlc";
                         ReportParameter PCategorie = new ReportParameter("RPCategorie", Nomcategorie);
                         ReportParameter PNom = new ReportParameter("RPNom", pr.Nom_Produit);
                         ReportParameter PQuantite = new ReportParameter("RPQuantite", pr.Quantite_Produit.ToString());
                         ReportParameter RPrix = new ReportParameter("RPPrix", pr.Prix_Produit);
                         string imagestring = Convert.ToBase64String(pr.Image_Produit);
                         ReportParameter RPImage = new ReportParameter("RPImage", imagestring);
                        fRM_REPPORT.RPAffiche.LocalReport.SetParameters(new ReportParameter[] { PCategorie, PNom, PQuantite, RPrix, RPImage });
                        fRM_REPPORT.RPAffiche.RefreshReport();
                        fRM_REPPORT.ShowDialog();
                }
            }
         }
       

        private void button1_Click(object sender, EventArgs e)
        {
             Produit pr  = new Produit();
            if (verifie() != null)
            {
                MessageBox.Show(verifie(), "selection", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                for (int j = 0; j < dvgproduit.Rows.Count; j++) {
                    if ((bool)dvgproduit.Rows[j].Cells[0].Value == true)
                    {
                        int MYSELECT = (int)dvgproduit.Rows[j].Cells[1].Value;
                        pr = db.Produits.SingleOrDefault(s => s.ID_Produit == MYSELECT);
                        if (pr != null)
                        {
                            FRM_Photo_Produit frmp = new FRM_Photo_Produit();
                            MemoryStream ms = new MemoryStream(pr.Image_Produit);
                            frmp.produitimage.BackgroundImage = Image.FromStream(ms);
                            frmp.Produitname.Text = dvgproduit.Rows[j].Cells[2].Value.ToString();
                            frmp.ShowDialog();

                        }
                    }
                } 
            }
        }
    }
}