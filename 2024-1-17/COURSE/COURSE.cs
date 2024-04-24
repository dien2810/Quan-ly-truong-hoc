using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_1_17.COURSE
{
    class COURSE
    {
        MY_DB mydb = new MY_DB();

        public DataTable getCourses(string query)
        {
            SqlCommand command = new SqlCommand(query);
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable getCourseBySemester(int semester)
        {

            SqlCommand command = new SqlCommand("SELECT * from Course WHERE semester=@semester");
            command.Connection = mydb.getConnection;
            command.Parameters.Add("@semester", SqlDbType.Int).Value = semester;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;

        }

        //  function to insert a new student
        public bool insertCourse(string id, string label, int period, string description, int semester)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Course (Id, label, period, description, semester)" +
                " VALUES (@Id, @label, @period, @description, @semester)", mydb.getConnection);
            command.Parameters.Add("@Id", SqlDbType.VarChar).Value = id;
            command.Parameters.Add("@label", SqlDbType.VarChar).Value = label;
            command.Parameters.Add("@period", SqlDbType.Int).Value = period;
            command.Parameters.Add("@description", SqlDbType.VarChar).Value = description;
            command.Parameters.Add("@semester", SqlDbType.Int).Value = semester;

            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public DataTable getAllCourses()
        {
            SqlCommand command = new SqlCommand("SELECT * from Course");
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable getCourses(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public bool updateCourse(string Id, string label, int period, string description, int semester)
        {
            SqlCommand command = new SqlCommand("UPDATE Course SET label=@label, period=@period, description=@description" +
                ", semester=@semester WHERE Id=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = Id;
            command.Parameters.Add("@label", SqlDbType.VarChar).Value = label;
            command.Parameters.Add("@period", SqlDbType.Int).Value = period;
            command.Parameters.Add("@description", SqlDbType.VarChar).Value = description;
            command.Parameters.Add("@semester", SqlDbType.Int).Value = semester;
            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public bool deleteCourse(string id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Course WHERE Id=@id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
            mydb.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public DataTable getCourseByID(string id)
        {
            
            SqlCommand command = new SqlCommand("SELECT * from Course WHERE Id=@id");
            command.Connection = mydb.getConnection;
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
            
        }
        public bool checkCourseName(string courseName, int semester, string id = "0")
        {
            //Id<>id de xem co ton tai khong, chi la parameter
            SqlCommand command = new SqlCommand("SELECT * from Course WHERE label=@courseName And " +
                "Id<>@id And semester=@semester");
            command.Connection = mydb.getConnection;
            command.Parameters.Add("@courseName", SqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
            command.Parameters.Add("@semester", SqlDbType.Int).Value = semester;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                //neu phat hien co 1 dong ton tai trung ten
                return false;
            }
            return true;
        }
        string execCount(string query)
        {
            SqlCommand cmd = new SqlCommand(query, mydb.getConnection);
            mydb.openConnection();
            string count = cmd.ExecuteScalar().ToString();
            mydb.closeConnection();
            return count;
        }
        public string totalCourses()
        {
            return execCount("select count(*) from Course");
        }

        public DataTable listStudent(string course_id)
        {
            //SqlCommand command = new SqlCommand("select std.Id, std.fname, std.lname, std.bdate from std");
            SqlCommand command = new SqlCommand("SELECT std.Id, std.fname, std.lname, std.bdate FROM std" +
                " INNER JOIN Score ON std.Id = Score.student_id WHERE Score.course_id LIKE @course_id");
            command.Connection = mydb.getConnection;
            command.Parameters.Add("@course_id", SqlDbType.VarChar).Value = course_id;
            DataTable list = getCourses(command);
            return list;
        }
    }
}
