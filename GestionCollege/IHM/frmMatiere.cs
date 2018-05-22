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
    public partial class frmMatiere : Form
    {
        public frmMatiere()
        {
            InitializeComponent();
        }

        private void btnEditerDepartement_Click(object sender, EventArgs e)
        {
            frmGestionDepartement gestionDepartement = new frmGestionDepartement();
            gestionDepartement.ShowDialog();
        }

        private void btnEditerMatiere_Click(object sender, EventArgs e)
        {
            frmGestionMatiere gestionMatiere = new frmGestionMatiere();
            gestionMatiere.ShowDialog();
        }

        private void btnFicheEtudiants_Click(object sender, EventArgs e)
        {
            frmGestionEtudiant gestionEtudiant = new frmGestionEtudiant();
            gestionEtudiant.Show();
            gestionEtudiant.Controls["textBox1"].Enabled = false;
            gestionEtudiant.Controls["textBox2"].Enabled = false;
            gestionEtudiant.Controls["textBox3"].Enabled = false;
            gestionEtudiant.Controls["textBox4"].Enabled = false;
            gestionEtudiant.Controls["textBox5"].Enabled = false;
        }

        private void btnAjouterNote_Click(object sender, EventArgs e)
        {
            this.pnlAjouterNote.Visible = true;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            this.pnlAjouterNote.Visible = false;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.pnlAjouterNote.Visible = false;
        }

        private void btnFicheEnseignants_Click(object sender, EventArgs e)
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

        private void btnAccueil_Click(object sender, EventArgs e)
        {
            frmAccueil accueil = new frmAccueil();
            this.Hide();
            accueil.ShowDialog();
            this.Close();
        }



        private void btnQuitter_Click(object sender, EventArgs e)
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
                return; //annuler le ragequit
            }
        }
    }
}
