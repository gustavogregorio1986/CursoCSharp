using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class CalculadoraComum
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }

        public int Subtrair(int a , int b)
        {
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }
    }

    public class MetodosComRetorno
    {
        public static void Executar()
        {
           var calculadoraComum = new CalculadoraComum();
            var resultado = calculadoraComum.Somar(5, 5);
            Console.WriteLine($"Resultado da soma: {resultado}");
            resultado = calculadoraComum.Subtrair(10, 5);
            Console.WriteLine($"Resultado da subtração: {resultado}");
            resultado = calculadoraComum.Multiplicar(3, 4);
            Console.WriteLine($"Resultado da multiplicação: {resultado}");
        }
    }
}
