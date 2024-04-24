using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace _2024_1_17
{
    public partial class frmManageStudent : Form
    {
        public frmManageStudent()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();
        private void ManageStudentForm_Load(object sender, EventArgs e)
        {
            dtpBirthday.Format = DateTimePickerFormat.Custom;
            dtpBirthday.CustomFormat = "dd/MM/yyyy";
            fillGrid(new SqlCommand("select * from std"));
            
        }

        void fillGrid(SqlCommand cmd)
        {     
            dtgStudent.ReadOnly = true;
            //xu ly hinh anh, code co tham khao msdn
            DataGridViewImageColumn picCol = new DataGridViewImageColumn(); //doi tuong lam viec voi dang picture
            dtgStudent.RowTemplate.Height = 80;//dong nay tham khao tren msdn, co gian de pic dep, dang tim auto-size
            DataTable studentList = student.getStudents(cmd);
            studentList.Columns.Add("Selected Course", typeof(string));
            for (int i = 0; i < studentList.Rows.Count; i++)
            {
                string selectedCourse = "";
                //lay du lieu selected course ung voi moi student_id
                DataTable selectedCourseList = student.getSeletectedCourse(
                    int.Parse(studentList.Rows[i][0].ToString()));
                for (int j = 0; j < selectedCourseList.Rows.Count; j++)
                {
                    selectedCourse += selectedCourseList.Rows[j][0].ToString() + ": " + 
                        selectedCourseList.Rows[j][1].ToString().Trim() + "\n";
                }
                studentList.Rows[i]["Selected Course"] = selectedCourse;
                Console.WriteLine(int.Parse(studentList.Rows[i][0].ToString()));
                Console.WriteLine(student.getSeletectedCourse(
                    int.Parse(studentList.Rows[i][0].ToString())));
            }
            dtgStudent.DataSource = studentList;
            //chinh do rong cua cot id
            dtgStudent.Columns[0].Width = 25;
            //dinh dang ngay/thang/nam cho cot birthday
            dtgStudent.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            picCol = (DataGridViewImageColumn)dtgStudent.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            // Giả sử columnIndex là chỉ số của cột bạn muốn cho phép xuống dòng

            // Thiết lập WrapMode (che do xuong dong) cho cot selected course
            foreach (DataGridViewRow row in dtgStudent.Rows)
            {
                row.Cells[9].Style.WrapMode = DataGridViewTriState.True;
            }

            dtgStudent.AllowUserToAddRows = false;

            //Dem sinh vien
            lblTotalStudent.Text = ("Total Student(s): " + dtgStudent.Rows.Count);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("SELECT * FROM std WHERE CONCAT(Id,fname,lname,bdate,gender,address)" +
                " LIKE '%" + txbSearch.Text + "%'"));
        }

        private void dtgStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // thu tu cua cac cot: id-fname-lname-bd-gder-phone-adrs-pic
            txbID.Text = dtgStudent.CurrentRow.Cells[0].Value.ToString();
            txbFirstName.Text = dtgStudent.CurrentRow.Cells[1].Value.ToString();
            txbLastName.Text = dtgStudent.CurrentRow.Cells[2].Value.ToString();
            dtpBirthday.Value = (DateTime)dtgStudent.CurrentRow.Cells[3].Value;            
            if (dtgStudent.CurrentRow.Cells[4].Value.ToString().Trim() == "Female")
                rdbFemale.Checked = true;
            else
                rdbMale.Checked = true;
            txbPhone.Text = dtgStudent.CurrentRow.Cells[5].Value.ToString();
            rtxbAddress.Text = dtgStudent.CurrentRow.Cells[6].Value.ToString();


            //code xu ly hinh anh up len, version 01, chay OK, tim hieu them de code nhe hon
            
            if (!Convert.IsDBNull(dtgStudent.CurrentRow.Cells[7].Value))
            {
                byte[] pic;
                pic = (byte[])dtgStudent.CurrentRow.Cells[7].Value;
                MemoryStream picture = new MemoryStream(pic);
                picImage.Image = Image.FromStream(picture);
            }
            else
            {
                picImage.Image = null;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                picImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txbID.Text = "";
            txbFirstName.Text = "";
            txbLastName.Text = "";
            rtxbAddress.Text = "";
            txbPhone.Text = "";
            picImage.Image = null;
            rdbMale.Checked = true;
            dtpBirthday.Value = DateTime.Now;

        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = ("student__" + txbID.Text);
            if (picImage.Image == null)
            {
                MessageBox.Show("No Image In The PictureBox");
            }
            else if (svf.ShowDialog() == DialogResult.OK)
            {
                picImage.Image.Save(svf.FileName + ("." + ImageFormat.Jpeg.ToString()));
            }
        }

        bool verif()
        {
            if ((txbFirstName.Text.Trim() == "") || (txbFirstName.Text.Trim() == "") ||
                    (rtxbAddress.Text.Trim() == "") || (txbPhone.Text.Trim() == "") ||
                (picImage.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //button Add
        private void btnAdd_Click(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();
            
            string firstName = txbFirstName.Text;
            string lastName = txbLastName.Text;
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            DateTime birthday = dtpBirthday.Value;
            string phone = txbPhone.Text;
            string address = rtxbAddress.Text;
            string gender = "Male";
            if (rdbFemale.Checked)
            {
                gender = "Female";
            }
            MemoryStream pic = new MemoryStream();
            int born_year = dtpBirthday.Value.Year;
            int this_year = DateTime.Now.Year;

            //allow only students age between 10-100
            if (this_year - born_year < 10 || this_year - born_year > 100)
            {
                MessageBox.Show("Student Age Must Be Between 10 And 100", 
                    "Invalid Birthday", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (verif())
                {
                    try
                    {
                        int id = Convert.ToInt32(txbID.Text);
                        picImage.Image.Save(pic, picImage.Image.RawFormat);
                        if (student.insertStudent(id, firstName, lastName, birthday, gender, phone, address, pic))
                        {
                            MessageBox.Show("New Student Added", "Add Student",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            fillGrid(new SqlCommand("select * from std"));
                        }
                        else
                        {
                            MessageBox.Show("Error: ", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    } catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Add Student", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Add Student", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id;
            string firstName = txbFirstName.Text;
            string lastName = txbLastName.Text;
            DateTime birthday = dtpBirthday.Value;
            string phone = txbPhone.Text;
            string address = rtxbAddress.Text;
            string gender = "Male";
            if (rdbFemale.Checked)
            {
                gender = "Female";
            }
            MemoryStream pic = new MemoryStream();
            int born_year = dtpBirthday.Value.Year;
            int this_year = DateTime.Now.Year;

            //allow only students age between 10-100
            if (this_year - born_year < 10 || this_year - born_year > 100)
            {
                MessageBox.Show("Student Age Must Be Between 10 And 100",
                    "Invalid Birthday", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (verif())
                {
                    try
                    {
                        id = Convert.ToInt32(txbID.Text);
                        picImage.Image.Save(pic, picImage.Image.RawFormat);
                        if (student.updateStudent(id, firstName, lastName, birthday, gender, phone, address, pic))
                        {
                            MessageBox.Show("Student Information Updated", "Edit Student",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            fillGrid(new SqlCommand("select * from std"));
                        }
                        else
                        {
                            MessageBox.Show("Error: ", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    } catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        //xoa theo id, tuong tu phan truoc
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txbID.Text);
                if (MessageBox.Show("Are you want to delete this student", "Delete Student", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (student.deleteStudent(id))
                    {
                        MessageBox.Show("Student Deleted", "Delete Student",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillGrid(new SqlCommand("select * from std"));
                        txbID.Text = "";
                        txbFirstName.Text = "";
                        txbLastName.Text = "";
                        txbPhone.Text = "";
                        rtxbAddress.Text = "";
                        dtpBirthday.Value = DateTime.Now;
                        picImage.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("Can't Delete This Student", "Delete Student",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } catch
            {
                MessageBox.Show("Please Enter A Valid ID", "Delete Student",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
