using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5
{
    internal class Tabuada
    {
        public int numeroUser, count, resultado;

        public void ChamarTabuada()
        {
            Console.WriteLine("Digite um número inteiro: ");
            numeroUser = int.Parse(Console.ReadLine());

            Console.WriteLine("\n-----\n");

            while (count <= 10)
            {
                resultado = numeroUser * count;
                Console.WriteLine(numeroUser + " x " + count + " = " + resultado);
                count++;
            }
        }




    }
}
