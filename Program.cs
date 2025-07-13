using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Text;
using System.Threading;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharpRouteSessions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 
            //1 - Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //Example
            //Input: 5
            //Output: 1, 2, 3, 4, 5 

            //StartAgain:
            //Console.Write("Enter An Intger: ");

            //bool flag = int.TryParse(Console.ReadLine(), out int number);
            //if (!flag || number < 1)
            //{
            //Console.WriteLine("Please enter a valid positive integer.");
            //goto StartAgain; // Uncomment this line to allow re-entry
            //}
            //// using for loop
            //for (int i = 1; i <= number; i++)
            //{
            //    Console.Write(i);
            //    if (i == number)
            //    {
            //        Console.WriteLine(); // To avoid trailing comma on the last number
            //    }
            //    else
            //    {
            //        Console.Write(", ");
            //    }
            //}
            //// using while loop
            //int j = 1;
            //while (j <= number)
            //{
            //    Console.Write(j);
            //    if (j == number)
            //    {
            //        Console.WriteLine(); // To avoid trailing comma on the last number
            //    }
            //    else
            //    {
            //        Console.Write(", ");
            //    }
            //    j++;
            //} 

            //// using goto statement
            //int k = 1;
            //start:
            //if (k <= number)
            //{
            //    Console.Write(k);
            //    if (k == number)
            //    {
            //        Console.WriteLine(); // To avoid trailing comma on the last number
            //    }
            //    else
            //    {
            //        Console.Write(", ");
            //    }
            //    k++;
            //    goto start;
            //}

            #endregion

            #region Q2
            //2 - Write a program that allows the user to insert an integer then
            //print a multiplication table up to 12.
            //Example
            //Input: 5
            //Outputs: 5 10 15 20 25 30 35 40 45 50 55 60

            //StartAgain:
            //    Console.Write("Enter An Intger Number: ");
            //    bool flag = int.TryParse(Console.ReadLine(), out int number);

            //    if(!flag || number < 1)
            //    {
            //        Console.WriteLine("Please enter a valid positive integer.");
            //        goto StartAgain;
            //    }
            //    // using for loop
            //    for (int i = 1; i <= 12; i++)
            //    {
            //        Console.Write(number * i + " ");
            //    }
            //    Console.WriteLine("----");
            //    for (int i = 1; i <= 12; i++)
            //    {
            //        Console.WriteLine($"{number} * {i} = {number * i}");
            //    }

            #endregion

            #region Q3
            //3 - Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //Example:
            //Input: 15
            // Output: 2 4 6 8 10 12 14

            //StartAgain:
            //Console.Write("Enter An Intger Number: ");
            //bool flag =  int.TryParse(Console.ReadLine(), out int number);

            //if (!flag || number < 1)
            //{
            //    Console.WriteLine("Please enter a valid positive integer.");
            //    goto StartAgain; // Uncomment this line to allow re-entry
            //}
            //// using for loop
            //for (int i = 1; i <= number; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.Write(i + " ");
            //    }
            //}
            #endregion

            #region Q4
            //4 - Write a program that takes two integers then prints the power.
            //Example:
            //Input: 4 3
            //Output: 64
            //Hint: how to calculate 4 ^ 3 = 4 * 4 * 4 = 64

            //Startagain:
            //Console.Write("Enter Base Number: ");
            //bool flag1 = int.TryParse(Console.ReadLine(), out int baseNumber);
            //Console.Write("Enter Power Number: ");
            //bool flag2 = int.TryParse(Console.ReadLine(), out int powerNumber);
            //if (!flag1 || !flag2)
            //{
            //    Console.WriteLine("Please enter valid integers.");
            //    goto Startagain;
            //}
            //int mul = 1;
            //// using for loop
            //for (int i = 1; i <= powerNumber; i++)
            //{
            //    mul *= baseNumber;
            //}
            //Console.WriteLine($"{baseNumber} ^ {powerNumber} = {mul}");
            #endregion

            #region Q5
            //5 - Write a program to enter marks of five subjects and calculate total, average and percentage.
            //Example
            //Input: -Enter Marks of five subjects: 95 76 58 90 89
            //Output: Total marks = 408
            //Average Marks = 81
            //Percentage = 81
            //StartAgain:
            //Console.Write("Enter The Marks Of Subjects(seprate by one space): ");
            //string input = Console.ReadLine().Trim();
            //string[] marks = input.Split(' ');

            //if(marks.Length != 5)
            //{
            //    Console.WriteLine("Please enter exactly five marks.");
            //    goto StartAgain;
            //}
            //// check if marks are valid integers (0,100)

            //int total = 0;
            //int count = 0;

            //foreach (string mark in marks)
            //{
            //    int markValue;
            //    if (int.TryParse(mark, out markValue) && markValue >= 0 && markValue <= 100)
            //    {
            //        total += markValue;
            //        count++;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Invalid input: {mark} is not a valid integer degree.");
            //        goto StartAgain;
            //    }
            //}

            //Console.WriteLine($"Total is {total}");

            //double average = (double)total / count;
            //Console.WriteLine($"Average is {average}");
            //Console.WriteLine($"Percentage is {average}%");

            #endregion

            #region Q6
            //6 - Write a program to allow the user to enter a string and print the REVERSE of it.
            //StartAgain:
            //    Console.Write("Enter A string:");
            //    string input = Console.ReadLine();
            //    string reversedString = string.Empty;// "";
            //    if (string.IsNullOrEmpty(input))
            //    {
            //        Console.WriteLine("Please enter a valid string.");
            //        goto StartAgain;
            //    }
            //    else
            //    {
            //        // using for loop
            //        for (int i = input.Length - 1; i >= 0; i--)
            //        {
            //            reversedString += input[i];
            //        }

            //        Console.WriteLine($"Reversed String using for loop: {reversedString}");
            //    }
            #endregion

            #region Q7
            //7 - Write a program to allow the user to enter int and print the REVERSED of it.
            //StartAgain:
            //Console.Write("Enter An Integer: ");
            //bool flag = int.TryParse(Console.ReadLine(), out int number);
            //if (!flag)
            //{
            //    Console.WriteLine("Please enter a valid integer.");
            //    goto StartAgain; // Uncomment this line to allow re-entry
            //}
            // method 1: using for loop and converting to string
            //string reversedNumber = string.Empty;
            //for (int i = number.ToString().Length - 1; i >= 0; i--)
            //{
            //    reversedNumber += number.ToString()[i];
            //}
            //Console.WriteLine($"Reversed Number using for loop: {reversedNumber}");
            // method 2: without converting to string
            //int reversedNumber = 0;
            //// if input : 1234
            //while (number > 0)
            //{
            //    int digit = number % 10; // Get the last digit // 4, 3, 2, 1
            //    reversedNumber = reversedNumber * 10 + digit; // Build the reversed number 4+0 = 4, // 4*10 + 3 = 43, 43*10 + 2 = 432, 432*10 + 1 = 4321
            //    number /= 10; // Remove the last digit // 123, 12, 1, 0
            //}
            //Console.WriteLine($"Reversed Number without converting to string: {reversedNumber}");
            #endregion

            #region Q8
            //8 - Write a program in C# Sharp to find prime numbers within a range of numbers.
            //Test Data:
            //            Input starting number of ranges: 1
            //Input ending number of range: 50

            //Expected Output :
            //The prime number between 1 and 50 are:
            //            2 3 5 7 11 13 17 19 23 29 31 37 41 43 47

            //StartAgain:
            //Console.Write("Enter Starting Number of Range: ");
            //bool flag1 = int.TryParse(Console.ReadLine(), out int startRange);
            //Console.Write("Enter Ending Number of Range: ");
            //bool flag2 = int.TryParse(Console.ReadLine(), out int endRange);
            //if (!flag1 || !flag2 || startRange < 1 || endRange < startRange)
            //{
            //    Console.WriteLine("Please enter valid positive integers for the range.");
            //    goto StartAgain;
            //}
            //Console.WriteLine($"The prime numbers between {startRange} and {endRange} are:");

            //for(int i = startRange; i <= endRange; i++)
            //{
            //    if (i < 2) continue;// skip numbers less than 2, as they are not prime
            //    bool isPrime = true;
            //    for (int j = 2; j < i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            isPrime = false; // found a divisor, so it's not prime
            //            break; // not a prime number
            //        } 
            //    }
            //    if (!isPrime) continue; // skip to next iteration if not prime
            //    Console.Write(i + " ");
            //}
            // make it more simple
            // use a method to check if a number is prime
            //for (int i = startRange; i <= endRange; i++)
            //{
            //    if (IsPrime(i))
            //    {
            //        Console.Write(i + " ");
            //    }
            //}
            #endregion

            #region Q9
            //9 - .Write a program in C# Sharp to convert a decimal number into binary without using an array.
            //Test Data:
            //            Enter a number to convert: 25
            //Expected Output :
            //The Binary of 25 is 11001.

            //StartAgain:
            //Console.Write("Enter a decimal intger number to convert: ");
            //bool flag = int.TryParse(Console.ReadLine(), out int decimalNumber);
            //if (!flag || decimalNumber < 0)
            //{
            //    Console.WriteLine("Please enter a valid positive integer.");
            //    goto StartAgain; // Uncomment this line to allow re-entry
            //}
            //string binaryNumber = string.Empty;
            //// using for loop
            //int temp = decimalNumber;
            //while (temp > 0)
            //{
            //    int remainder = temp % 2; // Get the remainder when divided by 2 [1 or 0]
            //    binaryNumber = remainder + binaryNumber;
            //    temp /= 2; // Divide the number by 2 // 25 /2 = 12, 12/2 = 6, 6/2 = 3, 3/2 = 1, 1/2 = 0
            //}
            //Console.WriteLine($"The Binary of {decimalNumber} is {binaryNumber}.");

            #endregion

            #region Q10
            //10 - Create a program that asks the user to input three points(x1, y1), (x2, y2), and(x3, y3),
            //and determines whether these points lie on a single straight line.
            //StartAgain:
            //Console.Write("Enter x1: ");
            //bool flag1 = double.TryParse(Console.ReadLine(), out double x1);
            //Console.Write("Enter y1: ");
            //bool flag2 = double.TryParse(Console.ReadLine(), out double y1);
            //Console.Write("Enter x2: ");
            //bool flag3 = double.TryParse(Console.ReadLine(), out double x2);
            //Console.Write("Enter y2: ");
            //bool flag4 = double.TryParse(Console.ReadLine(), out double y2);
            //Console.Write("Enter x3: ");
            //bool flag5 = double.TryParse(Console.ReadLine(), out double x3);
            //Console.Write("Enter y3: ");
            //bool flag6 = double.TryParse(Console.ReadLine(), out double y3);
            //if (!flag1 || !flag2 || !flag3 || !flag4 || !flag5 || !flag6)
            //{
            //    Console.WriteLine("Please enter valid numbers for the points.");
            //    goto StartAgain; // Uncomment this line to allow re-entry
            //}

            //double slope1 = (y2 - y1) / (x2 - x1); // Slope between point 1 and point 2
            //double slope2 = (y3 - y2) / (x3 - x2); // Slope between point 2 and point 3

            //if (slope1 == slope2)
            //{
            //    Console.WriteLine("The points lie on a single straight line.");
            //}
            //else
            //{
            //    Console.WriteLine("The points do not lie on a single straight line.");
            //}
            #endregion

            #region Q11
            //11 - .Write a program that prints an identity matrix using for loop,
            //in other words takes a value n from the user and shows the identity table of size n * n.

            //StartAgain:
            //Console.Write("Enter the size of the identity matrix (n): ");
            //bool flag = int.TryParse(Console.ReadLine(), out int n);
            //if (!flag || n <= 0)
            //{
            //    Console.WriteLine("Please enter a valid positive integer for the size of the matrix.");
            //    goto StartAgain; // Uncomment this line to allow re-entry
            //}

            //for(int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == j)
            //        {
            //            Console.Write("1"); // Diagonal elements are 1
            //        }
            //        else
            //        {
            //            Console.Write("0"); // Non-diagonal elements are 0
            //        }
            //        if (j < n - 1)
            //        {
            //            Console.Write(" ");
            //        }
            //    }
            //    Console.WriteLine(); // Move to the next line after each row
            //}
            #endregion

        }
        // Q8 Helper Method
        static bool IsPrime(int number)
        {
            if (number < 2) return false; // 0 and 1 are not prime numbers
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0) return false; // found a divisor, so it's not prime
            }
            return true; // no divisors found, so it's prime
        }
    }
}
