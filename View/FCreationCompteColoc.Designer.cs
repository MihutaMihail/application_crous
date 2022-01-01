
namespace View
{
    partial class FCreationCompteColoc
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
            this.btnValider = new System.Windows.Forms.Button();
            this.tbMdp = new System.Windows.Forms.TextBox();
            this.tbIdentifiant = new System.Windows.Forms.TextBox();
            this.lbMdp = new System.Windows.Forms.Label();
            this.lbIdentifiant = new System.Windows.Forms.Label();
            this.lbCompteCreation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnValider
            // 
            this.btnValider.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.Location = new System.Drawing.Point(11, 94);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(246, 29);
            this.btnValider.TabIndex = 9;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // tbMdp
            // 
            this.tbMdp.Location = new System.Drawing.Point(124, 67);
            this.tbMdp.Name = "tbMdp";
            this.tbMdp.Size = new System.Drawing.Size(133, 20);
            this.tbMdp.TabIndex = 8;
            this.tbMdp.UseSystemPasswordChar = true;
            // 
            // tbIdentifiant
            // 
            this.tbIdentifiant.Location = new System.Drawing.Point(124, 36);
            this.tbIdentifiant.Name = "tbIdentifiant";
            this.tbIdentifiant.Size = new System.Drawing.Size(133, 20);
            this.tbIdentifiant.TabIndex = 7;
            // 
            // lbMdp
            // 
            this.lbMdp.AutoSize = true;
            this.lbMdp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMdp.Location = new System.Drawing.Point(7, 66);
            this.lbMdp.Name = "lbMdp";
            this.lbMdp.Size = new System.Drawing.Size(109, 19);
            this.lbMdp.TabIndex = 6;
            this.lbMdp.Text = "Mot de Passe : ";
            // 
            // lbIdentifiant
            // 
            this.lbIdentifiant.AutoSize = true;
            this.lbIdentifiant.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdentifiant.Location = new System.Drawing.Point(7, 36);
            this.lbIdentifiant.Name = "lbIdentifiant";
            this.lbIdentifiant.Size = new System.Drawing.Size(83, 19);
            this.lbIdentifiant.TabIndex = 5;
            this.lbIdentifiant.Text = "Identifiant :";
            // 
            // lbCompteCreation
            // 
            this.lbCompteCreation.AutoSize = true;
            this.lbCompteCreation.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lbCompteCreation.Location = new System.Drawing.Point(15, 4);
            this.lbCompteCreation.Name = "lbCompteCreation";
            this.lbCompteCreation.Size = new System.Drawing.Size(237, 23);
            this.lbCompteCreation.TabIndex = 10;
            this.lbCompteCreation.Text = "Création Compte Colocataire";
            // 
            // FCreationCompteColoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 133);
            this.Controls.Add(this.lbCompteCreation);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.tbMdp);
            this.Controls.Add(this.tbIdentifiant);
            this.Controls.Add(this.lbMdp);
            this.Controls.Add(this.lbIdentifiant);
            this.Name = "FCreationCompteColoc";
            this.Text = "FCreationCompteColoc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox tbMdp;
        private System.Windows.Forms.TextBox tbIdentifiant;
        private System.Windows.Forms.Label lbMdp;
        private System.Windows.Forms.Label lbIdentifiant;
        private System.Windows.Forms.Label lbCompteCreation;
    }
}