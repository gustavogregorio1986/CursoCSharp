using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    public class OperadoresLogico
    {
        public static void Executar()
        {
            var executarTrabalho1 = true;
            var executarTrabalho2 = false;

            var comprouTV50 = executarTrabalho1 && executarTrabalho2;
            Console.WriteLine("Comprou a TV 50?, {0}", comprouTV50);
            
            var comprouSorvete = executarTrabalho1 || executarTrabalho2;
            Console.WriteLine("Comprou o sorvete {0}", comprouSorvete);

            var comprouTv32 = executarTrabalho1 ^ executarTrabalho2;
            Console.WriteLine("Comprou a TV 32? {0}", comprouTv32);

            Console.WriteLine("Mais saudável? {0}", !comprouSorvete);

        }
    }
}
