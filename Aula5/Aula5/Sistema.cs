using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5
{
    internal class Sistema
    {

        public void Cadastro()
        {
            while (true)
            {
                Console.WriteLine("== Sistema ==");
                Console.WriteLine("(1) Cadastro");
                Console.WriteLine("(2) Login");
                Console.WriteLine("(0) Sair");
                Console.WriteLine("Escolha");
                int op =int.Parse(Console.ReadLine());  

                switch(op)
                {
                    case 1:
                        Console.WriteLine("Função Cadastro");
                        break;
                    case 2:
                        Console.WriteLine("Função Login");
                        break;
                    case 0:
                        Console.WriteLine("Função Sair");
                        return;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
                Console.WriteLine("Pressione ENTER para continuar...");
                Console.ReadLine();

                Console.Clear();
            }
        }
    }
}
