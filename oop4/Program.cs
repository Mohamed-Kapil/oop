using oop4.RouteDeliverySystem;

namespace oop4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part 1 question 1 (a)
            /*Abstraction is the process of hiding complex implementation details and showing only the essential features of an object.*/
            #endregion

            #region part 1 question 1 (b)
            /*Abstraction is one of the four pillars of OOP because it reduces complexity, hides unnecessary implementation details, and allows users to focus on what an object does rather than how it works.*/
            #endregion

            #region part 1 question 2 (a)
            /*An abstract class is a class that cannot be instantiated directly and can contain fields, properties, constructors, concrete methods, and abstract methods.
             * An interface defines a contract that specifies the members a class must implement.*/
            #endregion

            #region part 1 question 2 (b)
            /*We choose an interface when we want different and unrelated classes to share a common behavior or contract.
             * A class can implement multiple interfaces, making interfaces useful when multiple behaviors are required.*/
            #endregion

            #region part 1 question 2 (c)
            /*No, a class cannot inherit from multiple abstract classes because C# supports single class inheritance.
             * However, a class can implement multiple interfaces.*/
            #endregion

            #region part 2  Practical
            var s1 = new StandardShipment { TrackingCode = "SH001", Description = "Laptop" };
            var s2 = new ExpressShipment { TrackingCode = "SH002", ExtraFee = 30m };
            var s3 = new InternationalShipment { TrackingCode = "SH003", Destination = new DeliveryAddress { Country = "Germany" } };

            var center = new DeliveryCenter();
            center.AddShipment(s1);
            center.AddShipment(s2);
            center.AddShipment(s3);
            center.PrintAllShipments();
            center.PrintTrackingStatuses();
            center.PrintInsuranceCosts();

            
            ITrackable[] trackables = { s1, s2, s3 };
           
            IInsurable[] insurables = { s1, s2, s3 };

            Console.WriteLine("Interface Polymorphism Demonstrated Successfully.");

            #endregion
        }
    }
}
