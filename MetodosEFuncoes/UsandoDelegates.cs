using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    public class UsandoDelegates
    {
        // Declaração dos delegates customizados
        delegate double Soma(double x, double y);
        delegate void ImprimirSoma(double x, double y);

        // Métodos que correspondem às assinaturas
        static double MinhaSoma(double x, double y)
        {
            return x + y;
        }

        static void MeuImprimirSoma(double x, double y)
        {
            Console.WriteLine($"A soma de {x} e {y} é: {x + y}");
        }

        public static void Executar()
        {
            // 1. Usando delegate customizado 'Soma'
            Soma op1 = MinhaSoma;
            Console.WriteLine(op1(2, 3.9));

            // 2. Usando delegate customizado 'ImprimirSoma'
            ImprimirSoma op2 = MeuImprimirSoma;
            op2(5.4, 8);

            // 3. Usando o delegate genérico 'Func' (para métodos com retorno)
            Func<double, double, double> op3 = MinhaSoma;
            Console.WriteLine(op3(2.5, 3));

            // 4. Usando o delegate genérico 'Action' (para métodos void)
            Action<double, double> op4 = MeuImprimirSoma;
            op4(7.7, 23.4);
        }
    }
}