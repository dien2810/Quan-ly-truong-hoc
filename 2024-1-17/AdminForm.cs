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

namespace _2024_1_17
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBDataSet.std' table. You can move, or remove it, as needed.
            //this.stdTableAdapter.Fill(this.myDBDataSet.std);
            LOGIN login = new LOGIN();
            SqlCommand command = new SqlCommand("SELECT * FROM login");
            dtgLogin.ReadOnly = true;
            //xu ly hinh anh, code co tham khao msdn
            DataGridViewImageColumn picCol = new DataGridViewImageColumn(); //doi tuong lam viec voi dang picture
            dtgLogin.RowTemplate.Height = 80;//dong nay tham khao tren msdn, co gian de pic dep, dang tim auto-size
            
            dtgLogin.DataSource = login.getLogin(command);
            dtgLogin.AllowUserToAddRows = false;
        }
    }
}
