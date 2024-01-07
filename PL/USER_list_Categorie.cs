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
    public partial class USER_list_Categorie : UserControl
    {

        private static USER_list_Categorie User_List_Commande;
        private GestionDeStock db;
        public static USER_list_Categorie Instance
        {
            get
            {
                if (User_List_Commande == null)
                {
                    User_List_Commande = new USER_list_Categorie();
                }
                return User_List_Commande;
            }
        }
        public USER_list_Categorie()
        {
            InitializeComponent();
            db = new GestionDeStock();
        }

        private void txtrecherche_TextChanged(object sender, EventArgs e)
        {
            if (txtrecherche.Text== "Recherche")
            {
                txtrecherche.Text = "";
                txtrecherche.ForeColor = Color.Black;
            }
        }

        private void USER_list_Categorie_Load(object sender, EventArgs e)
        {

        }
    }
}
