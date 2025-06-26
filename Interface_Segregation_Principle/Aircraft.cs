using System;

namespace Interface_Segregation_Principle
{
    internal class Aircraft : IRunnable, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Aircraft Flying");
        }

        public void Run()
        {
            Console.WriteLine("Aircraft Running");
        }
    }
}