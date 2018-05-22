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
            this.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmEnseignant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enseignant";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAccueil;
        private System.Windows.Forms.Button btnQuitter;
    }
}