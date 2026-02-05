using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3_Exercícios
{
    internal class Situacao
    {
        double nota;
   

    public void ChamarNota()
        {
            Console.WriteLine("Informe a nota do aluno: ");
            nota = double.Parse(Console.ReadLine());
        }

         public void Nota()
        {

            if (nota >= 6)
            {
                Console.WriteLine("Aluno Aprovado");
            }

            else
            {
                Console.WriteLine("Aluno Reprovado");
            }

        }
    }
}
