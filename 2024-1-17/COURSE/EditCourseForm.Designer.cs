namespace _2024_1_17.COURSE
{
    partial class frmEditCourse
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.rtxbDescription = new System.Windows.Forms.RichTextBox();
            this.txbLabel = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblLabel = new System.Windows.Forms.Label();
            this.lblSelectCourse = new System.Windows.Forms.Label();
            this.cbbSelectCourse = new System.Windows.Forms.ComboBox();
            this.nudPeriod = new System.Windows.Forms.NumericUpDown();
            this.lblSemester = new System.Windows.Forms.Label();
            this.cbbSemester = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeriod)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(343, 386);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(124, 36);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // rtxbDescription
            // 
            this.rtxbDescription.Location = new System.Drawing.Point(295, 213);
            this.rtxbDescription.Name = "rtxbDescription";
            this.rtxbDescription.Size = new System.Drawing.Size(370, 139);
            this.rtxbDescription.TabIndex = 18;
            this.rtxbDescription.Text = "";
            // 
            // txbLabel
            // 
            this.txbLabel.Location = new System.Drawing.Point(295, 96);
            this.txbLabel.Name = "txbLabel";
            this.txbLabel.Size = new System.Drawing.Size(370, 22);
            this.txbLabel.TabIndex = 16;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(147, 212);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(112, 20);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "Description:";
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriod.ForeColor = System.Drawing.Color.White;
            this.lblPeriod.Location = new System.Drawing.Point(147, 155);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(69, 20);
            this.lblPeriod.TabIndex = 11;
            this.lblPeriod.Text = "Period:";
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabel.ForeColor = System.Drawing.Color.White;
            this.lblLabel.Location = new System.Drawing.Point(147, 98);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(61, 20);
            this.lblLabel.TabIndex = 10;
            this.lblLabel.Text = "Label:";
            // 
            // lblSelectCourse
            // 
            this.lblSelectCourse.AutoSize = true;
            this.lblSelectCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblSelectCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCourse.ForeColor = System.Drawing.Color.White;
            this.lblSelectCourse.Location = new System.Drawing.Point(147, 41);
            this.lblSelectCourse.Name = "lblSelectCourse";
            this.lblSelectCourse.Size = new System.Drawing.Size(134, 20);
            this.lblSelectCourse.TabIndex = 9;
            this.lblSelectCourse.Text = "Select Course:";
            // 
            // cbbSelectCourse
            // 
            this.cbbSelectCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSelectCourse.FormattingEnabled = true;
            this.cbbSelectCourse.Location = new System.Drawing.Point(295, 37);
            this.cbbSelectCourse.Name = "cbbSelectCourse";
            this.cbbSelectCourse.Size = new System.Drawing.Size(185, 24);
            this.cbbSelectCourse.TabIndex = 14;
            this.cbbSelectCourse.SelectedIndexChanged += new System.EventHandler(this.cbbSelectCourse_SelectedIndexChanged);
            this.cbbSelectCourse.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbbSelectCourse_KeyDown);
            this.cbbSelectCourse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbSelectCourse_KeyPress);
            // 
            // nudPeriod
            // 
            this.nudPeriod.Location = new System.Drawing.Point(295, 153);
            this.nudPeriod.Name = "nudPeriod";
            this.nudPeriod.Size = new System.Drawing.Size(120, 22);
            this.nudPeriod.TabIndex = 17;
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemester.ForeColor = System.Drawing.Color.White;
            this.lblSemester.Location = new System.Drawing.Point(504, 41);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(95, 20);
            this.lblSemester.TabIndex = 13;
            this.lblSemester.Text = "Semester:";
            // 
            // cbbSemester
            // 
            this.cbbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSemester.FormattingEnabled = true;
            this.cbbSemester.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbbSemester.Location = new System.Drawing.Point(607, 37);
            this.cbbSemester.Name = "cbbSemester";
            this.cbbSemester.Size = new System.Drawing.Size(131, 24);
            this.cbbSemester.TabIndex = 15;
            this.cbbSemester.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbbSemester_KeyDown);
            this.cbbSemester.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbSemester_KeyPress);
            // 
            // frmEditCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbbSemester);
            this.Controls.Add(this.lblSemester);
            this.Controls.Add(this.nudPeriod);
            this.Controls.Add(this.cbbSelectCourse);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.rtxbDescription);
            this.Controls.Add(this.txbLabel);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.lblLabel);
            this.Controls.Add(this.lblSelectCourse);
            this.Name = "frmEditCourse";
            this.Text = "Edit Course";
            this.Load += new System.EventHandler(this.frmEditCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPeriod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.RichTextBox rtxbDescription;
        private System.Windows.Forms.TextBox txbLabel;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.Label lblSelectCourse;
        private System.Windows.Forms.ComboBox cbbSelectCourse;
        private System.Windows.Forms.NumericUpDown nudPeriod;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.ComboBox cbbSemester;
    }
}