using System;

namespace Liskov_Substitution_Principle
{
    internal class Onibus : Veiculo
    {
        public void DriveOnibus() => Console.WriteLine("Dirigindo Onibus");
    }
}