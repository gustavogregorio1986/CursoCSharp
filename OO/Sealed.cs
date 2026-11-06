using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    public sealed class SemFilho
    {
        public double ValorDaPropriedade { get; set; }
    }

    public class Avo
    {
        public virtual bool HonrarNomeDaFamilia()
        {
            return true;
        }
    }

    public class Pai : Avo
    {
        public sealed override bool HonrarNomeDaFamilia()
        {
            return true;
        }
    }

    public class FilhoRebelde : Pai
    {         //public override bool HonrarNomeDaFamilia()
        //{
        //    return false;
        //}
    }


    public class Sealed
    {
        public static void Executar()
        {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorDaPropriedade);
            
            FilhoRebelde filhoRebelde = new FilhoRebelde();
            Console.WriteLine(filhoRebelde.HonrarNomeDaFamilia());
        }
    }
}
