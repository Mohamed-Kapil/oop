using System;
using System.Collections.Generic;
using System.Text;

namespace oop3.RouteDeliverySystem
{
    public class CompletedShipment : Shipment
    {
      public CompletedShipment(string tracking, string desc, double weight, double fee, DeliveryAddress address)
      : base(tracking, desc, weight, fee, address)
        {
        }
    }
}
