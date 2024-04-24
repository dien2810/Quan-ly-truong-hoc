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

namespace _2024_1_17.COURSE
{
    public partial class frmAddScore : Form
    {
        public frmAddScore()
        {
            InitializeComponent();
        }
        COURSE course = new COURSE();      
        STUDENT student = new STUDENT();
        SCORE score = new SCORE();

        private void frmAddScore_Load(object sender, EventArgs e)
        {
            cbbSelectScore.DataSource = course.getAllCourses();
            cbbSelectScore.DisplayMember = "label";
            cbbSelectScore.ValueMember = "id";

            //dua no voi student
            SqlCommand sqlCommand = new SqlCommand("SELECT id, fname, lname FROM std");
            dgvStudent.DataSource = student.getStudents(sqlCommand);
        }
        //on datagridview student click
        private void dgvStudent_Click(object sender, DataGridViewCellEventArgs e)
        {
            txbID.Text = dgvStudent.CurrentRow.Cells[0].Value.ToString();

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
                if (scoreValue < 0 || scoreValue > 10){
                    throw new Exception("Score Is Invalid. Score Must Be Between 0 And 10!");
                }
                string description = txbDescription.Text;

                //check if score is already set for this student on this course
                if (!score.studentScoreExist(student_id, course_id)){
                    if (score.insertScore(student_id, course_id, scoreValue, description))
                    {
                        MessageBox.Show("Student Score Added", "Add Score", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Student Score Not Added", "Add Score", MessageBoxButtons.OK,
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
    }
}
