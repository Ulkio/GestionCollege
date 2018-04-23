namespace GestionCollege
{
    partial class frmDepartement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartement));
            this.txtMoyenne = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtResponsable = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.btnFiche = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstMatieres = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstEnseignants = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstDepartement = new System.Windows.Forms.ListBox();
            this.btnAccueil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMoyenne
            // 
            this.txtMoyenne.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMoyenne.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoyenne.Location = new System.Drawing.Point(40, 328);
            this.txtMoyenne.Name = "txtMoyenne";
            this.txtMoyenne.ReadOnly = true;
            this.txtMoyenne.Size = new System.Drawing.Size(56, 21);
            this.txtMoyenne.TabIndex = 44;
            this.txtMoyenne.Text = "12";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bradley Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(36, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 24);
            this.label5.TabIndex = 43;
            this.label5.Text = "Moyenne département :";
            // 
            // txtResponsable
            // 
            this.txtResponsable.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtResponsable.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtResponsable.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResponsable.Location = new System.Drawing.Point(40, 278);
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.ReadOnly = true;
            this.txtResponsable.Size = new System.Drawing.Size(100, 21);
            this.txtResponsable.TabIndex = 42;
            this.txtResponsable.Text = "DUPONT Paul";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bradley Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(36, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 24);
            this.label4.TabIndex = 41;
            this.label4.Text = "Responsable département :";
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.Transparent;
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjouter.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAjouter.Location = new System.Drawing.Point(40, 219);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(126, 31);
            this.btnAjouter.TabIndex = 40;
            this.btnAjouter.Text = "Ajouter département";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.Transparent;
            this.btnSupprimer.FlatAppearance.BorderSize = 0;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSupprimer.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSupprimer.Location = new System.Drawing.Point(222, 94);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(87, 31);
            this.btnSupprimer.TabIndex = 39;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.Transparent;
            this.btnModifier.FlatAppearance.BorderSize = 0;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModifier.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModifier.Location = new System.Drawing.Point(222, 65);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(87, 31);
            this.btnModifier.TabIndex = 38;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.Color.Transparent;
            this.btnAcceder.Enabled = false;
            this.btnAcceder.FlatAppearance.BorderSize = 0;
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAcceder.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAcceder.Location = new System.Drawing.Point(631, 219);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(87, 31);
            this.btnAcceder.TabIndex = 37;
            this.btnAcceder.Text = "Accéder";
            this.btnAcceder.UseVisualStyleBackColor = false;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // btnFiche
            // 
            this.btnFiche.BackColor = System.Drawing.Color.Transparent;
            this.btnFiche.Enabled = false;
            this.btnFiche.FlatAppearance.BorderSize = 0;
            this.btnFiche.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiche.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiche.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFiche.Location = new System.Drawing.Point(407, 219);
            this.btnFiche.Name = "btnFiche";
            this.btnFiche.Size = new System.Drawing.Size(87, 31);
            this.btnFiche.TabIndex = 36;
            this.btnFiche.Text = "Fiche";
            this.btnFiche.UseVisualStyleBackColor = false;
            this.btnFiche.Click += new System.EventHandler(this.btnFiche_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bradley Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(628, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 35;
            this.label3.Text = "Matières :";
            // 
            // lstMatieres
            // 
            this.lstMatieres.FormattingEnabled = true;
            this.lstMatieres.Location = new System.Drawing.Point(631, 65);
            this.lstMatieres.Name = "lstMatieres";
            this.lstMatieres.ScrollAlwaysVisible = true;
            this.lstMatieres.Size = new System.Drawing.Size(176, 147);
            this.lstMatieres.TabIndex = 34;
            this.lstMatieres.SelectedIndexChanged += new System.EventHandler(this.lstMatieres_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bradley Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(403, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 33;
            this.label2.Text = "Enseignants";
            // 
            // lstEnseignants
            // 
            this.lstEnseignants.FormattingEnabled = true;
            this.lstEnseignants.Location = new System.Drawing.Point(407, 65);
            this.lstEnseignants.Name = "lstEnseignants";
            this.lstEnseignants.ScrollAlwaysVisible = true;
            this.lstEnseignants.Size = new System.Drawing.Size(176, 147);
            this.lstEnseignants.TabIndex = 32;
            this.lstEnseignants.SelectedIndexChanged += new System.EventHandler(this.lstEnseignants_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bradley Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(36, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Département :";
            // 
            // lstDepartement
            // 
            this.lstDepartement.FormattingEnabled = true;
            this.lstDepartement.Location = new System.Drawing.Point(40, 65);
            this.lstDepartement.Name = "lstDepartement";
            this.lstDepartement.ScrollAlwaysVisible = true;
            this.lstDepartement.Size = new System.Drawing.Size(176, 147);
            this.lstDepartement.TabIndex = 30;
            // 
            // btnAccueil
            // 
            this.btnAccueil.BackColor = System.Drawing.Color.Transparent;
            this.btnAccueil.FlatAppearance.BorderSize = 0;
            this.btnAccueil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAccueil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAccueil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAccueil.Font = new System.Drawing.Font("Bradley Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccueil.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAccueil.Location = new System.Drawing.Point(688, 317);
            this.btnAccueil.Name = "btnAccueil";
            this.btnAccueil.Size = new System.Drawing.Size(119, 31);
            this.btnAccueil.TabIndex = 46;
            this.btnAccueil.Text = "ACCUEIL";
            this.btnAccueil.UseVisualStyleBackColor = false;
            this.btnAccueil.Click += new System.EventHandler(this.btnAccueil_Click);
            // 
            // frmDepartement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(845, 389);
            this.Controls.Add(this.btnAccueil);
            this.Controls.Add(this.txtMoyenne);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtResponsable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.btnFiche);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstMatieres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstEnseignants);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstDepartement);
            this.DoubleBuffered = true;
            this.Name = "frmDepartement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departement";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDepartement_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMoyenne;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtResponsable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.Button btnFiche;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstMatieres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstEnseignants;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstDepartement;
        private System.Windows.Forms.Button btnAccueil;
    }
}