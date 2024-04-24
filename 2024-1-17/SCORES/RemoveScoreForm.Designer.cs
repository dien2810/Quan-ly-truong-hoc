namespace _2024_1_17.COURSE
{
    partial class frmRemoveScore
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
            this.dtgScore = new System.Windows.Forms.DataGridView();
            this.btnRemoveScore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgScore)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgScore
            // 
            this.dtgScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgScore.Location = new System.Drawing.Point(12, 25);
            this.dtgScore.Name = "dtgScore";
            this.dtgScore.RowHeadersWidth = 51;
            this.dtgScore.RowTemplate.Height = 24;
            this.dtgScore.Size = new System.Drawing.Size(776, 346);
            this.dtgScore.TabIndex = 0;
            // 
            // btnRemoveScore
            // 
            this.btnRemoveScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRemoveScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveScore.ForeColor = System.Drawing.Color.White;
            this.btnRemoveScore.Location = new System.Drawing.Point(325, 389);
            this.btnRemoveScore.Name = "btnRemoveScore";
            this.btnRemoveScore.Size = new System.Drawing.Size(148, 39);
            this.btnRemoveScore.TabIndex = 1;
            this.btnRemoveScore.Text = "Remove Score";
            this.btnRemoveScore.UseVisualStyleBackColor = false;
            this.btnRemoveScore.Click += new System.EventHandler(this.btnRemoveScore_Click);
            // 
            // frmRemoveScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemoveScore);
            this.Controls.Add(this.dtgScore);
            this.Name = "frmRemoveScore";
            this.Text = "Remove Score";
            this.Load += new System.EventHandler(this.frmRemoveScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgScore;
        private System.Windows.Forms.Button btnRemoveScore;
    }
}