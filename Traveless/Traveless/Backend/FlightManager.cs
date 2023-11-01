﻿using System;
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
		public const string FLIGHTS_FILE = "Data/flights.csv";

		// Property

		public IList<Flight> Flights { get { return _flights; } }

		// Constructor

		public FlightManager() { }

		// Methods
		public Flight FindFlightByCode(string code)
		{
			foreach (var flight in Flights) 
			{
				if (flight.Code == code)
					return flight;
				return null;
			}
			return null;
		}

		public void LoadFlights()
		{
            string[] lines = File.ReadAllLines(FLIGHTS_FILE);

            foreach (string line in lines)
            {
                string[] columns = line.Split(',');
                string code = columns[0];
                string from = columns[2];
                string to = columns[3];
                string weekday = columns[4];
                string time = columns[5];
                int seats = int.Parse(columns[6]);
                decimal costPerSeat = decimal.Parse(columns[7]);

                Flight flight = new(code, from, to, weekday, time, seats, costPerSeat);
                Flights.Add(flight);
            }
        }
	}
}