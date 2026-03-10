using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _123123
{
    internal class Booking
    {

        public string Day { get; private set; }         // Mandag-Fredag indbygget enum i c#

        public string TimeSlot { get; private set; }       // "Morgen", "Formiddag", "Middag"

        public User? BookedBy { get; internal set; }        // Den bruger, der har booket, null hvis ledig

        private List<Booking> _allBookings = new List<Booking>();
        public Booking(string day, string timeslot, User bookedBy)
        {
            Day = day ; 
            TimeSlot = timeslot;
            BookedBy = bookedBy;
        }


      
        Booking booking1 = new Booking("mandag", "morgen", null);
        Booking booking2 = new Booking("mandag", "Formiddag", null);
        Booking booking3 = new Booking("mandag", "Eftermiddag", null);
        Booking booking4 = new Booking("tirsdag", "morgen", null);
        Booking booking5 = new Booking("tirsdag", "formiddag", null);
        Booking booking6 = new Booking("tirsdag", "eftermiddag", null);
        Booking booking7 = new Booking("onsdag", "morgen", null);
        Booking booking8 = new Booking("onsdag", "Formiddag", null);
        Booking booking9 = new Booking("onsdag", "Eftermiddag", null);
        Booking booking10 = new Booking("torsdag", "morgen", null);
        Booking booking11 = new Booking("torsdag", "Formiddag", null);
        Booking booking12 = new Booking("torsdag", "Eftermiddag", null);
        Booking booking13 = new Booking("fredag", "morgen", null);
        Booking booking14 = new Booking("fredag", "Formiddag", null);
        Booking booking15 = new Booking("fredag", "Eftermiddag", null);

        
        Booking

    }
    
} 
