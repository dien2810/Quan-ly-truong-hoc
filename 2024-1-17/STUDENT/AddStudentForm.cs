using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EXCEL = Microsoft.Office.Interop.Excel;
namespace _2024_1_17
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                STUDENT student = new STUDENT();
                //int id = Convert.ToInt32(txbStudentId.Text);
                if (!int.TryParse(txbStudentId.Text, out int id))
                {
                    throw new Exception("Giá trị ID không hợp lệ. Vui lòng nhập một số nguyên.");
                }                
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
                
                if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
                {
                    MessageBox.Show("The Student Age Must Be Between 10 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (hasDigits(fname) || hasDigits(lname))
                {
                    MessageBox.Show("Name Can't Have Digits", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    else
                        if (hasChar(phone))
                        {
                            MessageBox.Show("Phone Can't Have Character", "Invalid Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            if (verif())
                        {
                            picImage.Image.Save(pic, picImage.Image.RawFormat);
                            if (student.insertStudent(id, fname, lname, bdate, gender, phone, adrs, pic))
                            {
                                MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                else
                {
                    MessageBox.Show("Empty Fields", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (SqlException ex) //bắt lỗi từ cơ sở dữ liệu
            {
                // Xác định loại lỗi và cung cấp thông điệp tùy chỉnh
                string errorMessage;
                switch (ex.Number)
                {
                    case 2627: // Lỗi khóa chính/trùng lặp
                        errorMessage = "ID đã tồn tại. Vui lòng nhập giá trị khác.";
                        break;
                    case 547: // Lỗi khóa ngoại
                        errorMessage = "Lỗi khóa ngoại. Dữ liệu liên quan không tồn tại.";
                        break;
                    default: // Các loại lỗi khác
                        errorMessage = "Lỗi từ cơ sở dữ liệu: " + ex.Message;
                        break;
                }
                MessageBox.Show(errorMessage, "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (char.IsDigit(c)) { 
                return true;
                }
            }
            return false;
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
        private string GetFileExtension(string filePath)
        {
            // Lấy phần mở rộng của đường dẫn tập tin
            string fileExtension = Path.GetExtension(filePath);

            // Kiểm tra xem phần mở rộng có tồn tại không
            if (!string.IsNullOrEmpty(fileExtension))
            {
                // Trả về phần mở rộng (loại bỏ dấu chấm ở đầu nếu có)
                return fileExtension.TrimStart('.');
            }
            else
            {
                // Trả về chuỗi rỗng nếu không tìm thấy phần mở rộng
                return string.Empty;
            }
        }

        private void btnImportStudentList_Click(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Text Files|*.txt|Excel Files|*.xls;*.xlsx";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {                    
                    string filePath = openFileDialog.FileName;
                    string extension = GetFileExtension(filePath);
                    if (extension.Equals("txt"))
                    {
                        using (StreamReader reader = new StreamReader(filePath))
                        {
                            string line;
                            while ((line = reader.ReadLine()) != null)
                            {
                                // Phân tách dữ liệu từ mỗi dòng
                                string[] parts = line.Split('\t'); // Giả sử các thông tin của sinh viên được phân tách bằng dấu phẩy

                                if (parts.Length >= 2) // Kiểm tra xem dòng có ít nhất hai phần tử (tên và ID sinh viên)
                                {
                                    Console.WriteLine(parts[0].Trim());
                                    int studentID = Convert.ToInt32(parts[0].Trim()); // Lấy ID sinh viên từ phần tử thứ hai và loại bỏ các khoảng trắng thừa

                                    string firstName = parts[1].Trim(); // Lấy tên sinh viên từ phần tử đầu tiên và loại bỏ các khoảng trắng thừa
                                    string lastName = parts[2].Trim();

                                    //chuyen string thanh DateTime
                                    string dateString = parts[3].Trim();
                                    DateTime birthday = DateTime.Parse(dateString);

                                    string gender = parts[4].Trim();
                                    string phone = parts[5].Trim();
                                    string address = parts[6].Trim();

                                    //chuyen string thanh MemoryStream de luu anh
                                    //string pictureText = parts[7].Trim();
                                    //byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(pictureText);
                                    //MemoryStream picture = new MemoryStream(byteArray);


                                    // Thêm sinh viên vào bảng Std
                                    student.insertStudent(studentID, firstName, lastName, birthday, gender, phone, address);
                                }
                            }
                            MessageBox.Show("Student list imported successfully.", "Add Student",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                            reader.Close();
                        }
                    }
                    else
                    {
                        if (extension.Equals("xls") || extension.Equals("xlsx"))
                        {
                            EXCEL.Application exApp = new EXCEL.Application();
                            EXCEL.Workbook exBook = exApp.Workbooks.Open(filePath);
                            EXCEL.Worksheet exSheet;
                            exSheet = exBook.Worksheets["Sheet1"];
                            EXCEL.Range exRange = exSheet.UsedRange;
                            if (filePath != "")
                            {
                                for (int exRow = 2; exRow <= exRange.Rows.Count; exRow++)
                                {
                                    //string email = exRange.Cells[exRow, 5].Text;
                                    /*if (exRange.Cells[exRow, 5].Text != "")
                                    {
                                        email = exRange.Cells[exRow, 2].Text + "@student.hcmute.edu.vn";
                                    }*/
                                    if (!int.TryParse(exRange.Cells[exRow, 1].Text, out int student_id))
                                    {
                                        throw new Exception("Giá trị ID không hợp lệ. Vui lòng nhập một số nguyên.");
                                    }
                                    DateTime dateTimeValue;

                                    // Sử dụng phương thức ParseExact hoặc TryParseExact để chuyển đổi chuỗi thành kiểu DateTime
                                    if (!DateTime.TryParseExact(exRange.Cells[exRow, 4].Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTimeValue))
                                    {
                                        throw new Exception("Giá trị ngày sinh không hợp lệ. Vui lòng định dạng dd/MM/yyyy");
                                    }
                                    
                                    student.insertStudent(student_id, exRange.Cells[exRow, 2].Text,
                                        exRange.Cells[exRow, 3].Text,
                                        dateTimeValue,
                                        exRange.Cells[exRow, 5].Text,
                                        exRange.Cells[exRow, 6].Text,
                                        exRange.Cells[exRow, 7].Text
                                                                  );
                                }

                                exBook.Close(false);
                                exApp.Quit();
                                MessageBox.Show("Student list imported successfully.", "Import Student",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);                                
                            }
                        }
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
                        errorMessage = "ID đã tồn tại. Vui lòng nhập giá trị khác.";
                        break;
                    case 547: // Lỗi khóa ngoại
                        errorMessage = "Lỗi khóa ngoại. Dữ liệu liên quan không tồn tại.";
                        break;
                    default: // Các loại lỗi khác
                        errorMessage = "Lỗi từ cơ sở dữ liệu: " + ex.Message;
                        break;
                }
                MessageBox.Show(errorMessage, "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Add Student", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.CustomFormat = "dd/MM/yyyy";
            RadioButtonMale.Checked = true;
        }
    }
}
