using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.BL
{
    internal class CLS_Client
    {
        private GestionDeStock bd = new GestionDeStock();
        private Client c;
        public bool Ajoute_client(string Nom,string prenom,string Adresse, string telephone, string Email,string Pays,string ville )
        {
            c = new Client();
            c.Nom_client = Nom;
            c.Telephone_client = telephone;
            c.Pays_client = Pays;
            c.Ville_client = ville;
            c.Adresse_client = Adresse;
            c.Email_client = Email;
            c.Prenom_client = prenom;
            //verifier le nom existe
            if (bd.Clients.SingleOrDefault(s => s.Nom_client == Nom && c.Prenom_client == prenom) == null)
            {
                bd.Clients.Add(c);
                bd.SaveChanges();
                return true;
            }
            else
                return false;
        }

        public void modifie_client(int id,string Nom, string prenom, string Adresse, string telephone, string Email, string Pays, string ville)
        {
            c = new Client();
            c = bd.Clients.SingleOrDefault(s => s.ID_Client == id);
            if (c!= null)
            {
                c.Nom_client = Nom;
                c.Telephone_client = telephone;
                c.Pays_client = Pays;
                c.Ville_client = ville;
                c.Adresse_client = Adresse;
                c.Email_client = Email;
                c.Prenom_client = prenom;
                
                bd.SaveChanges();
               
            }
        }
        public void supprime(int id)
        {
            c = new Client();
            c = bd.Clients.SingleOrDefault(s => s.ID_Client == id);
            if (c != null)
            {
                bd.Clients.Remove(c);
                bd.SaveChanges();
            }
            
                
            
        }
    }
}
