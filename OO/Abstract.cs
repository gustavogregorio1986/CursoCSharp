using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    public abstract class Celular 
    { 
        public abstract string Assistente();

        public string Tocar()
        {
            return "Trim Trim Trim....";
        }
    }

    public class Sansug : Celular 
    {
        public override string Assistente()
        {
            return "Olá! Meu nome é bixby!";
        }
    }

    public class IPhone : Celular 
    {
        public override string Assistente()
        {
            return "Olá! Meu nome é soiri!";
        }
    }



    public class Abstract
    {
        public static void Executar()
        {
            var celulares = new List<Celular> {
                new IPhone(),
                new Sansug()
            };

            foreach(var celular in celulares)
            {
                Console.WriteLine(celular.Assistente());
            }

        }
    }
}
