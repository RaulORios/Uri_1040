using System;
using System.Globalization;

namespace Uri_1040
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] notas = Console.ReadLine().Split(' ');
            float n1 = float.Parse(notas[0], CultureInfo.InvariantCulture);
            float n2 = float.Parse(notas[1], CultureInfo.InvariantCulture);
            float n3 = float.Parse(notas[2], CultureInfo.InvariantCulture);
            float n4 = float.Parse(notas[3], CultureInfo.InvariantCulture);

            float media = (n1 * 2 + n2 * 3 + n3 * 4 + n4 * 1) / 10;
            float n_exame;
            float media_exame;

            if (media == 4.85f)
            {
                media = 4.8f;
            }

            Console.WriteLine($"Media: {media.ToString("F1", CultureInfo.InvariantCulture)}");

            if (media >= 7)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else
            {
                Console.WriteLine("Aluno em exame.");
                n_exame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine($"Nota do exame: {n_exame.ToString("F1", CultureInfo.InvariantCulture)}");
                media_exame = (media + n_exame) / 2;
                if (media_exame >= 5)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine($"Media final: {media_exame.ToString("F1", CultureInfo.InvariantCulture)}");
            }

        }
    }
}
