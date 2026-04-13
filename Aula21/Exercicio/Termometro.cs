using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    internal class Termometro
    {
        public double TemperaturaCelsius;

        public double ParaFahrenheit()
        {
            double Fahrenheit = (TemperaturaCelsius * 9/5) + 32;
            Console.WriteLine($"Temperatura em Fahrenheit: {Fahrenheit}º");
            Console.WriteLine("  _ ");
            Console.WriteLine(" | |");
            Console.WriteLine(" | |  100");
            Console.WriteLine(" | |");
            Console.WriteLine(" |*|  50");
            Console.WriteLine(" |*|");
            Console.WriteLine(" |*|  0");
            Console.WriteLine("/ * \\");
            Console.WriteLine("|***|");
            Console.WriteLine("\\___/");


            return Fahrenheit;

        }
    }
}
