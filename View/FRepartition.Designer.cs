
namespace View
{
    partial class FRepartition
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
            this.lblNomTest = new System.Windows.Forms.Label();
            this.tbNomTest = new System.Windows.Forms.TextBox();
            this.lblMontantTest = new System.Windows.Forms.Label();
            this.tbMontantTest = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNomTest
            // 
            this.lblNomTest.AutoSize = true;
            this.lblNomTest.Location = new System.Drawing.Point(25, 26);
            this.lblNomTest.Name = "lblNomTest";
            this.lblNomTest.Size = new System.Drawing.Size(38, 13);
            this.lblNomTest.TabIndex = 0;
            this.lblNomTest.Text = "Nom : ";
            // 
            // tbNomTest
            // 
            this.tbNomTest.Location = new System.Drawing.Point(82, 23);
            this.tbNomTest.Name = "tbNomTest";
            this.tbNomTest.Size = new System.Drawing.Size(100, 20);
            this.tbNomTest.TabIndex = 1;
            // 
            // lblMontantTest
            // 
            this.lblMontantTest.AutoSize = true;
            this.lblMontantTest.Location = new System.Drawing.Point(25, 60);
            this.lblMontantTest.Name = "lblMontantTest";
            this.lblMontantTest.Size = new System.Drawing.Size(52, 13);
            this.lblMontantTest.TabIndex = 2;
            this.lblMontantTest.Text = "Montant :";
            // 
            // tbMontantTest
            // 
            this.tbMontantTest.Location = new System.Drawing.Point(82, 57);
            this.tbMontantTest.Name = "tbMontantTest";
            this.tbMontantTest.Size = new System.Drawing.Size(100, 20);
            this.tbMontantTest.TabIndex = 3;
            // 
            // FRepartition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 240);
            this.Controls.Add(this.tbMontantTest);
            this.Controls.Add(this.lblMontantTest);
            this.Controls.Add(this.tbNomTest);
            this.Controls.Add(this.lblNomTest);
            this.Name = "FRepartition";
            this.Text = "FRepartition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomTest;
        private System.Windows.Forms.TextBox tbNomTest;
        private System.Windows.Forms.Label lblMontantTest;
        private System.Windows.Forms.TextBox tbMontantTest;
    }
}