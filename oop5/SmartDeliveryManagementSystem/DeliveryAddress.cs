using System;
using System.Collections.Generic;
using System.Text;

namespace oop5.SmartDeliveryManagementSystem
{
    public class DeliveryAddress
    {
        public string City { get; set; }

        public DeliveryAddress(string city)
        {
            City = city;
        }
    }
}
