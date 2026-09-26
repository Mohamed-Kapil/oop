using System;
using System.Collections.Generic;
using System.Text;

namespace oop4.RouteDeliverySystem
{
    public abstract class Shipment : ITrackable, IInsurable
    {
        public string TrackingCode { get; set; }
        public string Description { get; set; }
        public decimal Weight { get; set; }
        public decimal DeliveryFee { get; set; }
        public DeliveryAddress Destination { get; set; }
        public abstract decimal EstimatedCost { get; }
        public abstract void PrintShipment();
        public abstract string GetTrackingStatus();
        public abstract decimal CalculateInsurance();
    }
}
