using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    public class VariaveisEConstantes
    {
        public static void Executar()
        {
            // area de circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            double area = PI * raio * raio;
            Console.WriteLine(area);

            Console.WriteLine("Área é " + area);

            bool estaChovendo = true;
            Console.WriteLine("Esta chovendo " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine(saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salario " + salario);
            int menorValorInt = int.MinValue; // Mais usado dos inteiros!
            Console.WriteLine("Menor int " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População Brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor Long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial " + populacaoMundial);

            float precoComputador = 1200.99f;
            Console.WriteLine("Preço do Computador " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00;
            Console.WriteLine("Valor de Mercado da Apple " + valorDeMercadoDaApple); //Mais usado dos reais!

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância entre Estrelas " + distanciaEntreEstrelas);

            var letra = 'b';
            Console.WriteLine("Letra " + letra);

            string texto = "Seja bem vindo ao curso de C#!";
            Console.WriteLine(texto);
        }
    }
}
