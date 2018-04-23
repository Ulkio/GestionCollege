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
    public partial class frmGestionEnseignant : Form
    {
        public frmGestionEnseignant()
        {
            InitializeComponent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValiderEnseignant_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void frmGestionEnseignant_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
