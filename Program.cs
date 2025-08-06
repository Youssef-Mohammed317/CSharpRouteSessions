namespace CSharpRouteSessions
{
    internal class Program
    {
        //static public void MoveWithSpeed(Car car,double speed)
        //{
        //    car.Move(speed);
        //}
        //static public void MoveWithSpeed(Plane plane,double speed)
        //{
        //    plane.Move(speed);
        //}
        //static public void MoveWithSpeed(Bike bike,double speed)
        //{
        //    bike.Move(speed);
        //}
        static public void MoveWithSpeed(Vehicle vehicle, double speed)
        {
           vehicle.Move(speed);
        }
     
        static void Main(string[] args)
        {

            //MoveWithSpeed(new Car(), 200);
            //MoveWithSpeed(new Plane(), 200);
            //MoveWithSpeed(new Bike(), 200);

            Vehicle vehicle = new Car();

            Vehicle vehicle2 = new Plane();

            Car car = new Car();

            vehicle.Move(200); 

            car.Move(200);

            vehicle2.Move(200); 

        }
    }
}
