using System;
using System.Collections.Generic;
using System.Text;

namespace oop3.RouteDeliverySystem
{
    public class StandardShipment : Shipment
    {
        public StandardShipment(string tracking, string desc, double weight, double fee, DeliveryAddress address)
            : base(tracking, desc, weight, fee, address)
        {
        }
        public override void PrintShipment()
        {
            Console.WriteLine("Standard Shipment");
            base.PrintShipment();
            Console.WriteLine("--------------------------------------------------");
        }
    }
}
