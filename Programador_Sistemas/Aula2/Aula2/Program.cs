//AULA II - CLASSES E OBJETOS
//EXERCÍCIOS 
//Ler uma temperatura em grau Celsius e apresenta-la  convertida 
//em  graus Fahrenheit. A formula da conversão é F=C*9/5+32, 
//Sendo F a temperatura em Fahrenheit e C a temperatura em Celsius.

using Aula2;

//Temperatura z=new Temperatura();

//Console.WriteLine("Qual a temperatura em Celsius:");
//z.tempC = double.Parse(Console.ReadLine());
//z.tempF = (z.tempC * 9 / 5) + 32;

//Console.WriteLine("A temperatura em Fahrenheit é: " + z.tempF);


//---------------------------------------------------------

// FUNÇÃO | MÉTODO
//METODO VOID

//Função para somar dois valores 

//static void Soma(int a, int b)
//{
//    int soma = a + b;
//    Console.WriteLine(soma);

//}

//Soma(5, 3);
//Soma(6, 4);
//Soma(7, 5);

//Média de 3 notas, o usuario colocará o seu nome e suas notas
//e o programa mostrará o resultado;


//INSTANCIAMENTO

Media media = new Media();

media.ChamarNome();

media.ChamarNota();

media.ChamarMedia();