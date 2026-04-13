//SOMAR DOIS NÚMEROS

//DECLARAÇÃO DE VARIÁVEIS | ENTRADA

//Instanciamento (CHAMAR AS VARIÁVEIS)

//using Aula1_Revisão;

//Soma x = new Soma();

//Console.WriteLine("Digite um número inteiro: ");
//x.a= int.Parse(Console.ReadLine());

//Console.WriteLine("Digite outro número inteiro: ");
//x.b = int.Parse(Console.ReadLine());

////PROCESSAMENTO
//x.resultado = x.a + x.b;

////SAIDA
//Console.WriteLine("O resultado da soma é: " + x.resultado);


////EXERCÍCIO
//// Escreva um programa que peça uma altura em metros e converta para cm.

//DECLARAÇÃO DE VARIÁVEIS(ATRIBUTOS)

using Aula1_Revisão;

Converter y = new Converter();

//ENTRADA
Console.WriteLine("Digite sua altura em Metros:");
y.alturaM = double.Parse(Console.ReadLine());


//PROCESSAMENTO
y.converter = y.alturaM * 100;


//SAIDA
Console.WriteLine("Sua altura em Centimetros: " + y.converter);

//===============================================================

