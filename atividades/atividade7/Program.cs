﻿

// Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
// X, se for o caso.

using System;

class Program
{
  static void Main(string[] args)
  {
    Console.Write("Digite um número: ");
    int number = int.Parse(Console.ReadLine());

    for (int i = 0; i < number; i++) 
    {
      if (i % 2 == 1) {
        Console.WriteLine(i);
      }
    }
  }
}