using _2024_1_17.COURSE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024_1_17.SCORES
{
    public partial class frmAvgScoreByCourse : Form
    {
        SCORE score = new SCORE();
        public frmAvgScoreByCourse()
        {
            InitializeComponent();
        }

        private void frmAvgScoreByCourse_Load(object sender, EventArgs e)
        {
            dtgAverage.DataSource = score.getAvgScoreByCourse();
            dtgAverage.Columns[0].HeaderText = "Label";
        }
    }
}
