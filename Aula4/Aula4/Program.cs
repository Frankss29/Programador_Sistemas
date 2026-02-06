//Desenvolver um programa de computador que leia um valor numérico
//inteiro entre os valores 1 e 12 e apresentar por extenso o nome do
//mês correspondente ao valor de entrada. Caso sejam fornecidos
//valores menores que 1 e maior que 12, o programa deve apresentar a
//mensagem de "valor inválido".

//VARIÁVEIS

//int mes;

//Entrada
//mes=int.Parse(Console.ReadLine());


//Processamento

//switch(mes)
//{
//    case 1:
//        Console.WriteLine("Janeiro");
//        break;

//    case 2:
//        Console.WriteLine("Fevereiro");
//        break;

//    case 3: 
//        Console.WriteLine("Março");
//        break;

//    case 4:
//        Console.WriteLine("Abril");
//        break;

//    case 5:
//        Console.WriteLine("Maio");
//        break;

//    case 6:
//        Console.WriteLine("Junho");
//        break;

//    case 7:
//        Console.WriteLine("Julho");
//        break;

//    case 8:
//        Console.WriteLine("Agosto");
//        break;

//    case 9:
//        Console.WriteLine("Setembro");
//        break;

//    case 10:
//        Console.WriteLine("Outubro");
//        break;

//    case 11:
//        Console.WriteLine("Novembro");
//        break;

//    case 12:
//        Console.WriteLine("Dezembro");
//        break;
//    default:
//        Console.WriteLine("Mês Inválido");
//        break;

//}



//EXERCÍCIOS DE SWITCH CASE 
//Exercício 2: Operações matemáticas
//Enunciado
//Ler um caractere representando uma operação matemática:
//"1" para adição
//"2" para subtração
//"3" para multiplicação
//"4" para divisão
//Depois, ler dois números reais e aplicar a operação.
//Se o caractere for inválido, apresentar
//"Operação inválida".


//VARIÁVEIS

int operacao,a,b;


//Entrada
//Classe Calculadora
//Função ChamarNumero 
//Função Operação

Console.WriteLine("Digite 1 para adição");
Console.WriteLine("Digite 2 para subtração");
Console.WriteLine("Digite 3 para multiplicação");
Console.WriteLine("Digite 4 para divisão");
operacao=int.Parse(Console.ReadLine());

Console.WriteLine("\n-----\n");

Console.WriteLine("Digite um número:");
a=int.Parse(Console.ReadLine());

Console.WriteLine("\n-----\n");

Console.WriteLine("Digite outro número:");
b = int.Parse(Console.ReadLine());


//Processamento

switch (operacao)
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


