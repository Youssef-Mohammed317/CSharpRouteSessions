namespace CSharpRouteSessions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Demo of C#02
            #region ErrorTypes
            // syntax error: missing semicolon, undeclared variable
            // Console.WriteLine("Hello, World!")
            // Console.WriteLine(VarName);
            // undeclared variable: VarName
            // runtime error: division by zero
            // int x = 10
            // int y = 0;
            // int result = x / y;
            // Console.WriteLine(result);
            // logic error: incorrect addition logic
            // int a = 5;
            // int b = 10;
            // int sum = Sum(a, b);
            // file not found error: trying to read a file that does not exist
            // warning: unused variable
            #endregion

            #region Comments
            // This is a single-line comment explaining the next line of code
            /* This is a multi-line comment
               explaining the purpose of the program */
            // Console.WriteLine("Hello, World!"); // This prints a greeting message to the console
            // This line is commented out and will not execute
            #endregion

            #region DeclareVariables
            //// declare without initialization
            //int uninitializedVariable; // uninitialized integer variable
            //                           // initialize later
            //uninitializedVariable = 10; // now initialized with a value
            //                            // Declare and initialize variables
            //int number = 42; // integer variable
            //number = 100; // reassigning a new value
            //string message = "Hello, World!"; // string variable
            //bool isActive = true; // boolean variable
            //double pi = 3.14; // double variable
            //                  // Declare multiple variables in one line
            //int x = 5, y = 10, z = 15; // multiple integers
            //                           // Declare a constant
            //const double E = 2.71828; // constant for Euler's number
            //                          // Declare a nullable integer
            //int? nullableNumber = null; // nullable integer variable

            // invalid variable names
            // int 1stNumber = 10; // cannot start with a digit
            // int my-variable = 20; // cannot contain hyphens
            // int @class = 30; // reserved keyword, but can be used with '@'
            // int var name = 40; // cannot contain spaces
            #endregion

            #region valueTypes&referenceTypes
            #region ValueType
            // Value Types
            //short valueTypeShort = 5; // short value type Int16
            //int valueTypeInt = 10; // integer value type int or Int32
            //double valueTypeDouble = 20.5; // double value type double or Double
            //bool valueTypeBool = true; // boolean value type bool or Boolean
            //char valueTypeChar = 'A'; // character value type char or Char

            //int x2 = 10; // integer value type
            //             // CLR: allocate memory 4 byte for value types on the stack
            //int y2 = 20; // another integer value type
            //             // CLR: allocate memory 4 byte for value types on the stack
            //y2 = x2; // copy value from x2 to y2
            //Console.WriteLine(x2);
            //Console.WriteLine(y2);

            //// Nullable Types
            //int? nullableValueType = null; // nullable integer value type
            #endregion

            #region ReferenceType
            // Reference Types(class,struct,... )
            //string referenceTypeString = "Hello"; // string reference type
            //object referenceTypeObject = new object(); // object reference type
            //int[] referenceTypeArray = new int[] { 1, 2, 3 }; // array reference type
            //                                                  // allocate memory for reference types on the heap 3*4=12 byte
            //Point referenceTypePoint = new Point(); // custom class reference type
            //                                        //// CLR: allocate memory for Point class on the heap 8 byte (assuming Point has two int fields)

            //Point referenceTypePoint2 = new Point();

            //referenceTypePoint.X = 5; // accessing field x of Point class
            //referenceTypePoint.Y = 10; // accessing field y of Point class

            //referenceTypePoint2.X = 15; // accessing field x of Point class
            //referenceTypePoint2.Y = 20; // accessing field y of Point class

            //referenceTypePoint2 = referenceTypePoint; // reference type assignment, now both point to the same object in memory

            //// CLR: referenceTypePoint2 now points to the same memory location as referenceTypePoint

            //Console.WriteLine(referenceTypePoint2.X); // prints 5
            //Console.WriteLine(referenceTypePoint2.Y); // prints 10

            //Console.WriteLine(referenceTypePoint.X); // prints 5
            //Console.WriteLine(referenceTypePoint.Y); // prints 10

            //// the old referenceTypePoint2 object is now eligible for garbage collection

            //// Nullable Types
            //string? nullableReferenceType = null; // nullable string reference type
            #endregion
            #endregion
            #region ObjectType
            // Object Type
            //object obj = new object(); // object type
            //obj = "Hello"; // storing a string in an object
            //               // CLR: allocate memory for string on the heap, and obj now references that memory
            //obj = 42; // boxing: storing an integer in an object // boxing is the process of converting a value type to an object type
            //          // CLR: allocate memory for integer on the heap, and obj now references that memory
            //obj = new Point(); // storing a Point object in an object
            // CLR: allocate memory for Point class on the heap, and obj now references that memory
            #endregion

            
        }
        // Demo of C#02
        #region Function and Documentation Comment
        // documentation comment: This method sums two integers
        /// <summary>
        /// sums two integers
        /// </summary>
        /// <param name="x">num 1</param>
        /// <param name="y">num 2</param>
        /// <returns><paramref name="x"/>+<paramref name="y"/></returns>
        //static int Sum(int x, int y)
        //{
        //    // logic error: incorrect addition logic
        //    return x - y; // This should be return x + y;
        //}
        #endregion
    }
}
