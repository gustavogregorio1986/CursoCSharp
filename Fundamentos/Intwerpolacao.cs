using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    public class Intwerpolacao
    {
        public static void Executar()
        {
            string nome = "Notebook Gamer";
            string marca = "Dell";
            double preco = 5000.00;
            Console.WriteLine("O " + nome + " da marca " + marca + " custa R$ " + preco + ".");
            Console.WriteLine($"O {0}, da marca: {1}, custa: R$ {2}", nome, marca, preco);
            Console.WriteLine($"A marca {marca} é legal!");
            Console.WriteLine($"1 + 1 = {1 + 1}");
        }
    }
}
