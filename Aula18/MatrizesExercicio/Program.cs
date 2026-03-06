//Exercício
//Desenvolver um programa em C# que simule o cadastro de
//3 veículos em uma locadora. Cada veículo deve ter:
//Placa, Modelo, Ano e Valor da diária
//Após o cadastro, o programa deve permitir consultar os veículo

////Declarar Matriz
//string[,] locadora = new string[3, 4];
////Declaração de Variaveis
//int contador=1;
//int i;

//Console.WriteLine("===== CADASTRO DE VEÍCULO =====\n");

////LAÇO DE ENTRADA

//    for ( i = 0; i < 3; i++)
//    {

//            Console.Write($"Cadastro de Carro {contador}°:\n");
//            Console.Write($"Placa:");
//            locadora[i, 0] = Console.ReadLine();
//            Console.Write($"Modelo:");
//            locadora[i, 1] = Console.ReadLine();
//            Console.Write($"Ano:");
//            locadora[i, 2] = Console.ReadLine();
//            Console.Write($"Valor da diária:");
//            locadora[i, 3] = Console.ReadLine();
//            contador++;

//            Console.Write("\n----------------\n");


//    }

//Console.Write("Buscar Placa do Veículo:\n");

//string procuraPlaca = Console.ReadLine();
//bool encontrado = false;

//Console.WriteLine("\n------------\n");

//for (  i = 0; i < 3; i++)
//{
//    if (locadora[i, 0] == procuraPlaca)
//    {
//        encontrado = true;
//        break;
//    }
//    if (encontrado) break;

//}
//if (encontrado == true)
//{
//    Console.WriteLine("Veículo Encontrado:");
//    Console.WriteLine($"Placa: {locadora[i,0]}");
//    Console.WriteLine($"Modelo : {locadora[i,1]}");
//    Console.WriteLine($"Ano : {locadora[i,2]}");
//    Console.WriteLine($"Valor da diária : {locadora[i,3]}");
//}
//else
//{
//    Console.WriteLine(" Carro não Encontrado");
//}

//==========================================

/*Exercício 2
Desenvolver um programa em C# que simule o cadastro de 3 produtos em um mercado. Cada produto deve ter:
Nome, Código de barras, Preço e Quantidade em estoque Após o cadastro, o programa deve permitir consultar os produtos
pelo código de barras e exibir todas as informações.
Faça o sistema de pesquisa sequencial pelo código de barras;*/

////Declarar Matriz
//string[,] produto = new string[3, 4];
////Declaração de Variaveis
//int contador = 1;
//int i;

//Console.WriteLine("===== CADASTRO DE PRODUTO =====\n");

////LAÇO DE ENTRADA

//for (i = 0; i < 3; i++)
//{

//    Console.Write($"Cadastro de Produto {contador}°:\n");
//    Console.Write($"Nome:");
//    produto[i, 0] = Console.ReadLine();
//    Console.Write($"Código de barras:");
//    produto[i, 1] = Console.ReadLine();
//    Console.Write($"Preço:");
//    produto[i, 2] = Console.ReadLine();
//    Console.Write($"QTD. em Estoque:");
//    produto[i, 3] = Console.ReadLine();
//    contador++;

//    Console.Write("\n----------------\n");


//}

//Console.Write("Buscar Código de Barras:\n");

//string procuraProduto = Console.ReadLine();
//bool encontrado = false;

//Console.WriteLine("\n------------\n");

//for (i = 0; i < 3; i++)
//{
//    if (produto[i, 1] == procuraProduto)
//    {
//        encontrado = true;
//        break;
//    }
//    if (encontrado) break;

//}
//if (encontrado == true)
//{
//    Console.WriteLine("Produto Encontrado:");
//    Console.WriteLine($"Nome: {produto[i, 0]}");
//    Console.WriteLine($"Código de barras : {produto[i, 1]}");
//    Console.WriteLine($"Preço : {produto[i, 2]}");
//    Console.WriteLine($"QTD. em estoque : {produto[i, 3]}");
//}
//else
//{
//    Console.WriteLine(" Produto não Encontrado");
//}


//===================================
//0 que é uma List? 

//É uma lista dinâmica, ou seja, um espaço na memória onde você pode: 
//-adicionar itens
//- remover itens
//- acessar por índice 
//crescer e diminuir automaticamente 
//Ela funciona como um Array, só que melhor. 

List<string> nomes = new List<string>();

/*
 * List<string> lista de textos
 * nomes - nome da variável
 * New List<string> () - Cria a lista*/

//Adicionar informações 
nomes.Add(Console.ReadLine());
nomes.Add(Console.ReadLine());
nomes.Add(Console.ReadLine());
nomes.Add(Console.ReadLine());

//Mostrar Dados
Console.WriteLine("Nomes Digitados:");
//Console.WriteLine(nomes[0]);
//Console.WriteLine(nomes[1]);

//Mostrar todos  de uma vez
foreach (string s  in nomes)
{
    Console.WriteLine(s);
}

//string - tipo de dado da list
//nomeVariavel - nome que você dá para cada item
// lista- sua List, array, etc.


//Removendo itens
nomes.Remove("Senac"); //Remove pelo valor
nomes.RemoveAt(0);// remove pelo indice ou posição