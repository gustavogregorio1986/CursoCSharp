using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    public class EstruturaFor
    {
        public static void Executar()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Valor de i é  {i}.");
            }

            double somatorio = 0;
            string entrada;

            Console.WriteLine("Informe o tamanho da turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);

            for (int i = 0; i < tamanhoTurma; i++)
            {
                Console.WriteLine($"Aluno {i + 1}: ");
                entrada = Console.ReadLine();
                somatorio += double.Parse(entrada);
            }

            Console.WriteLine($"Média da turma: {somatorio / tamanhoTurma}");
        }
    }
}
