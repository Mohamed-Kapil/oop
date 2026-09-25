using System;
using System.Collections.Generic;
using System.Text;

namespace oop3.RouteDeliverySystem
{
    public class PriorityInternationalShipment : InternationalShipment
    {
        public PriorityInternationalShipment(string tracking, string desc, double weight, double fee, string country, double customs, DeliveryAddress address) 
            : base(tracking, desc, weight, fee, country, customs, address)
        {
        }
        public sealed override void GenerateCustomsReport()
        {
            Console.WriteLine("Generating PRIORITY customs report...");
        }
    }
}
