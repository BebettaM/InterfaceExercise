using System;
namespace InterfaceExercise
{
	public class SUV : IVehicle, ICompany
	{
		public SUV()
		{
		}

        public double EngineSize { get ; set ; }
        public string Make { get ; set ; }
        public string Model { get ; set ; }
        public int SeatCount { get ; set ; }
        public bool HasChangeGears { get ; set ; }
        public string CompanyName { get ; set ; }
        public string Motto { get ; set ; }

        public void Drive()
        {
            if (HasChangeGears == true)
            {
                Console.WriteLine($"{GetType().Name} now driving to the garage...");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} now it's driving away...");
            }
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
                Console.WriteLine("It stop reversing");
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
                Console.WriteLine("It's not in parking anymore");
            }
        }

        public void ChangeGears(bool isChanged)
        {
            HasChangeGears = isChanged;
        }
    }
}

