using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    public class ColecoesStack
    {
        public static void Executar()
        {
            var pilha = new Stack<string>();
            pilha.Push("Luiz");
            pilha.Push("Guilherme");
            pilha.Push("Ana");
            foreach (var nome in pilha)
            {
                Console.WriteLine(nome);
            }
            Console.WriteLine($"Pop: {pilha.Pop()}"); // Remove o último elemento adicionado
            Console.WriteLine($"Peek: {pilha.Peek()}"); // Mostra o último elemento adicionado sem remover
            Console.WriteLine($"Count: {pilha.Count}"); // Mostra a quantidade de elementos na pilha
        }
    }
}
