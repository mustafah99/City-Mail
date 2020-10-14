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

        public virtual void vehicleDeliveryForm()
        {
            WriteLine("The car delivers on wheel.");
        }
    }

    public class Quadcopter : Car
    {
        public string transponderID { get; set; }

        public override void vehicleDeliveryForm()
        {
            WriteLine("The quadcopter delivers on air.");
        }
    }

    public class senderDestination
    {
        public string senderName { get; set; }
        public string destination { get; set; }

        public string deliveryStatus;

        //public senderDestination(string status)
        //{
        //    deliveryStatus = status;
        //}
    }
}

