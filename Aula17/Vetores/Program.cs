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

//Declaração da Matriz com 3 linhas(pessoas) 3 colunas(Nome, CPF, Bairro)

string[,] agenda = new string[3, 3]; //[ , ] indica que é bidimensional.
int i;
//LAÇO DE CADASTRO(Preenchimento)

Console.WriteLine("==== Cadastro de 3 Pessoas ======");

for (i=0; i<3; i++) //Este FOR vai rodar 3 vezes, uma para cada pessoa. O i é o índice da linha atual.
{
    Console.WriteLine($"Pessoa {i + 1}°");
    Console.Write("Nome:");
    //Guarda o Nome na coluna 0 da linha atual.
    agenda[i, 0] = Console.ReadLine();
    Console.Write("CPF:");
    // Guarda o CPF na coluna 1 da linha atual.
    agenda[i, 1] = Console.ReadLine(); 

    Console.Write("Bairro:");
    //Guarda o Bairro na coluna 2 da linha atual.
    agenda[i, 2] = Console.ReadLine();
    Console.WriteLine("\n------------\n");
}

//MOSTRAR TABELA

Console.WriteLine($"   TABELA DE CADASTRO  ");
Console.WriteLine("Nome\tCPF\tBairro");

for (i = 0; i < 3; i++)
{
 
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"{agenda[i, j],6}");//reservar sempre 4 espaços para aquele número, alinhando-o à direita.
    }                                     
    Console.WriteLine();
}


//for (int i = 0; i < 3; i++)

//{
//    Console.WriteLine($"\n Pessoa {i + 1}:");
//    Console.WriteLine($"Nome:{agenda[i, 0]}\t");
//    Console.WriteLine($"CPF:{agenda[i, 1]}\t");
//    Console.WriteLine($"Bairro:{agenda[i, 2]}\t");

//}

Console.WriteLine("\n------------\n");

//SISTEMA DE PESQUISA (CPF)
Console.WriteLine("Pesquisa por CPF:");
string procuraCPF = Console.ReadLine();
bool encontrado = false;

Console.WriteLine("\n------------\n");

for ( i = 0; i < 4; i++)
{
    if (agenda[i, 1] == procuraCPF)
    {
        encontrado = true;
        break;
    }
    if (encontrado) break;

}
if (encontrado == true)
{
    Console.WriteLine($"Nome: {agenda[i,0]}");
    Console.WriteLine($"CPF : {agenda[i, 1]}");
    Console.WriteLine($"Bairro : {agenda[i, 2]}");
}
else
{
    Console.WriteLine("Não Cadastrado");
}









//SISTEMA DE PESQUISA POR QUALQUER CAMPO:
//================================================================
/*//LAÇO DE BUSCA
Console.WriteLine("Busque por Nome, CPF ou Bairro:");
//Lê o que o usuário quer encontrar (pode ser qualquer um dos dados).
string dadoProcurado = Console.ReadLine(); 
bool encontrado = false; // Começa como falso e só vira verdade se acharmos o que buscamos.

// Percorrendo as LINHAS
//Compara o conteúdo da célula atual [i, j] com o que foi digitado.
for (int i = 0; i < 3; i++)
    // Percorrendo as Colunas NOME,CPF, BAIRRO
    //Laço Interno: Controla qual coluna estamos verificando dentro daquela linha.
    for (int j = 0; j < 3; j++) 
    {

        if (agenda[i, j] == dadoProcurado) 
        {
            encontrado = true; //Se você achou o dadoProcurado na coluna 1, não precisa perder tempo olhando o bairro na coluna 2.
            break;//Sai do laço das colunas (não precisa olhar o resto da linha se já achou o dado nela).
        }
    }

    if (encontrado) break;// Este segundo break sai do laço das linhas.
}

//// fora dos laços, verificamos o resultado

if (encontrado)
{
    Console.WriteLine("Encontrado com sucesso!");
}
else
{
    Console.WriteLine("Não Foi Encontrado em nenhum registro.");
}

*/

