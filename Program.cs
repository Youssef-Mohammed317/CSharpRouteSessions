namespace Second_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Define Class Maths that has four methods:
            ●	Add()
            ●	Subtract()
            ●	Multiply()
            ●	Divide()
            Each of them takes two parameters. Call each method in Main().
            NOTE : Modify the program so that you do not have to create an instance of class to call the four methods.
            */
            Console.WriteLine($"Add:{MathOperations.Add(10, 12)}");
            Console.WriteLine($"Subtract:{MathOperations.Subtract(10, 12)}");
            Console.WriteLine($"Multiply:{MathOperations.Multiply(10, 12)}");
            Console.WriteLine($"Divide:{MathOperations.Divide(10, 12)}");
            Console.WriteLine($"Divide:{MathOperations.Divide(10, 0)}");
        }
    }
}
