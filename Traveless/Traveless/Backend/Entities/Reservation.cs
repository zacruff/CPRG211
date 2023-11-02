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
        public string Code { get; set; }
        public Flight Flight { get; set; }
        public string Name { get; set; }
        public string Citizenship {  get; set; }
        public bool IsActive { get; set; } = false;

        // Constructors
        public Reservation() { }
        public Reservation(string code, Flight flight, string name, string citizenship, bool isActive)
        {
            Code = code;
            Flight = flight;
            Name = name;
            Citizenship = citizenship;
            IsActive = isActive;
        }
        
        // Methods
        public string GenerateReservationCode(Flight flight)
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
            return "Reservation Code: " + code;
        }
        public bool Equals(Object obj)
        {
            if (ReferenceEquals(null, obj)) return false; return true;
        }
        public bool Equals(Reservation other)
        {
            if (!ReferenceEquals(this, other)) return false; return true;
        }
        public override string ToString()
        {
            return $"";
        }
    }
}
