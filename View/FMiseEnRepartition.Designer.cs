
namespace View
{
    partial class FMiseEnRepartition
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
            this.btnCalculerRepartition = new System.Windows.Forms.Button();
            this.btnSolderPeriode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalculerRepartition
            // 
            this.btnCalculerRepartition.Location = new System.Drawing.Point(12, 12);
            this.btnCalculerRepartition.Name = "btnCalculerRepartition";
            this.btnCalculerRepartition.Size = new System.Drawing.Size(239, 38);
            this.btnCalculerRepartition.TabIndex = 0;
            this.btnCalculerRepartition.Text = "Calculer la répartition";
            this.btnCalculerRepartition.UseVisualStyleBackColor = true;
            // 
            // btnSolderPeriode
            // 
            this.btnSolderPeriode.Location = new System.Drawing.Point(12, 56);
            this.btnSolderPeriode.Name = "btnSolderPeriode";
            this.btnSolderPeriode.Size = new System.Drawing.Size(239, 38);
            this.btnSolderPeriode.TabIndex = 1;
            this.btnSolderPeriode.Text = "Solder une période";
            this.btnSolderPeriode.UseVisualStyleBackColor = true;
            // 
            // FMiseEnRepartition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 110);
            this.Controls.Add(this.btnSolderPeriode);
            this.Controls.Add(this.btnCalculerRepartition);
            this.Name = "FMiseEnRepartition";
            this.Text = "FRepartition";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalculerRepartition;
        private System.Windows.Forms.Button btnSolderPeriode;
    }
}