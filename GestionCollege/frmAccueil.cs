﻿using System;
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
    public partial class frmAccueil : Form
    {
        public frmAccueil()
        {
            InitializeComponent();
        }


        private void btnDepartements_Click(object sender, EventArgs e)
        {
            Departement dpt = new Departement();
            this.Hide();
            dpt.ShowDialog();
            this.Close();
        }

        private void btnEnseignants_Click(object sender, EventArgs e)
        {
            Enseignant enseignant = new Enseignant();
            this.Hide();
            enseignant.ShowDialog();
            this.Close();
        }

        private void btnEtudiants_Click(object sender, EventArgs e)
        {
            frmEtudiant etudiant = new frmEtudiant();
            this.Hide();
            etudiant.ShowDialog();
            this.Close();
        }

        private void btnMatieres_Click(object sender, EventArgs e)
        {
            frmMatiere matiere = new frmMatiere();
            this.Hide();
            matiere.ShowDialog();
            this.Close();
        }

        private void btnSalle_Click(object sender, EventArgs e)
        {
            frmSalle salle = new frmSalle();
            this.Hide();
            salle.ShowDialog();
            this.Close();
        }

        private void frmAccueil_FormClosing(object sender, FormClosingEventArgs e)
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
