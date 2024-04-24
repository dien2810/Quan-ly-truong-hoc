using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_1_17.CONTACT
{
    internal class CONTACT
    {
        MY_DB db = new MY_DB();

        public bool InsertContact(string fname, string lname, string phone, string address, 
            string email, int userId, int groupId, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Contact(fname,lname,group_id," +
                "phone,email,address,pic,userId) VALUES(@fn,@ln,@grp,@phn,@mail,@adrs,@uid," +
                "@pic", db.getConnection);

            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@grp", SqlDbType.Int).Value = groupId;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userId;
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

        public bool UpdateContact(int contactId, string fname, string lname, string phone, 
            string address, string email, int groupId, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE Contact SET fname=@fn, lname=@ln, " +
                "group_id=@gid, phone=@phn, email=@mail, address=@adrs, pic=@pic" +
                " WHERE Id=@id", db.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = contactId;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@gid", SqlDbType.Int).Value = groupId;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            db.openConnection();

            if (command.ExecuteNonQuery() > 0)
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

        public bool DeleteContact(int contactId)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Contact WHERE Id=@id", db.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = contactId;
            db.openConnection();

            if (command.ExecuteNonQuery() > 0)
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

        //nap du lieu
        public DataTable SelectContactList(SqlCommand command)
        {
            command.Connection = db.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        
        public DataTable GetContactById(int contactId)
        {
            SqlCommand command = new SqlCommand("SELECT id, fname, lname, group_id, phone, " +
                "email, address, pic, userId FROM Contact WHERE Id=@id", db.getConnection);
            command.Parameters.Add("@id",SqlDbType.Int).Value = contactId;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table); return table;
        }
    }
}
