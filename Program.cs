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
