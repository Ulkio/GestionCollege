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
        //ATTRIBUTS
        private DAOenseignant daoEnseignant;
        private List<Enseignant> listEnseignant = new List<Enseignant>();
       // private DataTable dt = new DataTable();




        //CONSTRUCTEUR
        public frmEnseignant()
        {
            InitializeComponent();
        }

        //CHARGEMENT DU FORM
        private void frmEnseignant_Load(object sender, EventArgs e)
        {
            daoEnseignant = new DAOenseignant();
            dgvEnseignant.DataSource = daoEnseignant.DisplayData();
        }



        //BOUTONS CRUD
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            daoEnseignant.Save();
            daoEnseignant.sqlCommand.Parameters.AddWithValue("@nom", txtNom.Text);
            daoEnseignant.sqlCommand.Parameters.AddWithValue("@prenom", txtPrenom.Text);
            daoEnseignant.sqlCommand.Parameters.AddWithValue("@tel", txtTel.Text);
            daoEnseignant.sqlCommand.Parameters.AddWithValue("@mail", txtMail.Text);
            daoEnseignant.sqlCommand.Parameters.AddWithValue("@resp", chkResp.Checked);
            daoEnseignant.sqlCommand.Parameters.AddWithValue("@date", txtDate.Text);
            daoEnseignant.sqlCommand.Parameters.AddWithValue("@idDpt", cbxDpt.SelectedItem);
            daoEnseignant.sqlCommand.Parameters.AddWithValue("@idMat", cbxMt.SelectedItem);
            daoEnseignant.sqlCommand.ExecuteNonQuery();
            refresh();

        }

        private void btnEditer_Click(object sender, EventArgs e)
        {
            daoEnseignant.Update();
            daoEnseignant.sqlCommand.Parameters.AddWithValue("@id", txtId.Text);
            daoEnseignant.sqlCommand.Parameters.AddWithValue("@nom", txtNom.Text);
            daoEnseignant.sqlCommand.Parameters.AddWithValue("@prenom", txtPrenom.Text);
            daoEnseignant.sqlCommand.Parameters.AddWithValue("@tel", txtTel.Text);
            daoEnseignant.sqlCommand.Parameters.AddWithValue("@mail", txtMail.Text);
            daoEnseignant.sqlCommand.Parameters.AddWithValue("@resp", chkResp.Checked);
            daoEnseignant.sqlCommand.Parameters.AddWithValue("@date", Convert.ToDateTime(txtDate.Text));
            daoEnseignant.sqlCommand.Parameters.AddWithValue("@idDpt", cbxDpt.SelectedItem);
            daoEnseignant.sqlCommand.Parameters.AddWithValue("@idMat", cbxMt.SelectedItem);
            daoEnseignant.sqlCommand.ExecuteNonQuery();
            refresh();
        }

        private void btnFiche_Click(object sender, EventArgs e)
        {

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            daoEnseignant.Delete();
            daoEnseignant.sqlCommand.Parameters.AddWithValue("@id", txtId.Text);
            daoEnseignant.sqlCommand.ExecuteNonQuery();
            refresh();
            ClearBox();
        }




        public void refresh()
        {
            daoEnseignant = new DAOenseignant();
            dgvEnseignant.DataSource = daoEnseignant.DisplayData();
        }
        public void ClearBox()
        {
            txtId.Clear();
            txtDate.Clear();
            txtNom.Clear();
            txtPrenom.Clear();
            txtMail.Clear();
            txtTel.Clear();
            chkResp.Checked = false;
            cbxDpt.SelectedIndex = -1;
            cbxMt.SelectedIndex = -1;

        }



        private void dgvEnseignant_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvEnseignant.Rows[e.RowIndex].Cells[0].Value.ToString() != "")
            {
                txtId.Text = dgvEnseignant.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtDate.Text = dgvEnseignant.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtNom.Text = dgvEnseignant.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPrenom.Text = dgvEnseignant.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtTel.Text = dgvEnseignant.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtMail.Text = dgvEnseignant.Rows[e.RowIndex].Cells[5].Value.ToString();
                chkResp.Checked = Convert.ToBoolean(dgvEnseignant.Rows[e.RowIndex].Cells[6].Value);
                cbxDpt.SelectedItem = dgvEnseignant.Rows[e.RowIndex].Cells[7].Value.ToString();
                cbxMt.SelectedItem = dgvEnseignant.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
            else
                ClearBox();
        }










        //ACCUEIL ET QUITTER
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
