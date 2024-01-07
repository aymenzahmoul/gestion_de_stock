using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeStock.RAP
{
    public partial class FRM_REPPORT : Form
    {
        public FRM_REPPORT()
        {
            InitializeComponent();
        }

        private void FRM_REPPORT_Load(object sender, EventArgs e)
        {

            this.RPAffiche.RefreshReport();
        }
    }
}
