using System;

class Program
{
    public static void Main(string[] args)
    {
        double SomadasNotas = 0;
        Console.WriteLine("Por favor, informe a quantidade de disciplinas cursadas: ");
        int QuantidadeDisciplinas;

        while (!int.TryParse(Console.ReadLine(), out QuantidadeDisciplinas) || QuantidadeDisciplinas <= 0)
        {
            Console.WriteLine("Erro: Digite um número inteiro positivo para a quantidade de disciplinas.");
        }

        for (int i = 0; i < QuantidadeDisciplinas; i++)
        {
            Console.Write($"Informe a nota da disciplina {i + 1}: ");
            double NotaDisciplina;

            while (!double.TryParse(Console.ReadLine(), out NotaDisciplina) || NotaDisciplina < 0 || NotaDisciplina > 10)
            {
                Console.WriteLine("Erro: Digite uma nota válida entre 0 e 10.");
            }

            SomadasNotas += NotaDisciplina;
        }

        double Media = SomadasNotas / QuantidadeDisciplinas;
        Console.WriteLine($"A média das notas é: {Media:F2}");
    }
}