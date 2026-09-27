namespace oop5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part1 Q1  Object Copying (a)
            /* When one object variable is assigned to another object variable, the reference to the object is copied.
             * Both variables refer to the same object in memory.*/
            #endregion

            #region part1 Q1  Object Copying (b)
            /*No. Assigning one object variable to another does not create a new object.
             * It only copies the reference, so both variables refer to the same object.*/
            #endregion

            #region part1 Q1  Object Copying (c)
            /*Copying a reference means that two variables refer to the same object, so changes made through one variable affect the other.
             * Copying an object means creating a new, independent object with the same data, so changes to one object do not affect the other.*/
            #endregion

            #region part1 Q2  Shallow Copy vs Deep Copy (a)
            /*A Shallow Copy creates a new object and copies the values of the original object.
             * For reference-type members, it copies the references instead of creating new objects.*/
            #endregion

            #region part1 Q2  Shallow Copy vs Deep Copy (b)
            /*A Deep Copy creates a new object and also creates independent copies of the reference-type objects contained inside it.*/
            #endregion

            #region part1 Q2  Shallow Copy vs Deep Copy (c)
            /*The references are copied, so both the original object and the copied object refer to the same reference-type objects.*/
            #endregion

            #region part1 Q2  Shallow Copy vs Deep Copy (d)
            /*New independent objects are created for the reference-type members, so the original and copied objects do not share those objects.*/
            #endregion
        }
    }
}
