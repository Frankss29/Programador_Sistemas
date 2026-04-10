using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    internal class Alarme
    {
       public string Hora;

        public void HoraDeAcordar()
        {
           
            Console.WriteLine("Informe a Hora que quer acordar:");
            
        }

        public void Tocar()
        {
            Console.WriteLine($"Trimmmmm ! O alarme das {Hora} está tocando!");
            Console.WriteLine("  _ _ _ _ _ _");
            Console.WriteLine("|____________|");
            Console.WriteLine("|  __    __  |");
            Console.WriteLine("| |__ . |__| |");
            Console.WriteLine("| |__|. |__| |");
            Console.WriteLine("|____________|");
            Console.WriteLine(" /          \\");
           
        }
    }
}
