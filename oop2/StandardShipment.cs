using System;
using System.Collections.Generic;
using System.Text;

namespace oop2
{
    public class StandardShipment : Shipment
    {
        public StandardShipment(string trackingCode,string description,decimal weight,decimal deliveryFee,DeliveryAddress destination)
            : base(trackingCode,description,weight,deliveryFee,destination)
        {
        }
        public override void PrintShipment()
        {
            Console.WriteLine("Standard Shipment");
            base.PrintShipment();
        }
    }
}
