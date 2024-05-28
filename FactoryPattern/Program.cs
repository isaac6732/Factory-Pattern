namespace FactoryPattern
{


	public class Program
	{
		static void Main(string[] args)
		{
			bool continueCreating = true;

			while (continueCreating)
			{
				Console.WriteLine("Enter the number of tires for the vehicle:");
				if (int.TryParse(Console.ReadLine(), out int numberOfTires))
				{
					try
					{
						IVehicle myVehicle = VehicleFactory.GetVehicle(numberOfTires);
						myVehicle.Drive();
					}
					catch (ArgumentException ex)
					{
						Console.WriteLine(ex.Message);
					}
				}
				else
				{
					Console.WriteLine("Please enter a valid number.");
				}
                Console.WriteLine();
                Console.WriteLine("Do you want to create another vehicle? (yes/no)");
                string userResponse = Console.ReadLine().ToLower();
				continueCreating = userResponse == "yes";
				Console.WriteLine();
			}
		}
	}

}
