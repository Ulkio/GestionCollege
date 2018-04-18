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
    public partial class frmGestionMatiere : Form
    {
        public frmGestionMatiere()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            this.pnlNouvelleMatieres.Visible = true;
            this.pnlModifierMatieres.Visible = false;
        }

        private void btnValiderNouvelleMatiere_Click(object sender, EventArgs e)
        {
            this.lstMatieres.Items.Add(txtAjouter.Text);
            this.pnlNouvelleMatieres.Visible = false;
            
        }

        private void btnAnnulerNouvelleMatiere_Click(object sender, EventArgs e)
        {
            this.pnlNouvelleMatieres.Visible = false;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            this.pnlModifierMatieres.Visible = true;
            this.pnlNouvelleMatieres.Visible = false;
        }

        private void btnValiderModifierMatiere_Click(object sender, EventArgs e)
        {
            this.pnlModifierMatieres.Visible = false;
        }

        private void btnAnnulerModifierMatiere_Click(object sender, EventArgs e)
        {
            this.pnlModifierMatieres.Visible = false;
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            this.lstMatieres.Items.Remove(lstMatieres.SelectedItem);
        }
    }
}
