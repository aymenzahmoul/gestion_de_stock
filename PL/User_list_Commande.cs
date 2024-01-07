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
    public partial class User_list_Commande : UserControl
    {
        private static User_list_Commande User_List_Commande;
        private GestionDeStock db;
        public static User_list_Commande Instance
        {
            get
            {
                if (User_List_Commande == null)
                {
                    User_List_Commande = new User_list_Commande();
                }
                return User_List_Commande;
            }
        }
        public User_list_Commande()
        {
            InitializeComponent();
            db = new GestionDeStock();
        }

        private void txtrecherche_TextChanged(object sender, EventArgs e)
        {

        }

        private void User_list_Commande_Load(object sender, EventArgs e)
        {

        }
    }
}
