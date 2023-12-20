using ConsoleApp3;
using ConsoleApp3.TravelingStrategies;

namespace Travel

{
    class Program
    {

        static void Main(string[] args)
        {
             TravelPlanner travelPlanner = new TravelPlanner();

            Start:
            Console.WriteLine("Pick your vehicle");

            var key=Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.D1:
                    travelPlanner.SetTravelStrategy(new Car());
                    break;
                case ConsoleKey.D2:
                    travelPlanner.SetTravelStrategy(new Bus());
                    break;
                case ConsoleKey.D3:
                    travelPlanner.SetTravelStrategy(new Plane());
                    break;
                default:
                    Console.WriteLine("Select 1,2 or 3");
                    goto Start;
            }

            Console.WriteLine("Please enter kilometers you want to go");


            travelPlanner.Drive(int.Parse(Console.ReadLine()));

            Console.ReadKey();
            
           
        }



    }
}