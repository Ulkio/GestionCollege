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
    public partial class frmEnseignant : Form
    {
        public frmEnseignant()
        {
            InitializeComponent();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            frmGestionEnseignant gestion = new frmGestionEnseignant();
            try
            {
                gestion.Controls["txtNom"].Text = lstEnseignants.SelectedItem.ToString();
                gestion.Show();

            }
            catch (Exception)
            {
                MessageBox.Show("Veuillez sélectionner un enseignant à modifier");
            }

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            lstEnseignants.Items.Remove(lstEnseignants.SelectedItem);

        }

        private void btnFiche_Click(object sender, EventArgs e)
        {
            frmGestionEnseignant gestion = new frmGestionEnseignant();
            gestion.Show();
            gestion.Controls["txtNom"].Enabled = false;
            gestion.Controls["txtPrenom"].Enabled = false;
            gestion.Controls["txtTel"].Enabled = false;
            gestion.Controls["txtMail"].Enabled = false;
            gestion.Controls["txtDate"].Enabled = false;
            gestion.Controls["btnConfirmer"].Visible = false;
            gestion.Controls["btnAnnuler"].Visible = false;
            gestion.Controls["btnOK"].Visible = true;
            gestion.Controls["btnValiderEnseignant"].Visible = false;
            gestion.Controls["panel1"].Visible = true;


        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            frmGestionEnseignant gestion = new frmGestionEnseignant();
            gestion.Show();

        }

        private void btnAccueil_Click(object sender, EventArgs e)
        {
            frmAccueil accueil = new frmAccueil();
            this.Hide();
            accueil.ShowDialog();
            this.Close();
        }

        private void Enseignant_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rep;

            rep = MessageBox.Show("Voulez vous vraiment quitter", "Terminer?",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rep == DialogResult.No) //si l’arrêt est annulé par l'opérateur
            {
                e.Cancel = true; // annuler l'événement en cours
            };
        }
    }
}
