using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5
{
    internal class Contador
    {
        public int contador, num;

        public void Contagem()
        {
            contador = 1;
            while (contador <= 100)
            {
                Console.WriteLine(contador);
                contador++;
            }
        }

        public void Contar()

        {
            contador = 50;

            while (contador <= 100)
            {
                Console.WriteLine(contador);
                contador++;
            }
        }


        public void Regressiva()
        {
            contador = 10;


            while (contador >= 0)
            {
                Console.WriteLine(contador);
                contador--;
            }
            Console.WriteLine("Fogos");
        }

        public void ChamarContagem()
        {
            contador = 1;

            Console.WriteLine("Escreva um número positivo");
            num = int.Parse(Console.ReadLine());

            while (contador <= num)
            {
                Console.WriteLine(contador);
                contador++;
            }
        }

    }

    
}
