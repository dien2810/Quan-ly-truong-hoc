namespace _2024_1_17.CONTACT
{
    partial class frmSelectContact
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
            this.dtgSelectContact = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSelectContact)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgSelectContact
            // 
            this.dtgSelectContact.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgSelectContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSelectContact.Location = new System.Drawing.Point(31, 23);
            this.dtgSelectContact.Name = "dtgSelectContact";
            this.dtgSelectContact.RowHeadersWidth = 51;
            this.dtgSelectContact.RowTemplate.Height = 24;
            this.dtgSelectContact.Size = new System.Drawing.Size(736, 392);
            this.dtgSelectContact.TabIndex = 0;
            // 
            // frmSelectContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgSelectContact);
            this.Name = "frmSelectContact";
            this.Text = "Select Contact";
            ((System.ComponentModel.ISupportInitialize)(this.dtgSelectContact)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgSelectContact;
    }
}