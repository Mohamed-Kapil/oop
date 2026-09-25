using System;
using System.Collections.Generic;
using System.Text;

namespace oop2
{
    public struct DeliveryAddress
    {
        public string City { get; set; }
        public string Street { get; set; }
        public int BuildingNumber { get; set; }

        public DeliveryAddress(string city, string street, int buildingNumber)
        {
            if (string.IsNullOrWhiteSpace(city))
                throw new ArgumentException("City cannot be empty.");

            if (string.IsNullOrWhiteSpace(street))
                throw new ArgumentException("Street cannot be empty.");

            if (buildingNumber <= 0)
                throw new ArgumentException("Building number must be greater than 0.");

            City = city;
            Street = street;
            BuildingNumber = buildingNumber;
        }
        public override string ToString()
        {
            return $"{City}, {Street}, Building {BuildingNumber}";
        }
    }
}
