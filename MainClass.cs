using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sudoku2
{
    class MainClass
    {
    public    static void populateusrs()
        {
            
        }
        static void deleteUser(int userid)
        {
            foreach (User person in User.users)
            {
                if (person.Userid==userid)
                {
                    User.users.Remove(person);
                    break;
                }


            }
        }
      public static  void registerUser(string fname,  string username, string password)
        {
            User newuser = new User(fname,   username,  password);
            User.users.Add(newuser);
        }
    public static   Boolean login(string username,string password)
        {
            Boolean status=false;
            foreach(User person in User.users)
                {
                if(person.Username.Equals(username) && person.Password.Equals(password))
                {
                    status = true;
                }


            }
            return status;

        }
    }
}
