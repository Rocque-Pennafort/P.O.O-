using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Olá, por favor, digite abaixo as informações do produto para registro: ");
        Console.WriteLine();

        Console.WriteLine("Código do produto: ");
        int codigo;
        while (!int.TryParse(Console.ReadLine(), out codigo))
        {
            Console.WriteLine("Erro: Digite um número inteiro válido para o código do produto.");
        }
        Console.WriteLine();

        Console.WriteLine("Nome do produto: ");
        string nome = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("Preço do produto: ");
        decimal preco;
        while (!decimal.TryParse(Console.ReadLine(), out preco))
        {
            Console.WriteLine("Erro: Digite um valor numérico válido para o preço.");
        }
        Console.WriteLine();

        Console.WriteLine("Quantidade do produto: ");
        int quantidade;
        while (!int.TryParse(Console.ReadLine(), out quantidade))
        {
            Console.WriteLine("Erro: Digite um número inteiro válido para a quantidade.");
        }
        Console.WriteLine();

        Console.WriteLine("Produto cadastrado com sucesso!");
        Console.WriteLine($"Código: {codigo}");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Preço: {preco:C}");
        Console.WriteLine($"Quantidade: {quantidade}");
    }
}