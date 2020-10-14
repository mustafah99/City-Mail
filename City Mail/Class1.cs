using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using static System.Console;

namespace City_Mail
{
    public class Car
    {
        public string ID { get; set; }

        public string capacityKg { get; set; }

        public string reachKm { get; set; }

        public string registrationNumber { get; set; }
    }

    public class Quadcopter : Car
    {
        public string transponderID { get; set; }
    }

    public class senderDestination
    {
        public string senderName { get; set; }
        public string destination { get; set; }

        public string deliveryStatus;

        public senderDestination(string status)
        {
            deliveryStatus = status;
        }
    }
}

