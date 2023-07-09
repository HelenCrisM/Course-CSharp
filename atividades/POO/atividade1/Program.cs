
// Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais
// velha.


using System;

class Program
{
  static void Main(string[] args)
  {
    Pessoa pessoa1 = new Pessoa();
    Pessoa pessoa2 = new Pessoa();

    Console.Write("Digite um nome: ");
    pessoa1.Name = Console.ReadLine();

    Console.Write("Digite a idade da pessoa : ");
    pessoa1.Age = int.Parse(Console.ReadLine());

    Console.Write("Digite outro nome: ");
    pessoa2.Name = Console.ReadLine();

    Console.Write("Digite a idade da pessoa : ");
    pessoa2.Age = int.Parse(Console.ReadLine());

    if (pessoa1.Age > pessoa2.Age) 
    {
      Console.WriteLine("Pessoa mais velha: " + pessoa1.Name);
    }
    else 
    {
      Console.WriteLine("Pessoa mais velha: " + pessoa2.Name);
    }
   
  }
}