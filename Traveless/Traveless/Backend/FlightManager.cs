using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveless.Backend.Entities;

namespace Traveless.Backend
{
	public class FlightManager
	{
		// Field
		protected List<Flight> _flights;

		// Constant
		public string FLIGHTS_FILE = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data\\flights.csv");

        // Property

        public List<Flight> Flights { get; set; } = new();

		// Constructor

		public FlightManager() { }

		// Methods
		public void LoadFlights()
		{
            string[] lines = File.ReadAllLines(FLIGHTS_FILE);

            foreach (string line in lines)
            {
                string[] columns = line.Split(',');
                string code = columns[0];
                string name = columns[1];
                string from = columns[2];
                string to = columns[3];
                string weekday = columns[4];
                string time = columns[5];
                int seats = int.Parse(columns[6]);
                decimal costPerSeat = decimal.Parse(columns[7]);

                Flight flight = new(code, name, from, to, weekday, time, seats, costPerSeat);
                Flights.Add(flight);
            }
        }
	}
}
