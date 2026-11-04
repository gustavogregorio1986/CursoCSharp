using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public enum Genero { Acao,Aventura,Terror,Animacao,Comedia}

    public class Filme
    {
        public string Titulo;
        public Genero GeneroDoFilme;
    }

    public class ExemploEnum
    {
        public static void Executar()
        {
           int id = (int)Genero.Animacao;
            Console.WriteLine(id);

            var filmeParaFamilia = new Filme();
            filmeParaFamilia.Titulo = "Shrek 17";
            filmeParaFamilia.GeneroDoFilme = Genero.Animacao;
            Console.WriteLine($"Filme: {filmeParaFamilia.Titulo}, Gênero: {filmeParaFamilia.GeneroDoFilme}");
        }
    }
}
