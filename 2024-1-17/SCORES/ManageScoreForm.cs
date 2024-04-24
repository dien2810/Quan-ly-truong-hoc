using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2024_1_17.COURSE;
namespace _2024_1_17.SCORES
{
    public partial class frmManageScore : Form
    {
        SCORE score = new SCORE();
        STUDENT student = new STUDENT();
        COURSE.COURSE course = new COURSE.COURSE();
        string data = "score";
        public frmManageScore()
        {
            InitializeComponent();
        }


        private void frmManageScore_Load(object sender, EventArgs e)
        {
            dtgResult.DataSource = score.getStudentScores();

            dtgResult.Columns[0].HeaderText = "Student ID";
            dtgResult.Columns[1].HeaderText = "First Name";
            dtgResult.Columns[2].HeaderText = "Last Name";
            dtgResult.Columns[3].HeaderText = "Course ID";
            dtgResult.Columns[4].HeaderText = "Label";
            dtgResult.Columns[5].HeaderText = "Score";
            dtgResult.Columns[6].HeaderText = "Description";

            cbbSelectScore.DataSource = course.getAllCourses();
            cbbSelectScore.DisplayMember = "label";
            cbbSelectScore.ValueMember = "Id";
        }

        private void btnShowScores_Click(object sender, EventArgs e)
        {
            data = "score";
            dtgResult.DataSource = score.getStudentsScore();

            dtgResult.Columns[0].HeaderText = "Student ID";
            dtgResult.Columns[1].HeaderText = "First Name";
            dtgResult.Columns[2].HeaderText = "Last Name";
            dtgResult.Columns[3].HeaderText = "Course ID";
            dtgResult.Columns[4].HeaderText = "Label";
            dtgResult.Columns[5].HeaderText = "Score";
            dtgResult.Columns[6].HeaderText = "Description";
        }

        private void btnShowStudents_Click(object sender, EventArgs e)
        {
            data = "std";
            SqlCommand command = new SqlCommand("SELECT id,fname,lname,bdate FROM std");
            dtgResult.DataSource = student.getStudents(command);

            dtgResult.Columns[0].HeaderText = "Student ID";
            dtgResult.Columns[1].HeaderText = "First Name";
            dtgResult.Columns[2].HeaderText = "Last Name";
            dtgResult.Columns[3].HeaderText = "Birthday";
            dtgResult.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        void getDataFromDataGridView()
        {
            if (data == "std")
            {
                txbID.Text = dtgResult.CurrentRow.Cells[0].Value.ToString().Trim();                
            }
            else if (data == "score")
            {
                txbID.Text = dtgResult.CurrentRow.Cells[0].Value.ToString().Trim();
                cbbSelectScore.SelectedValue = dtgResult.CurrentRow.Cells[3].Value.ToString().Trim();
                txbScore.Text = dtgResult.CurrentRow.Cells[5].Value.ToString().Trim();
                txbDescription.Text = dtgResult.CurrentRow.Cells[6].Value.ToString().Trim();
            }
        }

        private void dtgResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getDataFromDataGridView();
        }

        private void btnAvgScoreByCourse_Click(object sender, EventArgs e)
        {
            frmAvgScoreByCourse frmAvgScoreByCourse = new frmAvgScoreByCourse();
            frmAvgScoreByCourse.Show(this);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txbID.Text, out int student_id))
                {
                    throw new Exception("ID Is Invalid. Please Enter An Interger!");
                }
                string course_id = cbbSelectScore.SelectedValue.ToString();
                if (!float.TryParse(txbScore.Text, out float scoreValue))
                {
                    throw new Exception("Score Is Invalid. Please Enter An Float Value!");
                }
                if (scoreValue < 0 || scoreValue > 10)
                {
                    throw new Exception("Score Is Invalid. Score Must Be Between 0 And 10!");
                }
                string description = txbDescription.Text;

                //check if score is already set for this student on this course
                if (!score.studentScoreExist(student_id, course_id))
                {
                    if (score.insertScore(student_id, course_id, scoreValue, description))
                    {
                        MessageBox.Show("Student Score Added", "Manage Score", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Student Score Not Added", "Manage Score", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("The Score For This Course Has Already Set ", "Add Score", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Score", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txbID.Text, out int student_id))
                {
                    MessageBox.Show("ID Is Invalid. Please Enter An Interger!","Manage Score", 
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                string course_id = cbbSelectScore.SelectedValue.ToString().Trim();

                if (score.deleteScore(student_id, course_id))
                {
                    MessageBox.Show("Score Deleted", "Manage Score",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }
                else
                {
                    MessageBox.Show("Score Not Deleted", "Manage Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Remove Score", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }
    }
}
