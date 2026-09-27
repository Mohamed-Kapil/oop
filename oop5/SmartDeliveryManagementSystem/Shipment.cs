using System;
using System.Collections.Generic;
using System.Text;

namespace oop5.SmartDeliveryManagementSystem
{
    public partial class Shipment
    {
        
        public static int TotalShipmentsCreated;

        static Shipment()
        {
            TotalShipmentsCreated = 0;
            Console.WriteLine("\nShipment System Initialized\n");
        }

        public string TrackingCode { get; set; }
        public string ShipmentType { get; set; }
        public double Weight { get; set; }
        public DeliveryAddress Address { get; set; }

        // Constructor
        public Shipment(string trackingCode, string shipmentType, double weight, string city)
        {
            TrackingCode = trackingCode;
            ShipmentType = shipmentType;
            Weight = weight;
            Address = new DeliveryAddress(city);
            TrackingStatus = "In Transit"; // Default Status

            TotalShipmentsCreated++; // Increment counter
        }

        // 1 & 2. Shallow Copy using MemberwiseClone
        public Shipment ShallowCopy()
        {
            return (Shipment)this.MemberwiseClone();
        }

        // 3. Deep Copy
        public Shipment DeepCopy()
        {
            Shipment copy = (Shipment)this.MemberwiseClone();
            // Create a completely new DeliveryAddress object
            copy.Address = new DeliveryAddress(this.Address.City);
            return copy;
        }

        // 6. Static Method
        public static int GetTotalShipmentsCreated()
        {
            return TotalShipmentsCreated;
        }

        // 10. Implementing Partial Method
        partial void OnTrackingStatusChanged(string newStatus)
        {
            Console.WriteLine($"\nTracking status changed to: {newStatus}\n");
        }
    
}
}

