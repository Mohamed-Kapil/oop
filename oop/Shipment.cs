using System;
using System.Collections.Generic;
using System.Text;

namespace oop
{
    public struct Shipment
    {
       
        
            private string trackingCode;
            private string description;
            private double weight;
            private decimal deliveryFee;

            public DeliveryAddress Destination { get; set; }

            public string TrackingCode
            {
                get
                {
                    return trackingCode;
                }
            }

            public string Description
            {
                get
                {
                    return description;
                }

                set
                {
                    if (!string.IsNullOrWhiteSpace(value))
                    {
                        description = value;
                    }
                }
            }
            public decimal DeliveryFee
            {
                get
                {
                    return deliveryFee;
                }

                private set
                {
                    if (value > 0)
                    {
                        deliveryFee = value;
                    }
                }
            }

            public decimal EstimatedCost
            {
                get
                {
                    return DeliveryFee + ((decimal)weight * 5);
                }
            }
            public Shipment(string trackingCode)
            {
                this.trackingCode = trackingCode;
                description = "Unknown";
                weight = 1;
                deliveryFee = 50;
                Destination =
                    new DeliveryAddress("Unknown", "Unknown", 0);
            }

            public Shipment(
                string trackingCode,
                string description,
                double weight,
                decimal deliveryFee,
                DeliveryAddress destination)
            {
                this.trackingCode = trackingCode;

                this.description =
                    !string.IsNullOrWhiteSpace(description)
                    ? description
                    : "Unknown";

                this.weight =
                    weight > 0
                    ? weight
                    : 1;
                this.deliveryFee = deliveryFee > 0 ? deliveryFee : 50;

                Destination = destination;
            }
              public void UpdateDeliveryFee(decimal newFee)
               {
                 if (newFee > 0)
                  {
                   deliveryFee = newFee;
                  }
               }
        public void PrintShipment()
        {
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {weight} KG");
            Console.WriteLine($"Delivery Fee: {DeliveryFee} EGP");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }
    }

}
 
    

