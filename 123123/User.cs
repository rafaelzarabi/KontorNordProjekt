using System;
using System.Collections.Generic;
using System.Text;

namespace _123123
{
    internal class User
    {
        //klassens atributes i fields
        public string _UserName { get; private set; }
        public string _Password { get; private set; }
        public int _UserID { get; private set; }


        //klassens Constructor 
        public User(string Username, string Password, int UserID)
        {
            _UserName = Username;
            _Password = Password;
            _UserID = UserID;
        }
    }
}
