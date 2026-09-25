using System;
using System.Collections.Generic;
using System.Text;

namespace oop3.RouteDeliverySystem
{
    public class InternationalShipment : Shipment
    {
        public string DestinationCountry { get; set; }
        public double CustomsFee { get; set; }
        public InternationalShipment(string tracking, string desc, double weight, double fee, string country, double customs, DeliveryAddress address)
            : base(tracking, desc, weight, fee, address)
        {
            DestinationCountry = country;
            CustomsFee = customs;
        }
        public override double EstimatedCost
        {
            get { return DeliveryFee + (Weight * 5) + CustomsFee; }
        }
        public override void PrintShipment()
        {
            Console.WriteLine("International Shipment");
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Weight        : {Weight} KG");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee} EGP");
            Console.WriteLine($"Destination Country: {DestinationCountry}");
            Console.WriteLine($"Customs Fee   : {CustomsFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
            Console.WriteLine("--------------------------------------------------");
        }
        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine("Generating standard customs report...");
        }
    }
}
