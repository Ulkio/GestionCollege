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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccueil));
            this.btnMatieres = new System.Windows.Forms.Button();
            this.btnSalle = new System.Windows.Forms.Button();
            this.btnEtudiants = new System.Windows.Forms.Button();
            this.btnEnseignants = new System.Windows.Forms.Button();
            this.btnDepartements = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMatieres
            // 
            this.btnMatieres.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatieres.Location = new System.Drawing.Point(210, 128);
            this.btnMatieres.Name = "btnMatieres";
            this.btnMatieres.Size = new System.Drawing.Size(114, 33);
            this.btnMatieres.TabIndex = 9;
            this.btnMatieres.Text = "Matières";
            this.btnMatieres.UseVisualStyleBackColor = true;
            this.btnMatieres.Click += new System.EventHandler(this.btnMatieres_Click);
            // 
            // btnSalle
            // 
            this.btnSalle.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalle.Location = new System.Drawing.Point(76, 248);
            this.btnSalle.Name = "btnSalle";
            this.btnSalle.Size = new System.Drawing.Size(114, 33);
            this.btnSalle.TabIndex = 8;
            this.btnSalle.Text = "Salle";
            this.btnSalle.UseVisualStyleBackColor = true;
            this.btnSalle.Click += new System.EventHandler(this.btnSalle_Click);
            // 
            // btnEtudiants
            // 
            this.btnEtudiants.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEtudiants.Location = new System.Drawing.Point(76, 188);
            this.btnEtudiants.Name = "btnEtudiants";
            this.btnEtudiants.Size = new System.Drawing.Size(114, 33);
            this.btnEtudiants.TabIndex = 7;
            this.btnEtudiants.Text = "Étudiants";
            this.btnEtudiants.UseVisualStyleBackColor = true;
            this.btnEtudiants.Click += new System.EventHandler(this.btnEtudiants_Click);
            // 
            // btnEnseignants
            // 
            this.btnEnseignants.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnseignants.Location = new System.Drawing.Point(210, 188);
            this.btnEnseignants.Name = "btnEnseignants";
            this.btnEnseignants.Size = new System.Drawing.Size(114, 33);
            this.btnEnseignants.TabIndex = 6;
            this.btnEnseignants.Text = "Enseignants";
            this.btnEnseignants.UseVisualStyleBackColor = true;
            this.btnEnseignants.Click += new System.EventHandler(this.btnEnseignants_Click);
            // 
            // btnDepartements
            // 
            this.btnDepartements.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartements.Location = new System.Drawing.Point(76, 128);
            this.btnDepartements.Name = "btnDepartements";
            this.btnDepartements.Size = new System.Drawing.Size(114, 33);
            this.btnDepartements.TabIndex = 5;
            this.btnDepartements.Text = "Départements";
            this.btnDepartements.UseVisualStyleBackColor = true;
            this.btnDepartements.Click += new System.EventHandler(this.btnDepartements_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "Gestion du collège ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Location = new System.Drawing.Point(234, 328);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(105, 13);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "www.siteducollege.fr";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(76, 308);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(114, 33);
            this.btnQuitter.TabIndex = 12;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(351, 372);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMatieres);
            this.Controls.Add(this.btnSalle);
            this.Controls.Add(this.btnEtudiants);
            this.Controls.Add(this.btnEnseignants);
            this.Controls.Add(this.btnDepartements);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMatieres;
        private System.Windows.Forms.Button btnSalle;
        private System.Windows.Forms.Button btnEtudiants;
        private System.Windows.Forms.Button btnEnseignants;
        private System.Windows.Forms.Button btnDepartements;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnQuitter;
    }
}