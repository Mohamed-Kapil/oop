using oop3.RouteDeliverySystem;
using System.Numerics;

namespace oop3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part1 question 1 (a)
            /* Method Overloading occurs when a class has multiple methods with the same name but different parameters.
             * It is resolved at compile time and does not require inheritance.
             *Method Overriding occurs when a derived class provides a new implementation for a method inherited from a base class.
             *The method in the base class must be virtual or abstract, and the derived class uses override.
             *It is resolved at runtime and requires inheritance.*/
            #endregion

            #region part1 question 1 (b)
            /*Static Binding means that the method to be executed is determined at compile time. 
             * It is commonly associated with method overloading.
             *Dynamic Binding means that the method to be executed is determined at runtime based on the actual object type.
             *It is commonly associated with method overriding and polymorphism.*/
            #endregion

            #region part1 question 2 (a)
            /*The sealed keyword prevents a class from being inherited by other classes. 
             * A sealed class cannot be used as a base class.*/
            #endregion

            #region part1 question 2 (b)
            /*A sealed class prevents other classes from inheriting from it.
            *A sealed method prevents a derived class from overriding that specific method.
            *A sealed method must be an overridden method.*/
            #endregion

            #region part1 question 2 (c)
            /*No, a sealed method cannot be overridden.
            *The sealed keyword is used with an overridden method to prevent further overriding in derived classes.
            *It stops the overriding chain at the current class.*/
            #endregion

            #region Part 02 Practical

            Driver driver = new Driver(1, "Ahmed Mohamed", "01000000000");
            DeliveryCenter center = new DeliveryCenter();
            center.Driver = driver;
            DeliveryAddress address = new DeliveryAddress("123 Main St", "Cairo");
            StandardShipment standard = new StandardShipment("SH001", "Laptop", 3, 50, address);
            ExpressShipment express = new ExpressShipment("SH002", "Mobile Phone", 2, 60, 30, address);
            InternationalShipment international = new InternationalShipment("SH003", "Television", 5, 120, "germany", 100, address);
            center.AddShipment(standard);
            center.AddShipment(express);
            center.AddShipment(international);
            center.PrintAllShipments();

            Console.WriteLine("==================================================");
            Console.WriteLine("Printing Using DeliveryHelper...\n");
            DeliveryHelper.PrintShipmentDetails(standard);
            Console.WriteLine();
            DeliveryHelper.PrintShipmentDetails(express);
            Console.WriteLine();
            DeliveryHelper.PrintShipmentDetails(international);
            Console.WriteLine();
            Console.WriteLine("==================================================");

            Console.WriteLine("Updating Weight...\n");
            Console.WriteLine($"Original Weight : {standard.Weight} KG\n");
            standard.UpdateWeight(5);
            Console.WriteLine($"Updated Weight : {standard.Weight} KG\n");
            standard.UpdateWeight(5, 0.5);
            Console.WriteLine($"Updated Weight After Packing : {standard.Weight} KG\n");
            Console.WriteLine("==================================================");

            Console.WriteLine("Printing Using Shipment[]...\n");
            Shipment[] mixedShipments = { standard, express, international };
            foreach (Shipment s in mixedShipments)
            {
                Console.WriteLine($"{s.GetType().Name}...");
                Console.WriteLine();
            }
            Console.WriteLine("==================================================");

            CompletedShipment completed = new CompletedShipment("SH004", "Book", 1, 20, address);

            PriorityInternationalShipment priority = new PriorityInternationalShipment("SH005", "Documents", 0.5, 200, "USA", 50, address);
            priority.GenerateCustomsReport();
            #endregion
            
        }
    }
}
