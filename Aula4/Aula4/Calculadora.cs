using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4
{
    internal class Calculadora
    {
        public int op, a, b;

        public string ChamarNumero()
        {
            Console.WriteLine("Digite um número:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("\n-----\n");

            Console.WriteLine("Digite outro número:");
            b = int.Parse(Console.ReadLine());
        }

        public int ChamarOperacao()
        {
            Console.WriteLine("Digite 1 para adição");
            Console.WriteLine("Digite 2 para subtração");
            Console.WriteLine("Digite 3 para multiplicação");
            Console.WriteLine("Digite 4 para divisão");
            op = int.Parse(Console.ReadLine());
        }
    }


}
