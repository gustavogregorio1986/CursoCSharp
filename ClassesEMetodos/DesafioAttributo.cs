using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class DesafioAttributo
    {
        int a = 10;

        public static void Executar()
        {
            DesafioAttributo desafio = new DesafioAttributo();
            Console.WriteLine(desafio.a);

            DesafioAttributo desafio2 = new DesafioAttributo();
            desafio2.a = 20;
            Console.WriteLine(desafio2.a);
        }   
    }
}
