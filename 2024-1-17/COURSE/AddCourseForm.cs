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
    public partial class frmAddCourse : Form
    {
        public frmAddCourse()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //check if name is not empty
            //check if this course already exists
            //the course hours number must be > 10, we can do it from the numbericDropDownTool, or using if condition
            //the description is optional
            try
            {
                string id = txbCourseID.Text;
                string name = txbLabel.Text;
                //int period = Convert.ToInt32(txbPeriod.Text);
                int period = 0;
                int semester;
                //int semester = int.Parse(cbbSemester.Text);
                if (!int.TryParse(cbbSemester.Text, out semester))
                {
                    throw new Exception("Please Choose Semester!");
                }
                if (!int.TryParse(txbPeriod.Text, out period))
                {
                    throw new Exception("Please Enter A Valid Period! Period Must Be Integer!");
                }
                string desc = rtxbDescription.Text;

                COURSE course = new COURSE();
                if (id.Trim() == "") //lam viec voi string xoa het cac khoang trang, truoc sau chi lay ten
                {
                    MessageBox.Show("Add a course id!", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else                
                    if (name.Trim() == "") //lam viec voi string xoa het cac khoang trang, truoc sau chi lay ten
                    {
                        MessageBox.Show("Add a course name!", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        if (checkPeriod(period))
                        {
                            if (course.checkCourseName(name, semester))
                            {
                                if (course.insertCourse(id, name, period, desc, semester))
                                {
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

        
    }
}
