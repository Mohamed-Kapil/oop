using System;
using System.Collections.Generic;
using System.Text;

namespace oop4.RouteDeliverySystem
{
    public class InternationalShipment : Shipment
    {
        public override decimal EstimatedCost => 260m;

        public override void PrintShipment()
        {
            Console.WriteLine("International Shipment\n");
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Destination Country : {Destination?.Country}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP\n");
            Console.WriteLine("========================================");
        }

        public override string GetTrackingStatus() => $"Shipment {TrackingCode} has been Delivered.";
        public override decimal CalculateInsurance() => EstimatedCost * 0.12m;
    }
}
