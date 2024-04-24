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
using _2024_1_17.USER;
namespace _2024_1_17
{
    public partial class frmLogin : Form
    {
     
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbUsername.Text.ToString();
            string password = txbPassword.Text.ToString();

            // Perform some validation here
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your username and password.");
                return;
            }

            // Check if the username and password are correct
            if (VerifyLogin(username, password))
            {
                //MessageBox.Show("Ok, next time will be go to Main Menu of App");

                if (rdbStudent.Checked == true)
                {
                    frmMain mainform = new frmMain();
                    this.Hide();
                    mainform.ShowDialog();
                    this.Show();
                }
                else
                {
                    if (rdbHumanResource.Checked == true)
                    {
                        USER.USER user = new USER.USER();
                        int userId = user.GetUserID(username, password);
                        if (userId != 0)
                        {
                            Globals.SetGlobalUserId(userId);
                            frmMainHumanResource mainform = new frmMainHumanResource();
                            this.Hide();
                            mainform.ShowDialog();
                            this.Show();
                        }
                        
                    }
                }
                /*Mainform mainform = new Mainform();
                mainform.Show();
                this.Hide();*/
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login", MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation);
            }
        }

        private bool VerifyLogin(string username, string password)
        {
            MY_DB mY_DB = new MY_DB();
            // Check the SQL table for a matching username and password            
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM [USER] WHERE uname=@username AND pwd=@password", mY_DB.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

            adapter.SelectCommand = command;
            adapter.Fill(dataTable);
            mY_DB.openConnection();
            int count = (int)command.ExecuteScalar();
            mY_DB.closeConnection();
            return count > 0;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            pcbLogo.Image = Image.FromFile("../../images/Screenshot 2024-01-17 135337.png");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string role = "";
            if (rdbStudent.Checked == true)
            {
                role = "Student";
            }
            else
            {
                if (rdbHumanResource.Checked == true)
                {
                    role = "Human Resource";
                }
                else
                {
                    MessageBox.Show("Please Choose Role!", "Invalid Role", MessageBoxButtons.OK,
                         MessageBoxIcon.Exclamation);
                    return;
                }
            }
            frmRegister frmRegister = new frmRegister(role);
            this.Hide();
            frmRegister.ShowDialog();
            this.Show();
        }
    }


}
