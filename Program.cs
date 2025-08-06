using CSharpRouteSessions.Part01.Q5;
using CSharpRouteSessions.Part02;

namespace CSharpRouteSessions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01
            #region Q1
            /*
             Q1) Write a class named Calculator that contains a method named Add. Overload the Add method to:
                ●	Accept two integers and return their sum.
                ●	Accept three integers and return their sum.
                ●	Accept two doubles and return their sum.
             */
            #endregion

            #region Q2
            /*
             Q2) Create a class named Rectangle with the following constructors:
                ●	A parameterless constructor that sets the width and height to 0.
                ●	A constructor that accepts width and height as integers.
                ●	A constructor that accepts a single integer and sets both width and height to that value.
             */
            #endregion

            #region Q3
            /*
             Q3) Define a class Complex Number that represents a complex number with real and imaginary parts.
                 *Note: Overload the +, - operator to add and subtract two complex numbers.	

             */
            #endregion

            #region Q4
            /*
             Question 4)   
                a) Create a base class named Employee with method That Work as it prints    "Employee is  working".

                b) Create a derived class named Manager that overrides the Work method to print "Manager is managing". 
                    *Ensure that the Manager class also calls the Work method of the Employee class within its  Overridden method   .
             */
            #endregion
            #region Q5
            /*
             Question 5)  
                a) Create a base class BaseClass with a virtual method DisplayMessage that prints  "Message from BaseClass".

                b) Create a derived class DerivedClass1 that overrides the DisplayMessage method using the override keyword.

                C) Create another derived class DerivedClass2 that hides the DisplayMessage method using the new keyword.

                 Then explain the difference between using override and new (using binding behavior)	

             */

            /*
                override = Override a virtual method, use polymorphism. (Runtime binding polymorphism)

                new = New version of a method, hides the old one, no polymorphism.(Compile-time binding polymorphism)

             */
            BaseClass dr = new DerivedClass1();
            dr.DisplayMessage(); // Calls the overridden method in DerivedClass1
                                // because of the override keyword, this will call the method in DerivedClass1 
                                // Output: "Message from DerivedClass1" // dynamic binding

            BaseClass dr2 = new DerivedClass2();
            dr2.DisplayMessage(); // Calls the new method in DerivedClass2, not the overridden one in DerivedClass1
                                  // because of the new keyword, this will call the method in BaseClass
                                  // Output: "Message from BaseClass"
                                  // new hides the base class method, not override it. still exists in BaseClass
                                  // static binding
            #endregion
            #endregion
            #region Part02
            /*
             Part02
                1-Define Class Duration To include Three Attributes Hours, Minutes and Seconds.

                2-Override All System. Object Members [To String(), Equals(),GetHashCode() ] .


                3-Define All Required Constructors to Produce this output:
                Duration D1 =new Duration (1,10,15);
                D1.ToString(); 
                Output: Hours: 1, Minutes :10, Seconds :15

                Duration D1 =new Duration (3600);
                D1.ToString(); 
                Output: Hours: 1, Minutes :0, Seconds :0

                Duration D2 =new Duration (7800);
                D2.ToString(); 
                Output: Hours: 2, Minutes :10, Seconds :0

                Duration D3 =new Duration (666);
                D3.ToString(); 
                Output: Minutes :11, Seconds :6




                4-Implement All required Operators overloading to enable this Code:
                ●	D3=D1+D2
                ●	D3=D1 + 7800
                ●	D3=666+D3
                ●	D3= ++D1 (Increase One Minute)
                ●	D3 = --D2 (Decrease One Minute)
                ●	D1= D1 -D2
                ●	If (D1>D2)
                ●	If (D1<=D2)
                ●	If (D1)
                ●	DateTime Obj = (DateTime) D1

             */
            Duration d1 = new Duration(1, 10, 15); // 1 hour, 10 minutes, 15 seconds
            Console.WriteLine(d1.ToString()); // "Hours:01,Minutes:10,Seconds:15"

            Duration d2 = new Duration(3600); // 1 hour (3600 seconds)
            Console.WriteLine(d2.ToString()); // "Hours:01,Minutes:00,Seconds:00"
            Duration d3 = new Duration(7800); // 2 hours, 10 minutes (7800 seconds)
            Console.WriteLine(d3.ToString()); // "Hours:02,Minutes:10,Seconds:00"
            Duration d4 = new Duration(666); // 11 minutes, 6 seconds (666 seconds)
            Console.WriteLine(d4.ToString()); // "Hours:00,Minutes:11,Seconds:06"

            Duration d5 = d1 + d2; // Adding two Duration objects
            Console.WriteLine(d5.ToString()); // "Hours:02,Minutes:10,Seconds:15"

            Duration d6 = d3 + 7800;
            Console.WriteLine(d6.ToString()); // "Hours:04,Minutes:20,Seconds:00"

            Duration d7 = 666 + d4;
            Console.WriteLine(d7.ToString()); // "Hours:00,Minutes:22,Seconds:12"

            Duration d8 = ++d1; 
            Console.WriteLine(d8.ToString()); // "Hours:02,Minutes:11,Seconds:15"

            Duration d9 = --d1; 
            Console.WriteLine(d8.ToString()); // "Hours:02,Minutes:10,Seconds:15"

            Duration d10 = d1 - d2;
            Console.WriteLine(d10.ToString()); // "Hours:00,Minutes:10,Seconds:15"

            Console.WriteLine(d1 > d2); // True, because d1 is greater than d2
            Console.WriteLine(d1 < d2); // False, because d1 is not less than d2
            Console.WriteLine(d1 <= d2); // False, because d1 is not less than or equal to d2
            Console.WriteLine(d1 >= d2); // True, because d1 is greater than or equal to d2

            if (d1)
            {
                Console.WriteLine("d1 is exist");
            }
            else
            {
                Console.WriteLine("d1 is null or default.");

            }
            DateTime dateTime = (DateTime)d1; // Implicit conversion from Duration to DateTime

            Console.WriteLine(dateTime);
            #endregion
        }
    }
}
