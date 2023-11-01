using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveless.Backend.Entities;

namespace Traveless.Backend
{
    public class AirlineManager
    {
        // Field
        protected List<Airline> _airlines;

        // Constant
        public const string AIRLINES_FILE = "Data/airlines.csv";

        // Property
        public IList<Airline> Airlines { get {  return _airlines; } }

        // Constructor
        public AirlineManager() { }
        
        // Methods
        public void LoadAirlines()
        {
            string[] lines = File.ReadAllLines(AIRLINES_FILE);

            foreach (string line in lines)
            {
                string[] columns = line.Split(',');
                string code = columns[0];
                string name = columns[1];

                Airline airline = new(code, name);
                Airlines.Add(airline);
            }
        }
        public Airline FindAirline(string code)
        {
            foreach (Airline airline in Airlines)
            {
                if (airline.Code == code)
                    return airline;
                return null;
            }
            return null;
        }
    }
}
