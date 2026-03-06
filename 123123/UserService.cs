using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _123123
{
    internal class UserService
    {
        //listen her gemmer alle Users
        private List<User> _usersList = new List<User>();

        public void RegisterBruger()
        {
            Console.WriteLine("===============================================".PadLeft(50));
            Console.WriteLine("               REGISTER BRUGER                 ".PadLeft(50));
            Console.WriteLine("===============================================".PadLeft(50));

            Console.Write("Indtast Dit brugernavn: ");
            string Username = Console.ReadLine().ToLower();

            Console.Write("Indtast Dit adgangkode: ");
            String Password = Console.ReadLine().ToLower();


            //automatisk tilføjer unikt id til UserID, +1 fordi ellers starer den ved nul
            int UserID = _usersList.Count + 1;

            //opretter en ny bruger og tilføjer den til _userslisten
            User NewUser = new User(Username, Password, UserID);
            _usersList.Add(NewUser);
        }

            
        public void ShowUserList(User User)   
     
        {
            foreach (var user in _usersList)       
            {
                Console.WriteLine($"{user._UserID}{user._UserName}");
            }
        }
       
    

          
        



        
    }
}
