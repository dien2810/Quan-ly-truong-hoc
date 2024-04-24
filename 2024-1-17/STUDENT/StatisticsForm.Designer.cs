namespace _2024_1_17
{
    partial class frmStatistics
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
            this.pnTotal = new System.Windows.Forms.Panel();
            this.pnMale = new System.Windows.Forms.Panel();
            this.pnFemale = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblMale = new System.Windows.Forms.Label();
            this.lblFemale = new System.Windows.Forms.Label();
            this.pnTotal.SuspendLayout();
            this.pnMale.SuspendLayout();
            this.pnFemale.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTotal
            // 
            this.pnTotal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnTotal.Controls.Add(this.lblTotal);
            this.pnTotal.Location = new System.Drawing.Point(1, -3);
            this.pnTotal.Name = "pnTotal";
            this.pnTotal.Size = new System.Drawing.Size(627, 175);
            this.pnTotal.TabIndex = 0;
            // 
            // pnMale
            // 
            this.pnMale.BackColor = System.Drawing.Color.Lime;
            this.pnMale.Controls.Add(this.lblMale);
            this.pnMale.Location = new System.Drawing.Point(1, 174);
            this.pnMale.Name = "pnMale";
            this.pnMale.Size = new System.Drawing.Size(316, 185);
            this.pnMale.TabIndex = 1;
            // 
            // pnFemale
            // 
            this.pnFemale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnFemale.Controls.Add(this.lblFemale);
            this.pnFemale.Location = new System.Drawing.Point(320, 174);
            this.pnFemale.Name = "pnFemale";
            this.pnFemale.Size = new System.Drawing.Size(308, 185);
            this.pnFemale.TabIndex = 2;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(197, 41);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(244, 78);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total Student: 100";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotal.MouseEnter += new System.EventHandler(this.lblTotal_MouseEnter);
            this.lblTotal.MouseLeave += new System.EventHandler(this.lblTotal_MouseLeave);
            // 
            // lblMale
            // 
            this.lblMale.BackColor = System.Drawing.Color.White;
            this.lblMale.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMale.Location = new System.Drawing.Point(70, 66);
            this.lblMale.Name = "lblMale";
            this.lblMale.Size = new System.Drawing.Size(177, 56);
            this.lblMale.TabIndex = 0;
            this.lblMale.Text = "label1";
            this.lblMale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMale.MouseEnter += new System.EventHandler(this.lblMale_MouseEnter);
            this.lblMale.MouseLeave += new System.EventHandler(this.lblMale_MouseLeave);
            // 
            // lblFemale
            // 
            this.lblFemale.BackColor = System.Drawing.Color.White;
            this.lblFemale.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFemale.Location = new System.Drawing.Point(69, 66);
            this.lblFemale.Name = "lblFemale";
            this.lblFemale.Size = new System.Drawing.Size(177, 56);
            this.lblFemale.TabIndex = 0;
            this.lblFemale.Text = "label1";
            this.lblFemale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFemale.MouseEnter += new System.EventHandler(this.lblFemale_MouseEnter);
            this.lblFemale.MouseLeave += new System.EventHandler(this.lblFemale_MouseLeave);
            // 
            // frmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 358);
            this.Controls.Add(this.pnFemale);
            this.Controls.Add(this.pnMale);
            this.Controls.Add(this.pnTotal);
            this.Name = "frmStatistics";
            this.Text = "StatisticsForm";
            this.Load += new System.EventHandler(this.frmStatistics_Load);
            this.pnTotal.ResumeLayout(false);
            this.pnMale.ResumeLayout(false);
            this.pnFemale.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTotal;
        private System.Windows.Forms.Panel pnMale;
        private System.Windows.Forms.Panel pnFemale;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblMale;
        private System.Windows.Forms.Label lblFemale;
    }
}