using System;
using System.Collections.Generic;
using System.Text;

namespace oop3.RouteDeliverySystem
{
    public static class DeliveryHelper
    {
        public static void PrintShipmentDetails(Shipment shipment)
        { 
            Console.WriteLine($"{shipment.GetType().Name} Printed Successfully.");
        }
    }
}
