using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Usando uma expressão lambda para adiar a execução até a seleção
                {"Primeiro Programa - Fundamentos", () => PrimeiroPrograma.Executar()},
                {"Comentarios - Fundamentos", () => Comentarios.Executar()}, // Passando um valor de exemplo
                {"Variaveis e Constantes - Fundamentos", () => VariaveisEConstantes.Executar()}, 
                {"Inferencia - Fundamentos", () => Inferencia.Executar()},
                {"Interpolacao - Fundamentos", () => Intwerpolacao.Executar()},
                {"Notação Ponto - Fundamentos", () => NotacaoPonto.Executar()},
            });

            central.SelecionarEExecutar();
        }
    }
}