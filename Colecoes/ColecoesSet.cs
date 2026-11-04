using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
   
    public class ColecoesSet
    {
        public static void Executar()
        {
             var livro = new Produto("Game of Thrones", 49.9);
            var carrinho = new HashSet<Produto>();

            carrinho.Add(livro);

            var carrinho2 = new HashSet<Produto> {
                new Produto("Harry Potter", 39.9),
                new Produto("Senhor dos Aneis", 29.9),
                new Produto("Percy Jackson", 19.9),
                livro
            };


            //carrinho.AddRange(carrinho2);
            carrinho.UnionWith(carrinho2);
            Console.WriteLine(carrinho.Count);
            //carrinho.RemoveAt(3);

            foreach (var item in carrinho)
            {
                //Console.WriteLine(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} - R$ {item.Preco}");
            }

            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);
            Console.WriteLine();
        }
    }
}
