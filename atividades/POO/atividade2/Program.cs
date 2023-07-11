
using System;

class Program
{
  static void Main(string[] args)
  {
    Funcionario funcionario1 = new Funcionario();

    Console.Write("Nome: ");
    funcionario1.Nome = Console.ReadLine();

    Console.Write("Salário bruto: ");
    funcionario1.SalarioBruto = double.Parse(Console.ReadLine());

    Console.Write("Imposto: ");
    funcionario1.Imposto = double.Parse(Console.ReadLine());

    string salarioLiquido = funcionario1.SalarioLiquido().ToString();

    Console.WriteLine("Funcionário: " + funcionario1.Nome + ", R$ " + salarioLiquido);

    Console.Write("Digite a porcentagem para aumentar o salário: ");
    double porcentagem = double.Parse(Console.ReadLine());


    Console.WriteLine("Dados atualizados: " + funcionario1.Nome + ", R$ " + funcionario1.AumentarSalario(porcentagem));

   
  }
}