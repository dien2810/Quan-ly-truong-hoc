namespace _2024_1_17.COURSE
{
    partial class frmManageCourse
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblLabel = new System.Windows.Forms.Label();
            this.lblHoursNumber = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.txbCourseName = new System.Windows.Forms.TextBox();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.nupHoursNumber = new System.Windows.Forms.NumericUpDown();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lsbManageCourse = new System.Windows.Forms.ListBox();
            this.lblTotalCourses = new System.Windows.Forms.Label();
            this.lblSemester = new System.Windows.Forms.Label();
            this.cbbSemester = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupHoursNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(73, 50);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(34, 20);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabel.ForeColor = System.Drawing.Color.White;
            this.lblLabel.Location = new System.Drawing.Point(73, 104);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(61, 20);
            this.lblLabel.TabIndex = 2;
            this.lblLabel.Text = "Label:";
            // 
            // lblHoursNumber
            // 
            this.lblHoursNumber.AutoSize = true;
            this.lblHoursNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursNumber.ForeColor = System.Drawing.Color.White;
            this.lblHoursNumber.Location = new System.Drawing.Point(73, 169);
            this.lblHoursNumber.Name = "lblHoursNumber";
            this.lblHoursNumber.Size = new System.Drawing.Size(137, 20);
            this.lblHoursNumber.TabIndex = 3;
            this.lblHoursNumber.Text = "Hours Number:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(73, 227);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(112, 20);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description:";
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(222, 50);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(150, 22);
            this.txbID.TabIndex = 5;
            // 
            // txbCourseName
            // 
            this.txbCourseName.Location = new System.Drawing.Point(222, 102);
            this.txbCourseName.Name = "txbCourseName";
            this.txbCourseName.Size = new System.Drawing.Size(239, 22);
            this.txbCourseName.TabIndex = 7;
            // 
            // txbDescription
            // 
            this.txbDescription.Location = new System.Drawing.Point(222, 227);
            this.txbDescription.Multiline = true;
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(275, 133);
            this.txbDescription.TabIndex = 9;
            // 
            // nupHoursNumber
            // 
            this.nupHoursNumber.Location = new System.Drawing.Point(222, 169);
            this.nupHoursNumber.Name = "nupHoursNumber";
            this.nupHoursNumber.Size = new System.Drawing.Size(150, 22);
            this.nupHoursNumber.TabIndex = 8;
            this.nupHoursNumber.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.ForeColor = System.Drawing.Color.White;
            this.btnFirst.Location = new System.Drawing.Point(32, 377);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(115, 33);
            this.btnFirst.TabIndex = 11;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(362, 377);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(115, 33);
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(197, 377);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(115, 33);
            this.btnPrevious.TabIndex = 12;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.ForeColor = System.Drawing.Color.White;
            this.btnLast.Location = new System.Drawing.Point(527, 377);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(115, 33);
            this.btnLast.TabIndex = 14;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(94, 438);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 41);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(253, 438);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(131, 41);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Red;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(412, 438);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(131, 41);
            this.btnRemove.TabIndex = 17;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lsbManageCourse
            // 
            this.lsbManageCourse.FormattingEnabled = true;
            this.lsbManageCourse.ItemHeight = 16;
            this.lsbManageCourse.Location = new System.Drawing.Point(666, 50);
            this.lsbManageCourse.Name = "lsbManageCourse";
            this.lsbManageCourse.Size = new System.Drawing.Size(315, 372);
            this.lsbManageCourse.TabIndex = 10;
            this.lsbManageCourse.Click += new System.EventHandler(this.lsbManageCourse_Click);
            this.lsbManageCourse.DoubleClick += new System.EventHandler(this.lsbManageCourse_DoubleClick);
            // 
            // lblTotalCourses
            // 
            this.lblTotalCourses.AutoSize = true;
            this.lblTotalCourses.BackColor = System.Drawing.Color.Black;
            this.lblTotalCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCourses.ForeColor = System.Drawing.Color.White;
            this.lblTotalCourses.Location = new System.Drawing.Point(792, 425);
            this.lblTotalCourses.Name = "lblTotalCourses";
            this.lblTotalCourses.Size = new System.Drawing.Size(133, 20);
            this.lblTotalCourses.TabIndex = 18;
            this.lblTotalCourses.Text = "Total Courses:";
            this.lblTotalCourses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemester.ForeColor = System.Drawing.Color.White;
            this.lblSemester.Location = new System.Drawing.Point(408, 52);
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
            this.cbbSemester.Location = new System.Drawing.Point(509, 48);
            this.cbbSemester.Name = "cbbSemester";
            this.cbbSemester.Size = new System.Drawing.Size(121, 24);
            this.cbbSemester.TabIndex = 6;
            // 
            // frmManageCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1041, 502);
            this.Controls.Add(this.cbbSemester);
            this.Controls.Add(this.lblSemester);
            this.Controls.Add(this.lblTotalCourses);
            this.Controls.Add(this.lsbManageCourse);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.nupHoursNumber);
            this.Controls.Add(this.txbDescription);
            this.Controls.Add(this.txbCourseName);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblHoursNumber);
            this.Controls.Add(this.lblLabel);
            this.Controls.Add(this.lblID);
            this.Name = "frmManageCourse";
            this.Text = "Manage Course";
            this.Load += new System.EventHandler(this.frmManageCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupHoursNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.Label lblHoursNumber;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.TextBox txbCourseName;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.NumericUpDown nupHoursNumber;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox lsbManageCourse;
        private System.Windows.Forms.Label lblTotalCourses;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.ComboBox cbbSemester;
    }
}