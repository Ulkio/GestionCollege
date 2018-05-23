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
    public partial class frmEtudiant : Form
    {
        public frmEtudiant()
        {
            InitializeComponent();
            List<string> Etudiants = new List<string>();
            Etudiants.AddRange(new string[] { "Jean", "Guillaume", "Maxence" });
            foreach (string value in Etudiants)
            {
                cbxEtudiants.Items.Add(value);
            }
        }

        private void btnFiche_Click(object sender, EventArgs e)
        {
            //frmGestionEtudiant gestionEtudiant = new frmGestionEtudiant();
            //gestionEtudiant.Show();
            //gestionEtudiant.Controls["textBox1"].Enabled = false;
            //gestionEtudiant.Controls["textBox2"].Enabled = false;
            //gestionEtudiant.Controls["textBox3"].Enabled = false;
            //gestionEtudiant.Controls["textBox4"].Enabled = false;
            //gestionEtudiant.Controls["textBox5"].Enabled = false;

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            //frmGestionEtudiant gestionEtudiant = new frmGestionEtudiant();
            //gestionEtudiant.Show();
            //gestionEtudiant.Controls["lblMatiereFiche"].Visible = false;
            //gestionEtudiant.Controls["lstCloneMatiereEtudiante"].Visible = false;
            //gestionEtudiant.Controls["btnOk"].Visible = false;
            //gestionEtudiant.Controls["btnValiderEtudiant"].Visible = true;
            //gestionEtudiant.Controls["btnAnnuler"].Visible = true;
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            cbxEtudiants.Items.Remove(cbxEtudiants.SelectedItem);
            cbxEtudiants.Text = ("");
        }


        private void btnRetour_Click(object sender, EventArgs e)
        {

        }

        private void btnAccueil_Click(object sender, EventArgs e)
        {
            frmAccueil accueil = new frmAccueil();
            this.Hide();
            accueil.ShowDialog();
            this.Close();
        }

        private void btnEditer_Click(object sender, EventArgs e)
        {
            //frmGestionEtudiant gestionEtudiant = new frmGestionEtudiant();
            //gestionEtudiant.Show();
            //gestionEtudiant.Controls["lblMatiereFiche"].Visible = false;
            //gestionEtudiant.Controls["lstCloneMatiereEtudiante"].Visible = false;
            //gestionEtudiant.Controls["btnOk"].Visible = false;
            //gestionEtudiant.Controls["btnValiderEtudiant"].Visible = true;
            //gestionEtudiant.Controls["btnAnnuler"].Visible = true;
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
