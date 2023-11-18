using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_Serialization_RAF
{
    [Serializable]
    public class Event
    {
        // Properties
        public int EventNumber;
        public string? Location;
    }
}
