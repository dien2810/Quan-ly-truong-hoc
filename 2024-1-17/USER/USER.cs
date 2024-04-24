using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _2024_1_17.USER
{
    internal class USER
    {
        MY_DB db = new MY_DB();

        public int GetUserID(string username, string password)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM [USER] WHERE uname = @uname " +
                "AND pwd = @pass", db.getConnection);

            command.Parameters.Add("@uname", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            int userId;
            if (int.TryParse(table.Rows[0][0].ToString(), out userId)){
                return userId;
            }
            return 0;

        }

        public DataTable GetUserByID(Int32 userId)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM [USER] WHERE Id = @uid", db.getConnection);
            
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userId;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;

        }

        public bool InsertUser(string fname, string lname, string username, string password,
            MemoryStream picture, string role)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [USER](fname,lname,uname,pwd,fig,role) " +
                "VALUES(@fn,@ln,@un,@pass,@pic,@role)", db.getConnection);

            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("@role", SqlDbType.VarChar).Value = role;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }

        }

        public bool InsertUser(string fname, string lname, string username, string password, 
            MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [USER](fname,lname,uname,pwd,fig) " +
                "VALUES(@fn,@ln,@un,@pass,@pic)", db.getConnection);

            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }

        }

        public bool UserNameExist(string username, string operation, int userId)
        {
            string query = "";
            if (operation == "register")
            {
                query = "SELECT * FROM [USER] WHERE uname=@un";
            }
            else
            {
                if (operation == "edit")
                {
                    query = "SELECT * FROM [USER] WHERE uname=@un AND id<>@uid";
                }
            }
            SqlCommand command = new SqlCommand(query, db.getConnection);

            command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            //command.Parameters.Add("@uid", SqlDbType.Int).Value = userId;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateUser(int userId, string fname, string lname, string username, 
            string password, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE [USER] SET fname=@fn, lname=@ln, uname=" +
                "@un, pwd=@pass, fig=@pic WHERE id=@uid", db.getConnection);

            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userId;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
    }
}
