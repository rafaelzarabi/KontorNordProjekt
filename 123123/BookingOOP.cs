using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Text;

namespace _123123
{
    internal class Booking
    {
        
        
            
        public string Day { get; set; }         // Mandag-Fredag indbygget enum i c#
            
        public string TimeSlot { get; set; }       // "Morgen", "Formiddag", "Middag"
            
        public string BookedBy { get; set; }        // Den bruger, der har booket, null hvis ledig




        public static List<Booking> BoookingSlots = new List<Booking>() // static så alle programmer kan se den og ikke behøves og kalde den
        {
            new Booking { Day = "Mandag", TimeSlot = "Morgen", BookedBy = null},
            new Booking { Day = "mandag", TimeSlot = "Formiddag", BookedBy = null},
            new Booking { Day = "Mandag", TimeSlot = "Middag", BookedBy = null},
            new Booking { Day = "Tirsdag", TimeSlot = "Morgen", BookedBy = null},
            new Booking { Day = "Tirsdag", TimeSlot = "Formiddag", BookedBy = null},
            new Booking { Day = "Tirsdag", TimeSlot = "Middag", BookedBy = null},
            new Booking { Day = "Onsdag", TimeSlot = "Morgen", BookedBy = null},
            new Booking { Day = "Onsdag", TimeSlot = "Formiddag", BookedBy = null},
            new Booking { Day = "Onsdag", TimeSlot = "Middag", BookedBy = null},
            new Booking { Day = "Torsdag", TimeSlot = "Morgen", BookedBy = null},
            new Booking { Day = "Torsdag", TimeSlot = "Formiddag", BookedBy = null},
            new Booking { Day = "Torsdag", TimeSlot = "Middag", BookedBy = null},
            new Booking { Day = "Fredag", TimeSlot = "Morgen", BookedBy = null},
            new Booking { Day = "Fredag", TimeSlot = "Formiddag", BookedBy = null},
            new Booking { Day = "Fredag", TimeSlot = "Middag", BookedBy = null}

        };


        public static void bookRoom()
        {
            
            int BookingNummer = 1;
            foreach (Booking slot in BoookingSlots)
            {
                string status;
                if (slot.BookedBy == null)
                {
                    status = "LEDIG";
                }
                else
                {
                    status = "OPTAGET af " + slot.BookedBy;
                }

                Console.WriteLine($"{BookingNummer} {slot.Day} {slot.TimeSlot} {slot.BookedBy} {status}");
                BookingNummer++;
            
            
                Console.WriteLine("Indtast navnet på facilitatoren af mødet");
                string Facilitator = Console.ReadLine();
           
                Console.WriteLine("Hvilket Tidspunkt ønsker du af booke? Morgen, formiddag, eftermiddag");
                string ØnsketDag = Console.ReadLine();

                Console.WriteLine("Hvilket Tidspunkt ønsker du af booke? Morgen, formiddag, eftermiddag");
                string ØnsketTidspunkt = Console.ReadLine();

                foreach (Booking booking in BoookingSlots)
                {
                    if (booking.Day.ToString() == ØnsketDag && booking.TimeSlot == ØnsketTidspunkt)
                    {
                        booking.BookedBy = Facilitator;
                    }
                }








            }
            

        }
    }
        





    
}
