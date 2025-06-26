using System;

namespace Interface_Segregation_Principle
{
    internal class Car : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("Car Running");
        }
    }
}