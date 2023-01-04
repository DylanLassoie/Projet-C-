using Projet_C.Backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_C.Management
{
    public class Dao
    {
        private static List<Player> users = new List<Player> { new Player("Pseudo", new DateTime(22 / 03 / 2022), DateTime.Now) { Username = "UserName", Password = "Password", Pseudo = "Pseudo" } };
        public static List<Player> GetUsers()
        {
            return users;
        }
        public static string GetPwdByUserName(string username)
        {
            return users.FirstOrDefault(x => x.Username == username)?.Password;
        }
    }
}
