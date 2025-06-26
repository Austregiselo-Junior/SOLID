using System;

namespace Liskov_Substitution_Principle
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Testando carro");
            var car = new Carro();
            TesteDriver(car);
            Console.ReadLine();

            Console.WriteLine("Testando onibus");
            var bus = new Onibus();
            TesteDriver(bus);
            Console.ReadLine();

            Console.WriteLine("Testando Veiculo");
            var veiculo = new Veiculo();
            TesteDriver(veiculo); // Aqui provamos a substituição que dá certo por conta que TesteDriver recebe veiculo que pode receber carro e onibus porque herdam de veiculo.
            Console.ReadLine();
        }

        private static void TesteDriver(Veiculo veiculo)
        {
            if (veiculo is Carro)
            {
                var car = new Carro();
                car.DriveCarro();
            }
            else if (veiculo is Onibus)
            {
                var bus = new Onibus();
                bus.DriveOnibus();
            }
            else veiculo.Drive();
        }
    }
}