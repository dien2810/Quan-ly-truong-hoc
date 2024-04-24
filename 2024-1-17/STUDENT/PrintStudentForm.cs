using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024_1_17
{
    public partial class frmPrint : Form
    {
        STUDENT student = new STUDENT();
        public frmPrint()
        {
            InitializeComponent();
        }

        void fillGrid(SqlCommand cmd)
        {
            dtgPrint.ReadOnly = true;
            //xu ly hinh anh, code co tham khao msdn
            DataGridViewImageColumn picCol = new DataGridViewImageColumn(); //doi tuong lam viec voi dang picture
            dtgPrint.RowTemplate.Height = 80;//dong nay tham khao tren msdn, co gian de pic dep, dang tim auto-size
            dtgPrint.DataSource = student.getStudents(cmd);
            picCol = (DataGridViewImageColumn)dtgPrint.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dtgPrint.AllowUserToAddRows = false;       
        }

        private void frmPrint_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM std");
            fillGrid(command);
            if (rdbNo.Checked )
            {
                dtpFrom.Enabled = false;
                dtpTo.Enabled = false;
            }
        }

        private void rdbYes_CheckedChanged(object sender, EventArgs e)
        {
            dtpFrom.Enabled = true;
            dtpTo.Enabled = true;
        }

        private void rdbNo_CheckedChanged(object sender, EventArgs e)
        {
            dtpFrom.Enabled = false;
            dtpTo.Enabled = false;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            String query;
            if (rdbYes.Checked ) {
                string dateFrom = dtpFrom.Value.ToString("yyyy-MM-dd");
                string dateTo = dtpTo.Value.ToString("yyyy-MM-dd");
                if (rdbMale.Checked )
                {
                    query = "SELECT * FROM std WHERE gender = 'Male' and bdate BETWEEN '" + dateFrom +
                        "'AND' " + dateTo + "'";                    
                }
                else if (rdbFemale.Checked )
                {
                    query = "SELECT * FROM std WHERE gender = 'Female' and bdate BETWEEN '" + dateFrom +
                        "'AND' " + dateTo + "'";
                }
                else
                {
                    query = "SELECT * FROM std WHERE bdate BETWEEN '" + dateFrom +
                        "'AND' " + dateTo + "'";
                }
                command = new SqlCommand(query);
                fillGrid(command);
            }
            //Neu khong can theo date
            else
            {
                if (rdbMale.Checked)
                {
                    query = "SELECT * FROM std WHERE gender = 'Male'";
                }
                else if (rdbFemale.Checked)
                {
                    query = "SELECT * FROM std WHERE gender = 'Female'";
                }
                else
                {
                    query = "SELECT * FROM std";
                }
            }
            command = new SqlCommand(query);
            fillGrid(command);
        }

        private void btnToPrinter_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDialog.Document = printDoc;
            printDialog.AllowSelection = true;
            printDialog.AllowSomePages = true;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }
        }

        private void btnSaveToTextFile_Click(object sender, EventArgs e)
        {
            try
            {
                String path = @"E:\Dien\Dai hoc\Lap trinh tren Windows\import\studentList.txt";
                using (TextWriter writer = new StreamWriter(path))
                {
                    if (!File.Exists(path))
                    {
                        File.Create(path);
                    }
                    DateTime bdate;
                    //sinh vien nhin vao file huong dan lam tieu de cho cac cot
                    for (int i = 0; i < dtgPrint.Rows.Count; i++)
                    {
                        for (int j = 0; j < dtgPrint.Columns.Count - 2; j++)
                        {
                            if (j == 3)
                            {
                                bdate = Convert.ToDateTime(dtgPrint.Rows[i].Cells[j].Value.ToString());
                                writer.Write("\t" + bdate.ToString("yyyy-MM-dd") + "\t" + "|");
                            }
                            else if (j == dtgPrint.Columns.Count - 2)
                            {
                                writer.Write("\t" + dtgPrint.Rows[i].Cells[j].Value.ToString().Trim());
                            }
                            else
                            {
                                writer.Write("\t" + dtgPrint.Rows[i].Cells[j].Value.ToString().Trim() + "\t" + "|");
                            }
                        }
                        writer.WriteLine("");
                        writer.WriteLine("-----------------------------------------------------------------------------------------------------------");
                    }
                    writer.Close();
                    MessageBox.Show("File Saved On E:\\Dien\\Dai hoc\\Lap trinh tren Windows\\import\\studentList.txt", "Save file", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FileLoadException fe)
            {
                MessageBox.Show("Error: " + fe.Message.ToString(), "Save File", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }
    }
}
