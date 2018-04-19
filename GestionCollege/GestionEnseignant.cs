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
    public partial class GestionEnseignant : Form
    {
        public GestionEnseignant()
        {
            InitializeComponent();
        }

        private void GestionEnseignant_Load(object sender, EventArgs e)
        {

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
    }
}
