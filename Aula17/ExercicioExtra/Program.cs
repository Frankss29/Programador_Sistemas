//EXERCÍCIOS 
//1. Preenchimento e Exibição 
//Crie uma matriz de inteiros 3x3. Peça ao utilizador para digitar os 9 números.
//No final, exiba a matriz no terminal no formato de tabela (linhas e colunas).

//Declaração de Matriz
/*int[,] tabela= new int[3,3];
//Declaração Variavel
int contador= 1;

Console.WriteLine("Digite 9 Números:\n"); //Titulo com quebra de linha

//Laço de Entrada (i = linha j=coluna)
//Preenchendo a linha
for(int i=0;i<3;i++)
{
    //Preenchendo a coluna
    for(int j=0; j<3; j++)
    {
      Console.Write($"Número {contador}°:");
      tabela[i,j]= int.Parse(Console.ReadLine());
      contador++;
    }
}

//Laço para exibir tabela
Console.WriteLine("\n------------\n");
Console.WriteLine($"   TABELA\n");

//Percorrer a linha 
for(int i=0; i<3; i++)
{
    //Percorrer a Coluna
    for(int j=0; j<3; j++)
    {
        Console.Write($"{tabela[i,j],4}");//reservar sempre 4 espaços para aquele número, alinhando-o à direita.
    }                                     //Assim, não importa se o número é 1 ou 99, ele ocupará o mesmo espaço na tabela.
    Console.WriteLine();
}*/

//==================================================================
//2. Soma de todos os Elementos 
//Crie uma matriz 2X2 de números reais (double ou float). Após o utilizador preencher
// a matriz, o programa deve calcular e exibir a soma total de todos os valores guardados nela.

//Declaração de Matriz
/* double[,]matriz= new double[2,2];
//Declaração Variavel
int contador=1;
double soma=0;

Console.WriteLine("Digite 4 Números:\n"); //Titulo com quebra de linha

//Laço de Entrada (i = linha j=coluna)
//Preenchendo a linha
for(int i=0;i<2;i++)
{
    //Preenchendo a coluna
    for(int j=0; j<2; j++)
    {
      Console.Write($"Número {contador}°:");
      matriz[i,j]= double.Parse(Console.ReadLine());
      contador++;
    }
}


//Titulo da Tabela
Console.WriteLine("\n------------\n");
Console.WriteLine($" RESULTADO DA SOMA   \n");

//Laço de saida 
//Soma dos valores 

for(int i=0; i<2; i++)
{
    for(int j=0; j<2; j++)
    {
        soma += matriz[i, j]; // Isto soma o valor da posição atual ao total
    }
}

Console.WriteLine($"    {matriz[0,0]}+{matriz[0,1]}+{matriz[1,0]}+{matriz[1,1]}={soma}");*/

//3. Substituição de Valores
//Crie uma matriz 4X4 e preencha-a com números inteiros aleatórios (ou peça ao utilizador). Depois, peça 
//um número "alvo". O programa deve percorrer a matriz e, onde encontrar um número negativo, 
//deve substituí-lo por zero. Exiba a matriz antes e depois da alteração.

//Declaração de Matriz
int[,]tabela = new int[4,4];
//Declaração de Variaveis
int contador = 1;

//Titulo
Console.WriteLine("Digite 16 Números:");


//Laço de Entrada
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write($"Número {contador}°:");
        tabela[i,j] = int.Parse( Console.ReadLine());
        contador++;
    }
}








//4. Localizador de Maior Valor
//Peça ao utilizador para preencher uma matriz 3x2 (3 linhas e 2 colunas). O seu programa deve
// identificar qual é o maior número digitado e informar em que linha e coluna ele se encontra
// (ex: "O maior valor é 10 e está na linha 1, coluna 0").

//5. Tabuada em Matriz
//Crie uma matriz 10x10 Preencha cada posição [i, j] com o resultado da multiplicação de (i + 1) * (j + 1).
// No final, terás uma tabela de tabuada completa do 1 ao 10 guardada numa matriz. Exiba-a de forma organizada.


//6-Contar números pares: Percorra uma matriz e conte quantos números são pares usando if/else.
//7-Soma da Diagonal Principal: Some apenas os elementos onde o índice da linha é igual ao da coluna.
//8-Identificar Matriz Identidade: Verifique se os elementos da diagonal são 1 e os outros são 0.
//7-Multiplicação de Matrizes: Crie um algoritmo que multiplique duas matrizes 2x2 (nível difícil).
