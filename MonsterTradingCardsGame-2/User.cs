using MonsterTradingCardsGame_2.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterTradingCardsGame_2
{
    internal class User
    {
        private string _username;
        private string _password;
        private string _coins;

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string Coins
        {
            get { return Coins; }
            set { Coins = value; }
        }

        public bool AddUser(string username, string password, AllUsers userList)
        {
            if (userList.IsNewUsername(username))
            {
                Username = username;
                Password = password;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
