using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterTradingCardsGame_2
{
    internal class AllUsers
    {
        public List<User> userList = null;

        public void CreateList(User user)
        {
            userList = new List<User>();
            userList.Add(user);
        }

        public void AddUser(User user)
        {
            userList.Add(user);
        }

        public bool IsNewUsername(string username)
        {
            for(int i = 0; i < userList.Count; i++)
            {
                if (userList[i].Username == username)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
