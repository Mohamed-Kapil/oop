using System;
using System.Collections.Generic;
using System.Text;

namespace oop3.RouteDeliverySystem
{
    public class Shipment
    {
        public string TrackingCode { get; set; }
        public string Description { get; set; }
        public double Weight { get; set; }
        public double DeliveryFee { get; set; }
        public DeliveryAddress Address { get; set; } 

        public Shipment(string tracking, string desc, double weight, double fee, DeliveryAddress address)
        {
            TrackingCode = tracking;
            Description = desc;
            Weight = weight;
            DeliveryFee = fee;
            Address = address; 
        }
        public virtual double EstimatedCost
        {
            get { return DeliveryFee + (Weight * 5); }
        }

        public virtual void PrintShipment()
        {
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Weight        : {Weight} KG");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }
        public void UpdateWeight(double newWeight)
        {
            Weight = newWeight;
        }

        public void UpdateWeight(double newWeight, double packingWeight)
        {
            Weight = newWeight + packingWeight;
        }

    }
}

