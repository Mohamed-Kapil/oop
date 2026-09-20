using static System.Runtime.InteropServices.JavaScript.JSType;

namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question 1 (a)
            /*When a DeliveryAddress variable is copied, a new independent copy of the value is created.
             Modifying the copied variable does not affect the original variable.*/
            #endregion

            #region question 1 (b)
            /*When a Customer variable is copied, both variables refer to the same object. Therefore, 
             modifying the object through one variable also affects the other variable.*/
            #endregion

            #region question 2 (a)
            /* a) Problems with the design
                 1-The fields are public, so they can be accessed and modified directly from outside the class or struct.
                 2-There is no validation for the data.
                 3-There is no control over how the data is accessed or modified, which weakens encapsulation.*/
            #endregion

            #region question 2 (b)
            /* Private fields and public properties can improve encapsulation by hiding the internal data and controlling access to it.
               The properties can use get and set accessors, and validation can be added inside the set accessor.*/
            #endregion

            #region question part 2 
            DeliveryCenter center = new DeliveryCenter();

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Enter Shipment {i} Data");

                Console.Write("Tracking Code: ");
                string trackingCode = Console.ReadLine();

                Console.Write("Description: ");
                string description = Console.ReadLine();

                Console.Write("Weight: ");
                double weight = double.Parse(Console.ReadLine());

                Console.Write("Delivery Fee: ");
                decimal deliveryFee = decimal.Parse(Console.ReadLine());

                Console.Write("City: ");
                string city = Console.ReadLine();

                Console.Write("Street: ");
                string street = Console.ReadLine();

                Console.Write("Building Number: ");
                int buildingNumber = int.Parse(Console.ReadLine());

                DeliveryAddress address = new DeliveryAddress(city, street, buildingNumber);

                Shipment shipment = new Shipment(trackingCode, description, weight, deliveryFee, address);

                if (center.AddShipment(shipment))
                {
                    Console.WriteLine("Shipment added successfully.");
                }
                else
                {
                    Console.WriteLine("Delivery center is full.");
                }

            }
            Console.WriteLine("--- All Shipments ---");

            for (int i = 0; i < 3; i++)
            {
                center[i].PrintShipment();
                Console.WriteLine();
            }

            Console.Write("Enter a tracking code to search: ");
            string searchCode = Console.ReadLine();

            Shipment foundShipment = center[searchCode];

            if (!string.IsNullOrEmpty(foundShipment.TrackingCode))
            {
                Console.WriteLine(
                    $"Shipment found: {foundShipment.TrackingCode} - {foundShipment.Description}"
                );
            }
            else
            {
                Console.WriteLine("Shipment not found.");
            }
            Console.WriteLine();
            Console.WriteLine("--- Struct Copy Test ---");

            DeliveryAddress originalAddress =
                new DeliveryAddress(
                    "Cairo",
                    "Tahrir Street",
                    15
                );

            DeliveryAddress copiedAddress = originalAddress;

            copiedAddress.Street = "Makram Ebeid Street";
            copiedAddress.BuildingNumber = 20;

            Console.WriteLine(
                "Original Address: " + originalAddress.GetFullAddress());

            Console.WriteLine("Copied Address: " + copiedAddress.GetFullAddress());
            #endregion
        }
    }
}
