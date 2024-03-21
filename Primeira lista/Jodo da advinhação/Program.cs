using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int numScrt = random.Next(1, 101);
        int dica;

        Console.WriteLine("Bem-vindo!");
        Console.WriteLine("Estou pensando em um número entre 1 e 100.");

        do
        {
            Console.Write("Tente advinhar o número: ");
            dica = Convert.ToInt32(Console.ReadLine());

            if (dica > numScrt)
            {
                Console.WriteLine("Passou por cima !!!!.");
            }
            else if (dica < numScrt)
            {
                Console.WriteLine("Muito baixo! .");
            }
        } while (dica != numScrt);

        Console.WriteLine("Parabéns! Você adivinhou o número.");
    }
}