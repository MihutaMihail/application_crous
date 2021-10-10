
namespace View
{
    partial class FeditColocataire
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
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(79, 42);
            this.tbPrenom.Margin = new System.Windows.Forms.Padding(2);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(56, 20);
            this.tbPrenom.TabIndex = 9;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(79, 11);
            this.tbNom.Margin = new System.Windows.Forms.Padding(2);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(56, 20);
            this.tbNom.TabIndex = 8;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(21, 45);
            this.lblPrenom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(52, 13);
            this.lblPrenom.TabIndex = 7;
            this.lblPrenom.Text = "Prenom : ";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(21, 13);
            this.lblNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(38, 13);
            this.lblNom.TabIndex = 6;
            this.lblNom.Text = "Nom : ";
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(79, 76);
            this.tbAge.Margin = new System.Windows.Forms.Padding(2);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(56, 20);
            this.tbAge.TabIndex = 11;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(21, 79);
            this.lblAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(35, 13);
            this.lblAge.TabIndex = 10;
            this.lblAge.Text = "Age : ";
            // 
            // tbTel
            // 
            this.tbTel.Location = new System.Drawing.Point(79, 109);
            this.tbTel.Margin = new System.Windows.Forms.Padding(2);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(56, 20);
            this.tbTel.TabIndex = 13;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(21, 112);
            this.lblTel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(28, 13);
            this.lblTel.TabIndex = 12;
            this.lblTel.Text = "Tel :";
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(79, 142);
            this.tbMail.Margin = new System.Windows.Forms.Padding(2);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(56, 20);
            this.tbMail.TabIndex = 15;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(21, 145);
            this.lblMail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(32, 13);
            this.lblMail.TabIndex = 14;
            this.lblMail.Text = "Mail :";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(62, 189);
            this.btnValider.Margin = new System.Windows.Forms.Padding(2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(85, 26);
            this.btnValider.TabIndex = 16;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // FeditColocataire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 226);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.tbTel);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Name = "FeditColocataire";
            this.Text = "FeditColocataire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Button btnValider;
    }
}