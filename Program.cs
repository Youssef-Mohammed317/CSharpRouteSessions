namespace CSharpRouteSessions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Struct
            //Point p1; // clr will 8 uninitialized bytes at stack 
            ////Console.WriteLine(p1.x); // x is unassigned so throws an error

            //p1 = new Point(); // new Just for constructor that will initialize the struct [paramerer less constructor]
            //// there is default constructor for structs that initializes all fields to their default values


            //Console.WriteLine($"x: {p1.x}, y: {p1.y}"); // x: 10, y: 20 // default values set by the constructor


            //p1 = new Point(11); // x and y will be initialized to 11

            //Console.WriteLine($"x: {p1.x}, y: {p1.y}"); // x: 11, y: 11

            //p1 = new Point(11, 22); // x and y will be initialized to 11 and 22 respectively

            //Console.WriteLine($"x: {p1.x}, y: {p1.y}"); // x: 11, y: 22

            //Console.WriteLine(p1); // CSharpRouteSessions.Point
            //Console.WriteLine(p1.ToString()); // CSharpRouteSessions.Point

            ////after overriding ToString method

            //Console.WriteLine(p1); // Point [x=11, y=22]
            //Console.WriteLine(p1.ToString()); // Point [x=11, y=22]

            //Point p2 = new Point(10, 20);

            //Console.WriteLine(p2); // Point [x=10, y=20]
            //Console.WriteLine(p1); // Point [x=11, y=22]

            //p2 = p1; // copy the value of p1 to p2

            //Console.WriteLine(p2); // Point [x=11, y=22]
            //Console.WriteLine(p1); // Point [x=11, y=22]

            //p2.x = 100; // change the value of x in p2

            //Console.WriteLine(p2); // Point [x=100, y=22]
            //Console.WriteLine(p1); // Point [x=11, y=22] // p1 is not changed because structs are value types 
            #endregion

            #region Encapsulation
            //Employee employee = new Employee(); // default constructor will initialize the properties to their default values
            //Employee employee = new Employee(1, "John Doe", 50000m); // parameterized constructor


            //Employee employee = new Employee()
            //{
            //    Id = 1,
            //    Name = "John Doe",
            //    Salary = 50000m
            //}; // using object initializer syntax with public properties only

            //Employee employee = new Employee(id: 1,salary: 50000m,name: "John Doe"); // named parameters in constructor call

            ////employee.Id = 2; // setting the Id property will work if the property is public

            ////Console.WriteLine(employee.Id); // get the Id property will work if the property is public

            //// for encapsulation, we can make the properties private and provide public methods to access them
            //employee.SetName("Jane Doe2"); // using setter method to set the name
            //Console.WriteLine(employee.GetName()); // using getter method to get the name

            //Employee employee1 = new Employee(2, "Jane Doe", 60000m); // create another employee object

            //employee.salary = 70000m; // using property to set the salary
            //Console.WriteLine(employee.salary); // using property to get the salary


            #endregion

            #region indexer
            PhoneNoteBook pnb = new PhoneNoteBook(2);
            pnb.AddPerson(0, "Alice", 1234567890);
            pnb.AddPerson(1, "Bob", 1236543210);


            // using getter method and setter method
            //Console.WriteLine(pnb.GetNumber("Bob"));
            //pnb.SetNumber("Bob", 1876543210);
            //Console.WriteLine(pnb.GetNumber("Bob"));

            // using indexer
            Console.WriteLine(pnb["Bob"]); // get the number of Bob
            pnb["Bob"] = 1876543210; // set the number of Bob
            Console.WriteLine(pnb["Bob"]); // get the number of Bob after setting it
            #endregion
        }
    }
}
