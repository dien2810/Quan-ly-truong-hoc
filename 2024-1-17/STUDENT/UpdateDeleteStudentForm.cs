using _2024_1_17.COURSE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024_1_17
{
    public partial class UpdateDeleteStudentForm : Form
    {
        public UpdateDeleteStudentForm()
        {
            InitializeComponent();
        }
        public TextBox TxbStudentId
        {
            get { return txbStudentId; }
            set { txbStudentId = value; }
        }
        public TextBox TxbFirstName
        {
            get { return txbFirstName; }
            set { txbFirstName = value; }
        }
        public TextBox TxbLastName
        {
            get { return txbLastName; }
            set { txbLastName = value; }
        }
        public DateTimePicker DtpBirthDate
        {
            get { return dtpBirthDate; }
            set { dtpBirthDate = value; }
        }

        public RadioButton RadioButtonMale
        {
            get { return rbtMale; }
            set { rbtMale = value; }
        }
        public RadioButton RadioButtonFemale
        {
            get { return rbtFemale; }
            set { rbtFemale = value; }
        }

        public TextBox TxbPhone
        {
            get { return txbPhone; }
            set { txbPhone = value; }
        }

        public TextBox TxbAddress
        {
            get { return txbAddress; }
            set { txbAddress = value; }
        }

        public PictureBox PicImage
        {
            get { return picImage; }
            set { picImage = value; }
        }
        private void UpdateDeleteStudentForm_Load(object sender, EventArgs e)
        {

        }

        private void btnFindId_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txbStudentId.Text, out int id))
                {
                    MessageBox.Show("ID is invalid! Please enter Integer!", "Update/Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                
                STUDENT student = new STUDENT();
                SqlCommand cmd = new SqlCommand("select * from std where id = " + id);

                DataTable table = student.getStudents(cmd);

                if (table.Rows.Count > 0)
                {
                    txbFirstName.Text = table.Rows[0]["fname"].ToString().Trim();
                    txbLastName.Text = table.Rows[0]["lname"].ToString().Trim();
                    dtpBirthDate.Value = (DateTime)table.Rows[0]["bdate"];
                    //gender
                    if (table.Rows[0]["gender"].ToString().Trim() == "Female")
                    {
                        rbtFemale.Checked = true;
                    }
                    else
                    {
                        rbtMale.Checked = true;
                    }
                    txbPhone.Text = table.Rows[0]["phone"].ToString().Trim();
                    txbAddress.Text = table.Rows[0]["address"].ToString().Trim();

                    //chuyen hinh anh tu datatable vao pictureBox trong form
                    byte[] pic = (byte[])table.Rows[0]["picture"];
                    MemoryStream picture = new MemoryStream(pic);
                    picImage.Image = Image.FromStream(picture);

                }
                else
                {
                    MessageBox.Show("Not found!", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //Kiem tra nhap vao la ki tu
        private void txbStudentId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                STUDENT student = new STUDENT();
                int id;
                string fname = txbFirstName.Text;
                string lname = txbLastName.Text;
                DateTime bdate = dtpBirthDate.Value;
                string phone = txbPhone.Text;
                string adrs = txbAddress.Text;
                string gender = "Male";

                if (RadioButtonFemale.Checked)
                {
                    gender = "Female";
                }

                MemoryStream pic = new MemoryStream();
                int born_year = dtpBirthDate.Value.Year;
                int this_year = DateTime.Now.Year;
                //  sv tu 10-100,  co the thay doi                
                if (verif())
                {
                    try
                    {
                        if (!int.TryParse(txbStudentId.Text, out id))
                        {
                            MessageBox.Show("ID is invalid! Please enter Integer!", "Update/Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        else
                            if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
                            {
                                MessageBox.Show("The Student Age Must Be Between 10 and 100 year", "Invalid BirthDate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }
                            else
                                if (hasDigits(fname) || hasDigits(lname))
                                {
                                    MessageBox.Show("Name Can't Have Digits", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    return;
                                }
                                else
                                    if (hasChar(phone))
                                    {
                                        MessageBox.Show("Phone Can't Have Character", "Invalid Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        picImage.Image.Save(pic, picImage.Image.RawFormat);
                                        if (student.updateStudent(id, fname, lname, bdate, gender, phone, adrs, pic))
                                        {
                                            MessageBox.Show("Student Is Updated", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                        else
                                        {
                                            MessageBox.Show("Error", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        } 

        bool verif()
        {
            if ((txbFirstName.Text.Trim() == "")
                        || (txbLastName.Text.Trim() == "")
                        || (txbAddress.Text.Trim() == "")
                        || (txbPhone.Text.Trim() == "")
                        || (picImage.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        bool hasChar(string s)
        {
            foreach (char c in s)
            {
                if (char.IsLetter(c))
                {
                    return true;
                }
            }
            return false;
        }

        bool hasDigits(string s)
        {
            foreach (char c in s)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //delete student
            STUDENT student = new STUDENT();
            try
            {
                if (!int.TryParse(txbStudentId.Text, out int studentId))
                {
                    MessageBox.Show("ID is invalid! Please enter Integer!", "Update/Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                //display a confirmation message before delete
                if (MessageBox.Show("Do you want to delete this student", "Delete Student", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.Yes)
                {
                    if (student.deleteStudent(studentId)){
                        MessageBox.Show("Student Is Deleted", "Delete Student");
                        //clear fields after delete
                        txbStudentId.Text = "";
                        txbFirstName.Text = "";
                        txbLastName.Text = "";
                        txbAddress.Text = "";
                        txbPhone.Text = "";
                        dtpBirthDate.Value = DateTime.Now;
                        picImage.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("Student Not Deleted! Please Enter A Valid ID", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                picImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            AddCourseFrm addCourseFrm = new AddCourseFrm();
            addCourseFrm.ShowDialog();
        }
    }
}
