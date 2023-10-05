namespace OOP___Arv_övning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();
            myCar.Model = "BMW M3";
            myCar.Year = "2023";
            myCar.SetMileage(1000);
            myCar.Seats = 5;
            myCar.Doors = 4;
            myCar.PrintInfo();
        }
    }
}