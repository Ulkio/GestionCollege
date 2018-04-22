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
    public partial class frmGestionEtudiant : Form
    {
        public frmGestionEtudiant()
        {
            InitializeComponent();

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValiderEtudiant_Click(object sender, EventArgs e)
        {
            this.Controls["pnlMatiereEtudiant"].Visible = true;
            this.Controls["textBox1"].Enabled = false;
            this.Controls["textBox2"].Enabled = false;
            this.Controls["textBox3"].Enabled = false;
            this.Controls["textBox4"].Enabled = false;
            this.Controls["textBox5"].Enabled = false;
            btnConfirmer.Visible = true;

        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjoute_Click(object sender, EventArgs e)
        {
            //ajoute en list box
            object selectedItem = this.cbxMatieres.SelectedItem;
            this.lstMatiereEtudiant.Items.Add(selectedItem);
            //retire de la combo box
            this.cbxMatieres.Items.Remove(this.cbxMatieres.SelectedItem);

            //Désactive le bouton ajoute
            this.btnAjoute.Enabled = false;
            //Désactive le boutons ajouteTOUT si liste source vide
            if (this.cbxMatieres.Items.Count == 0)
            {
                this.btnAjouteTout.Enabled = false;
            }
            //active le bouton SupprimeTout
            this.btnSupprimeTout.Enabled = true;
        }

        private void btnAjouteTout_Click(object sender, EventArgs e)
        {
            //ajoute un à un les éléments de la collection
            foreach (Object element in this.cbxMatieres.Items)
            {
                this.lstMatiereEtudiant.Items.Add(element);
            }
            //vide la collection de la combobox Source
            this.cbxMatieres.Items.Clear();

            //désactive les boutons d'ajouts
            this.btnAjoute.Enabled = false;
            this.btnAjouteTout.Enabled = false;
            //active le bouton SupprimeTout
            this.btnSupprimeTout.Enabled = true;
        }

        private void btnSupprime_Click(object sender, EventArgs e)
        {
            //ajoute en combo box
            this.cbxMatieres.Items.Add(this.lstMatiereEtudiant.SelectedItem);
            //retire de la list
            this.lstMatiereEtudiant.Items.Remove(this.lstMatiereEtudiant.SelectedItem);

            //Désactiver le bouton supprimer
            this.btnSupprime.Enabled = false;

            //désactiver le bouton supprimerTOUT si la liste est vide
            if (this.lstMatiereEtudiant.Items.Count == 0)
            {
                this.btnSupprimeTout.Enabled = false;
            }
        }

        private void btnSupprimeTout_Click(object sender, EventArgs e)
        {
            //ajoute toute la listebox dans le combobox
            foreach (Object element in this.lstMatiereEtudiant.Items)
            {
                //Copier tout les éléments de la listebox dans la combobox
                this.cbxMatieres.Items.Add(element);
            }
            // Supprimer tout les éléments restant dans la list box
            this.lstMatiereEtudiant.Items.Clear();

            //désactive les boutons supprime et supprime tout
            this.btnSupprime.Enabled = false;
            this.btnSupprimeTout.Enabled = false;
            //active le bouton ajouteTout
            this.btnAjouteTout.Enabled = true;
        }

        private void cbxMatieres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMatieres.SelectedIndex >= 0)
            {
                this.btnAjoute.Enabled = true;
            }
        }

        private void lstMatiereEtudiant_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMatiereEtudiant.SelectedIndex >= 0)
            {
                this.btnSupprime.Enabled = true;
            }
        }

        private void frmGestionEtudiant_FormClosing(object sender, FormClosingEventArgs e)
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
