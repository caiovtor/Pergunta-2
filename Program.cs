using System;

class Program
{
    // Função para calcular a sequência de Fibonacci até o n-ésimo termo
    static int[] Fibonacci(int n)
    {
        int[] fibonacciSequence = new int[n];
        fibonacciSequence[0] = 0;
        fibonacciSequence[1] = 1;

        for (int i = 2; i < n; i++)
        {
            fibonacciSequence[i] = fibonacciSequence[i - 1] + fibonacciSequence[i - 2];
        }

        return fibonacciSequence;
    }

    // Função para verificar se um número pertence à sequência de Fibonacci
    static bool VerificarSePertence(int num, int[] fibonacciSequence)
    {
        foreach (int termo in fibonacciSequence)
        {
            if (num == termo)
            {
                return true;
            }
        }
        return false;
    }

    static void Main()
    {
        Console.Write("Informe um número para verificar se pertence à sequência de Fibonacci: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        // Calcula a sequência de Fibonacci até um número arbitrariamente grande
        int[] sequenciaFibonacci = Fibonacci(100);

        // Verifica se o número informado pertence à sequência de Fibonacci
        bool pertence = VerificarSePertence(numero, sequenciaFibonacci);

        if (pertence)
        {
            Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
        }
    }
}
