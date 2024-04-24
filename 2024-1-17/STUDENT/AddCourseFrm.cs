using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024_1_17.COURSE
{
    public partial class AddCourseFrm : Form
    {
        COURSE course = new COURSE();
        SCORE score = new SCORE();
        BindingList<CourseData> availableCourse = new BindingList<CourseData>();
        BindingList<CourseData> selectedCourse = new BindingList<CourseData>();
        int pos = -1;
        class CourseData
        {
            public CourseData() { }
            public CourseData(string intValue, string strValue)
            {
                Id = intValue;
                label = strValue;
            }

            public string Id { get; set; }
            public string label { get; set; }
        }
        public AddCourseFrm()
        {
            InitializeComponent();
        }

        private void AddCourseFrm_Load(object sender, EventArgs e)
        {
            DataTable dt = course.getAllCourses();
            //tham khao https://stackoverflow.com/questions/208532/how-do-you-convert-a-datatable-into-a-generic-list
            List<DataRow> courseList = dt.AsEnumerable()            
              .ToList();
            foreach (DataRow item in courseList)
            {
                CourseData courseData = new CourseData();
                courseData.Id = item["Id"].ToString();
                courseData.label = item["label"].ToString();
                availableCourse.Add(courseData);
            }
            lsbAvailableCourse.DataSource = availableCourse;
            lsbAvailableCourse.ValueMember = "id";
            lsbAvailableCourse.DisplayMember = "label"; //co the chuyen thanh course name hay name
            lsbAvailableCourse.SelectedItem = null;

            lsbSelectedCourse.DataSource = selectedCourse;
            lsbSelectedCourse.ValueMember = "id";
            lsbSelectedCourse.DisplayMember = "label"; //co the chuyen thanh course name hay name
            lsbSelectedCourse.SelectedItem = null;
        }

        private void lsbAvailableCourse_Click(object sender, EventArgs e)
        {            
            pos = lsbAvailableCourse.SelectedIndex;                
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedCourse == null || pos == -1)
                {
                    MessageBox.Show("Please Choose A Course To Add", "Add Course",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    // Thêm phần tử được chọn vào ListBox đích
                    //lsbSelectedCourse.Items.Add(selectedCourse);
                    selectedCourse.Add(availableCourse[pos]);
                    availableCourse.RemoveAt(pos);
                    pos = lsbAvailableCourse.SelectedIndex;
                    //lsbAvailableCourse.Items.Remove(selectedCourse);
                    // Xóa phần tử đã chọn khỏi ListBox nguồn
                }
            } catch(ArgumentOutOfRangeException ex)
            {
                string message = ex.Message;
                MessageBox.Show("No Course Left!", "Add Course", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int student_id;
                if (!int.TryParse(txbStudentID.Text.ToString(), out student_id))
                {
                    MessageBox.Show("Please Enter A Valid Student ID! Student ID Must Be Integer!", "Add Course", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    return;                    
                }
                if (selectedCourse.Count == 0)
                {
                    MessageBox.Show("Please Enter A Course!", "Add Course", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    return;
                }

                int i = selectedCourse.Count-1;
                while(i>=0)
                {
                    CourseData item = selectedCourse[i];                    
                    if (!int.TryParse(txbStudentID.Text.ToString(), out student_id))
                    {
                        throw new Exception("Please Enter A Valid Student ID! Student ID Must Be Integer!");
                    }
                    string course_id = item.Id.ToString();
                    availableCourse.Add(item);
                    selectedCourse.RemoveAt(i);
                    pos = lsbAvailableCourse.SelectedIndex;
                    if (!score.insertScore(student_id, course_id))
                    {
                        MessageBox.Show("Course " + item.Id + ": " +
                           item.label + " Not Added", "Add Course", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    i--;
                }
                MessageBox.Show("Enroll Successful!", "Add Course", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }
            catch (SqlException ex) //bắt lỗi từ cơ sở dữ liệu
            {
                // Xác định loại lỗi và cung cấp thông điệp tùy chỉnh
                string errorMessage;
                switch (ex.Number)
                {
                    case 2627: // Lỗi khóa chính/trùng lặp
                        errorMessage = "Course Existed!";
                        MessageBox.Show(errorMessage, "Add Course", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
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

        private void cbbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            availableCourse.Clear();
            selectedCourse.Clear();
            int semester = int.Parse(cbbSemester.Text);
            DataTable dt = course.getCourseBySemester(semester);
            //tham khao https://stackoverflow.com/questions/208532/how-do-you-convert-a-datatable-into-a-generic-list
            List<DataRow> courseList = dt.AsEnumerable()
              .ToList();
            foreach (DataRow item in courseList)
            {
                CourseData courseData = new CourseData();
                courseData.Id = item["Id"].ToString();
                courseData.label = item["label"].ToString();
                availableCourse.Add(courseData);
            }
            lsbAvailableCourse.DataSource = availableCourse;
            lsbAvailableCourse.ValueMember = "id";
            lsbAvailableCourse.DisplayMember = "label"; //co the chuyen thanh course name hay name
            lsbAvailableCourse.SelectedItem = null;

            lsbSelectedCourse.DataSource = selectedCourse;
            lsbSelectedCourse.ValueMember = "id";
            lsbSelectedCourse.DisplayMember = "label"; //co the chuyen thanh course name hay name
            lsbSelectedCourse.SelectedItem = null;
        }
    }
}
