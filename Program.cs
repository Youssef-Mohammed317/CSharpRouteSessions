using System.ComponentModel;

namespace CSharpRouteSessions
{
    internal class Program
    {
        #region Q1
        internal struct Person
        {
            public string Name {  get; set; } // auto prop
            public int Age { get; set; }
        }
        #endregion

        #region Q2
        internal struct Point 
        {
            public float X { get; set; }
            public float Y { get; set; }
        }

        #endregion

        #region Q3
        // done before
        #endregion

        #region Q4
        internal struct Rectangle {
            private double width;
            private double height;

            // full prop
            public double Width { 
                set {
                    if (value < 0) Console.WriteLine("Error Data Input");
                    else width = value;
                    
                } 
            }
            public double Height { 
                set {
                    if (value < 0)
                    {
                        Console.WriteLine("Error Data Input");
                    }
                    else
                    { 
                        height = value;
                    }
                } 
            }

            public double Area { 
                get
                {
                    return width * height;
                } 
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"Rectangle's Width:{this.width} Height:{this.height} Area:{this.Area}");
            }
        }

        #endregion
        static void Main(string[] args)
        {

            #region Q1
            //1.	Define a struct "Person" with properties "Name" and "Age".
            //Create an array of three "Person" objects and populate it with data.
            //Then, write a C# program to display the details of all the persons in the array. 

            Person[] people = new Person[3];
            people[0] = new Person { Name = "Ahmed", Age = 20 };
            people[1] = new Person { Name = "Yasser", Age = 22 };
            people[2] = new Person { Name = "Mohammad", Age = 24 };

            foreach(Person per in people)
            {
                Console.WriteLine($"Person Name : {per.Name}, Age : {per.Age}");
            }

            #endregion

            #region Q2
            //2.	Create a struct called "Point" to represent a 2D point with properties "X" and   "Y".
            //Write a C# program that takes two points as input from the user and calculates the distance between them.

            Point point01 = new Point();
            Point point02 = new Point();

            for (int i = 0; i < 4; i++)
            {
                do
                {
                    char msg = i % 2 == 0 ? 'x' : 'y';
                    int p = i switch
                    {
                        0 => 1,
                        1 => 1,
                        2 => 2,
                        3 => 2,
                        _ => throw new NotImplementedException(),
                    };

                    Console.Write($"Enter {msg} axis for point {p} : ");
                    float num;
                    if (float.TryParse(Console.ReadLine(), out num)) switch (i) 
                        { 
                            case 0: point01.X = num; break;
                            case 1: point01.Y = num; break;
                            case 2: point02.X = num; break;
                            case 3: point02.Y = num; break;
                        }
                    else i--; 
                 
                    break;
                } while (true);
            }

            float dx = (point01.X - point02.X);
            float dy = (point01.Y - point02.Y);

            Console.WriteLine($"Distance is {Math.Sqrt((Math.Pow(dx, 2) + Math.Pow(dy, 2)))}");
            #endregion

            #region Q3
            //3.	Create a struct called "Person" with properties "Name" and "Age".
            //Write a C# program that takes details of 3 persons as input from the user and
            //displays the name and age of the oldest person.

            // struct done

            Person[] people1 = new Person[3];

            for (int i = 0; i < people1.Length; i++)
            {
                people1[i] = new Person();
                Console.Write($"Enter Name Of Person {i + 1}:");
                people1[i].Name = Console.ReadLine() ?? "Un Known";
                do
                {
                    Console.Write($"Enter Age Of Person {i + 1}:");
                    int age;
                    if (int.TryParse(Console.ReadLine(), out age))
                    {

                        if(age > 0)
                        {
                            people1[i].Age = age;
                            break;
                        }
                    }
                } while (true);
            }
            int oldest = 0;
            for (int i = 1; i < people1.Length; i++) {
                if (people1[oldest].Age < people1[i].Age)
                {
                    oldest = i;
                }
            }

            Console.WriteLine($"Person Number {oldest + 1 } is the oldest with Name:{people1[oldest].Name} and Age:{people1[oldest].Age}");

            #endregion


            #region Q4
            //4.Create a struct named Rectangle that represents a rectangle with the following fields:
            //width (type: double)
            //height (type: double)

            //Implement encapsulation by making the fields private and provide public properties  access and modify these values. Ensure the following conditions are met:
            //The width and height should not be negative. If a negative value is provided, the setter should not update the field and should instead print an error message.
            //Implement a public read-only property Area that calculates and returns the area of the rectangle (Area = width * height).

            //Implement a method DisplayInfo that prints the rectangle's dimensions and area.
            //Write a program to demonstrate the usage of this struct by creating an instance, setting values via properties, and displaying the area.
            Rectangle rectangle = new Rectangle(); //creating an instance
            rectangle.Width = 10;
            rectangle.Height = 20;
            //rectangle.Area = 20; // gives error
            rectangle.Width = -10; // print message
            Console.WriteLine($"Area is{rectangle.Area}");
            rectangle.DisplayInfo();

            #endregion


        }
    }
}
