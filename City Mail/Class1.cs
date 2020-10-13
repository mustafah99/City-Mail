using System;
using System.Collections.Generic;
using System.Text;

namespace City_Mail
{
    public class Car
    {
        public string ID { get; set; }

        public string capacityKg { get; set; }

        public string reachKm { get; set; }

        public string registrationNumber { get; set; }
    }

    public class Quadcopter
    {
        public string ID { get; set; }

        public string capacityKg { get; set; }

        public string reachKm { get; set; }

        public string transponderID { get; set; }
    }

    public class senderDestination
    {
        public string senderName { get; set; }
        public string destination { get; set; }
    }
}

