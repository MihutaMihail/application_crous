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
            this.btnDepenses = new System.Windows.Forms.Button();
            this.lblApplicationCrous = new System.Windows.Forms.Label();
            this.lbConnexion = new System.Windows.Forms.Label();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnColocataires
            // 
            this.btnColocataires.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColocataires.Location = new System.Drawing.Point(20, 78);
            this.btnColocataires.Margin = new System.Windows.Forms.Padding(2);
            this.btnColocataires.Name = "btnColocataires";
            this.btnColocataires.Size = new System.Drawing.Size(275, 63);
            this.btnColocataires.TabIndex = 2;
            this.btnColocataires.Text = "Gestion des Colocataires";
            this.btnColocataires.UseVisualStyleBackColor = true;
            // 
            // btnRepartition
            // 
            this.btnRepartition.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepartition.Location = new System.Drawing.Point(20, 230);
            this.btnRepartition.Margin = new System.Windows.Forms.Padding(2);
            this.btnRepartition.Name = "btnRepartition";
            this.btnRepartition.Size = new System.Drawing.Size(275, 63);
            this.btnRepartition.TabIndex = 4;
            this.btnRepartition.Text = "Mise en Répartition";
            this.btnRepartition.UseVisualStyleBackColor = true;
            // 
            // btnDepenses
            // 
            this.btnDepenses.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepenses.Location = new System.Drawing.Point(20, 154);
            this.btnDepenses.Margin = new System.Windows.Forms.Padding(2);
            this.btnDepenses.Name = "btnDepenses";
            this.btnDepenses.Size = new System.Drawing.Size(275, 63);
            this.btnDepenses.TabIndex = 3;
            this.btnDepenses.Text = "Gestion des Dépenses";
            this.btnDepenses.UseVisualStyleBackColor = true;
            // 
            // lblApplicationCrous
            // 
            this.lblApplicationCrous.AutoSize = true;
            this.lblApplicationCrous.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationCrous.Location = new System.Drawing.Point(13, 20);
            this.lblApplicationCrous.Name = "lblApplicationCrous";
            this.lblApplicationCrous.Size = new System.Drawing.Size(296, 42);
            this.lblApplicationCrous.TabIndex = 0;
            this.lblApplicationCrous.Text = "Application CROUS";
            // 
            // lbConnexion
            // 
            this.lbConnexion.AutoSize = true;
            this.lbConnexion.Location = new System.Drawing.Point(1, 5);
            this.lbConnexion.Name = "lbConnexion";
            this.lbConnexion.Size = new System.Drawing.Size(56, 13);
            this.lbConnexion.TabIndex = 4;
            this.lbConnexion.Text = "connexion";
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(241, 1);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(75, 23);
            this.btnConnexion.TabIndex = 1;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            // 
            // FApplicationCrous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 307);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.lbConnexion);
            this.Controls.Add(this.lblApplicationCrous);
            this.Controls.Add(this.btnDepenses);
            this.Controls.Add(this.btnRepartition);
            this.Controls.Add(this.btnColocataires);
            this.Name = "FApplicationCrous";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnColocataires;
        private System.Windows.Forms.Button btnRepartition;
        private System.Windows.Forms.Button btnDepenses;
        private System.Windows.Forms.Label lblApplicationCrous;
        private System.Windows.Forms.Label lbConnexion;
        private System.Windows.Forms.Button btnConnexion;
    }
}

