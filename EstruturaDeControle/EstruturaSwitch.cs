using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    public class EstruturaSwitch
    {
        public static void Executar()
        {
            Console.WriteLine("Avalie o seu atendimento com uma nota de 0 a 5");
            int.TryParse(Console.ReadLine(), out int nota);
            switch (nota)
            {
                case 0:
                case 1:
                case 2:
                    Console.WriteLine("Insatisfatório");
                    break;
                case 3:
                    Console.WriteLine("Regular");
                    break;
                case 4:
                    Console.WriteLine("Bom");
                    break;
                case 5:
                    Console.WriteLine("Excelente");
                    break;
                default:
                    Console.WriteLine("Nota inválida");
                    break;
            }
        }
    }
}
