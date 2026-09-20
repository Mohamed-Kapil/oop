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
        }
    }
}
