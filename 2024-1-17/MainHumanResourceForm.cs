using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2024_1_17.CONTACT;
using _2024_1_17.USER;
namespace _2024_1_17
{
    public partial class frmMainHumanResource : Form
    {
        USER.USER user = new USER.USER();
        public frmMainHumanResource()
        {
            InitializeComponent();
        }

        private void frmMainHumanResource_Load(object sender, EventArgs e)
        {
            lblWelcome.Text += " " + Globals.GlobalUserId.ToString() + "!";
            DataTable userInfo = user.GetUserByID(Globals.GlobalUserId);

            //code xu ly hinh anh up len, version 01, chay OK, tim hieu them de code nhe hon

            if (!Convert.IsDBNull(userInfo.Rows[0][5]))
            {
                byte[] pic;
                pic = (byte[])userInfo.Rows[0][5];
                MemoryStream picture = new MemoryStream(pic);
                picAvatar.Image = Image.FromStream(picture);
            }
            else
            {
                picAvatar.Image = null;
            }
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            frmAddContact addContactForm = new frmAddContact();
            this.Hide();
            addContactForm.ShowDialog();
            this.Show();
        }

        private void btnEditContact_Click(object sender, EventArgs e)
        {
            frmEditContact editContactForm = new frmEditContact();
            this.Hide();
            editContactForm.ShowDialog();
            this.Show();
        }

        private void btnSelectContact_Click(object sender, EventArgs e)
        {
            frmSelectContact selectContactForm = new frmSelectContact();
            this.Hide();
            selectContactForm.ShowDialog();
            this.Show();
        }

        private void btnShowFullContact_Click(object sender, EventArgs e)
        {
            frmShowFullList showFullListContactForm = new frmShowFullList();
            this.Hide();
            showFullListContactForm.ShowDialog();
            this.Show();
        }
    }
}
