using System.Buffers.Text;
using System.ComponentModel;
using System.IO.Pipelines;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace CSharpRouteSessions
{
    internal class Program
    {
        #region Q1
        
        public static void Add5(int num) // Passing by value
        {
            num += 5; // This will not affect the original variable
        }
        public static void Add5(ref int num) // Passing by reference
        {
            num += 5; // This will affect the original variable
        }
        #endregion

        #region Q2
        public static void Add3ToEachElement(int[] arr) // Passing by value
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += 3; // This will affect the original array
            }
        }
        public static void Add3ToEach(ref int[] arr) // Passing by reference
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += 3; // This will affect the original array
            }
        }
        public static void ChangeArray(ref int[] arr)
        {
            arr = new int[] { 7, 8, 9 }; // This will change the original reference
        }
        #endregion

        #region Q3
        public static void SumSubFor4NumFromUser(out int sum,out int sub)
        {
            Console.WriteLine("Enter four numbers:");
            int[] nums = new int[4];
            for (int i = 0; i < nums.Length; i++)
            {
                bool isValid = int.TryParse(Console.ReadLine(), out nums[i]);
                if(!isValid)
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                    i--; // Decrement i to retry this index
                }
            }
            sum = nums[0] + nums[1]; // Summation of first two numbers
            sub = nums[2] - nums[3]; // Subtraction of last two numbers
        }
        #endregion

        #region Q4
        public static int SumOfDigits(int number)
        {
            int sum = 0;
            //while (number > 0)
            //{
            //    sum += number % 10; // Add the last digit to sum
            //    number /= 10; // Remove the last digit
            //}
            foreach (char digit in number.ToString())
            {
                //sum += digit - '0'; // Convert char to int and add to sum
                sum += int.Parse(digit.ToString()); // Convert char to int and add to sum
            }
            return sum;
        }
        #endregion

        #region Q5
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false; // 0 and 1 are not prime numbers
            for (int i = 2; i <= number; i++)
            {
                if (number % i == 0) return false; // Found a divisor, not prime
            }
            return true; // No divisors found, it's prime
        }
        #endregion

        #region Q6
        public static void MinMaxArray(ref int[] arr, out int min, out int max)
        {
            min = arr[0];
            max = arr[0];

            //foreach (int num in arr)
            //{
            //    if (num < min) min = num; // Update min if current number is smaller
            //    if (num > max) max = num; // Update max if current number is larger
            //}

            Array.Sort(arr); // Sort the array first
            min = arr[0]; // First element is the minimum
            max = arr[arr.Length - 1]; // Last element is the maximum
        }
        #endregion

        #region Q7
        public static int factorial(int number)
        {
            if(number < 0)
            {
                throw new ArgumentException("Number must be non-negative.");
            }
            int mul = number;
            for (int i = number - 1; i > 0; i--)
            {
                mul *= i; // Multiply the current number with the next lower number
            }
            return mul;
        }

        #endregion

        #region Q8
        public static string ChangeChar(string str, int position, char newChar)
        {
            if (position < 0 || position >= str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(position), "Position is out of range.");
            }
            return $"{str.Substring(0, position)}{newChar}{str.Substring(position + 1)}";
        }
        #endregion
        static void Main(string[] args)
        {
            #region Q1 
            //1 - Explain the difference between passing(Value type parameters)
            //by value and by reference then write a suitable c# example.
            // by value: A copy of the variable is passed to the method.
            // Changes made to the parameter inside the method do not affect the original variable.
            // by reference: A reference to the original variable is passed to the method.
            // Changes made to the parameter inside the method will affect the original variable.

            //int number = 10;
            //Console.WriteLine($"Original number: {number}");
            //Add5(number); // Passing by value
            //Console.WriteLine($"After passing by value: {number}"); // Output: 10
            //Add5(ref number); // Passing by reference
            //Console.WriteLine($"After passing by reference: {number}"); // Output: 15
            #endregion

            #region Q2 
            //2 - Explain the difference between passing(Reference type parameters)
            //by value and by reference then write a suitable c# example.
            // by value: A copy of the reference is passed to the method.
            // Changes made to the object inside the method will affect the original object,
            // but reassigning the reference will not affect the original reference.
            // by reference: A reference to the original object is passed to the method.
            // Changes made to the object inside the method will affect the original object,
            // and reassigning the reference will also affect the original reference.

            //int[] arr1 = { 1, 2, 3 };
            //Console.WriteLine($"Original array: {string.Join(", ", arr1)}");
            //Add3ToEachElement(arr1); // Passing by value
            //Console.WriteLine($"After passing by value: {string.Join(", ", arr1)}"); // Output: 4, 5, 6
            //Add3ToEach(ref arr1); // Passing by reference
            //Console.WriteLine($"After passing by reference: {string.Join(", ", arr1)}"); // Output: 7, 8, 9

            // Note: In the case of arrays, passing by value means passing a copy of the reference,
            // so changes to the elements will affect the original array, but reassigning the array will not.
            // In contrast, passing by reference allows the method to change the reference itself,
            // which can lead to the original reference being changed to point to a new array.
            // Example of passing by reference changing the reference:
            //int[] arr2 = { 4, 5, 6 };
            //Console.WriteLine($"Original array before passing by reference: {string.Join(", ", arr2)}"); // Output: 4, 5, 6
            //ChangeArray(ref arr2); // Passing by reference
            //Console.WriteLine($"After passing by reference: {string.Join(", ", arr2)}"); // Output: 7, 8, 9
            // In this case, the original reference arr2 is changed to point to a new array.

            #endregion

            #region Q3 
            //3 - Write a c# Function that accept 4 parameters from user and
            //return result of summation and subtracting of two numbers
            //int sum, sub;
            //SumSubFor4NumFromUser(out sum, out sub);
            //Console.WriteLine($"The sum of the first two numbers is: {sum}");
            //Console.WriteLine($"The subtraction of the last two numbers is: {sub}");

            #endregion

            #region Q4 
            //4 - Write a program in C# Sharp to create a function to calculate
            //the sum of the individual digits of a given number.
            //        Output should be like
            //        Enter a number: 25
            //        The sum of the digits of the number 25 is: 7
            //retry:
            //    Console.Write("Enter a number: ");
            //    bool isValid = int.TryParse(Console.ReadLine(), out int num);
            //    if (isValid)
            //    {
            //        int sumOfDigits = SumOfDigits(num);
            //        Console.WriteLine($"The sum of the digits of the number {num} is: {sumOfDigits}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input. Please enter an integer.");
            //        goto retry;
            //    }

            #endregion

            #region Q5 
            //5 - Create a function named "IsPrime", which receives an integer number and
            //retuns true if it is prime, or false if it is not:

            //Console.WriteLine(IsPrime(5));
            //Console.WriteLine(IsPrime(3));
            //Console.WriteLine(IsPrime(4));

            #endregion

            #region Q6 
            //6 - Create a function named MinMaxArray, to return the minimum and
            //maximum values stored in an array, using reference parameters

            //int[] numbers = { 3, 5, 1, 8, 2 };
            //MinMaxArray(ref numbers, out int min, out int max);
            //Console.WriteLine($"Minimum: {min}, Maximum: {max}"); // Output: Minimum: 1, Maximum: 8

            #endregion

            #region Q7 
            //7 - Create an iterative(non-recursive) function to calculate
            //the factorial of the number specified as parameter

            //Console.Write("Enter a number to calculate its factorial: ");
            //bool isValid = int.TryParse(Console.ReadLine(), out int number);
            //if (isValid && number >= 0)
            //{
            //    int result = factorial(number);
            //    Console.WriteLine($"The factorial of {number} is: {result}");
            //}



            #endregion

            #region Q8 
            //8 - Create a function named "ChangeChar" to modify a letter in a certain
            //position(0 based) of a string, replacing it with a different letter

            //Console.Write("Enter a string: ");
            //string inputString = Console.ReadLine()??"Test";
            //Console.Write("Enter the position of the character to change (0-based): ");
            //bool isValidPosition = int.TryParse(Console.ReadLine(), out int position);
            //Console.Write("Enter the new character: ");
            //char newChar = Console.ReadKey().KeyChar;
            //Console.WriteLine(); // Move to the next line after reading the character

            //Console.WriteLine(ChangeChar(inputString, position, newChar));

            #endregion
        }
    }
}
