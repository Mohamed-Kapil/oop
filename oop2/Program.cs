using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace oop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part1 question 1 (A)
            /*When we create an object from a class and copy it to another variable, both variables refer to the same object in memory.Therefore, changing one variable can affect the other.
             When we copy a struct, a new copy of its data is created.Therefore, changing one variable does not affect the other.
             Classes can support inheritance, while structs cannot inherit from another class or struct.
             Classes are usually used for complex objects and large amounts of data, while structs are suitable for small and simple data...*/
            #endregion

            #region part1 question 1 (B)
            /*Classes are more suitable for large applications because they support inheritance, polymorphism, encapsulation, and reference-type behavior.
             * They make it easier to organize and manage complex objects and relationships between different parts of the application.*/
            #endregion

            #region part1 question 2 (A)
            /*The parent class is Shipment because it is the class that is inherited from.*/
            #endregion

            #region part1 question 2 (B)
            /*The child class is ExpressShipment because it inherits from the Shipment class.*/
            #endregion

            #region part1 question 2 (C)
            /*The ExpressShipment class inherits the TrackingCode property from the Shipment class.*/
            #endregion

            #region part1 question 2 (D)
            /*Inheritance is better because it allows us to reuse common code without duplicating it.
             * It makes the code easier to maintain, reduces repetition, and keeps the program more organized.*/
            #endregion

            #region part2 Practical
            Console.Write("Enter Delivery Center Name: ");
            string centerName = Console.ReadLine();

            DeliveryCenter center =
                new DeliveryCenter(centerName);
            Console.WriteLine();
            Console.WriteLine("=== Standard Shipment ===");

            Console.Write("Tracking Code: ");
            string standardTracking =
                Console.ReadLine();

            Console.Write("Description: ");
            string standardDescription =
                Console.ReadLine();

            Console.Write("Weight: ");
            decimal standardWeight =
                decimal.Parse(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            decimal standardFee =
                decimal.Parse(Console.ReadLine());

            Console.Write("City: ");
            string standardCity =
                Console.ReadLine();

            Console.Write("Street: ");
            string standardStreet =
                Console.ReadLine();

            Console.Write("Building Number: ");
            int standardBuilding =
                int.Parse(Console.ReadLine());
            DeliveryAddress standardAddress =
           new DeliveryAddress(
               standardCity,
               standardStreet,
               standardBuilding);

            StandardShipment standardShipment =
                new StandardShipment(
                    standardTracking,
                    standardDescription,
                    standardWeight,
                    standardFee,
                    standardAddress);

            if (center.AddShipment(standardShipment))
            {
                Console.WriteLine("Shipment Added Successfully.");
            }
            Console.WriteLine();
            Console.WriteLine("=== Express Shipment ===");

            Console.Write("Tracking Code: ");
            string expressTracking =
                Console.ReadLine();

            Console.Write("Description: ");
            string expressDescription =
                Console.ReadLine();

            Console.Write("Weight: ");
            decimal expressWeight =
                decimal.Parse(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            decimal expressFee =
                decimal.Parse(Console.ReadLine());

            Console.Write("Extra Fee: ");
            decimal extraFee =
                decimal.Parse(Console.ReadLine());

            Console.Write("City: ");
            string expressCity =
                Console.ReadLine();

            Console.Write("Street: ");
            string expressStreet =
                Console.ReadLine();
            Console.Write("Building Number: ");
            int expressBuilding =
                int.Parse(Console.ReadLine());

            DeliveryAddress expressAddress =
                new DeliveryAddress(
                    expressCity,
                    expressStreet,
                    expressBuilding);

            ExpressShipment expressShipment =
                new ExpressShipment(
                    expressTracking,
                    expressDescription,
                    expressWeight,
                    expressFee,
                    expressAddress,
                    extraFee);

            if (center.AddShipment(expressShipment))
            {
                Console.WriteLine(
                    "Shipment Added Successfully.");
            }
            Console.WriteLine();
            Console.WriteLine("=== International Shipment ===");

            Console.Write("Tracking Code: ");
            string internationalTracking =
                Console.ReadLine();

            Console.Write("Description: ");
            string internationalDescription =
                Console.ReadLine();

            Console.Write("Weight: ");
            decimal internationalWeight =
                decimal.Parse(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            decimal internationalFee =
                decimal.Parse(Console.ReadLine());

            Console.Write("Destination Country: ");
            string country =
                Console.ReadLine();

            Console.Write("Customs Fee: ");
            decimal customsFee =
                decimal.Parse(Console.ReadLine());

            Console.Write("City: ");
            string internationalCity =
                Console.ReadLine();
            Console.Write("Street: ");
            string internationalStreet =
                Console.ReadLine();

            Console.Write("Building Number: ");
            int internationalBuilding =
                int.Parse(Console.ReadLine());

            DeliveryAddress internationalAddress =
                new DeliveryAddress(
                    internationalCity,
                    internationalStreet,
                    internationalBuilding);

            InternationalShipment internationalShipment =
                new InternationalShipment(
                    internationalTracking,
                    internationalDescription,
                    internationalWeight,
                    internationalFee,
                    internationalAddress,
                    country,
                    customsFee);

            if (center.AddShipment(internationalShipment))
            {
                Console.WriteLine(
                    "Shipment Added Successfully.");
            }
            Console.WriteLine();
            Console.WriteLine("=== All Shipments ===");

            center.PrintAllShipments();
            Console.WriteLine();

            Console.Write(
                "Enter Tracking Code to Search: ");

            string searchCode =
                Console.ReadLine();

            Shipment searchedShipment =
                center[searchCode];

            if (searchedShipment != null)
            {
                Console.WriteLine();
                Console.WriteLine(
                    "Shipment Found:");

                searchedShipment.PrintShipment();
            }
            else
            {
                Console.WriteLine(
                    "Shipment Not Found.");
            }
            Console.WriteLine();

            Console.Write(
                "Enter Tracking Code to Remove: ");

            string removeCode =
                Console.ReadLine();

            if (center.RemoveShipment(removeCode))
            {
                Console.WriteLine(
                    "Shipment Removed Successfully.");
            }
            else
            {
                Console.WriteLine(
                    "Shipment Not Found.");
            }
            Console.WriteLine();
            Console.WriteLine(
                "=== Remaining Shipments ===");

            center.PrintAllShipments();
            #endregion
        }
    }
}
