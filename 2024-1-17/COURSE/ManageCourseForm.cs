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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _2024_1_17.COURSE
{
    public partial class frmManageCourse : Form
    {
        COURSE course = new COURSE();
        int pos = 0;
        public frmManageCourse()
        {
            InitializeComponent();
        }

        private void frmManageCourse_Load(object sender, EventArgs e)
        {
            reloadListBoxData();
        }

        private void reloadListBoxData()
        {
            lsbManageCourse.DataSource = course.getAllCourses();
            lsbManageCourse.ValueMember = "id";
            lsbManageCourse.DisplayMember = "label"; //co the chuyen thanh course name hay name
            lsbManageCourse.SelectedItem = null;
            lblTotalCourses.Text = ("Total Course(s): " + course.totalCourses());
            cbbSemester.SelectedIndex = 0;
        }

        private void showData(int index)
        {
            if (index != -1)
            {
                DataRow dr = course.getAllCourses().Rows[index];
                lsbManageCourse.SelectedIndex = index;
                txbID.Text = dr.ItemArray[0].ToString().Trim();
                txbCourseName.Text = dr.ItemArray[1].ToString().Trim();
                nupHoursNumber.Value = int.Parse(dr.ItemArray[2].ToString());
                txbDescription.Text = dr.ItemArray[3].ToString().Trim();
                cbbSemester.SelectedIndex = int.Parse(dr.ItemArray[4].ToString())-1;
            }
            
        }

        //dung thu datarowview xem tung dong
        private void lsbManageCourse_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)lsbManageCourse.SelectedItem;
            pos = lsbManageCourse.SelectedIndex;
            showData(pos);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //check if name is not empty
            //check if this course already exists
            //the course hours number must be > 10, we can do it from the numbericDropDownTool, or using if condition
            //the description is optional
            try
            {
                string id = txbID.Text;
                string name = txbCourseName.Text;
                //int period = Convert.ToInt32(txbPeriod.Text);
                int period = 0;
                int semester = int.Parse(cbbSemester.Text);
                if (!int.TryParse(nupHoursNumber.Value.ToString(), out period))
                {
                    throw new Exception("Please Enter A Valid Period! Period Must Be Integer!");
                }
                string desc = txbDescription.Text;

                COURSE course = new COURSE();
                if (name.Trim() == "") //lam viec voi string xoa het cac khoang trang, truoc sau chi lay ten
                {
                    MessageBox.Show("Add a course name!", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (checkPeriod(period))
                {
                    if (course.checkCourseName(name, semester, id))
                    {
                        if (course.insertCourse(id, name, period, desc, semester))
                        {
                            reloadListBoxData();
                            MessageBox.Show("New Course Inserted", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Course Not Inserted", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                    }
                    else
                    {
                        MessageBox.Show("This Course Already Exists", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("The Period Must Be Greater Than 10", "Invalid Period", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex) //bắt lỗi từ cơ sở dữ liệu
            {
                // Xác định loại lỗi và cung cấp thông điệp tùy chỉnh
                string errorMessage;
                switch (ex.Number)
                {
                    case 2627: // Lỗi khóa chính/trùng lặp
                        errorMessage = "ID Existed. Please Enter New ID!";
                        break;
                    case 547: // Lỗi khóa ngoại
                        errorMessage = "Lỗi khóa ngoại. Dữ liệu liên quan không tồn tại.";
                        break;
                    default: // Các loại lỗi khác
                        errorMessage = "Lỗi từ cơ sở dữ liệu: " + ex.Message;
                        break;
                }
                MessageBox.Show(errorMessage, "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        bool checkPeriod(int period)
        {
            if (period < 10)
            {
                return false;
            }
            return true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string label = txbCourseName.Text;
                int period = (int)nupHoursNumber.Value;
                int semester = int.Parse(cbbSemester.Text);
                string description = txbDescription.Text;
                string id = txbID.ToString();

                //lay lai phan kiem tra ten course
                if (checkPeriod(period))
                {
                    if (!course.checkCourseName(label, semester, id))
                    {
                        MessageBox.Show("This Course Name Already Exists", "Edit Course", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                    }
                    else if (course.updateCourse(id, label, period, description, semester))
                    {
                        MessageBox.Show("Course Updated", "Edit Course", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        reloadListBoxData();
                    }
                    else
                    {
                        MessageBox.Show("Course Not Updated", "Edit Course", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("The Period Must Be Greater Than 10", "Invalid Period", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                }
                pos = 0;
            }
            catch (SqlException ex) //bắt lỗi từ cơ sở dữ liệu
            {
                // Xác định loại lỗi và cung cấp thông điệp tùy chỉnh
                string errorMessage;
                switch (ex.Number)
                {
                    case 2627: // Lỗi khóa chính/trùng lặp
                        errorMessage = "ID Existed. Please Enter New ID!";
                        break;
                    case 547: // Lỗi khóa ngoại
                        errorMessage = "Lỗi khóa ngoại. Dữ liệu liên quan không tồn tại.";
                        break;
                    default: // Các loại lỗi khác
                        errorMessage = "Lỗi từ cơ sở dữ liệu: " + ex.Message;
                        break;
                }
                MessageBox.Show(ex.Number + errorMessage, "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Edit Course", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                string courseID = txbID.Text;
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
                            reloadListBoxData();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            pos = 0;
            showData(pos);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (pos < course.getAllCourses().Rows.Count - 1)
            {
                pos++;
                showData(pos);
            }            
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (pos > 0)
            {
                pos--;
                showData(pos);
            }
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            pos = course.getAllCourses().Rows.Count - 1;
            showData(pos);
        }

        private void lsbManageCourse_DoubleClick(object sender, EventArgs e)
        {
            string course_id = lsbManageCourse.SelectedValue.ToString();
            string course_name = lsbManageCourse.Text.ToString();
            string semester = cbbSemester.SelectedItem.ToString();
            //Console.WriteLine(course_id);
            DataTable courseStudentList = course.listStudent(course_id);

            frmCourseStudentList courseStudentListForm = new frmCourseStudentList();
            courseStudentListForm.ListStudents = courseStudentList;
            courseStudentListForm.Course_Name = course_name;
            courseStudentListForm.Semester = semester;
            courseStudentListForm.ShowDialog(this);
        }
    }
}
