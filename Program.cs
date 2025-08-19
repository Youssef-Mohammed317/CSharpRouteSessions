using System.Drawing;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First Project
            //1.Define 3D Point Class and the basic Constructors(use chaining in constructors).
            //2.Override the ToString Function to produce this output:
            //            Point3D P = new Point3D(10, 10, 10);
            //            Console.WriteLine(P.ToString());
            //        Output: “Point Coordinates: (10, 10, 10)”.
            //3.Read from the User the Coordinates for 2 points P1, P2(Check the input using try Pares, Parse, Convert).
            //4.Try to use  ==
            //If(P1 == P2)   Does it work properly? 
            //5.Define an array of points and sort this array based on X &Y coordinates.
            //6.Implement ICloneable interface to be able to clone the object.
            #endregion
            #region Q1,2
            //Point3D P = new Point3D(10, 10, 10);
            //Console.WriteLine(P.ToString());
            #endregion

            #region Q3
            //Point3D P1 = new Point3D();
            //Point3D P2 = new Point3D();
            #region Get Data using try parse
            //bool flag = false;
            //double coordinate;
            //do
            //{
            //    Console.Write("Enter X for Point 1:");
            //    flag = double.TryParse(Console.ReadLine(), out coordinate);
            //    if (flag) P1.X = coordinate;
            //} while (!flag);
            //flag = false;
            //do
            //{
            //    Console.Write("Enter Y for Point 1:");
            //    flag = double.TryParse(Console.ReadLine(), out coordinate);
            //    if (flag) P1.Y = coordinate;
            //} while (!flag);
            //flag = false;
            //do
            //{
            //    Console.Write("Enter X for Point 2:");
            //    flag = double.TryParse(Console.ReadLine(), out coordinate);
            //    if (flag) P2.X = coordinate;
            //} while (!flag);
            //flag = false;
            //do
            //{
            //    Console.Write("Enter Y for Point 2:");
            //    flag = double.TryParse(Console.ReadLine(), out coordinate);
            //    if (flag) P2.Y = coordinate;
            //} while (!flag);
            #endregion

            #region Get Data using Parse
            //bool flag = false;
            //double coordinate;
            //do
            //{
            //    Console.Write("Enter X for Point 1:");
            //    try
            //    {

            //        coordinate = double.Parse(Console.ReadLine() ?? "");
            //        P1.X = coordinate;
            //        flag = true;
            //    } catch(FormatException ex)
            //    {
            //        Console.WriteLine($"Error:{ex.Message}");
            //    }

            //} while (!flag);
            //flag = false;
            //do
            //{
            //    Console.Write("Enter Y for Point 1:");
            //    try
            //    {

            //        coordinate = double.Parse(Console.ReadLine() ?? "");
            //        P1.Y = coordinate;
            //        flag = true;
            //    }
            //    catch (FormatException ex)
            //    {
            //        Console.WriteLine($"Error:{ex.Message}");
            //    }
            //} while (!flag);
            //flag = false;
            //do
            //{
            //    Console.Write("Enter X for Point 2:");
            //    try
            //    {

            //        coordinate = double.Parse(Console.ReadLine() ?? "");
            //        P2.X = coordinate;
            //        flag = true;
            //    } catch(FormatException ex)
            //    {
            //        Console.WriteLine($"Error:{ex.Message}");
            //    }

            //} while (!flag);
            //flag = false;
            //do
            //{
            //    Console.Write("Enter Y for Point 2:");
            //    try
            //    {

            //        coordinate = double.Parse(Console.ReadLine() ?? "");
            //        P2.Y = coordinate;
            //        flag = true;
            //    }
            //    catch (FormatException ex)
            //    {
            //        Console.WriteLine($"Error:{ex.Message}");
            //    }
            //} while (!flag);
            #endregion

            #region Get Data using Convert
            //bool flag = false;
            //double coordinate;
            //do
            //{
            //    Console.Write("Enter X for Point 1:");
            //    try
            //    {

            //        coordinate = Convert.ToDouble(Console.ReadLine() ?? "");
            //        P1.X = coordinate;
            //        flag = true;

            //    }
            //    catch (FormatException ex)
            //    {
            //        Console.WriteLine($"Error:{ex.Message}");
            //    }

            //} while (!flag);
            //flag = false;
            //do
            //{
            //    Console.Write("Enter Y for Point 1:");
            //    try
            //    {

            //        coordinate = Convert.ToDouble(Console.ReadLine() ?? "");
            //        P1.Y = coordinate;
            //        flag = true;
            //    }
            //    catch (FormatException ex)
            //    {
            //        Console.WriteLine($"Error:{ex.Message}");
            //    }
            //} while (!flag);
            //flag = false;
            //do
            //{
            //    Console.Write("Enter X for Point 2:");
            //    try
            //    {

            //        coordinate = Convert.ToDouble(Console.ReadLine() ?? "");
            //        P2.X = coordinate;
            //        flag = true;
            //    }
            //    catch (FormatException ex)
            //    {
            //        Console.WriteLine($"Error:{ex.Message}");
            //    }

            //} while (!flag);
            //flag = false;
            //do
            //{
            //    Console.Write("Enter Y for Point 2:");
            //    try
            //    {

            //        coordinate = Convert.ToDouble(Console.ReadLine() ?? "");
            //        P2.Y = coordinate;
            //        flag = true;
            //    }
            //    catch (FormatException ex)
            //    {
            //        Console.WriteLine($"Error:{ex.Message}");
            //    }
            //} while (!flag);
            #endregion
            #endregion

            #region Q4
            // condition is false, Before Overload operator == && != because it compares references which points to 2 different objects 
            //if (P1 == P2) Console.WriteLine("Equals");
            //else Console.WriteLine("Not Equals"); 
            #endregion


            #region Q5
            //Point3D[] points =
            //{
            //    new Point3D(2,2,4),
            //    new Point3D(1,1,2),
            //    new Point3D(2,3,3),
            //};

            //Array.Sort(points,new Point3DComparer());

            //foreach (Point3D point in points)
            //{
            //    Console.WriteLine(point);
            //}
            #endregion
            #region Q6
            //Point3D P3 = (Point3D)P1.Clone();
            //Console.WriteLine(P1);
            //Console.WriteLine(P2);
            #endregion
        }
    }
}
