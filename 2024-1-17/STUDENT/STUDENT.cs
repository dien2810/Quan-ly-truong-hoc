using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2024_1_17.COURSE;

namespace _2024_1_17
{
    class STUDENT
    {
        MY_DB mydb = new MY_DB();


        //  function to insert a new student
        public bool insertStudent(int Id, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture)
        {
            string email = Id.ToString() + "@student.hcmute.edu.vn";
            SqlCommand command = new SqlCommand("INSERT INTO std (id, fname, lname, bdate, gender, phone, address, picture, email)" +
                " VALUES (@id,@fn, @ln, @bdt, @gdr, @phn, @adrs, @pic, @email)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname.Trim();
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname.Trim();
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender.Trim();
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone.Trim();
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address.Trim();
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = email.Trim();

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

        public bool insertStudent(int Id, string fname, string lname, DateTime bdate, string gender, string phone, string address)
        {
            string email = Id.ToString() + "@student.hcmute.edu.vn";
            SqlCommand command = new SqlCommand("INSERT INTO std (id, fname, lname, bdate, gender, phone, address, email)" +
                " VALUES (@id,@fn, @ln, @bdt, @gdr, @phn, @adrs, @email)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname.Trim();
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname.Trim();
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender.Trim();
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone.Trim();
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address.Trim();            
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = email.Trim();

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

        public DataTable getStudents(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public bool updateStudent(int Id, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE std SET fname=@fn, lname=@ln, bdate=@bdt, gender=@gdr, " +
                "phone=@phn, address=@adrs, picture=@pic WHERE Id=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            //them truong email
            string email = Id.ToString() + "@student.hcmute.edu.vn";
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;

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

        public bool deleteStudent(int id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM std WHERE id=@id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            mydb.openConnection();
            if (cmd.ExecuteNonQuery()==1) {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        string execCount(string query)
        {
            SqlCommand cmd = new SqlCommand(query, mydb.getConnection);
            mydb.openConnection();
            string count = cmd.ExecuteScalar().ToString();
            mydb.closeConnection();
            return count;
        }

        public string totalStudent()
        {
            return execCount("select count(*) from std");
        }

        public string totalMaleStudent()
        {
            return execCount("select count(*) from std where gender='Male'");
        }

        public string totalFemaleStudent()
        {
            return execCount("select count(*) from std where gender='Female'");
        }

        internal DataTable getSeletectedCourse(int student_id)
        {
            SqlCommand command = new SqlCommand(@"SELECT Course.Id, Course.label FROM Score INNER JOIN Course ON Course.Id = Score.course_id WHERE Score.student_id = @sid", mydb.getConnection);
            command.Parameters.Add("@sid", SqlDbType.Int).Value = student_id;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }
    }
}
