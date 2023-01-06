using Projet_C.Backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Controls.Primitives;
using ADO.Net.Client.Core;
using System.Data;
using System.Diagnostics;

namespace Projet_C.Management
{
    public class Dao
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
        private SqlCommand cmd = new SqlCommand();

        private SqlDataReader reader;
        public Dao()
        {
            cmd.Connection = connection;
        }
        public  List<Admin> ReadAllAdmins()
        {
            connection.Open();
            List<Admin> list = new List<Admin>();
          
            Admin ad;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from dbo.Admins";

            reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                ad = new Admin{ Username= reader.GetString(1), Password=reader.GetString(2)};
                list.Add(ad);
            }    
            connection.Close();
            cmd.Parameters.Clear();
            return list;

        }
        public Admin ReadByAdminID(int ID)
        {
            connection.Open();
            Admin ad=null;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from dbo.Admins where ID=@ID";
            cmd.Parameters.AddWithValue("ID",ID);
            reader = cmd.ExecuteReader();
            while(reader.Read()) 
            {
                ad = new Admin { Username = reader.GetString(1), Password = reader.GetString(2) }; 
            }
            connection.Close();
            cmd.Parameters.Clear();
            return ad;
        }
        public Admin ReadByAdminUnique(String user, String pwd )
        {
            connection.Open();
           
            Admin ad = null;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from dbo.Admins where username=@USER and password=@PWD";
            cmd.Parameters.AddWithValue("USER", user);
            cmd.Parameters.AddWithValue("PWD", pwd);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ad = new Admin { Username = reader.GetString(1), Password = reader.GetString(2) };
                Trace.WriteLine(ad.ToString());
            }
            cmd.Parameters.Clear();
            connection.Close();
            return ad;
        }
    }
}
