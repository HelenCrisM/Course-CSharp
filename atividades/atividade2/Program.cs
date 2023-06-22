using System.IO;
using System.Text.RegularExpressions;

// Exercicio 2 - Faça um programa para ler o valor do raio de um círculo, 
// e depois mostrar o valor da área deste círculo com quatro casas decimais conforme exemplos.
// Fórmula da área: area = π . raio2
// Considere o valor de π = 3.14159

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o valor do raio do circulo: ");
        Double raio = Double.Parse(Console.ReadLine());
        
        ValorAreaCirculo(raio);
    }

    static void ValorAreaCirculo(double raioParam) 
    {
        double pi = 3.14159;
        double area = pi * (raioParam * raioParam);
        double areaRound = Math.Round(area, 4);
        Console.WriteLine("Area: " + areaRound);
    }
    
}