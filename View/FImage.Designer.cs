
namespace View
{
    partial class FImage
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
            this.btnPb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnPb)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPb
            // 
            this.btnPb.Location = new System.Drawing.Point(12, 13);
            this.btnPb.Name = "btnPb";
            this.btnPb.Size = new System.Drawing.Size(579, 630);
            this.btnPb.TabIndex = 0;
            this.btnPb.TabStop = false;
            // 
            // FImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 655);
            this.Controls.Add(this.btnPb);
            this.Name = "FImage";
            this.Text = "FImage";
            ((System.ComponentModel.ISupportInitialize)(this.btnPb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnPb;
    }
}