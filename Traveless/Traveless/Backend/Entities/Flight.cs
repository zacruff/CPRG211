using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveless.Backend.Entities
{
	public class Flight
	{

		// Properties
		public string AirlineCode { get; set; }
		public string AirlineName { get; set; }
		public decimal CostPerSeat { get; set; }
		public string From { get; set; }
		public string Time { get; set; }
		public string To { get; set; }
		public int TotalSeats { get; set; }
		public string WeekDay { get; set; }

		// Constructors
		public Flight() { }
		public Flight(string airlineCode, string airlineName, string from, string to, string weekday, string time, int seats, decimal costPerSeat)
		{
			AirlineCode = airlineCode;
			AirlineName = airlineName;
			From = from;
			To = to;
			WeekDay = weekday;
			Time = time;
			TotalSeats = seats;
			CostPerSeat = costPerSeat;
		}
    }
}
