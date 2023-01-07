﻿using Projet_C.Backend;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Projet_C.Management
{
    internal class DaoPlayer : Dao
    {
        public List<Player> ReadAll()
        {
            connection.Open();
            List<Player> list = new List<Player>();

            Player pl;
            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from dbo.Players";


                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    pl = new Player(reader.GetString(3), reader.GetDateTime(4), reader.GetDateTime(5)) { Id_User = reader.GetInt32(0), Username = reader.GetString(1), Password = reader.GetString(2) };
                    list.Add(pl);
                }
            }
            catch (Exception ex)
            {
                Trace.Write(ex.Message);
            }
            connection.Close();
            cmd.Parameters.Clear();
            return list;

        }
        public Player ReadByID(int ID)
        {
            connection.Open();
            Player pl = null;
            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from dbo.Players where ID=@ID";
                cmd.Parameters.AddWithValue("ID", ID);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    pl = new Player(reader.GetString(3), reader.GetDateTime(4), reader.GetDateTime(5)) { Id_User = reader.GetInt32(0), Username = reader.GetString(1), Password = reader.GetString(2) };
                }
            }
            catch (Exception ex) { Trace.Write(ex.Message); }
            connection.Close();
            cmd.Parameters.Clear();
            return pl;
        }
        public Player ReadByUnique(String user, String pwd)
        {
            connection.Open();

            Player pl = null;
            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from dbo.Players where username=@USER and password=@PWD";
                cmd.Parameters.AddWithValue("USER", user);
                cmd.Parameters.AddWithValue("PWD", pwd);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    pl = new Player(reader.GetString(3), reader.GetDateTime(4), reader.GetDateTime(5)) { Id_User = reader.GetInt32(0), Username = reader.GetString(1), Password = reader.GetString(2) };
                }
            }
            catch (Exception ex) { Trace.WriteLine(ex.Message); }
            cmd.Parameters.Clear();
            connection.Close();
            return pl;
        }
        public Player ReadUser(String user)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();

            Player pl = null;
            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from dbo.Players where username=@USER";
                cmd.Parameters.AddWithValue("USER", user);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    pl = new Player(reader.GetString(3), reader.GetDateTime(4), reader.GetDateTime(5)) { Id_User = reader.GetInt32(0), Username = reader.GetString(1), Password = reader.GetString(2) };
                }
            }
            catch (Exception ex) { Trace.WriteLine(ex.Message); }
            cmd.Parameters.Clear();
            connection.Close();
            return pl;
        }

        public Boolean Insert(Player pl)
        {

            if (ReadUser(pl.Username) != null)
            {

                return false;

            }
            connection.Open();
            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into dbo.Players(username,password,pseudo,registrationdate,dateofbirth) values(@USER,@PWD,@PSEU,@RD,@DOB)";
                cmd.Parameters.AddWithValue("USER", pl.Username);
                cmd.Parameters.AddWithValue("PWD", pl.Password);
                cmd.Parameters.AddWithValue("PSEU", pl.Pseudo);
                cmd.Parameters.AddWithValue("RD", pl.RegistrationDate);
                cmd.Parameters.AddWithValue("DOB", pl.DateOfBirth);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex) { Trace.WriteLine(ex.Message); }

            cmd.Parameters.Clear();
            connection.Close();
            return true;
        }

        public Boolean Delete(Player pl)
        {

            connection.Open();
            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete dbo.Players where ID=@ID";
                cmd.Parameters.AddWithValue("ID", pl.Id_User);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex) { Trace.WriteLine(ex.Message); }

            cmd.Parameters.Clear();
            connection.Close();
            return true;
        }
    }
}
