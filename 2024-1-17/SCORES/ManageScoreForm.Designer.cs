namespace _2024_1_17.SCORES
{
    partial class frmManageScore
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
            this.cbbSelectScore = new System.Windows.Forms.ComboBox();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.txbScore = new System.Windows.Forms.TextBox();
            this.txbID = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblSelectCourse = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.dtgResult = new System.Windows.Forms.DataGridView();
            this.btnShowStudents = new System.Windows.Forms.Button();
            this.btnShowScores = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAvgScoreByCourse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResult)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbSelectScore
            // 
            this.cbbSelectScore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSelectScore.FormattingEnabled = true;
            this.cbbSelectScore.Location = new System.Drawing.Point(206, 97);
            this.cbbSelectScore.Name = "cbbSelectScore";
            this.cbbSelectScore.Size = new System.Drawing.Size(271, 24);
            this.cbbSelectScore.TabIndex = 13;
            // 
            // txbDescription
            // 
            this.txbDescription.Location = new System.Drawing.Point(206, 231);
            this.txbDescription.Multiline = true;
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(401, 273);
            this.txbDescription.TabIndex = 15;
            // 
            // txbScore
            // 
            this.txbScore.Location = new System.Drawing.Point(206, 165);
            this.txbScore.Name = "txbScore";
            this.txbScore.Size = new System.Drawing.Size(143, 22);
            this.txbScore.TabIndex = 14;
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(206, 31);
            this.txbID.Name = "txbID";
            this.txbID.ReadOnly = true;
            this.txbID.Size = new System.Drawing.Size(271, 22);
            this.txbID.TabIndex = 12;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(35, 235);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(112, 20);
            this.lblDescription.TabIndex = 11;
            this.lblDescription.Text = "Description:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(35, 167);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(64, 20);
            this.lblScore.TabIndex = 10;
            this.lblScore.Text = "Score:";
            // 
            // lblSelectCourse
            // 
            this.lblSelectCourse.AutoSize = true;
            this.lblSelectCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCourse.ForeColor = System.Drawing.Color.White;
            this.lblSelectCourse.Location = new System.Drawing.Point(35, 99);
            this.lblSelectCourse.Name = "lblSelectCourse";
            this.lblSelectCourse.Size = new System.Drawing.Size(134, 20);
            this.lblSelectCourse.TabIndex = 9;
            this.lblSelectCourse.Text = "Select Course:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(35, 31);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(104, 20);
            this.lblID.TabIndex = 8;
            this.lblID.Text = "Student ID:";
            // 
            // dtgResult
            // 
            this.dtgResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgResult.Location = new System.Drawing.Point(659, 85);
            this.dtgResult.Name = "dtgResult";
            this.dtgResult.RowHeadersWidth = 51;
            this.dtgResult.RowTemplate.Height = 24;
            this.dtgResult.Size = new System.Drawing.Size(792, 624);
            this.dtgResult.TabIndex = 16;
            this.dtgResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgResult_CellClick);
            // 
            // btnShowStudents
            // 
            this.btnShowStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowStudents.Location = new System.Drawing.Point(659, 56);
            this.btnShowStudents.Name = "btnShowStudents";
            this.btnShowStudents.Size = new System.Drawing.Size(373, 23);
            this.btnShowStudents.TabIndex = 17;
            this.btnShowStudents.Text = "Show Students";
            this.btnShowStudents.UseVisualStyleBackColor = true;
            this.btnShowStudents.Click += new System.EventHandler(this.btnShowStudents_Click);
            // 
            // btnShowScores
            // 
            this.btnShowScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowScores.Location = new System.Drawing.Point(1078, 56);
            this.btnShowScores.Name = "btnShowScores";
            this.btnShowScores.Size = new System.Drawing.Size(373, 23);
            this.btnShowScores.TabIndex = 18;
            this.btnShowScores.Text = "Show Scores";
            this.btnShowScores.UseVisualStyleBackColor = true;
            this.btnShowScores.Click += new System.EventHandler(this.btnShowScores_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(68, 560);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(185, 47);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Red;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(397, 560);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(185, 47);
            this.btnRemove.TabIndex = 20;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAvgScoreByCourse
            // 
            this.btnAvgScoreByCourse.BackColor = System.Drawing.Color.Blue;
            this.btnAvgScoreByCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvgScoreByCourse.ForeColor = System.Drawing.Color.White;
            this.btnAvgScoreByCourse.Location = new System.Drawing.Point(173, 662);
            this.btnAvgScoreByCourse.Name = "btnAvgScoreByCourse";
            this.btnAvgScoreByCourse.Size = new System.Drawing.Size(355, 47);
            this.btnAvgScoreByCourse.TabIndex = 21;
            this.btnAvgScoreByCourse.Text = "Average Score By Course";
            this.btnAvgScoreByCourse.UseVisualStyleBackColor = false;
            this.btnAvgScoreByCourse.Click += new System.EventHandler(this.btnAvgScoreByCourse_Click);
            // 
            // frmManageScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1498, 761);
            this.Controls.Add(this.btnAvgScoreByCourse);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnShowScores);
            this.Controls.Add(this.btnShowStudents);
            this.Controls.Add(this.dtgResult);
            this.Controls.Add(this.cbbSelectScore);
            this.Controls.Add(this.txbDescription);
            this.Controls.Add(this.txbScore);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblSelectCourse);
            this.Controls.Add(this.lblID);
            this.Name = "frmManageScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Score";
            this.Load += new System.EventHandler(this.frmManageScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbSelectScore;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.TextBox txbScore;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblSelectCourse;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DataGridView dtgResult;
        private System.Windows.Forms.Button btnShowStudents;
        private System.Windows.Forms.Button btnShowScores;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAvgScoreByCourse;
    }
}