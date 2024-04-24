using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _2024_1_17.COURSE
{
    public partial class frmRemoveCourse : Form
    {
        public frmRemoveCourse()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            COURSE course = new COURSE();
            try
            {
                string courseID = txbCourseID.Text;
                if (courseID.Trim() == "") //lam viec voi string xoa het cac khoang trang, truoc sau chi lay ten
                {
                    MessageBox.Show("Please Enter a ID!", "Remove course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (MessageBox.Show("Are you sure want to delete course with ID: " + courseID,
                        "Remove Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (course.deleteCourse(courseID))
                        {
                            MessageBox.Show("Course Deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Course Not Deleted", "Remove Course", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                        }
                    }
                }
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
