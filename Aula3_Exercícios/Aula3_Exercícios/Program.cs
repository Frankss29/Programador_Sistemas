//Exercícios If|Else com classe, metodo e etc

//Crie uma classe chamada Condicao

//using Aula3_Exercícios;

//Condicao valor=new Condicao();

//valor.ChamarValores();
//valor.Soma();

//Console.WriteLine(valor.Soma());

//if (valor.Soma()>=10)
//{
//    Console.WriteLine(valor.Soma()+5);
//}
//else
//{
//    Console.WriteLine(valor.Soma() - 7);
//}

//Exercícios
//Crie um programa em C# que:
//1.Declare uma variável para armazenar a nota de um aluno.
//2. Leia essa nota do teclado.
//3. Verifique se a nota é maior ou igual a 6.
//4. Exiba "Aluno aprovado!" se for verdade, ou "Aluno reprovado." caso contrário.


using Aula3_Exercícios;

//USANDO VOID
//Situacao avaliacao=new Situacao();
//avaliacao.ChamarNota();
//avaliacao.Nota(); 

//USANDO RETURN

Status avaliacao = new Status();
avaliacao.ChamarNota();

string resultado = avaliacao.Verificar();
Console.WriteLine(resultado);