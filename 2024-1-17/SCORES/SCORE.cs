using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;

namespace _2024_1_17.COURSE
{
    class SCORE
    {
        MY_DB mydb = new MY_DB();
        COURSE course = new COURSE();
        STUDENT student = new STUDENT();

        //them diem
        public DataTable getStudentsScore()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText = ("SELECT Score.student_id,std.fname,std.lname,Score.course_id," +
                "Course.label,Score.student_score,Score.description FROM std INNER JOIN Score ON std.Id=Score.student_id" +
                " INNER JOIN Course ON Score.course_id=Course.Id");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool insertScore(int studentID, string courseID, float score=0, string description="")
        {
            SqlCommand command = new SqlCommand("INSERT INTO Score(student_id,course_id,student_score,description)" +
                " VALUES(@sid,@cid,@scr,@dsc)", mydb.getConnection);
            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentID;
            command.Parameters.Add("@cid", SqlDbType.VarChar).Value = courseID;
            command.Parameters.Add("@scr", SqlDbType.Float).Value = score;
            command.Parameters.Add("@dsc", SqlDbType.NVarChar).Value = description;

            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool deleteScore(int studentID, string courseID)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Score WHERE student_id = @sid " +
                "AND course_id = @cid", mydb.getConnection);
            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentID;
            command.Parameters.Add("@cid", SqlDbType.VarChar).Value = courseID;

            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal bool studentScoreExist(int student_id, string course_id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Score WHERE student_id = @sid" +
                " AND course_id = @cid And student_score>0", mydb.getConnection);
            command.Parameters.Add("@sid", SqlDbType.Int).Value = student_id;
            command.Parameters.Add("@cid", SqlDbType.VarChar).Value = course_id;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            if ((dataTable.Rows.Count == 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public DataTable getStudentScoreByID(int studentId)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText = "SELECT Score.student_id,std.fname,Score.course_id,Course.label," +
                "Score.student_score FROM std INNER JOIN Score ON std.Id=Score.student_id" +
                " INNER JOIN Course ON Score.course_id=Course.Id WHERE Score.student_id= "+studentId ;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getStudentScores()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText = "SELECT Score.student_id,std.fname,std.lname,Score.course_id," +
                "Course.label,Score.student_score,Score.description FROM std INNER JOIN Score ON "
                + "std.Id=Score.student_id INNER JOIN Course ON Score.course_id=Course.Id";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getAvgScoreByCourse()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText = "SELECT Course.label,AVG(Score.student_score) AS [Average Grade]" +
                " FROM Course,Score WHERE Course.Id=Score.course_id GROUP BY Course.label";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getCourseScoresByID(int courseId)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText = "SELECT Score.student_id,std.fname,std.lname,Score.course_id," +
                "Course.label,Score.student_score FROM std INNER JOIN Score ON" +
                "std.Id=Score.student_id INNER JOIN Course ON Score.course_id=Course.Id " +
                "WHERE Score.course_id= " + courseId;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getStudentHasScore()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText = "SELECT Score.student_id, std.fname, std.lname FROM " +
                "Score INNER JOIN std ON Score.student_id = std.Id GROUP BY Score.student_id, std.fname, std.lname";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getAvgScoreByStudent()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText = "SELECT std.Id,std.fname,std.lname,AVG(Score.student_score) AS [Average Grade]" +
                " FROM std,Score WHERE std.Id=Score.student_id GROUP BY std.Id,std.fname,std.lname";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


    }
}
