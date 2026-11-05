using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    public class Animal
    {
        public string Nome;
        public Animal(string nome)
        {
            Nome = nome;
        }
    }

    public class Cachorro : Animal
    {
        public string Altura { get; set; }

        public Cachorro(string nome) : base(nome)
        {
            Console.WriteLine($"Cachorro {nome} criado.");
        }

        public Cachorro(string nome, string altura) : this(nome)
        {
            Altura = altura;
        }

        public override string ToString()
        {
            return $"Cachorro: {Nome}, Altura: {Altura}";
        }
    }

    public class ConstrutorThis
    {
        public static void Executar()
        {
            var spike = new Cachorro("Spike");
            var buddy = new Cachorro("Buddy", "1.5m");
            Console.WriteLine(spike);
            Console.WriteLine(buddy);
        }
    }
}
