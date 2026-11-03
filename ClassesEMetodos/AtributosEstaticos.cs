using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public static double Desconto = 0.1;
        public Produto(string nome, double preco, double desconto)
        {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }

        public Produto()
        {
            
        }

        public double PrecoComDesconto()
        {
            return Preco * (1 - Desconto);
        }
    }

    public class AtributosEstaticos
    {
        public static void Executar()
        {
            var produto1 = new Produto("Caneta", 3.50, 0.1);
            var produto2 = new Produto() 
            { 
                Nome = "Borracha", 
                Preco = 5.3
            };

            Console.WriteLine("Preço com Desconto: {0}", produto1.PrecoComDesconto());
            Console.WriteLine("Preço com Desconto: {0}", produto2.PrecoComDesconto());

            Produto.Desconto = 0.5;
            Console.WriteLine("Preço com Desconto: {0}", produto1.PrecoComDesconto());
            Console.WriteLine("Preço com Desconto: {0}", produto2.PrecoComDesconto());  
        }
    }
}
