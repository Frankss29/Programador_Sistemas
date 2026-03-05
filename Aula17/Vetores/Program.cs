//VETORES 
//Elaborar um programa que efetue a leitura de dez nomes
//de pessoas em uma matriz "A" do tipo vetor e apresentá-los
//em seguida.

////Instaciamento
//string[]A=new string[10];


////Entrada
//Console.WriteLine("Escreva Dez Nomes:");
//for (int i=0; i<A.Length; i++)
//{
//   A[i]=Console.ReadLine();
//}

////Saida
//for (int i=0; i<A.Length; i++)
//{
//    Console.WriteLine($"Nome {i+1}: {A[i]}");
//}


//Elabora um programa que leia oito elementos inteiros em
//uma matriz A do tipo vetor. Construir uma matriz B de mesma
//dimensão com os elementos da matriz A múltiplicados por 3.
//0 elemento B[1] deve ser igual a A[1]*3, o elemento B[2]
//deve ser igual a A[2]*3, ou seja B[i] = A[i]*3.
//A presentar a matriz B.

//int[]A=new int[8];
//int[]B=new int[8];

////Entrada
//Console.WriteLine("Escreva Oito Números Inteiros:");

//for (int i = 0; i < A.Length; i++)
//{
//    A[i] = int.Parse(Console.ReadLine());
//}

//Console.WriteLine("\n---------------\n");

//Console.WriteLine("Resultado:");

//Console.WriteLine("\n \n");

//for (int i = 0;i < B.Length;i++)
//{

//    Console.WriteLine($"{A[i]} x 3 = {B[i] = A[i]*3} ");
//}

//

//string[]nomes = new string[5];

//for (int i = 0; i < nomes.Length; i++)
//{
//    Console.WriteLine($"Cadastre o {i+1}° nome:");
//    nomes[i]=Console.ReadLine();
//}

//Console.WriteLine("Escreva um nome e veja se esta no nosso cadastro");
//string nomeProcurado = Console.ReadLine();

//for(int i = 0;i < nomes.Length;i++)
//{
//    if(nomes[i] == nomeProcurado)
//    {
//        Console.WriteLine("Nome Encontrado");
//        break;//Acho pode para a busca
//    }
//    else
//    {
//        Console.WriteLine("Não Foi Encontrado");
//        break;
//    }

//}


//////////MATRIZES BIDIMENCIONAIS

string[,] agenda = new string[3, 3];

Console.WriteLine("==== Cadastro de 3 Pessoas");

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Pessoa {i+1}");
    Console.WriteLine("Nome:");
    agenda[i, 0] = Console.ReadLine();

    Console.WriteLine("CPF:");
    agenda[i, 1] = Console.ReadLine();

    Console.WriteLine("Bairro:");
    agenda[i, 2] = Console.ReadLine();
    Console.WriteLine("\n------------\n");
}


for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"\n Pessoa {i+1}:");
    Console.WriteLine($"Nome:{agenda[i,0]}");
    Console.WriteLine($"CPF:{agenda[i,1]}");
    Console.WriteLine($"Bairro:{agenda[i,2]}");

}


/// Não ta certo ainda 
Console.WriteLine("\n Busque por Nome, CPF ou Bairro e veja se esta no nosso cadastro");
string dadoProcurado = Console.ReadLine();
bool encontrado = false;

for (int i = 0; i < 3; i++)
{
    if (agenda[i,i] == dadoProcurado)
    {
        Console.WriteLine("Encontrado");
        encontrado = true;
        break;//Acho pode para a busca
    }
    else
    {
        Console.WriteLine("Não Foi Encontrado");
        encontrado= false;
        break;
    }

}