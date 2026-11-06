using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    public class DelegateFunAnonima
    {
        public static void Executar()
        {
            // Action
            Action<string> imprimir = s => Console.WriteLine(s.ToUpper());
            imprimir("Usando delegate com expressao lambda");
            // Func
            Func<int, int, string> somar = (a, b) => (a + b).ToString();
            Console.WriteLine(somar(5, 5));
            // Predicate
            Predicate<int> teste = n => n >= 10;
            Console.WriteLine(teste(11));
        }
    }
}
