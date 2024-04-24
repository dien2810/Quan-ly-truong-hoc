using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2024_1_17.COURSE;


namespace _2024_1_17.RESULT
{
    public partial class frmAvgResultByScore : Form
    {
        COURSE.COURSE course = new COURSE.COURSE();
        SCORE score = new SCORE();
        public frmAvgResultByScore()
        {
            InitializeComponent();
        }

        private void frmAvgResultByScore_Load(object sender, EventArgs e)
        {
            
            DataTable courseData = course.getAllCourses();
            DataTable result = new DataTable();
            result.Columns.Add("student_id");
            result.Columns.Add("fname");
            result.Columns.Add("lname");            
            for (int i = 0; i < courseData.Rows.Count; i++)
            {
                DataRow row = courseData.Rows[i];
                result.Columns.Add(row["id"].ToString()+": "+row["label"].ToString().Trim());
            }
            result.Columns.Add("Average", typeof(float));
            result.Columns.Add("Result");
            Dictionary<int,int> keyValuePairs = new Dictionary<int, int>();
            DataTable scoreData = score.getStudentScores();
            DataTable listStudent = score.getStudentHasScore();
            DataTable avg = score.getAvgScoreByStudent();
            int count = 0;
            for (int i = 0; i < listStudent.Rows.Count; i++)
            {
                int student_id = Convert.ToInt32(listStudent.Rows[i][0].ToString());
                string firstName = listStudent.Rows[i][1].ToString().Trim();
                string lastName = listStudent.Rows[i][2].ToString().Trim();
                result.Rows.Add(student_id, firstName, lastName);
                float avgScore = (float)Convert.ToDouble(avg.Rows[i][3].ToString());
                string avgResult = "";
                if (avgScore >= 8)
                    avgResult = "Gioi";
                else
                    if (avgScore >= 6.5)
                    avgResult = "Kha";
                    else
                        if (avgScore >= 5)
                            avgResult = "Trung binh";
                        else
                            if (avgScore >= 3) avgResult = "Yeu";
                            else avgResult = "Kem";
                result.Rows[i][courseData.Rows.Count + 3] = avgScore;
                result.Rows[i][courseData.Rows.Count + 4] = avgResult;
                keyValuePairs.Add(student_id, count);
                count++;
                
            }
            for (int i = 0; i < scoreData.Rows.Count; i++)
            {
                int row = keyValuePairs[Convert.ToInt32(scoreData.Rows[i][0].ToString())];
                string column = scoreData.Rows[i][3].ToString().Trim() + ": "
                    + scoreData.Rows[i][4].ToString().Trim();
                float value = (float)Convert.ToDouble(scoreData.Rows[i][5].ToString());
                result.Rows[row][column] = value;            
            }
            dtgResult.DataSource = result;
            dtgResult.Columns[0].HeaderText = "Student ID";
            dtgResult.Columns[1].HeaderText = "First Name";
            dtgResult.Columns[2].HeaderText = "Last Name";
        }

        private void dtgResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbStudentID.Text = dtgResult.CurrentRow.Cells[0].Value.ToString().Trim();
            txbFirstName.Text = dtgResult.CurrentRow.Cells[1].Value.ToString().Trim();
            txbLastName.Text = dtgResult.CurrentRow.Cells[2].Value.ToString().Trim();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchDataGridView(string searchText)
        {
            // Xóa lựa chọn hiện tại trên DataGridView
            dtgResult.ClearSelection();
            // Duyệt qua từng hàng trong DataGridView
            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dtgResult.DataSource];
            
            foreach (DataGridViewRow row in dtgResult.Rows)
            {
                
                // Kiểm tra giá trị của cột searchColumn
                if ((row.Cells["student_id"].Value != null && row.Cells["student_id"].Value.ToString().Contains(searchText))||
                    (row.Cells["fname"].Value != null && row.Cells["fname"].Value.ToString().Contains(searchText))||
                    (row.Cells["lname"].Value != null && row.Cells["lname"].Value.ToString().Contains(searchText)))
                {
                    row.Visible = true;
                }
                else
                {
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();
                }
                
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txbSearch.Text.ToString();
            SearchDataGridView(searchValue);
        }
    }
}
