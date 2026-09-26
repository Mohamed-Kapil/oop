using System;
using System.Collections.Generic;
using System.Text;

namespace oop4.RouteDeliverySystem
{
    public class StandardShipment : Shipment
    {
        public override decimal EstimatedCost => 95m;
        public override void PrintShipment()
        {
            Console.WriteLine("Standard Shipment\n");
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP\n");
            Console.WriteLine("----------------------------------------");
        }
        public override string GetTrackingStatus() => $"Shipment {TrackingCode} is Ready.";
        public override decimal CalculateInsurance() => EstimatedCost * 0.05m;
    }
}
