using System;
using System.Collections.Generic;
using System.Text;

namespace oop2
{
    public class DeliveryCenter
    {
        public string CenterName { get; set; }

        private Shipment[] Shipments;

        private int shipmentCount = 0;

        public DeliveryCenter(string centerName)
        {
            if (string.IsNullOrWhiteSpace(centerName))
                throw new ArgumentException("Center name cannot be empty.");

            CenterName = centerName;

            Shipments = new Shipment[20];
        }
        public Shipment this[int index]
        {
            get
            {
                if (index < 0 || index >= shipmentCount)
                    throw new IndexOutOfRangeException();

                return Shipments[index];
            }

            set
            {
                if (index < 0 || index >= shipmentCount)
                    throw new IndexOutOfRangeException();

                Shipments[index] = value;
            }
        }
        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < shipmentCount; i++)
                {
                    if (Shipments[i].TrackingCode == trackingCode)
                    {
                        return Shipments[i];
                    }
                }

                return null;
            }
        }

        public bool AddShipment(Shipment shipment)
        {
            if (shipment == null)
                return false;

            if (shipmentCount >= 20)
                return false;

            Shipments[shipmentCount] = shipment;

            shipmentCount++;

            return true;
        }
        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < shipmentCount; i++)
            {
                if (Shipments[i].TrackingCode == trackingCode)
                {
                    for (int j = i; j < shipmentCount - 1; j++)
                    {
                        Shipments[j] = Shipments[j + 1];
                    }

                    Shipments[shipmentCount - 1] = null;

                    shipmentCount--;

                    return true;
                }
            }

            return false;
        }
        public void PrintAllShipments()
        {
            Console.WriteLine();
            Console.WriteLine($"Delivery Center : {CenterName}");

            Console.WriteLine("========================================");

            for (int i = 0; i < shipmentCount; i++)
            {
                Shipments[i].PrintShipment();

                Console.WriteLine("----------------------------------------");
            }
    }   }
}
