using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveless.Backend.Entities
{
    public class Reservation
    {
        // Properties
        public string FlightCode { get; set; }
        public string Airline { get; set; }
        public string Day { get; set; }
        public string Time {  get; set; }
        public string Cost { get; set; }
        public string Name { get; set; }
        public string Citizenship { get; set; }
        public string ReservationCode { get; set; }

        // Constructors
        public Reservation() { }
        public Reservation(string flightCode, string airline, string day, string time, string cost, string name, string citizenship, string reservationCode)
        {
            FlightCode = flightCode;
            Airline = airline;
            Day = day;
            Time = time;
            Cost = cost;
            Name = name;
            Citizenship = citizenship;
            ReservationCode = reservationCode;
        }
        
        // Methods
        public string GenerateReservationCode()
        {
            Random res = new Random();
            String code = "";

            String str = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int size = 1;

            for (int i = 0; i < size; i++)
            {

                int x = res.Next(26);
                code = code + str[x];
            }

            String num = "123456789";
            int size2 = 4;
            for (int i = 0;i < size2; i++)
            {
                int x = res.Next(9);
                code = code + num[x];
            }
            return code;
        }
        public override string ToString()
        {
            return $"{FlightCode},{Airline},{Day},{Time},{Cost},{Name},{Citizenship},{ReservationCode}";
        }
    }
}
