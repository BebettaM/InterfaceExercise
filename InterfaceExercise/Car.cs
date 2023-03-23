using System;
namespace InterfaceExercise
{
	public class Car : IVehicle , ICompany
	{
		public Car()
		{
		}

        public double EngineSize { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int SeatCount { get; set; }
        public string CompanyName { get; set; }
        public string Motto { get; set; }
        public bool HasChangeGears { get; set; }


        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving forward...");
        }
        public void Reverse()
        {
            if (HasChangeGears == true)
            {
                Console.WriteLine($"{GetType().Name} now it's reversing...");
                HasChangeGears = false;

            }
            else

            {
                Console.WriteLine("Can't reverse until we change gears");
            }

        }
        

        public void Park()
        {
            if (HasChangeGears == true)
            {
                Console.WriteLine($"{GetType().Name} now in park...");
                HasChangeGears = false;

            }
            else

            {
                Console.WriteLine("Can't park until we change gears");
            }
        }

        public void ChangeGears (bool isChanged)
        {
            HasChangeGears = isChanged;
        }
    }
}

