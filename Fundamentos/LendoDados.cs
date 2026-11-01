using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    public class LendoDados
    {
        public static void Executar()
        {
            Console.WriteLine("Qual seu nome? ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual idade é a sua idade ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual é o seu salario: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Olá {nome} {idade} R${salario}.");
        }
    }
}
