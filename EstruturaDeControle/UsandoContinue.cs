using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    public class UsandoContinue
    {
        public static void Executar()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue; // Pula para a próxima iteração se o número for par
                }
                Console.WriteLine(i); // Imprime apenas números ímpares
            }

            for(int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue; // Pula para a próxima iteração se o número for par
                }
                Console.WriteLine(i); // Imprime apenas números ímpares
            }
        }
    }
}
