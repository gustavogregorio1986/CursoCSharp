using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Excessoes
{
    

    public class ExcessoesPersonalizadas
    {
        public class NegativoException : Exception
        {
            public NegativoException(string message) : base(message)
            {
            }

            public NegativoException(string message, Exception inner)
            {

            }
        }

        public class ImparException : Exception
        {
            public ImparException(string message) : base(message)
            {

            }
        }

        public class ExcecoesPersonalidas : Exception
        {
            public static int PositivoPar()
            {
                Random random = new Random();
                int valor = random.Next(-30, 30);
                if (valor < 0)
                {
                    throw new NegativoException("O número não pode ser negativo");
                }
                if (valor % 2 != 0)
                {
                    throw new ImparException("O número deve ser par");
                }
                return valor;
            }
        }

        public static void Executar()
        {
            try
            {
                Console.WriteLine(ExcecoesPersonalidas.PositivoPar());
            }
            catch (NegativoException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            catch (ImparException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}
