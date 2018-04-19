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
    public partial class frmGestionSalle : Form
    {
        public frmGestionSalle()
        {
            InitializeComponent();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            this.pnlModifierSalle.Visible = false;
            this.pnlNouvelleSalle.Visible = true;
        }

        private void btnValiderNouvelleSalle_Click(object sender, EventArgs e)
        {
            this.pnlNouvelleSalle.Visible = false;
            this.lstSalle.Items.Add(txtAjouterSalle.Text);
        }

        private void btnAnnulerNouvelleSalle_Click(object sender, EventArgs e)
        {
            this.pnlNouvelleSalle.Visible = false;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            this.pnlModifierSalle.Visible = true;
            this.pnlNouvelleSalle.Visible = false;
        }

        private void btnValiderModifier_Click(object sender, EventArgs e)
        {
            this.pnlModifierSalle.Visible = false;
        }

        private void btnAnnulerModifier_Click(object sender, EventArgs e)
        {
            this.pnlModifierSalle.Visible = false;
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            this.lstSalle.Items.Remove(lstSalle.SelectedItem);
        }
    }
}
