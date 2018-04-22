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
    public partial class frmGestionDepartement : Form
    {
        public frmGestionDepartement()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGestionDepartement_FormClosing(object sender, FormClosingEventArgs e)
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
