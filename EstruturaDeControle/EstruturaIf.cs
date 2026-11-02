using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    public class EstruturaIf
    {
        public static void Executar()
        {
           bool bomComportamento = false;
           string entrada;

            Console.WriteLine("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            double nota = double.Parse(entrada);

            bomComportamento = entrada.ToLower() == "s" ? true : false;

            if (nota >= 9.0 | bomComportamento)
            {
                Console.WriteLine("quadro de hora!");
            }
        }
    }
}
