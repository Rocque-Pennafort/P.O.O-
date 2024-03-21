using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Digite números inteiros (insira um número negativo para encerrar):");

        int numero;
        int soma = 0;
        int quantidadeNumeros = 0;

        do {
            Console.Write("Digite um número: ");
            if (int.TryParse(Console.ReadLine(), out numero)) {
                if (numero >= 0) {
                    soma += numero;
                    quantidadeNumeros++;
                }
            } else {
                Console.WriteLine("Entrada inválida. Insira um número inteiro válido.");
            }
        } while (numero >= 0);

        if (quantidadeNumeros > 0) {
            double media = (double)soma / quantidadeNumeros;
            Console.WriteLine($"Números positivos inseridos: {quantidadeNumeros}");
            Console.WriteLine($"Soma dos números positivos: {soma}");
            Console.WriteLine($"Média dos números positivos: {media:F2}");
        } else {
            Console.WriteLine("Nenhum número positivo foi inserido.");
 }
}
}