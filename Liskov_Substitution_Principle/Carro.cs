using System;

namespace Liskov_Substitution_Principle
{
    internal class Carro : Veiculo
    {
        public void DriveCarro() => Console.WriteLine("Dirigindo um carro");
    }
}