using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    public class ExemploLabda
    {
        public static void Executar()
        {
            Action algoNoConsole = () =>
            {
                Console.WriteLine("Lambda com C#!");
            };

            algoNoConsole();

            Func<int> jogarDados = () => {
                Random random = new Random();
                return random.Next(1, 7);
            };

            Console.WriteLine(jogarDados());

            Func<int, string> conversorHex = numero => {
                return numero.ToString("X");
            };

            Console.WriteLine(conversorHex(1234));

            Func<int, int, int> calculadora = (x, y) => {
                return x + y;
            };
        }
    }
}
