using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GestionDeStock.BL
{
    internal class CLS_produit
    {
        private GestionDeStock bd = new GestionDeStock();
        private Produit P;
        public bool Ajoute_Produit(string Nom_Produit, int Quantite_Produit, string Prix_Produit, Byte[] Image_Produit, int ID_Categorie)
        {
            P = new Produit();

            P.Nom_Produit = Nom_Produit;
            P.Prix_Produit = Prix_Produit;
            P.Quantite_Produit = Quantite_Produit;
            P.Image_Produit = Image_Produit;
            P.ID_Categorie = ID_Categorie;
            //verifier le nom existe
            if (bd.Produits.SingleOrDefault(s => s.Nom_Produit == Nom_Produit) == null)
            {
                bd.Produits.Add(P);
                bd.SaveChanges();
                return true;
            }
            else
                return false;
        }
        public void Modifier_Produit(int idproduit, string Nom_Produit, int Quantite_Produit, string Prix_Produit, Byte[] Image_Produit, int ID_Categorie)
        {
            P = new Produit();
            P = bd.Produits.SingleOrDefault(s => s.ID_Produit == idproduit);
            if (P != null)
            {
                P.Nom_Produit = Nom_Produit;
                P.Prix_Produit = Prix_Produit;
                P.Quantite_Produit = Quantite_Produit;
                P.Image_Produit = Image_Produit;
                P.ID_Categorie = ID_Categorie;

                bd.SaveChanges();

            }
        }
        public void supprimer_produit(int id)
        {
            P= new Produit();
            P= bd.Produits.SingleOrDefault(s => s.ID_Produit == id);
            if (P != null) 
            { 
             bd.Produits.Remove(P);
             bd.SaveChanges() ;
            }

        }
        
    }
}
