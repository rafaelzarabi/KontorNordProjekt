using System;
using System.Collections.Generic;
using System.Text;

namespace _123123
{
    internal class Booking
    {
        
        
            
        public DayOfWeek Day { get; set; }         // Mandag-Fredag indbygget enum i c#
            
        public string TimeSlot { get; set; }       // "Morgen", "Formiddag", "Middag"
            
        public User BookedBy { get; set; }        // Den bruger, der har booket, null hvis ledig




        public static List<Booking> BoookingSlots = new List<Booking>() // static så alle programmer kan se den og ikke behøves og kalde den
        {
            new Booking { Day = DayOfWeek.Monday, TimeSlot = "Morgen", BookedBy = null},
            new Booking { Day = DayOfWeek.Monday, TimeSlot = "Formiddag", BookedBy = null},
            new Booking { Day = DayOfWeek.Monday, TimeSlot = "Middag", BookedBy = null},
            new Booking { Day = DayOfWeek.Tuesday, TimeSlot = "Morgen", BookedBy = null},
            new Booking { Day = DayOfWeek.Tuesday, TimeSlot = "Formiddag", BookedBy = null},
            new Booking { Day = DayOfWeek.Tuesday, TimeSlot = "Middag", BookedBy = null},
            new Booking { Day = DayOfWeek.Wednesday, TimeSlot = "Morgen", BookedBy = null},
            new Booking { Day = DayOfWeek.Wednesday, TimeSlot = "Formiddag", BookedBy = null},
            new Booking { Day = DayOfWeek.Wednesday, TimeSlot = "Middag", BookedBy = null},
            new Booking { Day = DayOfWeek.Thursday, TimeSlot = "Morgen", BookedBy = null},
            new Booking { Day = DayOfWeek.Thursday, TimeSlot = "Formiddag", BookedBy = null},
            new Booking { Day = DayOfWeek.Thursday, TimeSlot = "Middag", BookedBy = null}

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
                    status = "OPTAGET af " + slot.BookedBy._Firstname;
                }

                Console.WriteLine($"{BookingNummer} {slot.Day}");
                BookingNummer++;

            }






        }
    }
        





    
}
