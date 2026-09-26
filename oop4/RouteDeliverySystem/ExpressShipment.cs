using System;
using System.Collections.Generic;
using System.Text;

namespace oop4.RouteDeliverySystem
{
    public class ExpressShipment : Shipment
    {
        public decimal ExtraFee { get; set; }
        public override decimal EstimatedCost => 100m;

        public override void PrintShipment()
        {
            Console.WriteLine("Express Shipment\n");
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Extra Fee     : {ExtraFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP\n");
            Console.WriteLine("----------------------------------------");
        }

        public override string GetTrackingStatus() => $"Shipment {TrackingCode} is Out for Delivery.";
        public override decimal CalculateInsurance() => EstimatedCost * 0.08m;
    }
}
