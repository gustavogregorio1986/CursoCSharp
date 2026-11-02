using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    public class OperadoresAtribuicao
    {
        public static void Executar()
        {
            var num1 = 3;
            num1 += 10; // num1 = num1 + 10 
            num1 -= 3; // num1 = num1 - 3
            num1 *= 5; // num1 = num1 * 5
            num1 /= 2; // num1 = num1 / 2

            Console.WriteLine(num1);

            int a = 1;
            int b = a; // Atribuição de valor

            a++;  // Incremento a = a + 1
            b--;  //b = b - 1
            Console.WriteLine($" a = {a}, b = {b}");

            //Não se preoccupe com o codigo só entender melhor como revisão
            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "João";

            dynamic d = c; // Atribuição de referência
            d.nome = "Maria"; // Alterando o valor da propriedade nome do objeto referenciado por d

            Console.WriteLine($" c = {c.nome}");
        }
    }
}
