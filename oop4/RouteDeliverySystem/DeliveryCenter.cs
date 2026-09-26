using System;
using System.Collections.Generic;
using System.Text;

namespace oop4.RouteDeliverySystem
{
    public class DeliveryCenter
    {
        private List<Shipment> items = new List<Shipment>();

        public void AddShipment(Shipment s)
        {
            items.Add(s);
        }

        public void PrintAllShipments()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("Delivery Center");
            Console.WriteLine("========================================\n");
            foreach (var s in items)
            {
                s.PrintShipment();
            }
        }
        public void PrintTrackingStatuses()
        {
            Console.WriteLine("Tracking Status\n");
            foreach (ITrackable t in items)
            {
                Console.WriteLine(t.GetTrackingStatus() + "\n");
            }
            Console.WriteLine("========================================");
        }

        public void PrintInsuranceCosts()
        {
            Console.WriteLine("Insurance\n");
            foreach (IInsurable i in items)
            {
                string shipmentType = i.GetType().Name.Replace("Shipment", " Shipment");
                Console.WriteLine($"{shipmentType} Insurance : {i.CalculateInsurance():0.00} EGP\n");
            }
            Console.WriteLine("========================================");
        }
    }
}
