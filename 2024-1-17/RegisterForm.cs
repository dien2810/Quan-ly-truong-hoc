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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using _2024_1_17.USER;
using System.IO;

namespace _2024_1_17
{
    public partial class frmRegister : Form
    {
        private string role;

        public string Role
        {
            set
            {
                role = value;
            }
        }
        public frmRegister()
        {
            InitializeComponent();
        }

        public frmRegister(string role)
        {
            InitializeComponent();
            this.role = role;
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            USER.USER user = new USER.USER();
            //try
            //{
                int id;
                if (int.TryParse(txbID.Text, out id))
                {
                    string username = txbUsername.Text;
                    string password = txbPassword.Text;
                    string confirmPassword = txbConfirmPassword.Text;
                    string firstName = txbFirstName.Text;
                    string lastName = txbLastName.Text;
                    MemoryStream pic = new MemoryStream();

                    if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||
                        string.IsNullOrEmpty(confirmPassword) || string.IsNullOrEmpty(firstName) ||
                        string.IsNullOrEmpty(lastName) || picImage.Image == null)
                    {
                        MessageBox.Show("Plese enter the value!", "Register", MessageBoxButtons.OK
                            , MessageBoxIcon.Exclamation);
                        return;
                    }
                    if (txbPassword.Text.Equals(txbConfirmPassword.Text))
                    {
                        if (!user.UserNameExist(username, "register", id)) 
                        {
                            picImage.Image.Save(pic, picImage.Image.RawFormat);
                            if (user.InsertUser(firstName, lastName, username, password, pic, role))
                            {
                                MessageBox.Show("Đăng ký tài khoản thành công", "Thông báo", MessageBoxButtons.OK);
                                txbLastName.Text = "";
                                txbFirstName.Text = "";
                                txbUsername.Text = "";
                                txbConfirmPassword.Text = "";
                                txbPassword.Text = "";
                                txbID.Text = "";
                                picImage.Image = null;
                            }
                            else
                            {
                                MessageBox.Show("Đăng ký tài khoản thất bại!", "Thông báo", MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                            }

                        }
                            
                        else
                        {
                            MessageBox.Show("Tài khoản đã tồn tại!", "Register", MessageBoxButtons.OK
                            , MessageBoxIcon.Information);
                            return;
                        }
                            
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không trùng nhau", "Thông báo lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                    
                }
                else
                {
                    MessageBox.Show("ID Invalid!", "Register", MessageBoxButtons.OK, 
                        MessageBoxIcon.Exclamation);
                }
                



                    // Check the SQL table for a matching username and password
                    //
                    /*
                    MY_DB mY_DB = new MY_DB();
                    SqlCommand command = new SqlCommand("INSERT INTO login(username,password,email,fullname,trangthai,role) VALUES(@username,@password)", mY_DB.getConnection);

                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@fullname", fullname);
                    command.Parameters.AddWithValue("@trangthai", trangthai);
                    command.Parameters.AddWithValue("@role", role);

                    mY_DB.openConnection();
                    command.ExecuteNonQuery();
                    mY_DB.closeConnection();
                    */

                  
            /*} catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
            }*/
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*frmLogin loginForm = new frmLogin();
            this.Hide();
            loginForm.ShowDialog();
            this.Show();*/
            this.Dispose();
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
    }
}
