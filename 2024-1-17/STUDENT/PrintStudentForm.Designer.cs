namespace _2024_1_17
{
    partial class frmPrint
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
            this.dtgPrint = new System.Windows.Forms.DataGridView();
            this.btnSaveToTextFile = new System.Windows.Forms.Button();
            this.btnToPrinter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbNo = new System.Windows.Forms.RadioButton();
            this.rdbYes = new System.Windows.Forms.RadioButton();
            this.lblAnd = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblBirthdayBetween = new System.Windows.Forms.Label();
            this.lblUseDateRange = new System.Windows.Forms.Label();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.rdbAll = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrint)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgPrint
            // 
            this.dtgPrint.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgPrint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPrint.Location = new System.Drawing.Point(12, 150);
            this.dtgPrint.Name = "dtgPrint";
            this.dtgPrint.RowHeadersWidth = 51;
            this.dtgPrint.RowTemplate.Height = 24;
            this.dtgPrint.Size = new System.Drawing.Size(1068, 393);
            this.dtgPrint.TabIndex = 1;
            // 
            // btnSaveToTextFile
            // 
            this.btnSaveToTextFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSaveToTextFile.Location = new System.Drawing.Point(195, 562);
            this.btnSaveToTextFile.Name = "btnSaveToTextFile";
            this.btnSaveToTextFile.Size = new System.Drawing.Size(208, 49);
            this.btnSaveToTextFile.TabIndex = 2;
            this.btnSaveToTextFile.Text = "Save To Text File";
            this.btnSaveToTextFile.UseVisualStyleBackColor = false;
            this.btnSaveToTextFile.Click += new System.EventHandler(this.btnSaveToTextFile_Click);
            // 
            // btnToPrinter
            // 
            this.btnToPrinter.BackColor = System.Drawing.Color.Cyan;
            this.btnToPrinter.Location = new System.Drawing.Point(669, 562);
            this.btnToPrinter.Name = "btnToPrinter";
            this.btnToPrinter.Size = new System.Drawing.Size(208, 49);
            this.btnToPrinter.TabIndex = 3;
            this.btnToPrinter.Text = "To Printer";
            this.btnToPrinter.UseVisualStyleBackColor = false;
            this.btnToPrinter.Click += new System.EventHandler(this.btnToPrinter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCheck);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.rdbFemale);
            this.groupBox1.Controls.Add(this.rdbMale);
            this.groupBox1.Controls.Add(this.rdbAll);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1068, 132);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCheck.Location = new System.Drawing.Point(878, 48);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(152, 43);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbNo);
            this.groupBox2.Controls.Add(this.rdbYes);
            this.groupBox2.Controls.Add(this.lblAnd);
            this.groupBox2.Controls.Add(this.dtpTo);
            this.groupBox2.Controls.Add(this.dtpFrom);
            this.groupBox2.Controls.Add(this.lblBirthdayBetween);
            this.groupBox2.Controls.Add(this.lblUseDateRange);
            this.groupBox2.Location = new System.Drawing.Point(333, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 116);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // rdbNo
            // 
            this.rdbNo.AutoSize = true;
            this.rdbNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbNo.Location = new System.Drawing.Point(309, 29);
            this.rdbNo.Name = "rdbNo";
            this.rdbNo.Size = new System.Drawing.Size(57, 24);
            this.rdbNo.TabIndex = 6;
            this.rdbNo.TabStop = true;
            this.rdbNo.Text = "NO";
            this.rdbNo.UseVisualStyleBackColor = true;
            this.rdbNo.CheckedChanged += new System.EventHandler(this.rdbNo_CheckedChanged);
            // 
            // rdbYes
            // 
            this.rdbYes.AutoSize = true;
            this.rdbYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbYes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbYes.Location = new System.Drawing.Point(207, 29);
            this.rdbYes.Name = "rdbYes";
            this.rdbYes.Size = new System.Drawing.Size(65, 24);
            this.rdbYes.TabIndex = 5;
            this.rdbYes.TabStop = true;
            this.rdbYes.Text = "YES";
            this.rdbYes.UseVisualStyleBackColor = true;
            this.rdbYes.CheckedChanged += new System.EventHandler(this.rdbYes_CheckedChanged);
            // 
            // lblAnd
            // 
            this.lblAnd.AutoSize = true;
            this.lblAnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAnd.Location = new System.Drawing.Point(320, 73);
            this.lblAnd.Name = "lblAnd";
            this.lblAnd.Size = new System.Drawing.Size(41, 20);
            this.lblAnd.TabIndex = 4;
            this.lblAnd.Text = "And";
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(381, 73);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(116, 22);
            this.dtpTo.TabIndex = 3;
            this.dtpTo.Value = new System.DateTime(2024, 3, 20, 0, 0, 0, 0);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(191, 73);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(116, 22);
            this.dtpFrom.TabIndex = 2;
            this.dtpFrom.Value = new System.DateTime(2024, 3, 20, 0, 0, 0, 0);
            // 
            // lblBirthdayBetween
            // 
            this.lblBirthdayBetween.AutoSize = true;
            this.lblBirthdayBetween.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthdayBetween.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBirthdayBetween.Location = new System.Drawing.Point(21, 76);
            this.lblBirthdayBetween.Name = "lblBirthdayBetween";
            this.lblBirthdayBetween.Size = new System.Drawing.Size(163, 20);
            this.lblBirthdayBetween.TabIndex = 1;
            this.lblBirthdayBetween.Text = "Birthday Between:";
            // 
            // lblUseDateRange
            // 
            this.lblUseDateRange.AutoSize = true;
            this.lblUseDateRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUseDateRange.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUseDateRange.Location = new System.Drawing.Point(21, 29);
            this.lblUseDateRange.Name = "lblUseDateRange";
            this.lblUseDateRange.Size = new System.Drawing.Size(153, 20);
            this.lblUseDateRange.TabIndex = 0;
            this.lblUseDateRange.Text = "Use Date Range:";
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFemale.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbFemale.Location = new System.Drawing.Point(224, 48);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(91, 24);
            this.rdbFemale.TabIndex = 2;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMale.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbMale.Location = new System.Drawing.Point(122, 48);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(70, 24);
            this.rdbMale.TabIndex = 1;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // rdbAll
            // 
            this.rdbAll.AutoSize = true;
            this.rdbAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbAll.Location = new System.Drawing.Point(40, 48);
            this.rdbAll.Name = "rdbAll";
            this.rdbAll.Size = new System.Drawing.Size(52, 24);
            this.rdbAll.TabIndex = 0;
            this.rdbAll.TabStop = true;
            this.rdbAll.Text = "All";
            this.rdbAll.UseVisualStyleBackColor = true;
            // 
            // frmPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1092, 623);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnToPrinter);
            this.Controls.Add(this.btnSaveToTextFile);
            this.Controls.Add(this.dtgPrint);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "frmPrint";
            this.Text = "Print";
            this.Load += new System.EventHandler(this.frmPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrint)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgPrint;
        private System.Windows.Forms.Button btnSaveToTextFile;
        private System.Windows.Forms.Button btnToPrinter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbAll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.RadioButton rdbNo;
        private System.Windows.Forms.RadioButton rdbYes;
        private System.Windows.Forms.Label lblAnd;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblBirthdayBetween;
        private System.Windows.Forms.Label lblUseDateRange;
    }
}