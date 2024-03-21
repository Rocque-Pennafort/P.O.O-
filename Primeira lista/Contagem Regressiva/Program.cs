using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Por favor, informe o número para a contagem regressiva: ");
        int numero;

        while (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
        {
            Console.WriteLine("Erro: Digite um número inteiro positivo.");
        }

        for (int i = numero; i >= 0; i--)
        {
            Console.WriteLine(i);
        }
    }
}
