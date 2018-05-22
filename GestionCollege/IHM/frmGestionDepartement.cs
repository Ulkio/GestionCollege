using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCollege
{
    public partial class frmGestionDepartement : Form
    {
        public frmGestionDepartement()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGestionDepartement_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
