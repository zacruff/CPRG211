using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveless.Backend.Entities;

namespace Traveless.Backend
{
    public class AirportManager
    {
        // Field
        protected List<Airport> _airports;

        // Constant
        public string AIRPORTS_FILE = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data\\airports.csv");

        // Property
        public List<Airport> Airports { get; set; } = new();

        // Constructor
        public AirportManager() { }

        // Method
        public void LoadAirports()
        {
            string[] lines = File.ReadAllLines(AIRPORTS_FILE);

            foreach (string line in lines)
            {
                string[] columns = line.Split(',');
                string code = columns[0];
                string name = columns[1];

                Airport airport = new(code, name);
                Airports.Add(airport);
            }
        }
    }
}
