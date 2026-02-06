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

        public void  ChamarNumero()
        {
            Console.WriteLine("Digite um número:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("\n-----\n");

            Console.WriteLine("Digite outro número:");
            b = int.Parse(Console.ReadLine());
        }

        public void ChamarOperacao()
        {
            Console.WriteLine("Digite 1 para adição");
            Console.WriteLine("Digite 2 para subtração");
            Console.WriteLine("Digite 3 para multiplicação");
            Console.WriteLine("Digite 4 para divisão");
            op = int.Parse(Console.ReadLine());
        }

        public void FazerCalculo()
        {
            switch (op)
            {
                case 1:
                    Console.WriteLine(a + b);
                    break;
                case 2:
                    Console.WriteLine(a - b);
                    break;
                case 3:
                    Console.WriteLine(a * b);
                    break;
                case 4:
                    Console.WriteLine(a / b);
                    break;
                default:
                    Console.WriteLine("Operação Inválida");
                    break;
            }

        }
    }


}
