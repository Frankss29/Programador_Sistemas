using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    internal class Pet
    {
        public string Nome;
        public int Felicidade;

        public void Brincar()
        {
            Felicidade += 10;
            Console.WriteLine($"O {Nome} está feliz, nivel de {Felicidade}!");
            Console.WriteLine("   ____");
            Console.WriteLine(" C/    \\Ɔ");
            Console.WriteLine(" /  - O \\");
            Console.WriteLine("|    <   |");
            Console.WriteLine(" \\______/");



        }
    }
}
