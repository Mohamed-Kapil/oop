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
        }
    }
}
