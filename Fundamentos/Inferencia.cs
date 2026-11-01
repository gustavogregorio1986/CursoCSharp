using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    public class Inferencia
    {
        public static void Executar()
        {
           var nome = "Leonardo";
            Console.WriteLine(nome);
            //nome = 123;

            //int idade;
            var idade = 32;
            Console.WriteLine(idade);

            int a;
            a = 3;
            int b = 2;
            Console.WriteLine(a + b);
        }
    }
}
