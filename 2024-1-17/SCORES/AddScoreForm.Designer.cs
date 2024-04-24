namespace _2024_1_17.COURSE
{
    partial class frmAddScore
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
            this.lblSelectCourse = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.txbScore = new System.Windows.Forms.TextBox();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.cbbSelectScore = new System.Windows.Forms.ComboBox();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(33, 40);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(104, 20);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Student ID:";
            // 
            // lblSelectCourse
            // 
            this.lblSelectCourse.AutoSize = true;
            this.lblSelectCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCourse.ForeColor = System.Drawing.Color.White;
            this.lblSelectCourse.Location = new System.Drawing.Point(33, 108);
            this.lblSelectCourse.Name = "lblSelectCourse";
            this.lblSelectCourse.Size = new System.Drawing.Size(134, 20);
            this.lblSelectCourse.TabIndex = 1;
            this.lblSelectCourse.Text = "Select Course:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(33, 176);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(64, 20);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(33, 244);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(112, 20);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description:";
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(204, 40);
            this.txbID.Name = "txbID";
            this.txbID.ReadOnly = true;
            this.txbID.Size = new System.Drawing.Size(170, 22);
            this.txbID.TabIndex = 4;
            // 
            // txbScore
            // 
            this.txbScore.Location = new System.Drawing.Point(204, 174);
            this.txbScore.Name = "txbScore";
            this.txbScore.Size = new System.Drawing.Size(170, 22);
            this.txbScore.TabIndex = 5;
            // 
            // txbDescription
            // 
            this.txbDescription.Location = new System.Drawing.Point(204, 240);
            this.txbDescription.Multiline = true;
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(221, 130);
            this.txbDescription.TabIndex = 6;
            // 
            // cbbSelectScore
            // 
            this.cbbSelectScore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSelectScore.FormattingEnabled = true;
            this.cbbSelectScore.Location = new System.Drawing.Point(204, 106);
            this.cbbSelectScore.Name = "cbbSelectScore";
            this.cbbSelectScore.Size = new System.Drawing.Size(221, 24);
            this.cbbSelectScore.TabIndex = 7;
            // 
            // dgvStudent
            // 
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(446, 40);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersWidth = 51;
            this.dgvStudent.RowTemplate.Height = 24;
            this.dgvStudent.Size = new System.Drawing.Size(410, 395);
            this.dgvStudent.TabIndex = 8;
            this.dgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.Location = new System.Drawing.Point(121, 401);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(154, 34);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmAddScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(868, 479);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.cbbSelectScore);
            this.Controls.Add(this.txbDescription);
            this.Controls.Add(this.txbScore);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblSelectCourse);
            this.Controls.Add(this.lblID);
            this.Name = "frmAddScore";
            this.Text = "Add Score";
            this.Load += new System.EventHandler(this.frmAddScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblSelectCourse;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.TextBox txbScore;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.ComboBox cbbSelectScore;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Button btnAdd;
    }
}