namespace CSharpRouteSessions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Demo of C#02
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

            #endregion
            /*-----------------------------------------------------------------*/
            #region Demo of C#03
            #region Fraction and Discard

            //float myFloat = 10.123456789F; // 6 digits after point
            //Console.WriteLine(myFloat);

            //double myDouble = 10.123456789123456789123; // 14 digits after point 
            //Console.WriteLine(myDouble);

            //decimal myDecimal = 10.123456789123456789123456789123456789m; // 27 digits after point
            //Console.WriteLine(myDecimal);

            //long Number = 1_000_000_000_000_000;
            //Console.WriteLine($"{Number:c}"); // $1,000,000,000,000,000.00
            //Console.WriteLine(Number.ToString("c")); // $1,000,000,000,000,000.00

            //var cultureInfo = new CultureInfo("ar-SA");
            //Console.WriteLine(Number.ToString("c",cultureInfo)); // change c by the new currancy

            #endregion

            #region Implicit & Explicit Casting

            #region Implicit Casting [safe Casting]

            //int x = 1000; // 4 byte
            //long y = x; // 8 byte can contain 4 byte 
            //Console.WriteLine(y);

            #endregion

            #region Explicit Casting

            //int xx = 1000;
            //long yy = (int)xx; // not required because 8 byte can contain 4 byte

            //long yyy = 1_000_000_000_000_000;
            //int xxx = (int)yyy; // required becouse 8 byte may contain value larger than 4 byte

            //Console.WriteLine(xxx); // -1530494976 // risk // not true

            //// checked
            //checked // throw an exception if there is an error
            //{
            //    long a = 1_000_000_000_000_000; // 8 byte from user
            //    int b = (int)a;
            //    unchecked
            //    {
            //        Console.WriteLine(b);
            //    }
            //    // Unhandled exception. System.OverflowException: Arithmetic operation resulted in an overflow.
            //}

            //// protective code
            //long aa = 1_000_000_000_000_000; // 8 byte from user
            //if(aa > int.MaxValue || aa < int.MinValue)
            //{
            //    Console.WriteLine("Exception will be throw due to overflow");
            //}
            //else
            //{
            //    int bb = (int)aa;
            //    Console.WriteLine(bb);
            //}

            //// casting form float or decimal to int or long fraction will lost
            //decimal m = 10.123456m;
            //int mm = (int)m;
            //Console.WriteLine(mm);// 10 // no over flow because 10 can be exist in int type

            #endregion

            #endregion

            #region Casting

            #region Convert

            //Console.WriteLine("Please Enter Your Data");
            //Console.Write("Name: ");
            //string? name = Console.ReadLine(); // ? for nullable datatype
            //Console.Write("Age: ");
            //int? age = Convert.ToInt32(Console.ReadLine()); // string is the defalut input from console
            //Console.Write("Salary: ");
            //double? salary = Convert.ToDouble(Console.ReadLine()); // there is no toFloat

            //// convert 
            //// handle null and replace it by 0 for int and double
            //// can not handle empaty so throw an exception 

            //Console.WriteLine("Emp Data: ");
            //Console.WriteLine("Name is " + name);
            //Console.WriteLine("Age is " + age);
            //Console.WriteLine("Salary is " + salary);

            #endregion

            #region Parse()

            //Console.WriteLine("Please Enter Your Data");
            //Console.Write("Name: ");
            //string? name = Console.ReadLine(); // ? for nullable datatype
            //Console.Write("Age: ");
            //int? age = int.Parse(Console.ReadLine()); // string is the defalut input from console
            //Console.Write("Salary: ");
            //double? salary = double.Parse(Console.ReadLine()); // there is no toFloat

            //// parse 
            //// can`t handle null
            //// can not handle empaty so throw an exception 

            //Console.WriteLine("Emp Data: ");
            //Console.WriteLine("Name is " + name);
            //Console.WriteLine("Age is " + age);
            //Console.WriteLine("Salary is " + salary);

            #endregion

            #region TryParse()

            //Console.WriteLine("Please Enter Your Data");
            //Console.Write("Name: ");
            //string name = Console.ReadLine();
            //Console.Write("Age: ");
            //int age;
            //bool ageFlag = int.TryParse(Console.ReadLine(),out age);
            //Console.Write("Salary: ");


            //double salary;
            //bool salaryFlag = double.TryParse(Console.ReadLine(),out salary);


            //// TryParse 
            //// handle null and replace it by 0 for int and double
            //// can handle empaty and repalce it by 0

            //Console.WriteLine("Emp Data: ");
            //Console.WriteLine("Name is " + name);
            //Console.WriteLine("Age is " + age);
            //Console.WriteLine("Age Flag is " + ageFlag);
            //Console.WriteLine("Salary is " + salary);
            //Console.WriteLine("Salary Flag is " + salaryFlag);

            #endregion

            #endregion

            #region Operators

            #region Unary ++,--

            //int x = 0;
            //Console.WriteLine(++x); // 1 // pre
            //Console.WriteLine(x++); // 1 // post // after excution
            //Console.WriteLine(x); // 2

            #endregion

            #region Binary + , - , * , / , %

            //int x = 3;
            //int y = 4;

            //Console.WriteLine(x + y); // 7
            //Console.WriteLine(x - y); // -1
            //Console.WriteLine(x * y); // 12
            //Console.WriteLine(x / y); // 0 because the two types are int
            //Console.WriteLine((float)x / y); // 0.75 because one type is float(x)
            //Console.WriteLine(x * 1.0 / y); // 0.75 because one type is float(1.0)
            //Console.WriteLine(y % x); // y modulas x is 1
            //Console.WriteLine(4 % 2); // is 0 because 4 can be devided by 2 

            #endregion

            #region Assignment = , += , -= , *= , /= , %=

            //int x;
            //x = 0; // =
            //x += 1; // x = x + 1
            //x -= 2; // x = x - 2
            //x *= 2; // x = x * 2
            //x /= 2; // x = x / 2
            //x %= 2; // x = x % 2 

            #endregion

            #region Relational | Compresion == , != , > , < , <= , >=

            //int x = 1;
            //int y = 2;

            //Console.WriteLine(x == y); // false
            //Console.WriteLine(x != y); // true
            //Console.WriteLine(x > y); // false
            //Console.WriteLine(x < y); // true
            //Console.WriteLine(x >= y); // false
            //Console.WriteLine(x <= y); // true

            #endregion

            #region logical and(&&) , or(||) , not(!)

            //int x = 1;
            //int y = 2;

            //// and &&
            //// the two condtions must be ture to be the result ture
            //// or || 
            //// only one condtion required to be ture to be the result true
            //// not !
            //// change the value from ture to false or from false to true

            //Console.WriteLine(x == y && x != y); // false
            //Console.WriteLine(x != y || x == y); // true
            //Console.WriteLine(!(x > y)); // true

            #endregion

            #region Bitwise & , | , ~ , ^ , >> , <<

            //int x = 7; // 0111 in binary code
            //int y = 5; // 0101 in binary code

            //// & AND between the digits of the numbers in binary code
            //// 1 & 1 = 1
            //// 1 & 0 = 0
            //// 0 & 1 = 0
            //// 0 & 0 = 0
            //Console.WriteLine(x & y); // 0111
            //                          // 0101
            //                          // 0101 // answer is 5

            //Console.WriteLine(x | y);// 0111
            //                         // 0101
            //                         // 0111 // answer is 7
            //Console.WriteLine(~x); // ~0111 => 1000 answer is -8 // mins because x is signed number
            //Console.WriteLine(x ^ y); // xor gate returns 1 if the ones are odd
            //                          // 0111
            //                          // 0101
            //                          // 0010 // answer is 2

            //Console.WriteLine(x >> 2); // logical shift right by 2 means two times
            //                         // 0111 => 0011 => 0001 // answer is 1
            //Console.WriteLine(x << 2); // logical shift left by 2 means two times
            //                           // 00111 => 01110 => 01110 // answer is 28

            #endregion

            #region Ternay condition ? if true : if false 

            //if (1 > 2)
            //    Console.WriteLine("1 is greater than 2");
            //else
            //    Console.WriteLine("1 is not greater than 2");

            //Console.WriteLine(1 > 2 ? "1 is greater than 2" : "1 is not greater than 2");
            //Console.WriteLine(1 < 2 ? "1 is less than 2" : "1 is not less than 2");

            #endregion

            #region Priority and Associativity

            //int x = 7, y = 6, z = 3;

            //Console.WriteLine(x+y*z); // y*z first then plus x
            //Console.WriteLine((x+y)*z); // x+y first then multiple z
            //Console.WriteLine(++x*y+z); // ++ first then multi y then plus z
            //Console.WriteLine(x++*y+z); // multi y then plus then increment x
            //Console.WriteLine((x++)*(y+z)); // the last thing is increment x

            #endregion

            #endregion

            #region String Formating

            //int x = 1;
            //int y = 2;  
            //int z = x + y;
            //// Interpolation
            //Console.WriteLine($"{x} + {y} = {z}");
            //// Concatenation
            //Console.WriteLine(x + " + " + y + " = " + z);
            //// Composite Format
            //Console.WriteLine("{0} + {1} = {2}",x,y,z);
            //// string.format
            //string mes = string.Format("{0} + {1} = {2}", x, y, z);
            //Console.WriteLine(mes);

            #endregion
            #endregion
            /*-----------------------------------------------------------------*/
            #region Demo of C#04
            #region Conditional | Control Statements
            //Console.Write("Please Enter A Month Number Exists In The 1st Quarter: ");
            //bool flag = int.TryParse(Console.ReadLine(), out int monthNumber);
            //Console.Write("Please Enter A Month Name Exists In The 1st Quarter: ");
            //string monthName = Console.ReadLine() ?? "January"; // January is the default value if the user enter null

            #region if ,if else, else
            //if (monthNumber == 1) 
            //{
            //    Console.WriteLine("January"); 
            //}
            //else if (monthNumber == 2)
            //{
            //    Console.WriteLine("February");
            //}
            //else if (monthNumber == 3)
            //{
            //    Console.WriteLine("March");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Month Number");
            //}

            //// if one line statement {} not required
            //if (monthName == "January")
            //    Console.WriteLine("January");
            //else if (monthName == "February")
            //    Console.WriteLine("February");
            //else if (monthName == "March")
            //    Console.WriteLine("March");
            //else
            //    Console.WriteLine("Invalid Month Name");
            #endregion

            #region switch case
            //// jump table
            //switch (monthNumber)
            //{
            //    case 1:
            //        Console.WriteLine("January");
            //        break; // break is required to exit the switch case in c++ is not required
            //    case 2:
            //        Console.WriteLine("February");
            //        break;
            //    case 3:
            //        Console.WriteLine("March");
            //        break;
            //    case 4:
            //    case 5:
            //    case 6: // for multiple cases
            //        Console.WriteLine("This is not a month in the 1st quarter");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Month Number");
            //        break;
            //}

            //switch (monthName)
            //{ 
            //    case "January":
            //        Console.WriteLine("January");
            //        break;
            //    case "February":
            //        Console.WriteLine("February");
            //        break;
            //    case "March":
            //        Console.WriteLine("March");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Month Name");
            //        break;
            //}

            #endregion
            #endregion

            #region GOTO
            #region goto case in swith
            //int budget = 2000;

            //switch (budget)
            //{
            //    case 3000:
            //        Console.WriteLine("Option 01");
            //        Console.WriteLine("Option 02");
            //        Console.WriteLine("Option 03");
            //        break;
            //    case 2000:
            //        Console.WriteLine("Option 02");
            //        Console.WriteLine("Option 03");
            //        break;
            //    case 1000:
            //        Console.WriteLine("Option 03");
            //        break;
            //}

            // using goto to prevent repeatiton
            //switch (budget)
            //{
            //    case 3000:
            //        Console.WriteLine("Option 01");
            //        goto case 2000;
            //        //break;
            //    case 2000:
            //        Console.WriteLine("Option 02");
            //        goto case 1000;
            //        //break;
            //    case 1000:
            //        Console.WriteLine("Option 03");
            //        break;
            //} 
            #endregion

            #region Loop Using goto
            //    int negativeSum = 0;
            //    int positiveSum = 0;
            //    int oddPosSum = 0;
            //    int oddNegSum = 0;
            //    int evenPosSum = 0;
            //    int evenNegSum = 0;
            //Loop:
            //    Console.Write("Enter a number (0 to exit): ");
            //    bool isValid = int.TryParse(Console.ReadLine(), out int number);

            //    if (number > 0)
            //    {
            //        positiveSum += number;
            //        if (number % 2 == 0)
            //        {
            //            evenPosSum += number;
            //        }
            //        else
            //        {
            //            oddPosSum += number;
            //        }
            //        goto Loop;
            //    }
            //    else if (number < 0)
            //    {
            //        negativeSum += number;
            //        if (int.Abs(number) % 2 == 0)
            //        {
            //            evenNegSum += number;
            //        }
            //        else
            //        {
            //            oddNegSum += number;
            //        }
            //        goto Loop;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sum Of Pos is: " + positiveSum);
            //        Console.WriteLine("Sum Of odd Pos is: " + oddPosSum);
            //        Console.WriteLine("Sum Of even Pos is: " + evenPosSum);
            //        Console.WriteLine("Sum Of Neg is: " + negativeSum);
            //        Console.WriteLine("Sum Of odd Neg is: " + oddNegSum);
            //        Console.WriteLine("Sum Of even Neg is: " + evenNegSum);
            //    }

            #endregion
            #endregion

            #region C# 7.0 introduced pattern matching with the switch statement
            #region Grade With Case When
            //int grade = 70;
            //switch (grade)
            //{
            //    case int n when n >= 90:
            //        Console.WriteLine("A");
            //        break;
            //    case int n when n >= 80:
            //        Console.WriteLine("B");
            //        break;
            //    case int n when n >= 70:
            //        Console.WriteLine("C");
            //        break;
            //    case int n when n >= 60:
            //        Console.WriteLine("D");
            //        break;
            //    default:
            //        Console.WriteLine("F");
            //        break;
            //}
            #endregion

            #region check type of variable

            //object obj = "Hello";
            //switch (obj)
            //{
            //    case string s:
            //        Console.WriteLine($"String: {s}");
            //        break;
            //    case int i:
            //        Console.WriteLine($"Integer: {i}");
            //        break;
            //    case null:
            //        Console.WriteLine("Null value");
            //        break;
            //    default:
            //        Console.WriteLine("Unknown type");
            //        break;
            //}

            #endregion
            #endregion

            #region C# 8.0 without alies name

            //int grade = 70;

            //string gradeLetter = grade switch
            //{
            //    >= 90 => "A",
            //    >= 80 => "B",
            //    >= 70 => "C",
            //    >= 60 => "D",
            //    _ => "F"  // _ is the default case
            //};

            //Person person = new Person 
            //{
            //    Name = "John",
            //    Age = 30
            //};

            //string personInfo = person switch
            //{
            //    { Age: < 18 } => $"{person.Name} is a minor.",
            //    { Age: >= 18 } => $"{person.Name} is an adult.",
            //    _ => "Unknown person"
            //};

            #endregion

            #region C# 9.0 allows property patterns with relational patterns

            int grade = 70; 

            string gradeLetter = grade switch
            {
                < 100 and >= 90 => "A", // there is or and 
                < 90 and >= 80 => "B",
                < 80 and >= 70 => "C",
                < 70 and >= 60 => "D",
                _ => "F"  // _ is the default case
            };

            #endregion
            #endregion

        }
        #region Demo of C#02
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
        #endregion
    }
}
