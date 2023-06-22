using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número: ");
        int number = int.Parse(Console.ReadLine());

        NumPositivoNegativo(number);
    }

    static void NumPositivoNegativo(int numberParam) 
    {
        if (numberParam < 0) {
            Console.WriteLine("NEGATIVO");
        } else {
            Console.WriteLine("POSITIVO");
        }
        
        
    }
    
}