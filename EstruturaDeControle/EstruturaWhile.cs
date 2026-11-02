using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    public class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random random = new Random();
            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            while (palpite != numeroSecreto)
            {
                Console.Write("Digite um número entre 1 e 15: ");
                int.TryParse(Console.ReadLine(), out palpite);
                if (palpite == numeroSecreto)
                {
                    Console.WriteLine("Parabéns! Você acertou o número secreto!");
                    numeroEncontrado = true;
                }
                else
                {
                    Console.WriteLine("Tente novamente!");
                }
            }
            if (!numeroEncontrado)
            {
                Console.WriteLine($"O número secreto era: {numeroSecreto}");
            }
        }
    }
}
