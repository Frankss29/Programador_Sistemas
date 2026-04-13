using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3_Exercícios
{
    internal class Status
    {
        double nota;
        public void ChamarNota()
        {
            Console.WriteLine("Informe a nota do aluno: ");
            nota = double.Parse(Console.ReadLine());
        }

        public string Verificar()
        {
            if (nota >= 6)
            {
                return "Aluno Aprovado";
            }
            else
            {
                return "Aluno Reprovado";
            }

        }
    }
}
