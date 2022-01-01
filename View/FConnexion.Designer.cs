
namespace View
{
    partial class FConnexion
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
            this.lbIdentifiant = new System.Windows.Forms.Label();
            this.lbMdp = new System.Windows.Forms.Label();
            this.tbIdentifiant = new System.Windows.Forms.TextBox();
            this.tbMdp = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbIdentifiant
            // 
            this.lbIdentifiant.AutoSize = true;
            this.lbIdentifiant.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdentifiant.Location = new System.Drawing.Point(13, 13);
            this.lbIdentifiant.Name = "lbIdentifiant";
            this.lbIdentifiant.Size = new System.Drawing.Size(83, 19);
            this.lbIdentifiant.TabIndex = 0;
            this.lbIdentifiant.Text = "Identifiant :";
            // 
            // lbMdp
            // 
            this.lbMdp.AutoSize = true;
            this.lbMdp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMdp.Location = new System.Drawing.Point(13, 43);
            this.lbMdp.Name = "lbMdp";
            this.lbMdp.Size = new System.Drawing.Size(109, 19);
            this.lbMdp.TabIndex = 1;
            this.lbMdp.Text = "Mot de Passe : ";
            // 
            // tbIdentifiant
            // 
            this.tbIdentifiant.Location = new System.Drawing.Point(130, 13);
            this.tbIdentifiant.Name = "tbIdentifiant";
            this.tbIdentifiant.Size = new System.Drawing.Size(133, 20);
            this.tbIdentifiant.TabIndex = 2;
            // 
            // tbMdp
            // 
            this.tbMdp.Location = new System.Drawing.Point(130, 44);
            this.tbMdp.Name = "tbMdp";
            this.tbMdp.Size = new System.Drawing.Size(133, 20);
            this.tbMdp.TabIndex = 3;
            this.tbMdp.UseSystemPasswordChar = true;
            // 
            // btnValider
            // 
            this.btnValider.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.Location = new System.Drawing.Point(17, 71);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(246, 29);
            this.btnValider.TabIndex = 4;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // FConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 109);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.tbMdp);
            this.Controls.Add(this.tbIdentifiant);
            this.Controls.Add(this.lbMdp);
            this.Controls.Add(this.lbIdentifiant);
            this.Name = "FConnexion";
            this.Text = "FConnexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIdentifiant;
        private System.Windows.Forms.Label lbMdp;
        private System.Windows.Forms.TextBox tbIdentifiant;
        private System.Windows.Forms.TextBox tbMdp;
        private System.Windows.Forms.Button btnValider;
    }
}