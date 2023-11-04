using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveless.Backend.Entities;

namespace Traveless.Backend
{
    public class ReservationManager
    {
        // Field
        protected List<Reservation> _reservations;

        // Constant
        public string RESERVATIONS_FILE = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data\\reservations.csv");
        // Property
        public List<Reservation> Reservations { get; set; } = new();

        // Constructor
        public ReservationManager() { }

        // Methods
        public void LoadFromFile()
        {
            string[] lines = File.ReadAllLines(RESERVATIONS_FILE);
            foreach (string line in lines)
            {
                string[] columns = line.Split(',');
                string flightCode = columns[0];
                string airline = columns[1];
                string day = columns[2];
                string time = columns[3];
                string cost = columns[4];
                string name = columns[5];
                string citizenship = columns[6];
                string reservationCode = columns[7];

                Reservation reservation = new(flightCode, airline, day, time, cost, name, citizenship, reservationCode);
                Reservations.Add(reservation);
            }
        }
        public Reservation MakeReservation(string flightCode, string airline, string day, string time, string cost, string name, string citizenship, string reservationCode)
        {
            Reservation reservation = new(flightCode, airline, day, time, cost, name, citizenship, reservationCode);
            return reservation;
        }
        public void Save()
        {
            StreamWriter write = new StreamWriter(RESERVATIONS_FILE);
            foreach (Reservation reservation in Reservations) 
            {
               string formattedReservation = reservation.ToString().Trim();
                write.WriteLine(formattedReservation);
            }
            write.Close();
        }
    }
}
