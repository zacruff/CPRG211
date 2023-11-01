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

        //Constant
        public const string RESERVATIONS_JSON_FILE = "Data/reservations.json";
        // Property
        public IList<Reservation> Reservations { get { return _reservations; } }

        // Constructor
        public ReservationManager() { }

        // Methods
        public void LoadFromFile()
        {

        }
        public int AvailableSeats(Flight flight)
        {
            return flight.TotalSeats;
        }
        public Reservation FindReservationByCode(string code)
        {
            foreach (var reservation in Reservations)
            {
                if (reservation.Code == code)
                    return reservation;
                return null;
            }
            return null;
        }
        //public Reservation MakeReservation(Flight flight, string name, string citizenship)
        //{

        //}
        public void Save()
        {

        }
    }
}
