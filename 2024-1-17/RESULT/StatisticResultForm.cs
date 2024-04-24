using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2024_1_17.COURSE;
namespace _2024_1_17.RESULT
{
    public partial class frmStatisticResult : Form
    {
        SCORE score = new SCORE();
        
        public frmStatisticResult()
        {
            InitializeComponent();
        }



        private void frmStatisticResult_Load(object sender, EventArgs e)
        {
            DataTable statisticByCourse = score.getAvgScoreByCourse();

            lblByCourse.Text = "";
            
            for (int i = 0; i < statisticByCourse.Rows.Count; i++)
            {
                lblByCourse.Text += statisticByCourse.Rows[i][0].ToString().Trim() + ": " +
                    statisticByCourse.Rows[i][1].ToString().Trim() + "\n";
            }
            DataTable listStudent = score.getStudentHasScore();
            DataTable avg = score.getAvgScoreByStudent();
            int gioi = 0;
            int kha = 0;
            int trungbinh = 0;
            int yeu = 0;
            int kem = 0;
            int sum = listStudent.Rows.Count;
            for (int i = 0; i < sum; i++)
            {
                float avgScore = (float)Convert.ToDouble(avg.Rows[i][3].ToString());
                if (avgScore >= 8)
                    gioi++;
                else
                    if (avgScore >= 6.5)
                    kha++;
                else
                        if (avgScore >= 5)
                    trungbinh++;
                else
                            if (avgScore >= 3) yeu++;
                else kem++;
            }
            float gioiPercentage = (float)gioi / sum * 100;
            float khaPercentage = (float)kha / sum * 100;
            float trungbinhPercentage = (float)trungbinh / sum * 100;
            float yeuPercentage = (float)yeu / sum * 100;
            float kemPercentage = (float)kem / sum * 100 ;
            lblGioi.Text += gioiPercentage.ToString() + " %";
            lblKha.Text += khaPercentage.ToString() + " %";
            lblTrungBinh.Text += trungbinhPercentage.ToString() + " %";
            lblYeu.Text += yeuPercentage.ToString() + " %";
            lblKem.Text += kemPercentage.ToString() + " %";
        }
    }
}
