using System;

namespace CursoCSharp.MetodosEFuncoes
{
    // A classe estática que contém os métodos de extensão
    public static class ExtensoesInteiro
    {
        // O modificador 'this' antes de 'int num' indica que este método 
        // estende o tipo int, permitindo chamá-lo diretamente a partir de números.
        public static int Soma(this int num, int outroNumero)
        {
            return num + outroNumero;
        }

        public static int Subtracao(this int num, int outroNumero)
        {
            return num - outroNumero;
        }
    }

    class MetodosDeExtensao
    {
        public static void Executar()
        {
            int numero = 5;

            // Utilizando o método de extensão a partir de uma variável do tipo int
            Console.WriteLine(numero.Soma(3));        // Saída: 8
            Console.WriteLine(numero.Subtracao(10));  // Saída: -5

            // Utilizando o método de extensão diretamente num literal inteiro
            Console.WriteLine(2.Soma(3));             // Saída: 5
            Console.WriteLine(3.Subtracao(2));        // Saída: 1
        }
    }
}