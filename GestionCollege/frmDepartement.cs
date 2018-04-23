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
    public partial class frmDepartement : Form
    {
        public frmDepartement()
        {
            InitializeComponent();

            List<object> ListDpt = new List<object>();
            ListDpt.AddRange(new string[] { "Sciences", "Langues", "Histoire-Géographie", "Activités sportives et culturelles" });
            foreach (object dpt in ListDpt)
            {
                lstDepartement.Items.Add(dpt);
            }

            List<object> ListEns = new List<object>();
            ListEns.AddRange(new string[] { "Jacques OUILLE", "Pierre KIROUL" });
            foreach (object ens in ListEns)
            {
                lstEnseignants.Items.Add(ens);
            }

            List<object> ListMat = new List<object>();
            ListMat.AddRange(new string[] { "Mathématiques", "Français", "Histoire", "Sport" });
            foreach (object mat in ListMat)
            {
                lstMatieres.Items.Add(mat);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            frmGestionDepartement gestion = new frmGestionDepartement();
            try
            {
                gestion.Controls["txtDepartement"].Text = lstDepartement.SelectedItem.ToString();
                gestion.Show();

            }
            catch (Exception)
            {
                MessageBox.Show("Veuillez sélectionner un département à modifier");
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            lstDepartement.Items.Remove(lstDepartement.SelectedItem);
        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            frmGestionDepartement gestion = new frmGestionDepartement();
            gestion.Show();
            
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

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            frmMatiere matiere = new frmMatiere();
            this.Hide();
            matiere.ShowDialog();
            this.Close();
        }

        private void lstEnseignants_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstEnseignants.SelectedIndex >= 0)
            {
                btnFiche.Enabled = true;
            }
        }

        private void lstMatieres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMatieres.SelectedIndex >= 0)
            {
                btnAcceder.Enabled = true;
            }
        }

        private void btnAccueil_Click(object sender, EventArgs e)
        {
            frmAccueil accueil = new frmAccueil();
            this.Hide();
            accueil.ShowDialog();
            this.Close();
        }

        private void frmDepartement_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rep;

            rep = MessageBox.Show("Voulez vous vraiment quitter", "Terminer?",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rep == DialogResult.Yes) //si l’arrêt est annulé par l'opérateur
            {
                Application.ExitThread();

            }
            if (rep == DialogResult.No) //si l’arrêt est annulé par l'opérateur
            {
                e.Cancel = true; // annuler l'événement en cours
            }
        }
    }
}
