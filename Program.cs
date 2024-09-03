using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int numero;
        while (true)
        {
            Console.Write("Digite um número: ");
            try
            {
                numero = Convert.ToInt32(Console.ReadLine());
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: entrada inválida. Por favor, digite um número.");
            }
        }

        if (VerificaNumeroNaSequencia(numero))
        {
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");
        }
    }

    public static bool VerificaNumeroNaSequencia(int numero)
    {
        
        List<int> sequencia = Fibonacci(numero);
        return sequencia.Contains(numero);
    }

    public static List<int> Fibonacci(int numero)
    {
        
        List<int> sequencia = new List<int> { 0, 1 };
        while (sequencia[sequencia.Count - 1] < numero)
        {
            sequencia.Add(sequencia[sequencia.Count - 1] + sequencia[sequencia.Count - 2]);
        }
        return sequencia;
    }
}