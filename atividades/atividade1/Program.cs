
// Exercicio 1 - Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
// mensagem explicativa

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número: ");
        Double num1 = Double.Parse(Console.ReadLine());
        
        Console.Write("Digite outro número: ");
        Double num2 = Double.Parse(Console.ReadLine());
        SumFunction(num1,num2);

    }

    static void SumFunction(double num1, double num2) 
        {
            double sum = num1 + num2;
            Console.WriteLine("Soma = " + sum);
        }
}

