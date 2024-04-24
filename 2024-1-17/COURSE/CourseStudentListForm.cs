using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024_1_17.COURSE
{
    public partial class frmCourseStudentList : Form
    {
        public DataTable listStudents = new DataTable();
        public string course_name;
        public string semester;

        public string Course_Name
        {
            set
            {
                this.course_name = value;
            }
        }

        public string Semester
        {
            set
            {
                this.semester = value;
            }
        }
        public DataTable ListStudents {            
            set {
                this.listStudents = value;
            }
        }
        public frmCourseStudentList()
        {
            InitializeComponent();
        }

        private void frmCourseStudentList_Load(object sender, EventArgs e)
        {
            txbCourseName.Text = course_name.Trim();
            lblSemester.Text = "Semester: " + semester;

            dtgCourseStudentList.Columns.Add("stt", "STT");
            dtgCourseStudentList.Columns.Add("id", "Student ID");
            dtgCourseStudentList.Columns.Add("fname", "First Name");
            dtgCourseStudentList.Columns.Add("lname", "Last Name");
            dtgCourseStudentList.Columns.Add("bdate", "Date of birth");
            dtgCourseStudentList.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            dtgCourseStudentList.AllowUserToAddRows = false;
            txbCourseName.ReadOnly = true;
            Console.WriteLine(listStudents.Rows.Count);
            for (int i = 0; i < listStudents.Rows.Count; i++)
            {
                // Tạo một dòng mới
                DataGridViewRow row = new DataGridViewRow();

                // Thêm các ô dữ liệu vào dòng
                row.Cells.Add(new DataGridViewTextBoxCell { Value = i+1 });
                //Console.WriteLine(listStudents.Columns.Count);
                for (int j = 0; j < listStudents.Columns.Count; j++)
                {
                    row.Cells.Add(new DataGridViewTextBoxCell 
                    { Value = listStudents.Rows[i][j] });
                    //Console.WriteLine(listStudents.Rows[i][j]);
                }
                // Thêm dòng vào DataGridView
                dtgCourseStudentList.Rows.Add(row);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
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
    }
}
