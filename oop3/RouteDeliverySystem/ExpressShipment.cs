using System;
using System.Collections.Generic;
using System.Text;

namespace oop3.RouteDeliverySystem
{
    public class ExpressShipment : Shipment
    {
        public double ExtraFee { get; set; }
        public ExpressShipment(string tracking, string desc, double weight, double fee, double expressFee, DeliveryAddress address)
            : base(tracking, desc, weight, fee, address)
        {
            ExtraFee = expressFee;
        }

        public override double EstimatedCost
        {
            get { return DeliveryFee + (Weight * 5) + ExtraFee; }
        }
        public override void PrintShipment()
        {
            Console.WriteLine("Express Shipment");
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Weight        : {Weight} KG");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee} EGP");
            Console.WriteLine($"Extra Fee     : {ExtraFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
            Console.WriteLine("--------------------------------------------------");
        }
    }
}
