//AULA III - FUNÇÃO E MÉTODO 
//Criar uma função que só imprime valores

//static void Imprimir(int a, int b)
//{
//    int soma = a + b;    
//    Console.WriteLine(soma);
//}

//Imprimir(7, 4);

//Console.WriteLine(Imprimir(7, 4) + 3);

//static int Imprimir(int a, int b)
//{
//    return a + b;
//}

//Console.WriteLine(Imprimir(7, 4) + 3);


//Crie um método que peça um nome e idade(não usar parametros),
//mostre na tela, sem retorno;

//static void PedirDados()
//{
//    Console.WriteLine("Escreva seu nome:");
//    string nome=Console.ReadLine();
//    Console.WriteLine("Escreva sua idade");
//    string idade=Console.ReadLine();

//    Console.WriteLine($" Olá {nome} sua idade é { idade}");
//}

//   PedirDados();


//IF | ELSE (Estruturas)

// Vamos criar um programa que nos diga se(IF) 
// o carro é novo ou velho, pelo ano de fabricação
// se for acima de 2020 é novo senão(ELSE) é velho.

//Variáveis
//int ano;

////Entrada de dados
//Console.WriteLine("Escreva o ano do seu carro");
//ano =int.Parse(Console.ReadLine());

////Processo

//if (ano > 2020)
//{
//    Console.WriteLine("Carro Novo");
//}
//else
//{
//    Console.WriteLine("Carro Antigo");


//Crie um programa que peça dois números para o usuário.
//Depois de receber esses dois valores, o programa deve
//somar os dois. Se essa soma for maior ou igual a 10,
//o programa deve adicionar 5 ao resultado.Mas se a soma
//for menor que 10, o programa deve tirar 7 do resultado.
//No final, o programa mostra esse novo valor na tela.

//Variáveis
int a, b, soma;

//Entrada de dados

Console.WriteLine("Escreva um número");
a = int.Parse(Console.ReadLine());

Console.WriteLine("Escreva um número");
b = int.Parse(Console.ReadLine());

soma = a + b;

if (soma >= 10)
{
    int resultado;
    resultado = soma + 5;
    Console.WriteLine(resultado);

}
else
{
    int resultado;
    resultado = soma -7;
    Console.WriteLine(resultado);
}
