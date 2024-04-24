using _2024_1_17.COURSE;
using _2024_1_17.RESULT;
using _2024_1_17.SCORES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024_1_17
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm();
            addStudentForm.Show(this);
        }

        /*private void rToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            frmStudentList studentListForm = new frmStudentList();
            studentListForm.Show(this);

        }*/

        private void studentsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmStudentList studentListForm = new frmStudentList();
                studentListForm.Show(this);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void editRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDeleteStudentForm updateDeleteStudentForm = new UpdateDeleteStudentForm();
            this.Show();
            updateDeleteStudentForm.Show();
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStatistics StatisticsForm = new frmStatistics();
            StatisticsForm.Show(this);
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmin adminForm = new frmAdmin();
            adminForm.Show(this);
        }

        private void manageStudentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageStudent manageStudentForm = new frmManageStudent();
            manageStudentForm.Show(this);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrint printForm = new frmPrint();
            printForm.Show(this);
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddCourse addCourseForm = new frmAddCourse();
            addCourseForm.Show(this);
        }

        private void removeCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRemoveCourse removeCourseForm = new frmRemoveCourse();
            removeCourseForm.Show(this);
        }

        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditCourse editCourseForm = new frmEditCourse();
            editCourseForm.Show(this);
        }

        private void manageCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageCourse manageCourseForm = new frmManageCourse();
            manageCourseForm.Show(this);
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPrintCourse printCourseForm = new frmPrintCourse();
            printCourseForm.Show(this);
        }

        private void averageScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAvgScoreByCourse frmAvgScoreByCourse = new frmAvgScoreByCourse();
            frmAvgScoreByCourse.Show(this);
        }

        private void addScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddScore addScoreForm = new frmAddScore();
            addScoreForm.Show(this);
        }

        private void removeScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRemoveScore removeScoreForm = new frmRemoveScore();
            removeScoreForm.Show(this);
        }

        private void manageScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageScore manageScoreForm = new frmManageScore();
            manageScoreForm.Show(this);
        }

        private void avgResultByScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAvgResultByScore avgResultByScore = new frmAvgResultByScore();
            avgResultByScore.Show(this);
        }

        private void statisticResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStatisticResult statisticResultForm = new frmStatisticResult();
            statisticResultForm.Show(this);
        }
    }
}
