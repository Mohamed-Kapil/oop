using System;
using System.Collections.Generic;
using System.Text;

namespace oop5.SmartDeliveryManagementSystem
{
    public partial class Shipment
    {
        public string TrackingStatus { get; private set; }
        partial void OnTrackingStatusChanged(string newStatus);

        public void UpdateTrackingStatus(string newStatus)
        {
            TrackingStatus = newStatus;
            OnTrackingStatusChanged(newStatus); // Call the partial method
        }
    }
}
