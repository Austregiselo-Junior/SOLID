using System;

namespace Interface_Segregation_Principle
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Aircrafit");
            var aircraft = new Aircraft();

            aircraft.Run();
            aircraft.Fly();

            Console.ReadLine();

            Console.WriteLine("Car");
            var car = new Car();

            car.Run(); // Só implemento a interface que preciso.

            Console.ReadLine();
        }
    }
}