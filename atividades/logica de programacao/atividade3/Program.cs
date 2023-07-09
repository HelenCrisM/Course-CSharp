// using System.IO;
// using System.Text.RegularExpressions;

// Exercicio 3 - Fazer um programa para ler quatro valores inteiros A, B, C e D. 
// A seguir, calcule e mostre a diferença do produto
// de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D)

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número A: ");
        int A = int.Parse(Console.ReadLine());

        Console.Write("Digite número B: ");
        int B = int.Parse(Console.ReadLine());
        
        Console.Write("Digite número C: ");
        int C = int.Parse(Console.ReadLine());

        Console.Write("Digite número D: ");
        int D = int.Parse(Console.ReadLine());
        DiferencaDoNumero(A, B, C, D);
    }

    static void DiferencaDoNumero(int A, int B, int C, int D) 
    {
        int diferenca = (A * B )-(C * D);
        Console.WriteLine("Diferença: " + diferenca);
    }
    
}