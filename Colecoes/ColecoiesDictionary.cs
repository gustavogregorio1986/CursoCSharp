using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    public class ColecoiesDictionary
    {
        public static void Executar()
        {
            var filme = new Dictionary<string, string>();
            filme.Add("Titulo", "Star Wars");
            filme.Add("Diretor", "George Lucas");
            filme.Add("Ano", "1977");
            Console.WriteLine(filme["Titulo"]);
            Console.WriteLine(filme["Diretor"]);
            Console.WriteLine(filme["Ano"]);
        }
    }
}
