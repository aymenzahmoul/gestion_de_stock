using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.BL
{
    internal class CLS_Connexion
    {
        public bool ConnexionValide(GestionDeStock db,String nom,string mot_de_passe)
        {
            Utilisateur u = new Utilisateur();
            u.NomUtilisateur = nom;
            u.Mot_de_Passe = mot_de_passe;
            if(db.Utilisateurs.SingleOrDefault(s=>s.NomUtilisateur==nom&& s.Mot_de_Passe == mot_de_passe) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
