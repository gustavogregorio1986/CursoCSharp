using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class ParametrosNomeados
    {
        public static void Executar(int dia, int mes, int ano)
        {
            Console.WriteLine("Data: {0:D2}/{1:D2}/{2}", dia, mes, ano);
        }

        public static void Executar()
        {
            Executar(dia: 1, mes: 6, ano: 1996);
        }
        }
    }
}
