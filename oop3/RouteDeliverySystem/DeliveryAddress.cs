using System;
using System.Collections.Generic;
using System.Text;

namespace oop3.RouteDeliverySystem
{
    public class DeliveryAddress
    {
        public string Street { get; set; }
        public string City { get; set; }

        public DeliveryAddress(string street, string city)
        {
            Street = street;
            City = city;
        }

    }
}

