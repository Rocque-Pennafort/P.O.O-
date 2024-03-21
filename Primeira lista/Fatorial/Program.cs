using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Por favor, informe o número para calcular seu fatorial: ");
        int numero;

        while (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
        {
            Console.WriteLine("Erro: Digite um número inteiro positivo.");
        }

        long fatorial = 1;
        for (int i = numero; i > 1; i--)
        {
            fatorial *= i;
        }

        Console.WriteLine($"O fatorial de {numero} é {fatorial}");
    }
}
