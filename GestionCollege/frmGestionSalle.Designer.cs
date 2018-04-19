namespace GestionCollege
{
    partial class frmGestionSalle
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
            this.pnlNouvelleSalle = new System.Windows.Forms.Panel();
            this.btnAnnulerNouvelleSalle = new System.Windows.Forms.Button();
            this.btnValiderNouvelleSalle = new System.Windows.Forms.Button();
            this.txtAjouterSalle = new System.Windows.Forms.TextBox();
            this.lblNouvelleSalle = new System.Windows.Forms.Label();
            this.pnlModifierSalle = new System.Windows.Forms.Panel();
            this.btnAnnulerModifier = new System.Windows.Forms.Button();
            this.btnValiderModifier = new System.Windows.Forms.Button();
            this.txtModifierSalle = new System.Windows.Forms.TextBox();
            this.lblModifierSalle = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.lstSalle = new System.Windows.Forms.ListBox();
            this.lblSalle = new System.Windows.Forms.Label();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.pnlNouvelleSalle.SuspendLayout();
            this.pnlModifierSalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNouvelleSalle
            // 
            this.pnlNouvelleSalle.Controls.Add(this.btnAnnulerNouvelleSalle);
            this.pnlNouvelleSalle.Controls.Add(this.btnValiderNouvelleSalle);
            this.pnlNouvelleSalle.Controls.Add(this.txtAjouterSalle);
            this.pnlNouvelleSalle.Controls.Add(this.lblNouvelleSalle);
            this.pnlNouvelleSalle.Location = new System.Drawing.Point(8, 151);
            this.pnlNouvelleSalle.Name = "pnlNouvelleSalle";
            this.pnlNouvelleSalle.Size = new System.Drawing.Size(168, 95);
            this.pnlNouvelleSalle.TabIndex = 22;
            this.pnlNouvelleSalle.Visible = false;
            // 
            // btnAnnulerNouvelleSalle
            // 
            this.btnAnnulerNouvelleSalle.Location = new System.Drawing.Point(89, 55);
            this.btnAnnulerNouvelleSalle.Name = "btnAnnulerNouvelleSalle";
            this.btnAnnulerNouvelleSalle.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulerNouvelleSalle.TabIndex = 11;
            this.btnAnnulerNouvelleSalle.Text = "Annuler";
            this.btnAnnulerNouvelleSalle.UseVisualStyleBackColor = true;
            this.btnAnnulerNouvelleSalle.Click += new System.EventHandler(this.btnAnnulerNouvelleSalle_Click);
            // 
            // btnValiderNouvelleSalle
            // 
            this.btnValiderNouvelleSalle.Location = new System.Drawing.Point(6, 55);
            this.btnValiderNouvelleSalle.Name = "btnValiderNouvelleSalle";
            this.btnValiderNouvelleSalle.Size = new System.Drawing.Size(75, 23);
            this.btnValiderNouvelleSalle.TabIndex = 10;
            this.btnValiderNouvelleSalle.Text = "Valider";
            this.btnValiderNouvelleSalle.UseVisualStyleBackColor = true;
            this.btnValiderNouvelleSalle.Click += new System.EventHandler(this.btnValiderNouvelleSalle_Click);
            // 
            // txtAjouterSalle
            // 
            this.txtAjouterSalle.Location = new System.Drawing.Point(7, 29);
            this.txtAjouterSalle.Name = "txtAjouterSalle";
            this.txtAjouterSalle.Size = new System.Drawing.Size(157, 20);
            this.txtAjouterSalle.TabIndex = 4;
            // 
            // lblNouvelleSalle
            // 
            this.lblNouvelleSalle.AutoSize = true;
            this.lblNouvelleSalle.Location = new System.Drawing.Point(3, 5);
            this.lblNouvelleSalle.Name = "lblNouvelleSalle";
            this.lblNouvelleSalle.Size = new System.Drawing.Size(79, 13);
            this.lblNouvelleSalle.TabIndex = 7;
            this.lblNouvelleSalle.Text = "Nouvelle salle :";
            // 
            // pnlModifierSalle
            // 
            this.pnlModifierSalle.Controls.Add(this.btnAnnulerModifier);
            this.pnlModifierSalle.Controls.Add(this.btnValiderModifier);
            this.pnlModifierSalle.Controls.Add(this.txtModifierSalle);
            this.pnlModifierSalle.Controls.Add(this.lblModifierSalle);
            this.pnlModifierSalle.Location = new System.Drawing.Point(182, 151);
            this.pnlModifierSalle.Name = "pnlModifierSalle";
            this.pnlModifierSalle.Size = new System.Drawing.Size(168, 95);
            this.pnlModifierSalle.TabIndex = 15;
            this.pnlModifierSalle.Visible = false;
            // 
            // btnAnnulerModifier
            // 
            this.btnAnnulerModifier.Location = new System.Drawing.Point(89, 55);
            this.btnAnnulerModifier.Name = "btnAnnulerModifier";
            this.btnAnnulerModifier.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulerModifier.TabIndex = 11;
            this.btnAnnulerModifier.Text = "Annuler";
            this.btnAnnulerModifier.UseVisualStyleBackColor = true;
            this.btnAnnulerModifier.Click += new System.EventHandler(this.btnAnnulerModifier_Click);
            // 
            // btnValiderModifier
            // 
            this.btnValiderModifier.Location = new System.Drawing.Point(6, 55);
            this.btnValiderModifier.Name = "btnValiderModifier";
            this.btnValiderModifier.Size = new System.Drawing.Size(75, 23);
            this.btnValiderModifier.TabIndex = 10;
            this.btnValiderModifier.Text = "Valider";
            this.btnValiderModifier.UseVisualStyleBackColor = true;
            this.btnValiderModifier.Click += new System.EventHandler(this.btnValiderModifier_Click);
            // 
            // txtModifierSalle
            // 
            this.txtModifierSalle.Location = new System.Drawing.Point(7, 29);
            this.txtModifierSalle.Name = "txtModifierSalle";
            this.txtModifierSalle.Size = new System.Drawing.Size(157, 20);
            this.txtModifierSalle.TabIndex = 4;
            // 
            // lblModifierSalle
            // 
            this.lblModifierSalle.AutoSize = true;
            this.lblModifierSalle.Location = new System.Drawing.Point(3, 5);
            this.lblModifierSalle.Name = "lblModifierSalle";
            this.lblModifierSalle.Size = new System.Drawing.Size(74, 13);
            this.lblModifierSalle.TabIndex = 7;
            this.lblModifierSalle.Text = "Modifier salle :";
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(275, 288);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 20;
            this.btnFermer.Text = "Femer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // lstSalle
            // 
            this.lstSalle.FormattingEnabled = true;
            this.lstSalle.Items.AddRange(new object[] {
            "101",
            "201",
            "301",
            "404"});
            this.lstSalle.Location = new System.Drawing.Point(15, 25);
            this.lstSalle.Name = "lstSalle";
            this.lstSalle.Size = new System.Drawing.Size(101, 95);
            this.lstSalle.TabIndex = 19;
            // 
            // lblSalle
            // 
            this.lblSalle.AutoSize = true;
            this.lblSalle.Location = new System.Drawing.Point(12, 9);
            this.lblSalle.Name = "lblSalle";
            this.lblSalle.Size = new System.Drawing.Size(36, 13);
            this.lblSalle.TabIndex = 18;
            this.lblSalle.Text = "Salle :";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(121, 83);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 17;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(121, 54);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 16;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(122, 25);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 15;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // frmGestionSalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestionCollege.Properties.Resources.GestionSalleFond1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(358, 323);
            this.Controls.Add(this.pnlModifierSalle);
            this.Controls.Add(this.pnlNouvelleSalle);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.lstSalle);
            this.Controls.Add(this.lblSalle);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Name = "frmGestionSalle";
            this.Text = "Gestion Salle";
            this.pnlNouvelleSalle.ResumeLayout(false);
            this.pnlNouvelleSalle.PerformLayout();
            this.pnlModifierSalle.ResumeLayout(false);
            this.pnlModifierSalle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlNouvelleSalle;
        private System.Windows.Forms.Panel pnlModifierSalle;
        private System.Windows.Forms.Button btnAnnulerModifier;
        private System.Windows.Forms.Button btnValiderModifier;
        private System.Windows.Forms.TextBox txtModifierSalle;
        private System.Windows.Forms.Label lblModifierSalle;
        private System.Windows.Forms.Button btnAnnulerNouvelleSalle;
        private System.Windows.Forms.Button btnValiderNouvelleSalle;
        private System.Windows.Forms.TextBox txtAjouterSalle;
        private System.Windows.Forms.Label lblNouvelleSalle;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.ListBox lstSalle;
        private System.Windows.Forms.Label lblSalle;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
    }
}