﻿namespace View
{
    partial class DataGridView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apaye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuraitDuPayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoldesARegler = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dataGridView1.Location = new System.Drawing.Point(4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 258);
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
            // DataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 267);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DataGridView";
            this.Text = "DataGridView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apaye;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuraitDuPayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoldesARegler;
    }
}