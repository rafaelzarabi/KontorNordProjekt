using _123123;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace _123123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Menu menu = new Menu();
            UserService userService = new UserService();

            Rooms lokale1 = new Rooms("A", 70, true, true);
            Rooms lokale2 = new Rooms("B", 40, true, false);
            Rooms lokale3 = new Rooms("C", 20, false, true);

            Booking booking1 = new Booking("mandag", "morgen", null, null);
            Booking booking2 = new Booking("mandag", "Formiddag", null, null);
            Booking booking3 = new Booking("mandag", "Eftermiddag", null, null);
            Booking booking4 = new Booking("tirsdag", "morgen", null, null);
            Booking booking5 = new Booking("tirsdag", "formiddag", null, null);
            Booking booking6 = new Booking("tirsdag", "eftermiddag", null, null);
            Booking booking7 = new Booking("onsdag", "morgen", null, null);
            Booking booking8 = new Booking("onsdag", "Formiddag", null, null);
            Booking booking9 = new Booking("onsdag", "Eftermiddag", null, null);
            Booking booking10 = new Booking("torsdag", "morgen", null, null);
            Booking booking11 = new Booking("torsdag", "Formiddag", null, null);
            Booking booking12 = new Booking("torsdag", "Eftermiddag", null, null);
            Booking booking13 = new Booking("fredag", "morgen", null, null);
            Booking booking14 = new Booking("fredag", "Formiddag", null, null);
            Booking booking15 = new Booking("fredag", "Eftermiddag", null, null);

            User user = userService.CurrentUser;

            Booking booking = new Booking(
                "Mandag",
                "Morgen",
                user,
                lokale1
            );

            lokale1.TilføjBooking(booking);




            bool ProgramRunning = true;
            bool LogIn = false;

            while (ProgramRunning == true)
            {
                while (LogIn == false)
                {

                    Console.WriteLine("================================================");
                    Console.WriteLine("                     Log In                     ");
                    Console.WriteLine("================================================");
                    Console.WriteLine("1)  Log ind ");
                    Console.WriteLine("2)  Register bruger");
                    Console.WriteLine("3)  Se alle registeret brugere");
                    Console.WriteLine("4)  Afslut programmet");

                    ConsoleKeyInfo keyinfo = Console.ReadKey();

                    switch (keyinfo.KeyChar)
                    {
                        case '1':
                            Console.Clear();
                            return userService.LoginBool();
                        case '2':
                            Console.Clear();
                            userService.RegisterUser();
                            break;
                        case '3':
                            Console.Clear();
                            userService.ShowUserList();
                            break;
                        case '4':
                            Console.Clear();
                            CloseProgram();
                            break;
                    }
                    return false;
                }

                Console.Clear();
                Console.Clear();
                Console.WriteLine("===============================================");
                Console.WriteLine("                   HOVEDMENU                   ");
                Console.WriteLine("===============================================");

                Console.WriteLine("1)  Status på lokaler");
                Console.WriteLine("2)  Lokale information");
                Console.WriteLine("3)  Book et lokale");
                Console.WriteLine("4)  Log ud");

                ConsoleKeyInfo keyinfo = Console.ReadKey();

                switch (keyinfo.KeyChar)
                {
                    case '1':
                        Console.Clear();

                        break;

                    case '2':
                        Console.Clear();

                        break;

                    case '3':
                        Console.Clear();

                        break;
                    case '4':
                        Console.Clear();
                        return userService.LogOutBool();

                }
                return true;      // Vi har en return stafet med bool fra  LogOut()-->mainMenu()-->Main()    
            }
        }
        




























        public void CloseProgram()
        {
            Console.WriteLine("Er du sikker på du vil afslutte programmet?\n At afslutte programmet fjerne af indtastet data");
            Console.WriteLine("1) ja");
            Console.WriteLine("2) Nej");

            ConsoleKeyInfo input = Console.ReadKey();
            switch (input.KeyChar)
            {
                case '1':
                    Environment.Exit(0);
                    break;
                case '2':
                break;
            } 
            


            /*//LOKALE INFO - FRA LOKALER.CS KLASSE
            List<Rooms> rooms = ne 

            foreach (var room in rooms)
            {
                Console.WriteLine($"Lokale {room.Name} ({room.SeatsAmount} pladser) - {(room.HasWhiteboard ? "Whiteboard" : "Ingen whiteboard")} - {(room.HasProjector ? "Projektor" : "Ingen projektor")}");
            }*/
        }
    }
}
