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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apaye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuraitDuPayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoldesARegler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSolderPeriode = new System.Windows.Forms.Button();
            this.lbAppartement = new System.Windows.Forms.Label();
            this.txtAppartement = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.Apaye,
            this.AuraitDuPayer,
            this.SoldesARegler});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 157);
            this.dataGridView1.TabIndex = 0;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Apaye
            // 
            this.Apaye.HeaderText = "A Payé";
            this.Apaye.Name = "Apaye";
            this.Apaye.ReadOnly = true;
            // 
            // AuraitDuPayer
            // 
            this.AuraitDuPayer.HeaderText = "Aurait du Payer";
            this.AuraitDuPayer.Name = "AuraitDuPayer";
            this.AuraitDuPayer.ReadOnly = true;
            // 
            // SoldesARegler
            // 
            this.SoldesARegler.HeaderText = "Soldes à Régler";
            this.SoldesARegler.Name = "SoldesARegler";
            this.SoldesARegler.ReadOnly = true;
            // 
            // btnSolderPeriode
            // 
            this.btnSolderPeriode.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.btnSolderPeriode.Location = new System.Drawing.Point(4, 168);
            this.btnSolderPeriode.Name = "btnSolderPeriode";
            this.btnSolderPeriode.Size = new System.Drawing.Size(443, 32);
            this.btnSolderPeriode.TabIndex = 29;
            this.btnSolderPeriode.Text = "Solder une Période";
            this.btnSolderPeriode.UseVisualStyleBackColor = true;
            // 
            // lbAppartement
            // 
            this.lbAppartement.AutoSize = true;
            this.lbAppartement.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAppartement.Location = new System.Drawing.Point(116, 206);
            this.lbAppartement.Name = "lbAppartement";
            this.lbAppartement.Size = new System.Drawing.Size(173, 18);
            this.lbAppartement.TabIndex = 30;
            this.lbAppartement.Text = "Numéro d\'appartment : ";
            // 
            // txtAppartement
            // 
            this.txtAppartement.Location = new System.Drawing.Point(295, 204);
            this.txtAppartement.Name = "txtAppartement";
            this.txtAppartement.ReadOnly = true;
            this.txtAppartement.Size = new System.Drawing.Size(24, 20);
            this.txtAppartement.TabIndex = 31;
            // 
            // FMiseEnRepartition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 233);
            this.Controls.Add(this.txtAppartement);
            this.Controls.Add(this.lbAppartement);
            this.Controls.Add(this.btnSolderPeriode);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FMiseEnRepartition";
            this.Text = "DataGridView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apaye;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuraitDuPayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoldesARegler;
        private System.Windows.Forms.Button btnSolderPeriode;
        private System.Windows.Forms.Label lbAppartement;
        private System.Windows.Forms.TextBox txtAppartement;
    }
}