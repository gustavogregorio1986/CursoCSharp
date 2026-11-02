using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    public class UsandoBreak
    {
        public static void Executar()
        {
            int numero = 5;
            int tentativa = 0;
            while (tentativa < 10)
            {
                Console.WriteLine($"Tentativa {tentativa + 1}: Digite o número {numero}:");
                int palpite = Convert.ToInt32(Console.ReadLine());
                if (palpite == numero)
                {
                    Console.WriteLine("Parabéns! Você acertou o número!");
                    break; // Sai do loop se o número estiver correto
                }
                else
                {
                    Console.WriteLine("Número incorreto. Tente novamente.");
                }
                tentativa++;
            }
            if (tentativa == 10)
            {
                Console.WriteLine("Você atingiu o número máximo de tentativas.");
            }
        }
    }
}
