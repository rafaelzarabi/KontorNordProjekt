using _123123;
using System.Runtime.ConstrainedExecution;

namespace _123123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ProgramRunning = true;

            //jeg kalder på klassen ellers kan jeg ikke få adgang til den i main
            UserService userService = new UserService();
            
            while (ProgramRunning == true)
            {
                
                userService.RegisterBruger();
                userService.ShowUserList();








            }

           




            Console.ReadLine();
        }
    }
}
