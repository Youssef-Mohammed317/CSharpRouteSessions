using System.Text;

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
            /*-----------------------------------------------------------------*/
            #region Demo of C#05

            #region Control Statements [Loops]

            #region for - foreach
            //int[] numbers = { 1, 2, 3, 4, 5, 6 };
            #region No Loop

            // 6 steps for printing if 1000 elements 1000 steps for printing
            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);
            //Console.WriteLine(numbers[3]);
            //Console.WriteLine(numbers[4]);
            //Console.WriteLine(numbers[5]);

            // 6 steps for mintanence if 1000 elements 1000 steps for mintenance
            //Console.WriteLine($"Number is{numbers[0]}");
            //Console.WriteLine($"Number is{numbers[1]}");
            //Console.WriteLine($"Number is{numbers[2]}");
            //Console.WriteLine($"Number is{numbers[3]}");
            //Console.WriteLine($"Number is{numbers[4]}");
            //Console.WriteLine($"Number is{numbers[5]}");

            #endregion

            #region for
            // 19 steps for printing if 1000 elements 3001 steps for printing
            // improve readability and maintainability
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    //Console.WriteLine(numbers[i]);

            //    // 1 step for mintenance if 1000 elements 1 steps for mintenance and 1 for 100000000000 steps
            //    Console.WriteLine($"Number is {numbers[i]}");  
            //}

            // continue; // skip the rest of the loop and continue to the next iteration
            // break; // exit the loop

            // print only odd numbers
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //   if( numbers[i] % 2 == 0)
            //    {
            //        continue; // skip the rest of the loop and continue to the next iteration
            //    }
            //    Console.WriteLine($"Number is {numbers[i]}");
            //}

            // break example
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] == 4)
            //    {
            //        break; // exit the loop
            //    }
            //    Console.WriteLine($"Number is {numbers[i]}");
            //}
            #endregion

            #region foreach
            // work with any collection 
            // copy the collection to a new collection and iterate over it
            //foreach (int number in numbers)
            //{
            //    // 1 step for mintenance if 1000 elements 1 steps for mintenance and 1 for 100000000000 steps
            //    Console.WriteLine($"Number is {number}");
            //}
            #endregion

            #endregion

            #region while - do while
            //int[] numbers = { 1, 2, 3, 4, 5, 6 };

            #region while

            //int i = 0;
            //// while loop
            //while (i < numbers.Length)
            //{
            //    Console.WriteLine($"Number is {numbers[i]}");
            //    i++;
            //}
            //i = 0; // reset i to 0 for the next loop

            //while (true)
            //{
            //    if (i >= numbers.Length)
            //    {
            //        break; // exit the loop
            //    }
            //    Console.WriteLine($"Number is {numbers[i]}");
            //    i++;
            //}
            //i = 0; // reset i to 0 for the next loop

            //// do while loop print at least one time using while
            //while (true)
            //{
            //    Console.WriteLine($"Number is {numbers[i]}");
            //    i++;
            //    if (i >= numbers.Length)
            //    {
            //        break; // exit the loop
            //    }
            //}
            #endregion

            #region do while
            //i = 0; // reset i to 0 for the next loop

            //do
            //{
            //    Console.WriteLine($"Number is {numbers[i]}");
            //    i++;
            //} while (i < numbers.Length);

            //i = 0; // reset i to 0 for the next loop
            //// do while
            //do
            //{
            //    Console.WriteLine($"Number is {numbers[i]}");
            //    i++;
            //    if (i >= numbers.Length)
            //    {
            //        break; // exit the loop
            //    }
            //} while (true);
            //i = 0; // reset i to 0 for the next loop

            //// while loop using do while
            //do
            //{   if (i >= numbers.Length)
            //    {
            //        break; // exit the loop
            //    }
            //    Console.WriteLine($"Number is {numbers[i]}");
            //    i++;
            //} while (true);
            #endregion

            #endregion

            #region while to for and do while to for
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };

            // for
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine($"Number is {numbers[i]}");
            //}

            // while
            //int j = 0; // initialize the counter
            //while (j < numbers.Length)
            //{
            //    Console.WriteLine($"Number is {numbers[j]}");
            //    j++; // increment the counter
            //}

            // convert for to while
            //j = 0; // initialize the counter
            //for(; ; )
            //{
            //    if (j >= numbers.Length)
            //    {
            //        break; // exit the loop
            //    }
            //    Console.WriteLine($"Number is {numbers[j]}");
            //    j++; // increment the counter
            //}

            // convert for to do while
            //j = 0; // initialize the counter
            //for (; ; )
            //{
            //    Console.WriteLine($"Number is {numbers[j]}");
            //    j++; // increment the counter
            //    if (j >= numbers.Length)
            //    {
            //        break; // exit the loop
            //    }
            //}

            #endregion

            #endregion

            #region String
            #region Example 01
            //string name;

            //name = new string("John");// 4 byte in stack and 8 byte for each char 2 byte in heap

            //Console.WriteLine($"Name is {name}");
            //Console.WriteLine($"Name is {name.GetHashCode()}");
            //Console.WriteLine($"Name is {name.GetHashCode()}");

            //string name2 = "John"; // 4 byte in stack and 8 byte for each char 2 byte in heap this is syntax sugar for the above code
            //Console.WriteLine($"Name is {name2}");
            //Console.WriteLine($"Name is {name2.GetHashCode()}");
            #endregion

            #region Example 02
            //string name1 = "Omar";
            //string name2 = "Ahmed";
            //Console.WriteLine($"Name1 is {name1}");
            //Console.WriteLine($"HashCode of Name1 is {name1.GetHashCode()}");
            //Console.WriteLine($"Name2 is {name2}");
            //Console.WriteLine($"HashCode of Name2 is {name2.GetHashCode()}");

            //name2 = name1; // assign name1 to name2

            //Console.WriteLine("After Assign");
            //Console.WriteLine($"Name1 is {name1}");
            //Console.WriteLine($"HashCode of Name1 is {name1.GetHashCode()}");
            //Console.WriteLine($"Name2 is {name2}");
            //Console.WriteLine($"HashCode of Name2 is {name2.GetHashCode()}");

            //name1 = "Ali"; // change name1 to Ali

            //Console.WriteLine("After Change Name1 to Ali");

            //Console.WriteLine("After Assign");
            //Console.WriteLine($"Name1 is {name1}");
            //Console.WriteLine($"HashCode of Name1 is {name1.GetHashCode()}");
            //Console.WriteLine($"Name2 is {name2}");
            //Console.WriteLine($"HashCode of Name2 is {name2.GetHashCode()}");

            #endregion

            #region Ecample 03
            //string msg = "Hello";
            //Console.WriteLine(msg);
            //Console.WriteLine(msg.GetHashCode());

            //msg = msg + " World"; // concatenate strings
            //Console.WriteLine(msg);
            //Console.WriteLine(msg.GetHashCode());

            //msg = "Hello";
            //Console.WriteLine(msg);
            //Console.WriteLine(msg.GetHashCode());
            #endregion
            #endregion

            #region String Methods
            //string msg = "   Hello World   ";

            //Console.WriteLine(msg.Length);

            //Console.WriteLine(msg.Trim());
            //Console.WriteLine(msg.Trim().Length);
            //Console.WriteLine(msg.TrimStart());
            //Console.WriteLine(msg.TrimStart().Length);
            //Console.WriteLine(msg.TrimEnd());
            //Console.WriteLine(msg.TrimEnd().Length);

            //Console.WriteLine(msg.ToUpper());
            //Console.WriteLine(msg.ToLower());
            //Console.WriteLine(msg.Contains("Hello")); // check if the string contains a substring

            //Console.WriteLine(msg.Substring(3,5));
            //Console.WriteLine(msg.IndexOf("Hello")); // find the index of a substring

            //Console.WriteLine(msg.Replace("o","d"));
            //Console.WriteLine(msg.Replace("Hello","Hi"));
            //Console.WriteLine(msg.Replace("or","d"));

            //Console.WriteLine(msg.Remove(0,3));
            //Console.WriteLine(msg.Insert(0,"Hi"));
            //Console.WriteLine(msg.Insert(0,"Hi").Replace("   "," "));
            #endregion

            #region StringBuilder
            // string in immutable type made of array of characters
            // stringbuilder is mutable type made of linked list of characters 

            //StringBuilder sb = new StringBuilder("Hello");
            //Console.WriteLine(sb);
            //Console.WriteLine(sb.GetHashCode());


            //sb.Append(" World"); // append string to the end of the stringbuilder
            //Console.WriteLine(sb);
            //Console.WriteLine(sb.GetHashCode());

            //StringBuilder sb2 = new StringBuilder("Hello");
            //Console.WriteLine(sb2);
            //Console.WriteLine(sb2.GetHashCode());

            //sb2 = sb; // assign sb to sb2
            //Console.WriteLine("After Assign");
            //sb2.Append(" World"); // append string to the end of the stringbuilder
            //Console.WriteLine(sb2);
            //Console.WriteLine(sb2.GetHashCode());

            //Console.WriteLine(sb);
            //Console.WriteLine(sb.GetHashCode());

            #endregion

            #region StringBuilder Methods
            //StringBuilder sb = new StringBuilder("   Hello   ");

            //Console.WriteLine(sb.Length); // 11

            //Console.WriteLine(sb.Append("World")); //   Hello   World

            //Console.WriteLine(sb); //    Hello   World

            //sb.AppendLine("!"); // append a new line to the end of the stringbuilder

            //Console.WriteLine(sb); //    Hello   World!

            //Console.WriteLine(sb.Length); // 17

            //sb.Replace("Hello", "Hi"); // replace a substring with another substring
            //sb.Replace("World", "Everyone"); // replace a substring with another substring

            //Console.WriteLine(sb); // Hi   Everyone!

            //sb.Remove(0, 3); // remove a substring from the stringbuilder

            //sb.AppendFormat("Your Age is {0} and Your Salary is {1}", 30, 1000.50); // format the stringbuilder
            //Console.WriteLine("---");
            //Console.WriteLine(sb);

            //Console.WriteLine("---");
            //sb.AppendJoin("_", "A", "B", "C", "D", "F"); // join multiple strings with a separator
            //Console.WriteLine(sb);

            #endregion

            #endregion
            /*-----------------------------------------------------------------*/
            #region Demo of C#06

            #region Arrays

            #region 1D Array
            //int[] numbers; // address of the array in stack

            ////Console.WriteLine(numbers); // null // numbers is not initialized yet
            ////Console.WriteLine(numbers[0]); // Use of unassigned local variable 'numbers'

            //numbers = new int[3]; // 3 elements array in heap


            //Console.WriteLine(numbers[0]); // 0
            //Console.WriteLine(numbers[1]); // 0
            //Console.WriteLine(numbers[2]); // 0

            //// asign value to the array
            //numbers[0] = 1; // assign value to the first element
            //numbers[1] = 2; // assign value to the second element
            //numbers[2] = 3; // assign value to the third element

            ////numbers[2] = 4.5; // gives a warning because 4.5 is a double and the array is of type int
            ////Console.WriteLine(numbers[3]); // System.IndexOutOfRangeException

            //// length of the array
            //Console.WriteLine(numbers.Length); // size of the array is 3

            //Console.WriteLine(numbers.Rank); // rank of the array is 1 (1D array)

            //Console.WriteLine(numbers.GetType()); // type of the array is System.Int32[]

            //Console.WriteLine(numbers.GetType().Name); // name of the array type is Int32[]

            //Console.WriteLine(numbers.LongLength); // long length of the array is 3 == numbers.Length because it is 1D array

            //int[] nums = new int[3]; // address int stack and 3 elements array in heap with initialization

            //nums[0]= 4; // assign value to the first element
            //nums[1] = 5; // assign value to the second element
            //nums[2] = 6; // assign value to the third element

            //int[] nums2 = new int[3] { 7, 8, 9 }; // address int stack and 3 elements array in heap with initialization
            //int[] nums3 = new int[] { 7, 8, 9 }; // address int stack and 3 elements array in heap with initialization

            //int[] nums4 = { 10, 11, 12 }; // shorter syntax for array initialization

            //Console.WriteLine("Numbers Array:");
            //Console.WriteLine(string.Join(", ", numbers)); // print the array elements

            //int[] nums5 = nums4; // assign nums4 to nums5

            // add elements to the array

            //int[] num6  = new int[nums5.Length + 1];

            //for (int i = 0; i < nums5.Length; i++)
            //{
            //    num6[i] = nums5[i]; // copy the elements from nums5 to num6
            //}
            //num6[num6.Length - 1] = 13; // add the new element to the end of the array

            //// merge the two arrays

            //int[] mergedArray = new int[nums5.Length + num6.Length];// create a new array with the size of the two arrays

            //for (int i = 0; i < nums5.Length; i++)
            //{
            //    mergedArray[i] = nums5[i]; // copy the elements from nums5 to mergedArray
            //}
            //for (int i = 0; i < num6.Length; i++)
            //{
            //    mergedArray[nums5.Length + i] = num6[i]; // copy the elements from num6 to mergedArray
            //}

            #endregion

            #region 2D Array
            //int[,] matrix = new int[3, 3]; // 2D array with 3 rows and 3 columns

            ////Console.WriteLine(matrix[0, 0]); // 0
            ////Console.WriteLine(matrix[1, 1]); // 0

            //// assign values to the 2D array
            //matrix[0, 0] = 1; // assign value to the first row and first column
            //matrix[0, 1] = 2; // assign value to the first row and second column

            //int[,] matrix2 = new int[3, 3] // 2D array with 3 rows and 3 columns with initialization
            //{
            //    { 1, 2, 3 },
            //    { 4, 5, 6 },
            //    { 7, 8, 9 }
            //};
            ////Console.WriteLine(matrix2[0, 0]); // 1
            ////Console.WriteLine(matrix2[1, 1]); // 5

            //int[,] matrix3 =
            //{
            //    { 1, 2, 3 },
            //    { 4, 5, 6 },
            //    { 7, 8, 9 }
            //};
            ////Console.WriteLine(matrix3[3,3]);

            //Console.WriteLine(matrix3.Length); // 9
            //Console.WriteLine(matrix3.Rank); // 2 (2D array)
            //Console.WriteLine(matrix3.LongLength); // 9
            //Console.WriteLine(matrix3.GetLength(0)); // 3 (number of rows)
            //Console.WriteLine(matrix3.GetLength(1)); // 3 (number of columns)

            // print the 2D array
            //for (int i = 0; i < matrix3.GetLength(0); i++) // loop through the rows
            //{
            //    for (int j = 0; j < matrix3.GetLength(1); j++) // loop through the columns
            //    {
            //        Console.Write(matrix3[i, j] + " "); // print the element
            //    }
            //    Console.WriteLine(); // new line after each row
            //}
            //// prin the 2D array using 1 loop
            //for (int i = 0; i < matrix3.Length; i++)
            //{
            //    Console.Write(matrix3[i / matrix3.GetLength(1), i % matrix3.GetLength(1)] + " ");
            //    // i / matrix3.GetLength(1) gives the row index
            //    // i % matrix3.GetLength(1) gives the column index
            //    if ((i + 1) % matrix3.GetLength(1) == 0) // check if the current index is the last column
            //    {
            //        Console.WriteLine(); // new line after each row
            //    }
            //}

            //// modify the 2D array
            //for (int i = 0; i < matrix3.GetLength(0); i++) // loop through the rows
            //{
            //    for (int j = 0; j < matrix3.GetLength(1); j++) // loop through the columns
            //    {
            //        matrix3[i, j] += 10; // add 10 to each element
            //    }
            //}

            //// create and modify the 2D array by user then print it
            //Console.Write("Enter the number of rows: ");
            //bool rowFlag = int.TryParse(Console.ReadLine(), out int rows);
            //Console.Write("Enter the number of columns: ");
            //bool columnFlag = int.TryParse(Console.ReadLine(), out int columns);

            //if (rowFlag && columnFlag && rows > 0 && columns > 0)
            //{
            //    int[,] userMatrix = new int[rows, columns]; // create a new 2D array with the user input size
            //    // fill the 2D array with user input
            //    for (int i = 0; i < rows; i++) // loop through the rows or userMatrix.GetLength(0)
            //    {
            //        for (int j = 0; j < columns; j++)
            //        {
            //            Console.Write($"Enter value for [{i}, {j}]: ");
            //            bool valueFlag = int.TryParse(Console.ReadLine(), out int value);
            //            if (valueFlag)
            //            {
            //                userMatrix[i, j] = value; // assign the value to the 2D array
            //            }
            //            else
            //            {
            //                Console.WriteLine("Invalid input. Please enter an integer.");
            //                j--; // repeat the current column
            //            }
            //        }
            //    }
            //    // print the user-defined 2D array
            //    Console.WriteLine("Your 2D Array:");
            //    for (int i = 0; i < rows; i++)
            //    {
            //        for (int j = 0; j < columns; j++)
            //        {
            //            Console.Write(userMatrix[i, j] + " ");
            //        }
            //        Console.WriteLine();
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input for rows or columns.");
            //}

            #endregion

            #region Jagged Array
            //// jagged array is an array of arrays
            //int[][] jaggedArray = new int[3][]; // create a jagged array with 3 rows
            //jaggedArray[0] = new int[2] { 1 , 2 }; // first row has 2 columns
            ////jaggedArray[0] = { 1 , 3};// gives error
            //jaggedArray[1] = new int[3] { 1, 2, 3 }; // second row has 3 columns
            //jaggedArray[2] = new int[4] { 1, 2, 3, 4 }; // third row has 4 columns

            //// print the jagged array
            //for (int i = 0; i < jaggedArray.Length; i++) // loop through the rows
            //{
            //    for (int j = 0; j < jaggedArray[i].Length; j++) // loop through the columns of each row
            //    {
            //        Console.Write(jaggedArray[i][j] + " "); // print the element
            //    }
            //    Console.WriteLine(); // new line after each row
            //}

            //// print the jagged array using string.Join
            //for (int i = 0; i < jaggedArray.Length; i++) // loop through the rows
            //{
            //    Console.WriteLine($"Row {i}: {string.Join(", ", jaggedArray[i])}"); // print the row
            //}

            //// modify the jagged array
            //for (int i = 0; i < jaggedArray.Length; i++) // loop through the rows
            //{
            //    for (int j = 0; j < jaggedArray[i].Length; j++) // loop through the columns of each row
            //    {
            //        jaggedArray[i][j] += 10; // add 10 to each element
            //    }
            //}

            //// create and modify the jagged array by user then print it
            //Console.Write("Enter the number of rows: ");
            //bool jaggedRowFlag = int.TryParse(Console.ReadLine(), out int jaggedRows);
            //if (jaggedRowFlag && jaggedRows > 0)
            //{
            //    int[][] userJaggedArray = new int[jaggedRows][]; // create a new jagged array with the user input size
            //    // fill the jagged array with user input
            //    for (int i = 0; i < jaggedRows; i++) // loop through the rows or userJaggedArray.Length
            //    {
            //        Console.Write($"Enter the number of columns for row {i}: ");
            //        bool columnFlag = int.TryParse(Console.ReadLine(), out int columns);
            //        if (columnFlag && columns > 0)
            //        {
            //            userJaggedArray[i] = new int[columns]; // create a new array for the current row
            //            for (int j = 0; j < columns; j++)
            //            {
            //                Console.Write($"Enter value for [{i}, {j}]: ");
            //                bool valueFlag = int.TryParse(Console.ReadLine(), out int value);
            //                if (valueFlag)
            //                {
            //                    userJaggedArray[i][j] = value; // assign the value to the jagged array
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Invalid input. Please enter an integer.");
            //                    j--; // repeat the current column
            //                }
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid input for columns.");
            //            i--; // repeat the current row
            //        }
            //    }
            //    // print the user-defined jagged array
            //    Console.WriteLine("Your Jagged Array:");
            //    for (int i = 0; i < userJaggedArray.Length; i++)
            //    {
            //        Console.WriteLine($"Row {i}: {string.Join(", ", userJaggedArray[i])}"); // print the row
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input for rows.");
            //}

            #endregion

            #region Array Methods
            #region 1D Array
            //int[] arr = { 1, 2, 3, 4 };

            //Console.WriteLine(arr.Length); // 4
            //Console.WriteLine(arr.Rank); // 1 (1D array)
            //Console.WriteLine(arr.GetType()); // System.Int32[]
            //Console.WriteLine(arr.GetType().Name); // Int32[]
            //Console.WriteLine(arr.LongLength); // 4
            //Console.WriteLine(arr.GetLength(0)); // 4 (number of elements in the array) of the first dimension
            //Console.WriteLine(arr.GetLowerBound(0)); // 0 (lower bound of the array)
            //Console.WriteLine(arr.GetUpperBound(0)); // 3 (upper bound of the array)
            //Console.WriteLine(arr.GetValue(0)); // 1 (get the value at index 0)
            //Console.WriteLine(arr.GetValue(1)); // 2 (get the value at index 1)
            //Console.WriteLine(arr.GetValue(2)); // 3 (get the value at index 2)
            //Console.WriteLine(arr.GetValue(3)); // 4 (get the value at index 3)
            //                                    //Console.WriteLine(arr.GetValue(4)); // null (index out of range) // IndexOutOfRangeException


            //int[] arr2 = { 1, 10, 60, 5, 3, 100, 0 };

            //Console.Write("before:");
            //Console.WriteLine(string.Join(", ", arr2)); // print the array elements
            //Array.Sort(arr2); // sort the array in ascending order
            //Console.Write("after:");
            //Console.WriteLine(string.Join(", ", arr2)); // print the array elements
            //Array.Reverse(arr2); // reverse the array
            //Console.Write("after reverse:");
            //Console.WriteLine(string.Join(", ", arr2)); // print the array elements
            //Array.Clear(arr2, 1, 3); // clear the array (set all elements to default value) // 0 is the start index and 3 is the number of elements to clear
            //Console.Write("after clear:");
            //Console.WriteLine(string.Join(", ", arr2)); // print the array elements

            //int[] arr3 = new int[3]; // copy the array to a new array

            //Array.Copy(arr2, arr3, 3);

            //Console.Write("after copy:");
            //Console.WriteLine(string.Join(", ", arr3)); // print the array elements

            //Console.WriteLine(string.Join(", ",arr2));
            //Console.WriteLine(Array.IndexOf(arr2,100)); // find the index of an element in the array // 0
            //Console.WriteLine(Array.IndexOf(arr2,30)); // -1 not exist
            //Console.WriteLine(Array.IndexOf(arr2,0)); // if repeated it will return the first index // 1

            //Console.WriteLine(Array.LastIndexOf(arr2,0)); // if repeated it will return the last index // 6

            //Array.Resize(ref arr2, 10); // resize the array to 10 elements // will add default values to the new elements

            //Console.WriteLine(string.Join(", ",arr2));// 
            #endregion

            #region 2D Array
            //int[,] matrix = 
            //{
            //    { 1, 2, 3 },
            //    { 4, 5, 6 },
            //    { 7, 8, 9 }
            //};

            //Console.WriteLine(matrix.Length); // 9 (total number of elements in the 2D array)
            //Console.WriteLine(matrix.Rank); // 2 (2D array)
            //Console.WriteLine(matrix.GetType()); // System.Int32[,]
            //Console.WriteLine(matrix.GetType().Name); // Int32[,]
            //Console.WriteLine(matrix.LongLength); // 9 (total number of elements in the 2D array)
            //Console.WriteLine(matrix.GetLength(0)); // 3 (number of rows)
            //Console.WriteLine(matrix.GetLength(1)); // 3 (number of columns)
            //Console.WriteLine(matrix.GetLowerBound(0)); // 0 (lower bound of the first dimension)
            //Console.WriteLine(matrix.GetUpperBound(0)); // 2 (upper bound of the first dimension)
            //Console.WriteLine(matrix.GetLowerBound(1)); // 0 (lower bound of the second dimension)
            //Console.WriteLine(matrix.GetUpperBound(1)); // 2 (upper bound of the second dimension)
            //Console.WriteLine(matrix.GetValue(0, 0)); // 1 (get the value at row 0, column 0)
            //Console.WriteLine(matrix.GetValue(1, 1)); // 5 (get the value at row 1, column 1)

            //Array.Sort(matrix); // sort the 2D array in ascending order (will not work as expected for 2D arrays)
            // System.RankException: Only single dimension arrays are supported here.

            //Array.Reverse(matrix); // reverse the 2D array (will not work as expected for 2D arrays)

            //Array.IndexOf(matrix, 5); // find the index of an element in the 2D array (will not work as expected for 2D arrays)

            //Array.Clear(matrix, 0, matrix.Length); // clear the 2D array (set all elements to default value) // no exception will be thrown


            #endregion

            #region Jagged Array
            //int[][] ints = new int[3][]; // create a jagged array with 3 rows
            //ints[0] = new int[2] { 2, 0 }; // first row has 2 columns
            //ints[1] = new int[3] { 3, 4, 5 }; // second row has 3 columns
            //ints[2] = new int[4] { 6, 7, 8, 9 }; // third row has 4 columns

            //Console.WriteLine(ints.Length); // 3 (number of rows in the jagged array)
            //Console.WriteLine(ints.Rank); // 1 (jagged array)
            //Console.WriteLine(ints.GetType()); // System.Int32[][]
            //Console.WriteLine(ints.GetType().Name); // Int32[][]
            //Console.WriteLine(ints.LongLength); // 3 (number of rows in the jagged array)
            //Console.WriteLine(ints[0].Length); // 2 (number of columns in the first row)
            //Console.WriteLine(ints[1].Length); // 3 (number of columns in the second row)
            //Console.WriteLine(ints[2].Length); // 4 (number of columns in the third row)
            //Console.WriteLine(ints[0][0]); // 1 (get the value at row 0, column 0)
            //Console.WriteLine(ints[1][1]); // 4 (get the value at row 1, column 1)
            //Console.WriteLine(ints[2][2]); // 8 (get the value at row 2, column 2)
            ////Console.WriteLine(ints[3][0]); // System.IndexOutOfRangeException: Index was outside the bounds of the array.

            ////Array.Sort(ints); // sort the jagged array (will not work as expected for jagged arrays)
            //// InvalidOperationException: Jagged arrays cannot be sorted directly.
            //Array.Sort(ints[0]); // sort the first row of the jagged array
            //Console.WriteLine(string.Join(", ", ints[0]));
            //Array.Reverse(ints[1]); // reverse the second row of the jagged array
            //Console.WriteLine(string.Join(", ", ints[1])); // print the second row of the jagged array
            //// all other methods like IndexOf, Clear, Copy, Resize will not work as expected for jagged arrays
            //// but you can use them on each row of the jagged array

            ////Array.Clear(ints, 0, ints.Length); // System.ArgumentNullException:
            ////Console.WriteLine(string.Join(", ", ints[0]));

            #endregion
            #endregion
            #endregion

            #region Functions
            //Program.PrintShape(5, "Hello World"); // call the PrintShape method to print "Hello World" 5 times

            //PrintShape(5, "Hello World"); // call the PrintShape method to print "Hello World" 5 times 

            // pass by order
            //PrintShape(5,"Hello World"); // call the PrintShape method to print "Hello World" 5 times

            // pass by name
            //PrintShape(count: 3, str: "Hello C#"); // call the PrintShape method to print "Hello C#" 3 times
            //PrintShape(str: "Hello C#", count: 3); // call the PrintShape method to print "Hello C#" 3 times

            //PrintShape(); // call the PrintShape method with default values

            #region Function Take [Value Type] inputs [int, double, char, bool, etc.] 
            //// pass by value
            //int number = 5; // initialize a variable
            //Console.WriteLine($"Before IncVal: {number}"); // print the initial value
            //IncVal(number); // call the IncVal method to increment the number by 1
            //Console.WriteLine($"After IncVal: {number}"); // print the value after the method call

            //// pass by reference

            //int refNumber = 5; // initialize a variable
            //Console.WriteLine($"Before IncRef: {refNumber}"); // print the initial value
            //IncRef(ref refNumber); // call the IncRef method to increment the number by 1
            //Console.WriteLine($"After IncRef: {refNumber}"); // print the value after the method call

            //// pass by output
            //int outNumber; // declare a variable without initializing it
            //IncOut(out outNumber); // call the IncOut method to initialize the number and increment it by 1
            //Console.WriteLine($"After IncOut: {outNumber}"); // print the value after the method call

            //// pass by in
            //int inNumber = 5; // initialize a variable
            //Console.WriteLine($"Before IncIn: {inNumber}"); // print the initial value
            //int result = IncIn(inNumber); // call the IncIn method to increment the number by 1 and return the result
            //Console.WriteLine($"After IncIn: {inNumber}"); // print the value after the method call
            //Console.WriteLine($"Result of IncIn: {result}"); // print the result of the method call

            //// for string
            //string str = "Hello"; // initialize a string variable
            //Console.WriteLine($"Before StrFunc: {str}"); // print the initial value
            //string resultStr = StrFunc(str); // call the StrFunc method to concatenate "!" to the string
            //Console.WriteLine($"After StrFunc: {str}"); // print the value after the method call
            //Console.WriteLine($"Result of StrFunc: {resultStr}"); // print the result of the method call

            //// for string with ref
            //string str2 = "Hello"; // initialize a string variable
            //Console.WriteLine($"Before StrFunc2: {str2}"); // print the initial value
            //string resultStr2 = StrFunc2(ref str2); // call the StrFunc2 method to concatenate "!" to the string and modify it
            //Console.WriteLine($"After StrFunc2: {str2}"); // print the value after the method call
            //Console.WriteLine($"Result of StrFunc2: {resultStr2}"); // print the result of the method call

            // by params (params keyword) (array of values)
            //int[] numbers = { 1, 2, 3, 4, 5 }; // initialize an array
            //Console.WriteLine($"Sum of numbers: {SumNumbers(numbers)}"); // call the SumNumbers method to calculate the sum of the array elements
            //Console.WriteLine($"Sum of numbers with params: {SumNumbers(1, 2, 3, 4, 5)}"); // call the SumNumbersWithParams method to calculate the sum of the array elements using params keyword
            #endregion

            #region Function Take [Ref Type] inputs [class, array, etc.]
            //// by value
            //int[] arr = { 1, 2, 3, 4 }; // initialize an array
            //Console.WriteLine("Before IncBy1ThenReturnSum:");
            //Console.WriteLine(string.Join(", ", arr)); // print the initial array
            //IncBy1ThenReturnSum(arr); // call the IncBy1ThenReturnSum method to increment each element by 1 and return the sum
            //Console.WriteLine("After IncBy1ThenReturnSum:");
            //Console.WriteLine(string.Join(", ", arr)); // print the array after the method call
            //// the array is modified because it is a reference type and the method modifies the original array

            //// by ref
            //int[] arr2 = { 1, 2, 3, 4 }; // initialize an array
            //Console.WriteLine("Before IncBy1ThenReturnSumRef:");
            //Console.WriteLine(string.Join(", ", arr2)); // print the initial array
            //IncBy1ThenReturnSumRef(ref arr2); // call the IncBy1ThenReturnSumRef method to increment each element by 1 and return the sum
            //Console.WriteLine("After IncBy1ThenReturnSumRef:");
            //Console.WriteLine(string.Join(", ", arr2)); // print the array after the method call

            //int[] arr3 = { 1, 2, 3, 4 }; // initialize an array
            //int[] arr4 = { 5, 6, 7, 8 }; // initialize another array
            //// by value
            //Console.WriteLine("Before SwapVal:");
            //Console.WriteLine("arr3:" + string.Join(", ", arr3)); // print the initial array
            //Console.WriteLine("arr4:" + string.Join(", ", arr4)); // print the initial array
            //SwapVal(arr3, arr4); // call the Swap method to swap the two arrays
            //Console.WriteLine("After SwapVal:");
            //Console.WriteLine("arr3:" + string.Join(", ", arr3)); // print the first array after the method call
            //Console.WriteLine("arr4:" + string.Join(", ", arr4)); // print the second array after the method call

            //// by ref
            //Console.WriteLine("Before SwapRef:");
            //Console.WriteLine("arr3:" + string.Join(", ", arr3)); // print the initial array
            //Console.WriteLine("arr4:" + string.Join(", ", arr4)); // print the initial array
            //SwapRef(ref arr3, ref arr4); // call the Swap method to swap the two arrays
            //Console.WriteLine("After SwapRef:");
            //Console.WriteLine("arr3:" + string.Join(", ", arr3)); // print the first array after the method call
            //Console.WriteLine("arr4:" + string.Join(", ", arr4)); // print the second array after the method call

            #endregion
            // reference type is a type that is stored in the heap and the variable holds the address of the object in the heap
            // value type is a type that is stored in the stack and the variable holds the value itself
            // reference type can be modified by the method and the changes will be reflected outside the method
            // value type cannot be modified by the method and the changes will not be reflected outside the method
            // so we need to use ref or out keywords to modify the value type in the method
            // ref keyword is used to pass the variable by reference and out keyword is used to pass the variable by output
            // in keyword is used to pass the variable by input and it is read-only in the method


            #endregion
            #region Escape sequance

            //Console.WriteLine("/*\\"); // \ there is a special character in C# so we need to escape it with another \

            //Console.WriteLine(@"/*\"); // @ to print a verbatim string (no need to escape special characters)

            //Console.WriteLine("Hello \"World\""); // " to print " in the string we need to escape it with \

            //Console.WriteLine("Hello \n World"); // \n to print a new line in the string

            //Console.WriteLine("Hello \t World"); // \t to print a tab in the string

            //Console.WriteLine("Hello\b\b World"); // \b to print a backspace in the string

            //Console.WriteLine("Hello\rWorld"); // \r to print a carriage return in the string (moves the cursor to the beginning of the line)

            //Console.WriteLine("Hello\\World"); // \\ to print \ in the string

            //Console.WriteLine("Hello \u0041 World"); // \u to print a unicode character in the string (A in this case)

            //Console.WriteLine("Hello \x0041 World"); // \x to print a hexadecimal unicode character in the string (A in this case)

            //Console.WriteLine("Hello \U00000041 World"); // \U to print a unicode character in the string (A in this case)

            //Console.WriteLine(@"Hello World! "); // @ to print a verbatim string (no need to escape special characters)
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

        #region Demo of C#06
        #region Methods
        //public static void PrintShape(int count = 4, string str = "_") // default values for parameters
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        Console.WriteLine(str);
        //    }
        //}
        //public static void IncVal(int number) // pass by value
        //{
        //    number++; // increment the number by 1
        //    //Console.WriteLine($"Inside IncVal: {number}"); // this will print the incremented value
        //}
        //public static void IncRef(ref int number) // pass by reference
        //{
        //    number++; // increment the number by 1
        //}

        //public static void IncOut(out int number) // pass by output
        //{
        //    number = 0; // initialize the number to 0
        //    number++; // increment the number by 1

        //    int x = number; // copy the value of number : valid

        //}
        //public static int IncIn(in int number) // pass by in
        //{
        //    int x = number; // copy the value of number : valid
        //                    //number++; // this will give an error because in parameter is read-only
        //    return number + 1; // return the incremented value
        //}

        //public static string StrFunc(string str) // function that takes a string as input
        //{
        //    return str + "!"; // return the string
        //}
        //public static string StrFunc2(ref string str)
        //{
        //    str += "!"; // modify the string
        //    return str + "!"; // return the modified string
        //}

        //public static void IncBy1ThenReturnSum(int[] arr)
        //{
        //    int sum = 0; // initialize the sum to 0
        //    for (int i = 0; i < arr.Length; i++) // loop through the array
        //    {
        //        arr[i]++; // increment each element by 1
        //        sum += arr[i]; // add each element to the sum
        //    }
        //    Console.WriteLine($"Sum of the array is: {sum}"); // print the sum
        //}
        //public static void IncBy1ThenReturnSumRef(ref int[] arr)
        //{
        //    int sum = 0; // initialize the sum to 0
        //    for (int i = 0; i < arr.Length; i++) // loop through the array
        //    {
        //        arr[i]++; // increment each element by 1
        //        sum += arr[i]; // add each element to the sum
        //    }
        //    Console.WriteLine($"Sum of the array is: {sum}"); // print the sum
        //}

        //public static void SwapRef(ref int[] arr1, ref int[] arr2)
        //{
        //    int[] temp = arr1; // store the first array in a temporary variable
        //    arr1 = arr2; // assign the second array to the first array
        //    arr2 = temp; // assign the temporary variable to the second array
        //}

        //public static void SwapVal(int[] arr1, int[] arr2)
        //{
        //    int[] temp = arr1; // store the first array in a temporary variable
        //    arr1 = arr2; // assign the second array to the first array
        //    arr2 = temp; // assign the temporary variable to the second array
        //    // this will not change the original arrays outside this method
        //}
        //public static int SumNumbers(params int[] numbers) // params keyword allows passing a variable number of arguments
        //{
        //    int sum = 0; // initialize the sum to 0
        //    foreach (var number in numbers) // loop through the array of numbers
        //    {
        //        sum += number; // add each number to the sum
        //    }
        //    return sum; // return the sum
        //}
        #endregion
        #endregion
    }
}
