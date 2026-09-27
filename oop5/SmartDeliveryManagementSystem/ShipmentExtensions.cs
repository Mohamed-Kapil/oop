using System;
using System.Collections.Generic;
using System.Text;

namespace oop5.SmartDeliveryManagementSystem
{
    public static class ShipmentExtensions
    {
        public static string GetSummary(this Shipment shipment)
        {
            return $"{shipment.TrackingCode} | {shipment.ShipmentType} | {shipment.Weight} KG | {shipment.TrackingStatus}";
        }

        public static bool IsDelivered(this Shipment shipment)
        {
            return shipment.TrackingStatus == "Delivered";
        }
    }
}
