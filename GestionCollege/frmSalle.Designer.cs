namespace GestionCollege
{
    partial class frmSalle
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
            this.lstMatieres = new System.Windows.Forms.ListBox();
            this.lblMatieres = new System.Windows.Forms.Label();
            this.btnEditerSalle = new System.Windows.Forms.Button();
            this.lstSalle = new System.Windows.Forms.ListBox();
            this.lblSalle = new System.Windows.Forms.Label();
            this.btnAccueil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstMatieres
            // 
            this.lstMatieres.FormattingEnabled = true;
            this.lstMatieres.Location = new System.Drawing.Point(128, 32);
            this.lstMatieres.Name = "lstMatieres";
            this.lstMatieres.Size = new System.Drawing.Size(120, 95);
            this.lstMatieres.TabIndex = 20;
            // 
            // lblMatieres
            // 
            this.lblMatieres.AutoSize = true;
            this.lblMatieres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatieres.Location = new System.Drawing.Point(125, 7);
            this.lblMatieres.Name = "lblMatieres";
            this.lblMatieres.Size = new System.Drawing.Size(133, 15);
            this.lblMatieres.TabIndex = 19;
            this.lblMatieres.Text = "Matières dans la salle :";
            // 
            // btnEditerSalle
            // 
            this.btnEditerSalle.Location = new System.Drawing.Point(12, 133);
            this.btnEditerSalle.Name = "btnEditerSalle";
            this.btnEditerSalle.Size = new System.Drawing.Size(75, 20);
            this.btnEditerSalle.TabIndex = 18;
            this.btnEditerSalle.Text = "Editer";
            this.btnEditerSalle.UseVisualStyleBackColor = true;
            this.btnEditerSalle.Click += new System.EventHandler(this.btnEditerSalle_Click);
            // 
            // lstSalle
            // 
            this.lstSalle.FormattingEnabled = true;
            this.lstSalle.Items.AddRange(new object[] {
            "101",
            "201",
            "301",
            "404"});
            this.lstSalle.Location = new System.Drawing.Point(12, 32);
            this.lstSalle.Name = "lstSalle";
            this.lstSalle.Size = new System.Drawing.Size(87, 95);
            this.lstSalle.TabIndex = 17;
            // 
            // lblSalle
            // 
            this.lblSalle.AutoSize = true;
            this.lblSalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalle.Location = new System.Drawing.Point(9, 7);
            this.lblSalle.Name = "lblSalle";
            this.lblSalle.Size = new System.Drawing.Size(41, 15);
            this.lblSalle.TabIndex = 16;
            this.lblSalle.Text = "Salle :";
            // 
            // btnAccueil
            // 
            this.btnAccueil.Location = new System.Drawing.Point(173, 203);
            this.btnAccueil.Name = "btnAccueil";
            this.btnAccueil.Size = new System.Drawing.Size(75, 23);
            this.btnAccueil.TabIndex = 37;
            this.btnAccueil.Text = "ACCUEIL";
            this.btnAccueil.UseVisualStyleBackColor = true;
            this.btnAccueil.Click += new System.EventHandler(this.btnAccueil_Click);
            // 
            // frmSalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestionCollege.Properties.Resources.Sallefond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(260, 238);
            this.Controls.Add(this.btnAccueil);
            this.Controls.Add(this.lstMatieres);
            this.Controls.Add(this.lblMatieres);
            this.Controls.Add(this.btnEditerSalle);
            this.Controls.Add(this.lstSalle);
            this.Controls.Add(this.lblSalle);
            this.Name = "frmSalle";
            this.Text = "Salle de cours";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMatieres;
        private System.Windows.Forms.Label lblMatieres;
        private System.Windows.Forms.Button btnEditerSalle;
        private System.Windows.Forms.ListBox lstSalle;
        private System.Windows.Forms.Label lblSalle;
        private System.Windows.Forms.Button btnAccueil;
    }
}