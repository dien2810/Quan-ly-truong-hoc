namespace _2024_1_17.COURSE
{
    partial class frmAddCourse
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
            this.lblCourseID = new System.Windows.Forms.Label();
            this.lblLabel = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txbCourseID = new System.Windows.Forms.TextBox();
            this.txbLabel = new System.Windows.Forms.TextBox();
            this.txbPeriod = new System.Windows.Forms.TextBox();
            this.rtxbDescription = new System.Windows.Forms.RichTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblSemester = new System.Windows.Forms.Label();
            this.cbbSemester = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblCourseID
            // 
            this.lblCourseID.AutoSize = true;
            this.lblCourseID.BackColor = System.Drawing.Color.Blue;
            this.lblCourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseID.ForeColor = System.Drawing.Color.White;
            this.lblCourseID.Location = new System.Drawing.Point(99, 55);
            this.lblCourseID.Name = "lblCourseID";
            this.lblCourseID.Size = new System.Drawing.Size(94, 20);
            this.lblCourseID.TabIndex = 0;
            this.lblCourseID.Text = "CourseID:";
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabel.ForeColor = System.Drawing.Color.White;
            this.lblLabel.Location = new System.Drawing.Point(99, 112);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(61, 20);
            this.lblLabel.TabIndex = 2;
            this.lblLabel.Text = "Label:";
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriod.ForeColor = System.Drawing.Color.White;
            this.lblPeriod.Location = new System.Drawing.Point(99, 169);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(69, 20);
            this.lblPeriod.TabIndex = 3;
            this.lblPeriod.Text = "Period:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(99, 226);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(112, 20);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description:";
            // 
            // txbCourseID
            // 
            this.txbCourseID.Location = new System.Drawing.Point(236, 53);
            this.txbCourseID.Name = "txbCourseID";
            this.txbCourseID.Size = new System.Drawing.Size(226, 22);
            this.txbCourseID.TabIndex = 5;
            // 
            // txbLabel
            // 
            this.txbLabel.Location = new System.Drawing.Point(236, 110);
            this.txbLabel.Name = "txbLabel";
            this.txbLabel.Size = new System.Drawing.Size(370, 22);
            this.txbLabel.TabIndex = 7;
            // 
            // txbPeriod
            // 
            this.txbPeriod.Location = new System.Drawing.Point(236, 167);
            this.txbPeriod.Name = "txbPeriod";
            this.txbPeriod.Size = new System.Drawing.Size(254, 22);
            this.txbPeriod.TabIndex = 8;
            // 
            // rtxbDescription
            // 
            this.rtxbDescription.Location = new System.Drawing.Point(236, 227);
            this.rtxbDescription.Name = "rtxbDescription";
            this.rtxbDescription.Size = new System.Drawing.Size(370, 139);
            this.rtxbDescription.TabIndex = 9;
            this.rtxbDescription.Text = "";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(338, 390);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 36);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.BackColor = System.Drawing.Color.Blue;
            this.lblSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemester.ForeColor = System.Drawing.Color.White;
            this.lblSemester.Location = new System.Drawing.Point(496, 55);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(95, 20);
            this.lblSemester.TabIndex = 1;
            this.lblSemester.Text = "Semester:";
            // 
            // cbbSemester
            // 
            this.cbbSemester.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3"});
            this.cbbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSemester.FormattingEnabled = true;
            this.cbbSemester.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbbSemester.Location = new System.Drawing.Point(605, 53);
            this.cbbSemester.Name = "cbbSemester";
            this.cbbSemester.Size = new System.Drawing.Size(121, 24);
            this.cbbSemester.TabIndex = 6;
            // 
            // frmAddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbbSemester);
            this.Controls.Add(this.lblSemester);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.rtxbDescription);
            this.Controls.Add(this.txbPeriod);
            this.Controls.Add(this.txbLabel);
            this.Controls.Add(this.txbCourseID);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.lblLabel);
            this.Controls.Add(this.lblCourseID);
            this.Name = "frmAddCourse";
            this.Text = "Add Course";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCourseID;
        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txbCourseID;
        private System.Windows.Forms.TextBox txbLabel;
        private System.Windows.Forms.TextBox txbPeriod;
        private System.Windows.Forms.RichTextBox rtxbDescription;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.ComboBox cbbSemester;
    }
}