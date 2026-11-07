using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Excessoes
{
    public class PrimeiraExcecao
    {
        public static void Executar()
        {
            try
            {
                Console.Write("Digite o numerador: ");
                int numerador = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite o denominador: ");
                int denominador = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(numerador / denominador);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Não é possível dividir um número por 0");
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Entrada inválida");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
