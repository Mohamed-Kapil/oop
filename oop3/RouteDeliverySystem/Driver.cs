using System;
using System.Collections.Generic;
using System.Text;

namespace oop3.RouteDeliverySystem
{
    public class Driver
    {
        public int DriverId { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }

        public Driver(int id, string name, string phone)
        {
            DriverId = id;
            FullName = name;
            PhoneNumber = phone;
        }
    }
}

