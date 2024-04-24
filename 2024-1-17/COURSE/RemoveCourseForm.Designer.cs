namespace _2024_1_17.COURSE
{
    partial class frmRemoveCourse
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
            this.txbCourseID = new System.Windows.Forms.TextBox();
            this.lblEnterCourseID = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbCourseID
            // 
            this.txbCourseID.Location = new System.Drawing.Point(264, 111);
            this.txbCourseID.Name = "txbCourseID";
            this.txbCourseID.Size = new System.Drawing.Size(254, 22);
            this.txbCourseID.TabIndex = 6;
            // 
            // lblEnterCourseID
            // 
            this.lblEnterCourseID.AutoSize = true;
            this.lblEnterCourseID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblEnterCourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterCourseID.ForeColor = System.Drawing.Color.Black;
            this.lblEnterCourseID.Location = new System.Drawing.Point(47, 111);
            this.lblEnterCourseID.Name = "lblEnterCourseID";
            this.lblEnterCourseID.Size = new System.Drawing.Size(188, 20);
            this.lblEnterCourseID.TabIndex = 5;
            this.lblEnterCourseID.Text = "Enter The Course ID:";
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(562, 103);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(124, 36);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // frmRemoveCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(731, 264);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.txbCourseID);
            this.Controls.Add(this.lblEnterCourseID);
            this.Name = "frmRemoveCourse";
            this.Text = "Remove Course";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbCourseID;
        private System.Windows.Forms.Label lblEnterCourseID;
        private System.Windows.Forms.Button btnRemove;
    }
}