namespace _2024_1_17.CONTACT
{
    partial class frmShowFullList
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
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblShowAll = new System.Windows.Forms.Label();
            this.lsbGroup = new System.Windows.Forms.ListBox();
            this.dtgShowAll = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgShowAll)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblGroup.Location = new System.Drawing.Point(54, 50);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(60, 20);
            this.lblGroup.TabIndex = 0;
            this.lblGroup.Text = "Group";
            // 
            // lblShowAll
            // 
            this.lblShowAll.AutoSize = true;
            this.lblShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblShowAll.Location = new System.Drawing.Point(302, 50);
            this.lblShowAll.Name = "lblShowAll";
            this.lblShowAll.Size = new System.Drawing.Size(82, 20);
            this.lblShowAll.TabIndex = 1;
            this.lblShowAll.Text = "Show All";
            // 
            // lsbGroup
            // 
            this.lsbGroup.FormattingEnabled = true;
            this.lsbGroup.ItemHeight = 16;
            this.lsbGroup.Location = new System.Drawing.Point(58, 99);
            this.lsbGroup.Name = "lsbGroup";
            this.lsbGroup.Size = new System.Drawing.Size(226, 308);
            this.lsbGroup.TabIndex = 2;
            // 
            // dtgShowAll
            // 
            this.dtgShowAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgShowAll.Location = new System.Drawing.Point(306, 99);
            this.dtgShowAll.Name = "dtgShowAll";
            this.dtgShowAll.RowHeadersWidth = 51;
            this.dtgShowAll.RowTemplate.Height = 24;
            this.dtgShowAll.Size = new System.Drawing.Size(445, 308);
            this.dtgShowAll.TabIndex = 3;
            // 
            // frmShowFullList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgShowAll);
            this.Controls.Add(this.lsbGroup);
            this.Controls.Add(this.lblShowAll);
            this.Controls.Add(this.lblGroup);
            this.Name = "frmShowFullList";
            this.Text = "Show Full List";
            ((System.ComponentModel.ISupportInitialize)(this.dtgShowAll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblShowAll;
        private System.Windows.Forms.ListBox lsbGroup;
        private System.Windows.Forms.DataGridView dtgShowAll;
    }
}