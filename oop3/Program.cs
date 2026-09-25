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
        }
    }
}
