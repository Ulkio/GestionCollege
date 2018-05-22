namespace GestionCollege
{
    partial class frmEnseignant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnseignant));
            this.btnAccueil = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnFiche = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstEnseignants = new System.Windows.Forms.ListBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAccueil
            // 
            this.btnAccueil.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccueil.Location = new System.Drawing.Point(559, 476);
            this.btnAccueil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAccueil.Name = "btnAccueil";
            this.btnAccueil.Size = new System.Drawing.Size(113, 44);
            this.btnAccueil.TabIndex = 15;
            this.btnAccueil.Text = "ACCUEIL";
            this.btnAccueil.UseVisualStyleBackColor = true;
            this.btnAccueil.Click += new System.EventHandler(this.btnAccueil_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(63, 195);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(132, 32);
            this.btnAjouter.TabIndex = 13;
            this.btnAjouter.Text = "Ajouter Enseignant";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnFiche
            // 
            this.btnFiche.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiche.Location = new System.Drawing.Point(263, 119);
            this.btnFiche.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFiche.Name = "btnFiche";
            this.btnFiche.Size = new System.Drawing.Size(87, 32);
            this.btnFiche.TabIndex = 12;
            this.btnFiche.Text = "Fiche";
            this.btnFiche.UseVisualStyleBackColor = true;
            this.btnFiche.Click += new System.EventHandler(this.btnFiche_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Location = new System.Drawing.Point(263, 79);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(87, 32);
            this.btnSupprimer.TabIndex = 11;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(263, 39);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(87, 32);
            this.btnModifier.TabIndex = 10;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(63, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enseignants :";
            // 
            // lstEnseignants
            // 
            this.lstEnseignants.FormattingEnabled = true;
            this.lstEnseignants.ItemHeight = 18;
            this.lstEnseignants.Items.AddRange(new object[] {
            "Pierre KIROUL",
            "Jacques OUILLE"});
            this.lstEnseignants.Location = new System.Drawing.Point(63, 39);
            this.lstEnseignants.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstEnseignants.Name = "lstEnseignants";
            this.lstEnseignants.ScrollAlwaysVisible = true;
            this.lstEnseignants.Size = new System.Drawing.Size(194, 148);
            this.lstEnseignants.TabIndex = 8;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(440, 476);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(113, 44);
            this.btnQuitter.TabIndex = 16;
            this.btnQuitter.Text = "QUITTER";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // frmEnseignant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 533);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnAccueil);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnFiche);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstEnseignants);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmEnseignant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enseignant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccueil;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnFiche;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstEnseignants;
        private System.Windows.Forms.Button btnQuitter;
    }
}