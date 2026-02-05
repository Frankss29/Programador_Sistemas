using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2
{
    internal class Media
    {
        public double  N1, N2, N3, RMedia;
        public string Nome;

       

        public void ChamarNome()
        {
            Console.WriteLine("Escreva seu Nome:");
            Nome = Console.ReadLine();
        }

        public void ChamarNota() 
        {

            Console.WriteLine("Digite sua Nota 1:");
            N1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua Nota 2:");
            N2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua Nota 3 :");
            N3 = double.Parse(Console.ReadLine());

            

        }

        public void ChamarMedia()
        {

            RMedia =( N1 + N2 + N3) / 3;
            Console.WriteLine( Nome + " sua média é " + RMedia);
        }
    }
}
