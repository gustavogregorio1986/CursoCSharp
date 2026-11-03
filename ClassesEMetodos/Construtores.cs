using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class Carro
    {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro()
        {
            
        }

        public Carro(string modelo, string fabricante, int ano)
        {
            this.Modelo = modelo;
            this.Fabricante = fabricante;
            this.Ano = ano;
        }

    }


    public class Construtores
    {
        public static void Executar()
        {
            var carro1 = new Carro();
            carro1.Fabricante = "BMW";
            carro1.Modelo = "320i";
            carro1.Ano = 2017;
            Console.WriteLine($"Fabricante: {carro1.Fabricante}, Modelo: {carro1.Modelo}, Ano: {carro1.Ano}");

            var carro2 = new Carro("Ka", "Ford", 2018);
            Console.WriteLine($"Fabricante: {carro2.Fabricante}, Modelo: {carro2.Modelo}, Ano: {carro2.Ano}");

            var carro3 = new Carro() 
            { 
               Fabricante = "Chevrolet",
                Modelo = "Onix",
                Ano = 2019
            };
            Console.WriteLine($" {carro3.Fabricante}, {carro3.Modelo}, {carro3.Ano}");
        }
    }
}
