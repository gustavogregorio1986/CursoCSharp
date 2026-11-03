using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class CalculadoraEstatica
    {
        public static int Somar(int a, int b)
        {
            return a + b;
        }
        public static int Subtrair(int a, int b)
        {
            return a - b;
        }
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }
    }

    public class MetodosEstaticos
    {
        public static void Executar()
        {
             var resultado = CalculadoraEstatica.Somar(5, 5);
            Console.WriteLine($"Resultado da soma: {resultado}");
            resultado = CalculadoraEstatica.Subtrair(10, 5);
            Console.WriteLine($"Resultado da subtração: {resultado}");
            CalculadoraComum calculadoraComum = new CalculadoraComum();
            resultado = calculadoraComum.Multiplicar(3, 4);
            Console.WriteLine($"Resultado da multiplicação: {resultado}");
        }
    }
}
