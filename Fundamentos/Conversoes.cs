using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    public class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int)nota;
            Console.WriteLine("Nota Truncada: {0}", notaTruncada);

            Console.WriteLine("Digite a sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inserida: {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeInteiro);
            Console.WriteLine("Resultado {0}", idadeInteiro);

            Console.WriteLine("Digite um número: ");
            string numeroString = Console.ReadLine();
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(numeroString, out numero);
            Console.WriteLine("Resultado {0}", numero);


            Console.WriteLine("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resultado {0}", numero2);



        }
    }
}
