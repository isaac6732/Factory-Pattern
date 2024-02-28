namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello what type of vehicle you whant to make Car/Motarcycle");
            string userInput = Console.ReadLine();

            VehicleFactory factory = new VehicleFactory();
            IVehicle myCar = factory.CreateVehicle(userInput);

            myCar.Drive();

            Console.WriteLine("Whant to make another vehicle");
            userInput = Console.ReadLine();
        }
    }
}
