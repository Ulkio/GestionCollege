using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GestionCollege
{
    public partial class frmEtudiant : Form
    {

        private DAO.DAOetudiant daoEtu;
        private DAO.Connect connect;


        public frmEtudiant()
        {
            InitializeComponent();
        }

        private void frmEtudiant_Load(object sender, EventArgs e)
        {
            daoEtu = new DAO.DAOetudiant();    
            dgvEtudiant.DataSource = daoEtu.DisplayData();
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
            try
            {
                daoEtu.save();
                daoEtu.sqlCde.Parameters.AddWithValue("@nom", txtNom.Text);
                daoEtu.sqlCde.Parameters.AddWithValue("@prenom", txtPrenom.Text);
                daoEtu.sqlCde.Parameters.AddWithValue("@date", txtDateEntree.Text);
                daoEtu.sqlCde.Parameters.AddWithValue("@tel", txtTel.Text);
                daoEtu.sqlCde.Parameters.AddWithValue("@mail", txtMail.Text);
                daoEtu.sqlCde.ExecuteNonQuery();
                MessageBox.Show("Enregistrement réeussi");
                dgvEtudiant.DataSource = daoEtu.DisplayData();
            }
            catch
            {
                MessageBox.Show("Veuillez spécifier les caractéristiques de l'étudiant");
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

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
