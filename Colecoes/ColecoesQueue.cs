using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    public class ColecoesQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>();
            fila.Enqueue("Fulano");
            fila.Enqueue("Ciclano");
            fila.Enqueue("Beltrano");
            Console.WriteLine(fila.Peek()); // Retorna o primeiro elemento da fila, sem removê-lo
            Console.WriteLine(fila.Count); // Retorna a quantidade de elementos na fila
            while (fila.Count > 0)
            {
                Console.WriteLine(fila.Dequeue()); // Remove e retorna o primeiro elemento da fila
            }
        }
    }
}
