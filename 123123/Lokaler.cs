using System;
using System.Collections.Generic;
using System.Text;

namespace _123123
{
    internal class Lokaler
    {
        public string Name  { get; private set; }
        public int SeatsAmount { get; private set; }
        public bool HasWhiteboard { get; private set; }
        public bool HasProjector { get; private set; }
        
        public Lokaler(string name, int seatsAmount, bool hasWhiteboard, bool hasProjector)
        {
            Name = name;
            SeatsAmount = seatsAmount;
            HasWhiteboard = hasWhiteboard;
            HasProjector = hasProjector;
        }
        public static List<Lokaler> GetLokaler()
        {
            List<Lokaler> lokaler = new List<Lokaler>();
    
            lokaler.Add(new Lokaler("A", 70, true, true));
            lokaler.Add(new Lokaler("B", 40, true, false));
            lokaler.Add(new Lokaler("C", 20, false, true));
            
            return lokaler; 
        }
    }
}
        
      