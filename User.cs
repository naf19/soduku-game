using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sudoku2
{
   
    class User
    {
        
      public static  ArrayList users = new ArrayList();

        private string fname;
        private int userid;
        static int counter;
        private string username;
        private string password;

        public User(string fname, string username, string password)
        {
            counter += 1;
            userid = counter;
            this.fname = fname;
         
            this.username = username;
            this.password = password;
        }

        public string Fname
        {
            get
            {
                return fname;
            }

            set
            {
                fname = value;
            }
        }



        public int Userid
        {
            get
            {
                return userid;
            }

            set
            {
                userid = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }
    }
}
