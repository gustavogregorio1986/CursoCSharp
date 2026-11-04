using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    public class Produto {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }


    public class ColecoesList
    {
        public static void Executar()
        {
             var livro = new Produto("Game of Thrones", 49.9);
            var carrinho = new List<Produto>();

            carrinho.Add(livro);

            var carrinho2 = new List<Produto> {
                new Produto("Harry Potter", 39.9),
                new Produto("Senhor dos Aneis", 29.9),
                new Produto("Percy Jackson", 19.9)
            };


            carrinho.AddRange(carrinho2);

            Console.WriteLine(carrinho.Count);
            carrinho.RemoveAt(3);

            foreach (var item in carrinho)
            {
                Console.WriteLine(carrinho.IndexOf(item));
            }

            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);
            Console.WriteLine();
        }
    }
}
