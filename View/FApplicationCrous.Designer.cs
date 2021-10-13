namespace View
{
    partial class FApplicationCrous
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnColocataires = new System.Windows.Forms.Button();
            this.btnRepartition = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnColocataires
            // 
            this.btnColocataires.Location = new System.Drawing.Point(75, 11);
            this.btnColocataires.Margin = new System.Windows.Forms.Padding(2);
            this.btnColocataires.Name = "btnColocataires";
            this.btnColocataires.Size = new System.Drawing.Size(136, 27);
            this.btnColocataires.TabIndex = 1;
            this.btnColocataires.Text = "Colocataires";
            this.btnColocataires.UseVisualStyleBackColor = true;
            // 
            // btnRepartition
            // 
            this.btnRepartition.Location = new System.Drawing.Point(75, 49);
            this.btnRepartition.Margin = new System.Windows.Forms.Padding(2);
            this.btnRepartition.Name = "btnRepartition";
            this.btnRepartition.Size = new System.Drawing.Size(136, 27);
            this.btnRepartition.TabIndex = 2;
            this.btnRepartition.Text = "Mise en répartition";
            this.btnRepartition.UseVisualStyleBackColor = true;
            // 
            // FApplicationCrous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 87);
            this.Controls.Add(this.btnRepartition);
            this.Controls.Add(this.btnColocataires);
            this.Name = "FApplicationCrous";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnColocataires;
        private System.Windows.Forms.Button btnRepartition;
    }
}

