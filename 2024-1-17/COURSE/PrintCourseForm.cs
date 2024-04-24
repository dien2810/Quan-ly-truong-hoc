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

namespace _2024_1_17.COURSE
{
    public partial class frmPrintCourse : Form
    {
        COURSE course = new COURSE();
        public frmPrintCourse()
        {
            InitializeComponent();
        }

        void fillGrid(SqlCommand cmd)
        {
            dtgPrint.ReadOnly = true;
            //xu ly hinh anh, code co tham khao msdn            
            dtgPrint.RowTemplate.Height = 80;//dong nay tham khao tren msdn, co gian de pic dep, dang tim auto-size
            dtgPrint.DataSource = course.getCourses(cmd);            
            dtgPrint.AllowUserToAddRows = false;
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
                String path = "E:\\Dien\\Dai hoc\\Lap trinh tren Windows\\Week 7"
                    + @"\courses_list.txt";
                using (TextWriter writer = new StreamWriter(path))
                {
                    if (!File.Exists(path))
                    {
                        File.Create(path);
                    }
                    //sinh vien nhin vao file huong dan lam tieu de cho cac cot
                    for (int i = 0; i < dtgPrint.Rows.Count; i++)
                    {
                        for (int j = 0; j < dtgPrint.Columns.Count - 1; j++)
                        {
                            if (j == dtgPrint.Columns.Count - 2)
                            {
                                writer.Write("\t" + dtgPrint.Rows[i].Cells[j].Value.ToString());
                            }
                            else
                            {
                                writer.Write("\t" + dtgPrint.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                            }
                        }
                        writer.WriteLine("");
                        writer.WriteLine("--------------------------------------------------------------------------------------------------------------");
                    }
                    writer.Close();
                    MessageBox.Show("File Saved", "Save file", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FileLoadException fe)
            {
                MessageBox.Show("Error: " + fe.Message.ToString(), "Save File", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void frmPrintCourse_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Course");
            fillGrid(command);
        }
    }
}
