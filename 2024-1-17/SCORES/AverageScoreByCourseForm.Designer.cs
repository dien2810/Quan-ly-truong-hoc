namespace _2024_1_17.SCORES
{
    partial class frmAvgScoreByCourse
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
            this.dtgAverage = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAverage)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgAverage
            // 
            this.dtgAverage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgAverage.BackgroundColor = System.Drawing.Color.SandyBrown;
            this.dtgAverage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAverage.Location = new System.Drawing.Point(12, 12);
            this.dtgAverage.Name = "dtgAverage";
            this.dtgAverage.RowHeadersWidth = 51;
            this.dtgAverage.RowTemplate.Height = 24;
            this.dtgAverage.Size = new System.Drawing.Size(776, 426);
            this.dtgAverage.TabIndex = 0;
            // 
            // frmAvgScoreByCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgAverage);
            this.Name = "frmAvgScoreByCourse";
            this.Text = "AverageScoreByCourseForm";
            this.Load += new System.EventHandler(this.frmAvgScoreByCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAverage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgAverage;
    }
}