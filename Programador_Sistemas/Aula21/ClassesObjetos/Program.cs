// AULA 21 - Classes e Objetos

using ClassesObjetos;

/*Cachorro meuCachorro = new Cachorro();
meuCachorro.Nome = Console.ReadLine();
meuCachorro.Latir();*/


Calculos meuCalculo = new Calculos();
meuCalculo.A = Convert.ToDouble(Console.ReadLine());
meuCalculo.B = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine(meuCalculo.SomarSEMretorno());
Console.WriteLine(meuCalculo.SomarCOMretorno());


