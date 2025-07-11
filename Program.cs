namespace CSharpRouteSessions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            // 1.Write a program that allows the user to enter a number then print it.
            //Console.WriteLine("Please enter a number:");
            //float.TryParse(Console.ReadLine(), out float number);
            //Console.WriteLine($"You entered: {number}");
            #endregion

            #region Q2
            // 2.Write C# program that converts a string to an integer, but the string contains
            // non-numeric characters. And mention what will happen
            // string str1 = "123abc",str2 = "1b2a3";

            // Console.WriteLine(Convert.ToInt32(str1)); // System.FormatException
            // Console.WriteLine(Convert.ToInt32(str2)); // System.FormatException
            #endregion

            #region Q3
            //3.Write C# program that Perform a simple arithmetic operation with
            //floating-point numbers And mention what will happen

            //double num1 = 5.5,num2 = 3.3;

            //Console.WriteLine(num1 + num2); // 8.8
            //Console.WriteLine(num1 - num2); // 2.2
            #endregion

            #region Q4
            //4.Write C# program that Extract a substring from a given string.
            //string str = "Hello, World!",str2 = "123abc";

            //string substring = str.Substring(7, 5); // Extracts "World" // from index 7, length 5

            //Console.WriteLine($"Extracted substring: {substring}"); // Output: Extracted substring: World

            //int num = Convert.ToInt32(str2.Substring(0, 3));
            //Console.WriteLine(num); // Output: 123
            #endregion

            #region Q5
            //5.Write C# program that Assigning one value type variable to another and
            //modifying the value of one variable and mention what will happen

            //int a = 10;
            //int b = a; // b is assigned the value of a
            //a = 30; // modifying a not affect b

            //Console.WriteLine("a is ",a," and b is ",b); // Output: a is 30 and b is 10
            #endregion

            #region Q6
            //6.Write C# program that Assigning one reference type variable to another and
            //modifying the object through one variable and mention what will happen
            //int[] arr = { 1, 2, 3 };

            //int[] arr2 = arr; // arr2 is a reference to the same array as arr

            //arr[0] = 10; // modifying arr will affect arr2 since they reference the same array

            //Console.WriteLine("arr[0] is " + arr[0] + " and arr2[0] is " + arr2[0]); // Output: arr[0] is 10 and arr2[0] is 10
            #endregion

            #region Q7
            //7.write C# program that take two string variables and print them as one variable 
            //Console.Write("Enter The First String: ");
            //string firstString = Console.ReadLine() ?? "str1";
            //Console.Write("Enter The Second String: ");
            //string secondString = Console.ReadLine() ?? "str2";

            //string combinedString1 = firstString + " " + secondString; // Concatenating the two strings with a space in between
            //string combinedString2 = string.Concat(firstString, " ", secondString); // Using string.Concat to combine the strings
            //string combinedString3 = $"{firstString} {secondString}"; // Using string interpolation to combine the strings
            //string combinedString4 = string.Join(" ", firstString, secondString); // Using string.Join to combine the strings with a space
            //string combinedString5 = string.Format("{0} {1}", firstString, secondString); // Using string.Format to combine the strings

            //Console.WriteLine($"Comined 1 : ",combinedString1);
            //Console.WriteLine($"Comined 2 : ",combinedString2);
            //Console.WriteLine($"Comined 3 : ",combinedString3);
            //Console.WriteLine($"Comined 4 : ",combinedString4);
            //Console.WriteLine($"Comined 5 : ",combinedString5);
            #endregion

            #region Q8
            //8.Write a program that calculates the simple interest given the principal amount, rate of interest, and time. 
            //Note: The formula for simple interest is Interest = (principal * rate * time) / 100.
            //Console.WriteLine("Enter the data:");
            //Console.Write("The Principal is:");
            //float.TryParse(Console.ReadLine(), out float principal);
            //Console.Write("The Rate is:");
            //float.TryParse(Console.ReadLine(), out float rate);
            //Console.Write("The Time is:");
            //float.TryParse(Console.ReadLine(), out float time);

            //float interest = (principal * rate * time) / 100;
            //Console.WriteLine($"The Simple Interest is: {interest}");
            #endregion

            #region Q9
            //9.Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. 
            //Note: The formula for BMI is BMI = (Weight) / (Height * Height)
            //Console.WriteLine("Enter The Data:");
            //Console.Write("The Weight in KG is: ");
            //float.TryParse(Console.ReadLine(), out float weight);
            //Console.Write("The Height in M is: ");
            //float.TryParse(Console.ReadLine(), out float height);
            //float bmi = weight / (height * height);
            //Console.WriteLine($"The Body Mass Index (BMI) is: {bmi}");
            #endregion

            #region Q10
            //10.Write a program that uses the ternary operator to check if the temperature is too hot,
            //too cold, or just good. Assign the result in a variable then display the result. 
            //Note:
            //a.that below 10 degrees is "Just Cold"
            //b.above 30 degrees is "Just Hot"
            //c.anything else is "Just Good"

            //Console.Write("Enter The Temperature :");
            //float.TryParse(Console.ReadLine(), out float temp);
            //string result = temp < 10 ? "Just Cold" : (temp > 30 ? "Just Hot" : "Just Good");
            //Console.WriteLine("The Result is ",result);
            #endregion

            #region Q11
            //11.Write a program that takes the date from the user and displays it in various formats using string interpolation.
            //Ex:
            //Today’s date : 20 , 11 , 2001
            //Today's date : 20 / 11 / 2001
            //Today's date : 20 – 11 – 2001

            //Console.WriteLine("Enter The Date:");
            //bool dayFlag = int.TryParse(Console.ReadLine(), out int day);
            //Console.WriteLine("Enter The Month:");
            //bool monthFlag = int.TryParse(Console.ReadLine(), out int month);
            //Console.WriteLine("Enter The Year:");
            //bool yearFlag = int.TryParse(Console.ReadLine(), out int year);

            // Protective if statements to ensure valid input and stop the program if any input is invalid
            //if (!dayFlag || day < 1 || day > 31 || !monthFlag || month < 1 || month > 12 || !yearFlag || year < 1)
            //{
            //    Console.WriteLine("Invalid Input");
            //    return;
            //}
            // protective and to correctly handle the case of invalid dates
            //month = month > 12 ? 12 : month < 1 ? 1 : month; // Ensure month is within valid range
            //day = day > 31 ? 31 : day < 1 ? 1 : day; // Ensure day is within valid range
            //year = year < 1 ? 1 : year; // Ensure year is a positive number
            //// from github copilot
            //if (month == 2 && day > 29) // February can have a maximum of 29 days in a leap year
            //{
            //    day = 29;
            //}
            //else if ((month == 4 || month == 6 || month == 9 || month == 11) && day > 30) // April, June, September, November have a maximum of 30 days
            //{
            //    day = 30;
            //}

            //string date1 = $"{day}, {month}, {year}";
            //string date2 = $"{day}/{month}/{year}";
            //string date3 = $"{day} - {month} - {year}";

            //Console.WriteLine($"Today's date : {date1}");
            //Console.WriteLine($"Today's date : {date2}");
            //Console.WriteLine($"Today's date : {date3}");
            #endregion

            #region Q12
            //Write a program that takes a number from the user then print yes
            //if that number can be divided by 3 and 4 otherwise print no.
            //Example(1)
            //Input: 12
            //Output: Yes
            //Example(2)
            //Input: 9
            //Output: No

            //Console.Write("Enter A Number:");
            //int.TryParse(Console.ReadLine(), out int number);

            //string result = (number % 3 == 0 && number % 4 == 0) ? "Yes" : "No";
            //Console.WriteLine($"The Result is: {result}");

            //string result2 = number switch
            //{
            //    int when number % 3 == 0 && number % 4 == 0 => "Yes",
            //    _ => "No"
            //};
            //Console.WriteLine($"The Result using switch is: {result2}");

            //string result3 = number switch
            //{
            //    _ when number % 3 == 0 && number % 4 == 0 => "Yes",
            //    _ => "No"
            //};
            //Console.WriteLine($"The Result using switch with when is: {result3}");
            #endregion

            #region Q13
            //13 - Write a program that allows the user to insert an integer then
            //print negative if it is negative number otherwise print positive.
            //Example(1)
            //Input: -5
            //Output: negative
            //Example(2)
            //Input: 10
            //Output: positive
            //Console.WriteLine("Enter An Integer Number");
            //Console.Write("Input: ");
            //bool userInputFlag = int.TryParse(Console.ReadLine(), out int userInput);
            //if (!userInputFlag)
            //{
            //    Console.WriteLine("Invalid Input");
            //    return;
            //}
            //string result = userInput < 0 ? "negative" : "positive";

            //Console.WriteLine($"Output: {result}");
            #endregion

            #region Q14
            //14 - Write a program that takes 3 integers from the user then prints the max element and the min element.
            //Example(1)
            //Input: 7,8,5
            //Output:
            //max element = 8
            //min element = 5
            //------------------------------
            //Example(2)
            //Input: 3 6 9
            //Outputs:
            //Max element = 9
            //Min element = 3
            //Console.WriteLine("Enter 3 Numbers");
            //Console.Write("Number 1: ");
            //bool num1Flag = int.TryParse(Console.ReadLine(), out int num1);
            //Console.Write("Number 2: ");
            //bool num2Flag = int.TryParse(Console.ReadLine(), out int num2);
            //Console.Write("Number 3: ");
            //bool num3Flag = int.TryParse(Console.ReadLine(), out int num3);
            //if (!num1Flag || !num2Flag || !num3Flag)
            //{
            //    Console.WriteLine("Invalid Input");
            //    return;
            //}
            //int max = num1;
            //int min = num1;

            //if(num2 > max) max = num2;
            //if(num2 < min) min = num2;

            //if(num3 > max) max = num3;
            //if(num3 < min) min = num3;
            //Console.WriteLine("max element = " + max);
            //Console.WriteLine("min element = " + min);


            // if it an array and you want to find the max and min in a more generic way
            //int[] numbers = { 1,2,3,10,5,6,17 };

            //int maxElement = numbers[0];
            //int minElement = numbers[0];
            //foreach (int number in numbers)
            //{
            //    if (number > maxElement) maxElement = number;
            //    if (number < minElement) minElement = number;
            //}
            //Console.WriteLine($"Max element = {maxElement}");
            //Console.WriteLine($"Min element = {minElement}");
            #endregion

            #region Q15
            //15 - Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //Console.WriteLine("Enter An Intger Number");
            //Console.Write("Input: ");
            //bool isValidInput = int.TryParse(Console.ReadLine(), out int userNumber);
            //if (!isValidInput)
            //{
            //    Console.WriteLine("Invalid Input");
            //    return;
            //}
            //string evenOrOdd = userNumber % 2 == 0 ? "even" : "odd";
            //Console.WriteLine($"Output: {evenOrOdd}");
            #endregion

            #region Q16
            //16 - Write a program that takes character from the user then
            //if it is a vowel chars(a, e, I, o, u) then print(vowel) otherwise print(consonant).
            //Example(1)
            //Input: O
            //Output: vowel
            //Example(2)
            //Input: b
            //Output: Consonant

            //Console.WriteLine("Enter A Character:");
            //Console.Write("Input: ");
            //bool isValidChar = char.TryParse(Console.ReadLine(), out char userChar);

            //if (!isValidChar)
            //{
            //    Console.WriteLine("Invalid Input");
            //    return;
            //}
            /*
             preferred to convert the character to lower or upper case
             */
            //userChar = char.ToLower(userChar); // or char.ToUpper(userChar);
            // to avoid checking both cases separately

            // method 1: using switch
            //string result1 = userChar switch
            //{
            //    'a' or 'A' or 'e' or 'E' or 'i' or 'I' or 'o' or 'O' or 'u' or 'U' => "vowel",
            //    _ => "consonant"
            //};
            //string result2;
            //switch (userChar)
            //{
            //    case 'a':
            //    case 'A':
            //    case 'e':
            //    case 'E':
            //    case 'i':
            //    case 'I':
            //    case 'o':
            //    case 'O':
            //    case 'u':
            //    case 'U':
            //        result2 = "vowel";
            //        break;
            //    default:
            //        result2 = "consonant";
            //        break;
            //}

            //// method 2: using if-else
            //string result3 = "consonant";
            //if (userChar == 'a' || userChar == 'A' ||
            //    userChar == 'e' || userChar == 'E' ||
            //    userChar == 'i' || userChar == 'I' ||
            //    userChar == 'o' || userChar == 'O' ||
            //    userChar == 'u' || userChar == 'U')
            //{
            //    result3 = "vowel";
            //}
            //// method 3: using array and Contains
            //char[] vowelsArray = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            //string result4 = Array.Exists(vowelsArray, element => element == userChar) ? "vowel" : "consonant";

            //// method 4: using linear search with LINQ (Linear Query)
            //char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            //bool Flag = false;

            //foreach (char vowel in vowels)
            //{
            //    if (userChar == vowel)
            //    {
            //        Flag = true;
            //        break;
            //    }
            //}
            //string result5 = Flag ? "vowel" : "consonant";

            //// printing the results
            //Console.WriteLine($"Output using switch: {result1}");
            //Console.WriteLine($"Output using switch with case: {result2}");
            //Console.WriteLine($"Output using if-else: {result3}");
            //Console.WriteLine($"Output using array and Contains: {result4}");
            //Console.WriteLine($"Output using LINQ: {result5}");
            #endregion

            #region Q17
            //17 - Write a program to input the month number and print the number of days in that month.
            //Example
            //Input: Month Number: 1
            //Output: Days in Month: 31

            //Console.WriteLine("Enter The Month Number (1-12):");
            //Console.Write("Input: Month Number: ");
            //bool isValidMonth = int.TryParse(Console.ReadLine(), out int monthNumber);
            //if (!isValidMonth || monthNumber < 1 || monthNumber > 12)
            //{
            //    Console.WriteLine("Invalid Input");
            //    return;
            //}
            //int daysInMonth;
            //switch (monthNumber)
            //{
            //    case 1: // January
            //    case 3: // March
            //    case 5: // May
            //    case 7: // July
            //    case 8: // August
            //    case 10: // October
            //    case 12: // December
            //        daysInMonth = 31;
            //        break;
            //    case 4: // April
            //    case 6: // June
            //    case 9: // September
            //    case 11: // November
            //        daysInMonth = 30;
            //        break;
            //    case 2: // February
            //        daysInMonth = 28; // Not considering leap years for simplicity
            //        break;
            //    default:
            //        daysInMonth = 0; // This should never happen due to previous validation
            //        break;
            //}
            //Console.WriteLine($"Output: Days in Month: {daysInMonth}");

            //// other way using switch expression
            //int daysInMonth2 = monthNumber switch
            //{
            //    1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
            //    4 or 6 or 9 or 11 => 30,
            //    2 => 28, // Not considering leap years for simplicity
            //    _ => throw new ArgumentOutOfRangeException("Invalid month number") // not expected to reach here due to previous validation
            //};
            //Console.WriteLine($"Output using switch expression: Days in Month: {daysInMonth2}");

            #endregion


        }

    }
}
