using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
   
    public class CrroOpcional
    {
        double desconto = 0.1;

        string nome;

        public string Nome
        {
            get { 
                return "Opcional: " + nome; 
            }
            set { nome = value; }
        }

    }

    public class Props
    {
        public static void Executar()
        {
            var carro = new CrroOpcional();
            Console.WriteLine();
        }
    }
}
