using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3_Exercícios
{
    internal class Condicao
    {
        int a, b;

        public void ChamarValores()
        {
            Console.WriteLine("Escreva um número: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva outro número: ");
            b = int.Parse(Console.ReadLine());
        }

        public int Soma()
        {
            return a+b;
        }

    }




}
