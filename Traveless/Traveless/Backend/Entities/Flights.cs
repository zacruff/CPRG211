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
		public string Code { get; set; }
		public decimal CostPerSeat { get; set; }
		public int FlightNumber { get; set; }
		public string From { get; set; }
		public bool IsDomestic { get; set; } = true;
		public string Time { get; set; }
		public string To { get; set; }
		public int TotalSeats { get; set; }
		public string WeekDay { get; set; }

		// Constructors
		public Flight() { }
		public Flight(string code, string from, string to, string weekday, string time, int seats, decimal costPerSeat)
		{
			Code = code;
			From = from;
			To = to;
			WeekDay = weekday;
			Time = time;
			TotalSeats = seats;
			CostPerSeat = costPerSeat;
		}

		// Methods
		public bool Equals(Flight other)
		{
			if (ReferenceEquals(null, other)) return false; return Equals(other);
		}
		public bool Equals(Object other)
		{
			if (ReferenceEquals(null, other)) return false; return Equals(other);
		}
	}
}
