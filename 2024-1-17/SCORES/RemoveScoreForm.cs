using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024_1_17.COURSE
{
    public partial class frmRemoveScore : Form
    {
        SCORE score = new SCORE();
        public frmRemoveScore()
        {
            InitializeComponent();
        }

        private void frmRemoveScore_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("select * from Score"));
        }

        void fillGrid(SqlCommand cmd)
        {
            dtgScore.ReadOnly = true;
            //xu ly hinh anh, code co tham khao msdn
            DataGridViewImageColumn picCol = new DataGridViewImageColumn(); //doi tuong lam viec voi dang picture
            dtgScore.RowTemplate.Height = 80;//dong nay tham khao tren msdn, co gian de pic dep, dang tim auto-size
            DataTable scoreList = score.getStudentsScore();

            dtgScore.DataSource = scoreList;

            dtgScore.AllowUserToAddRows = false;

        }

        private void btnRemoveScore_Click(object sender, EventArgs e)
        {
            try
            {
                int student_id = Convert.ToInt32(dtgScore.CurrentRow.Cells[0].Value.ToString());
                string course_id = dtgScore.CurrentRow.Cells[3].Value.ToString();
            
                if (score.deleteScore(student_id,course_id))
                {
                    MessageBox.Show("Score Deleted", "Remove Score",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillGrid(new SqlCommand("select * from Score"));
                }
                else
                {
                    MessageBox.Show("Score Not Deleted", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Remove Score",MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation);
            }
        }
    }
}
