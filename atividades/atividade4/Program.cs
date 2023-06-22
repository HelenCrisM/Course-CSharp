// using System.IO;
// using System.Text.RegularExpressions;

// Exercicio 3 - Fazer um programa que leia o número de um funcionário, seu número de horas 
// trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário.
//  A seguir, mostre o número e o salário do funcionário, com duas casas decimais.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o número do funcionário: ");
        double numeroFuncionario = Double.Parse(Console.ReadLine());

        Console.Write("Digite seu número de horas trabalhadas: ");
        double numeroHorasTrabalhadas = Double.Parse(Console.ReadLine());
        
        Console.Write("Digite o valor que recebe por hora: ");
        double valorRecebidoPorHora = Double.Parse(Console.ReadLine());

        SalarioDoFuncionario(numeroFuncionario, numeroHorasTrabalhadas, valorRecebidoPorHora);
    }

    static void SalarioDoFuncionario(double numeroFuncionarioParam, double numeroHorasTrabalhadasparam, double valorRecebidoPorHora) 
    {
        double salario = valorRecebidoPorHora * numeroHorasTrabalhadasparam;
        double salarioRound = Math.Round(salario, 3);
        Console.WriteLine("Numero: " + numeroFuncionarioParam);
        Console.WriteLine("Salário: R$ " + salarioRound);
    }
    
}