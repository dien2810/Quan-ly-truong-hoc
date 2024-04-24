namespace _2024_1_17.COURSE
{
    partial class AddCourseFrm
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
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblSemester = new System.Windows.Forms.Label();
            this.lblAvailableCourse = new System.Windows.Forms.Label();
            this.lblSelectedCourse = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txbStudentID = new System.Windows.Forms.TextBox();
            this.cbbSemester = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lsbAvailableCourse = new System.Windows.Forms.ListBox();
            this.lsbSelectedCourse = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.ForeColor = System.Drawing.Color.White;
            this.lblStudentID.Location = new System.Drawing.Point(51, 54);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(104, 20);
            this.lblStudentID.TabIndex = 0;
            this.lblStudentID.Text = "Student ID:";
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemester.ForeColor = System.Drawing.Color.White;
            this.lblSemester.Location = new System.Drawing.Point(473, 51);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(95, 20);
            this.lblSemester.TabIndex = 2;
            this.lblSemester.Text = "Semester:";
            // 
            // lblAvailableCourse
            // 
            this.lblAvailableCourse.AutoSize = true;
            this.lblAvailableCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableCourse.ForeColor = System.Drawing.Color.White;
            this.lblAvailableCourse.Location = new System.Drawing.Point(51, 121);
            this.lblAvailableCourse.Name = "lblAvailableCourse";
            this.lblAvailableCourse.Size = new System.Drawing.Size(157, 20);
            this.lblAvailableCourse.TabIndex = 2;
            this.lblAvailableCourse.Text = "Available Course:";
            // 
            // lblSelectedCourse
            // 
            this.lblSelectedCourse.AutoSize = true;
            this.lblSelectedCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedCourse.ForeColor = System.Drawing.Color.White;
            this.lblSelectedCourse.Location = new System.Drawing.Point(593, 121);
            this.lblSelectedCourse.Name = "lblSelectedCourse";
            this.lblSelectedCourse.Size = new System.Drawing.Size(154, 20);
            this.lblSelectedCourse.TabIndex = 3;
            this.lblSelectedCourse.Text = "Selected Course:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(356, 235);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 46);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txbStudentID
            // 
            this.txbStudentID.Location = new System.Drawing.Point(171, 51);
            this.txbStudentID.Name = "txbStudentID";
            this.txbStudentID.Size = new System.Drawing.Size(230, 22);
            this.txbStudentID.TabIndex = 1;
            // 
            // cbbSemester
            // 
            this.cbbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSemester.FormattingEnabled = true;
            this.cbbSemester.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbbSemester.Location = new System.Drawing.Point(587, 50);
            this.cbbSemester.Name = "cbbSemester";
            this.cbbSemester.Size = new System.Drawing.Size(139, 24);
            this.cbbSemester.TabIndex = 2;
            this.cbbSemester.SelectedIndexChanged += new System.EventHandler(this.cbbSemester_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(356, 318);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 46);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lsbAvailableCourse
            // 
            this.lsbAvailableCourse.FormattingEnabled = true;
            this.lsbAvailableCourse.ItemHeight = 16;
            this.lsbAvailableCourse.Location = new System.Drawing.Point(55, 152);
            this.lsbAvailableCourse.Name = "lsbAvailableCourse";
            this.lsbAvailableCourse.Size = new System.Drawing.Size(259, 260);
            this.lsbAvailableCourse.TabIndex = 8;
            this.lsbAvailableCourse.Click += new System.EventHandler(this.lsbAvailableCourse_Click);
            // 
            // lsbSelectedCourse
            // 
            this.lsbSelectedCourse.FormattingEnabled = true;
            this.lsbSelectedCourse.ItemHeight = 16;
            this.lsbSelectedCourse.Location = new System.Drawing.Point(488, 152);
            this.lsbSelectedCourse.Name = "lsbSelectedCourse";
            this.lsbSelectedCourse.Size = new System.Drawing.Size(259, 260);
            this.lsbSelectedCourse.TabIndex = 9;
            // 
            // AddCourseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsbSelectedCourse);
            this.Controls.Add(this.lsbAvailableCourse);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbbSemester);
            this.Controls.Add(this.txbStudentID);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblSelectedCourse);
            this.Controls.Add(this.lblAvailableCourse);
            this.Controls.Add(this.lblSemester);
            this.Controls.Add(this.lblStudentID);
            this.Name = "AddCourseFrm";
            this.Text = "Add Course";
            this.Load += new System.EventHandler(this.AddCourseFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.Label lblAvailableCourse;
        private System.Windows.Forms.Label lblSelectedCourse;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txbStudentID;
        private System.Windows.Forms.ComboBox cbbSemester;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox lsbAvailableCourse;
        private System.Windows.Forms.ListBox lsbSelectedCourse;
    }
}