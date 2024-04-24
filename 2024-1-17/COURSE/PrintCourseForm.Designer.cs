namespace _2024_1_17.COURSE
{
    partial class frmPrintCourse
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnToPrinter = new System.Windows.Forms.Button();
            this.btnSaveToTextFile = new System.Windows.Forms.Button();
            this.dtgPrint = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrint)).BeginInit();
            this.SuspendLayout();
            // 
            // btnToPrinter
            // 
            this.btnToPrinter.BackColor = System.Drawing.Color.Cyan;
            this.btnToPrinter.Location = new System.Drawing.Point(587, 398);
            this.btnToPrinter.Name = "btnToPrinter";
            this.btnToPrinter.Size = new System.Drawing.Size(208, 49);
            this.btnToPrinter.TabIndex = 6;
            this.btnToPrinter.Text = "To Printer";
            this.btnToPrinter.UseVisualStyleBackColor = false;
            this.btnToPrinter.Click += new System.EventHandler(this.btnToPrinter_Click);
            // 
            // btnSaveToTextFile
            // 
            this.btnSaveToTextFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSaveToTextFile.Location = new System.Drawing.Point(128, 398);
            this.btnSaveToTextFile.Name = "btnSaveToTextFile";
            this.btnSaveToTextFile.Size = new System.Drawing.Size(208, 49);
            this.btnSaveToTextFile.TabIndex = 5;
            this.btnSaveToTextFile.Text = "Save To Text File";
            this.btnSaveToTextFile.UseVisualStyleBackColor = false;
            this.btnSaveToTextFile.Click += new System.EventHandler(this.btnSaveToTextFile_Click);
            // 
            // dtgPrint
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgPrint.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgPrint.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgPrint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgPrint.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgPrint.Location = new System.Drawing.Point(-1, -1);
            this.dtgPrint.Name = "dtgPrint";
            this.dtgPrint.RowHeadersWidth = 51;
            this.dtgPrint.RowTemplate.Height = 24;
            this.dtgPrint.Size = new System.Drawing.Size(937, 393);
            this.dtgPrint.TabIndex = 4;
            // 
            // frmPrintCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 450);
            this.Controls.Add(this.btnToPrinter);
            this.Controls.Add(this.btnSaveToTextFile);
            this.Controls.Add(this.dtgPrint);
            this.Name = "frmPrintCourse";
            this.Text = "Print Course";
            this.Load += new System.EventHandler(this.frmPrintCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnToPrinter;
        private System.Windows.Forms.Button btnSaveToTextFile;
        private System.Windows.Forms.DataGridView dtgPrint;
    }
}