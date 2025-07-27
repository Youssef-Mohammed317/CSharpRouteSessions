using System.ComponentModel;

namespace CSharpRouteSessions
{
    #region Q1
    public enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    #endregion

    #region Q2
    public enum Season
    {
        Spring, 
        Summer,  
        Autumn,
        Winter
    }
    #endregion

    #region Q3
    [Flags]
    enum Permissions :byte
    {
        None = 0,     // 0000
        Read = 1,      // 0001
        Write = 2,     // 0010
        Delete = 4,    // 0100
        Execute = 8    // 1000
    }

    #endregion

    #region Q4
    public enum Colors
    {
        Red = 1,
        Green = 2,
        Blue = 4 
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //1 - Create an Enum called "WeekDays" with the days of the week(Monday to Sunday) as its members.Then,
            //write a C# program that prints out all the days of the week using this Enum.

            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(day);
            }


            #endregion

            #region Q2
            // 2-Create an Enum called "Season" with the four seasons
            // (Spring, Summer, Autumn, Winter) as its members.
            // Write a C# program that takes a season name as input from the user and
            // displays the corresponding month range for that season. Note range for seasons
            // ( spring march to may , summer june to august , autumn September to November , winter December to February)

            Console.WriteLine("Enter the season name (Spring, Summer, Autumn, Winter):");
            string input = Console.ReadLine();
            Season season;
            while(!Enum.TryParse(input, true, out season))
            {
                Console.WriteLine("Invalid season name. Please enter one of the following: Spring, Summer, Autumn, Winter.");
                input = Console.ReadLine();
            }

            switch(season)
            {
                case Season.Spring:
                    Console.WriteLine("Spring: March to May");
                    break;
                case Season.Summer:
                    Console.WriteLine("Summer: June to August");
                    break;
                case Season.Autumn:
                    Console.WriteLine("Autumn: September to November");
                    break;
                case Season.Winter:
                    Console.WriteLine("Winter: December to February");
                    break;
                default:
                    Console.WriteLine("Unknown season.");
                    break;
            }


            #endregion

            #region Q3
            //3 - Assign the following Permissions(Read, write, Delete, Execute) in a form of Enum           .
            //Create Variable from previous Enum to Add and Remove Permission from variable,
            //check if specific Permission existed inside variable

            Permissions prem = Permissions.None; // no permissions initially

            prem |= Permissions.Read; // Add Read permission
            prem |= Permissions.Write; // Add Write permission

            Console.WriteLine($"Current Permissions after adding read and write: {prem}");

            // remove Write permission
            prem &= ~Permissions.Write;

            Console.WriteLine($"Current Permissions after remove write: {prem}");

            // Check if Execute permission exists
            if((prem & Permissions.Execute) == Permissions.Execute)
            {
                Console.WriteLine("Execute permission is exist.");
            }
            else
            {
                Console.WriteLine("Execute permission is not exist.");
            }

            // Check if Read permission exists
            if((prem & Permissions.Read) == Permissions.Read)
            {
                Console.WriteLine("Read permission is exist.");
            }
            else
            {
                Console.WriteLine("Read permission is not exist.");
            }

            #endregion

            #region Q4
            // 4.Create an Enum called "Colors" with the basic colors (Red, Green, Blue) as its members.
            // Write a C# program that takes a color name as input from the user and
            // displays a message indicating whether the input color is a primary color or not.
            Console.WriteLine("Enter a color name (Red, Green, Blue):");
            string colorInput = Console.ReadLine();
            Colors color;
            while (!Enum.TryParse(colorInput, true, out color))
            {
                Console.WriteLine("Invalid color name. Please enter one of the following: Red, Green, Blue.");
                colorInput = Console.ReadLine();
            }
            switch(color)
            {
                case Colors.Red:
                case Colors.Green:
                case Colors.Blue:
                    Console.WriteLine($"{color} is a primary color.");
                    break;
                default:
                    Console.WriteLine($"{color} is not a primary color.");
                    break;
            }
            #endregion
        }
    }


}
