using System;
using System.Collections.Generic;
using System.Text;

namespace oop3.RouteDeliverySystem
{
    public class DeliveryCenter
    {
        public Driver Driver { get; set; }
        private List<Shipment> Shipments = new List<Shipment>();
        public void AddShipment(Shipment shipment)
        {
            Shipments.Add(shipment);
        }

        public void RemoveShipment(Shipment shipment)
        {
            Shipments.Remove(shipment);
        }

        public void PrintAllShipments()
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("Delivery Center");
            Console.WriteLine("==================================================");
            if (Driver != null)
                Console.WriteLine($"Driver : {Driver.FullName}\n");
            Console.WriteLine("--------------------------------------------------");

            foreach (Shipment s in Shipments)
            {
                s.PrintShipment();
            }
        }
    }
}
