namespace GestionCollege
{
    partial class frmAccueil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMatieres = new System.Windows.Forms.Button();
            this.btnSalle = new System.Windows.Forms.Button();
            this.btnEtudiants = new System.Windows.Forms.Button();
            this.btnEnseignants = new System.Windows.Forms.Button();
            this.btnDepartements = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMatieres
            // 
            this.btnMatieres.Location = new System.Drawing.Point(79, 182);
            this.btnMatieres.Name = "btnMatieres";
            this.btnMatieres.Size = new System.Drawing.Size(90, 23);
            this.btnMatieres.TabIndex = 9;
            this.btnMatieres.Text = "Matières";
            this.btnMatieres.UseVisualStyleBackColor = true;
            this.btnMatieres.Click += new System.EventHandler(this.btnMatieres_Click);
            // 
            // btnSalle
            // 
            this.btnSalle.Location = new System.Drawing.Point(79, 225);
            this.btnSalle.Name = "btnSalle";
            this.btnSalle.Size = new System.Drawing.Size(90, 23);
            this.btnSalle.TabIndex = 8;
            this.btnSalle.Text = "Salle";
            this.btnSalle.UseVisualStyleBackColor = true;
            this.btnSalle.Click += new System.EventHandler(this.btnSalle_Click);
            // 
            // btnEtudiants
            // 
            this.btnEtudiants.Location = new System.Drawing.Point(79, 140);
            this.btnEtudiants.Name = "btnEtudiants";
            this.btnEtudiants.Size = new System.Drawing.Size(90, 23);
            this.btnEtudiants.TabIndex = 7;
            this.btnEtudiants.Text = "Étudiants";
            this.btnEtudiants.UseVisualStyleBackColor = true;
            this.btnEtudiants.Click += new System.EventHandler(this.btnEtudiants_Click);
            // 
            // btnEnseignants
            // 
            this.btnEnseignants.Location = new System.Drawing.Point(79, 99);
            this.btnEnseignants.Name = "btnEnseignants";
            this.btnEnseignants.Size = new System.Drawing.Size(90, 23);
            this.btnEnseignants.TabIndex = 6;
            this.btnEnseignants.Text = "Enseignants";
            this.btnEnseignants.UseVisualStyleBackColor = true;
            this.btnEnseignants.Click += new System.EventHandler(this.btnEnseignants_Click);
            // 
            // btnDepartements
            // 
            this.btnDepartements.Location = new System.Drawing.Point(79, 59);
            this.btnDepartements.Name = "btnDepartements";
            this.btnDepartements.Size = new System.Drawing.Size(90, 23);
            this.btnDepartements.TabIndex = 5;
            this.btnDepartements.Text = "Départements";
            this.btnDepartements.UseVisualStyleBackColor = true;
            this.btnDepartements.Click += new System.EventHandler(this.btnDepartements_Click);
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 304);
            this.Controls.Add(this.btnMatieres);
            this.Controls.Add(this.btnSalle);
            this.Controls.Add(this.btnEtudiants);
            this.Controls.Add(this.btnEnseignants);
            this.Controls.Add(this.btnDepartements);
            this.Name = "frmAccueil";
            this.Text = "Accueil";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMatieres;
        private System.Windows.Forms.Button btnSalle;
        private System.Windows.Forms.Button btnEtudiants;
        private System.Windows.Forms.Button btnEnseignants;
        private System.Windows.Forms.Button btnDepartements;
    }
}