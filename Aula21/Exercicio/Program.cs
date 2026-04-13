//EXERCÍCIOS - CLASSES E OBJETOS

// Nivel: Fácil (Foco en Atributos e void)
//1) Despertador: Crie uma classe Alarme. Ela deve ter um
//atributo Hora (string). Crie un método void, e um método
//void Tocar() que imprime "Trimmm! O alarme das [Hora]
//está tocando!".

using Exercicio;
/*
Alarme meuAlarme = new Alarme();
meuAlarme.HoraDeAcordar();
meuAlarme.Hora=Console.ReadLine();
meuAlarme.Tocar();
*/

//2.0 Pet Virtual: Crie usa classe Pet con Nome e Felicidade (int). 
//Crie un método void Brincar() que aumenta a felicidade em 10 e imprime
//"0 [Nome] está feliz, nivel de [felicidade]!".

/*
 Pet meuPet = new Pet();
meuPet.Nome = Console.ReadLine();
meuPet.Felicidade= Convert.ToInt32(Console.ReadLine());
meuPet.Brincar();
*/


//Nivel: Médio(Foco es return e Paråsetres)
//Agora os objetos começam a processar dados e devolver respostas.
//0 Termômetro: Crie una classe Termosetro con un atributo Temperatura Celsius (double).
//Crie un método double Parafahrenheit() que faz o cálculo e retorna o valor convertido.
//Formula: F = (C*5) + 32.

Termometro meuTermometro=new Termometro();
meuTermometro.TemperaturaCelsius=Convert.ToDouble(Console.ReadLine());
meuTermometro.ParaFahrenheit();
