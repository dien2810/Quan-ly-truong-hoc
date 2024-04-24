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
    public partial class frmEditCourse : Form
    {
        COURSE course = new COURSE();
        public frmEditCourse()
        {
            InitializeComponent();
        }

        private void frmEditCourse_Load(object sender, EventArgs e)
        {
            //dung combobox lay ten course
            cbbSelectCourse.DataSource = course.getAllCourses();
            cbbSelectCourse.DisplayMember = "id";
            cbbSelectCourse.ValueMember = "id";
            cbbSelectCourse.SelectedItem = "";

            cbbSemester.SelectedIndex = 0;
            
        }

        //courses name va id
        public void fillCombo(int index)
        {
            cbbSelectCourse.DataSource = course.getAllCourses();
            cbbSelectCourse.DisplayMember = "id";
            cbbSelectCourse.ValueMember = "id";
            cbbSelectCourse.SelectedItem = index;
        }

        private void cbbSelectCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //lay du lieu
                string id = cbbSelectCourse.SelectedValue.ToString();
                DataTable table = new DataTable();
                table = course.getCourseByID(id);
                if (table.Rows.Count > 0)
                {
                    txbLabel.Text = table.Rows[0][1].ToString().Trim();
                    nudPeriod.Value = Int32.Parse(table.Rows[0][2].ToString());
                    rtxbDescription.Text = table.Rows[0][3].ToString().Trim();
                    cbbSemester.SelectedIndex = int.Parse(table.Rows[0][4].ToString())-1;
                }

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string label = txbLabel.Text;
                int period = (int)nudPeriod.Value;
                int semester = int.Parse(cbbSemester.Text);
                string description = rtxbDescription.Text;
                string id = cbbSelectCourse.SelectedValue.ToString();

                //lay lai phan kiem tra ten course
                if (label.Trim() == "")
                {
                    MessageBox.Show("Please Enter Label!", "Edit Course", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                }
                else
                {
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
                            fillCombo(cbbSelectCourse.SelectedIndex);
                        }
                        else
                        {
                            MessageBox.Show("Course Not Updated", "Edit Course", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The Period Must Be Equal Or Greater Than 10", "Invalid Period", MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
                    }
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
                MessageBox.Show(ex.Number+errorMessage, "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Edit Course", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
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

        private void cbbSelectCourse_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // Ngăn chặn ký tự nhập vào
        }

        private void cbbSelectCourse_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true; // Ngăn chặn các phím mũi tên hoặc các phím di chuyển khác từ bàn phím
        }

        private void cbbSemester_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void cbbSemester_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
