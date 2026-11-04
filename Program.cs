using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar}, // Passando um valor de exemplo
                {"Variaveis e Constantes - Fundamentos",  VariaveisEConstantes.Executar}, 
                {"Inferencia - Fundamentos",  Inferencia.Executar},
                {"Interpolacao - Fundamentos",  Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos",  LendoDados.Executar},
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar},
                {"Convenções - Fundamentos",  Conversoes.Executar},
                {"Operadores Aritméticos - Fundamentos",  OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos",  OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos",  OperadoresLogico.Executar},
                {"Operadores de Atribuicoes - Fundamentos",  OperadoresAtribuicao.Executar},
                {"Operadores Unarios - Fundamentos", OperadoresUnarios.Executar}, 
                //Estruturas de Controle
                {"Estrutura If - Estruturas de Controle", EstruturaIf.Executar},
                {"Estrutura If Else - Estruturas de Controle",  EstruturaIfElse.Executar},
                {"Estrutura If Else If - Estruturas de Controle",  EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas de Controle",  EstruturaSwitch.Executar},
                {"Estrutura Do While - Estruturas de Controle",  EstruturaDoWhile.Executar},
                {"Estrutura Do For - Estruturas de Controle",  EstruturaFor.Executar},
                {"Estrutura Do For Each - Estruturas de Controle", EstruturaForEach.Executar},
                {"Usando Break - Estruturas de Controle", UsandoBreak.Executar},
                {"Usando Continue - Estruturas de Controle", () => UsandoContinue.Executar()},

                //Classes e Metodos
                {"Membros - Classes e Métodos", membros.Executar}, 
                {"Construtores - Classes e Métodos", Construtores.Executar},
                {"Métodos com Retorno - Classes e Métodos",  MetodosComRetorno.Executar},
                {"Métodos Estaticos - Classes e Métodos",  MetodosEstaticos.Executar},
                {"Atributos Estaticos - Classes e Métodos", AtributosEstaticos.Executar},
                {"Desafio Atributos - Classes e Métodos", DesafioAttributo.Executar},
                {"Params - Classes e Métodos",  Params.Executar},
                {"Parametros Nomeados - Classes e Métodos",  ParametrosNomeados.Executar},
                {"GetSet - Classes e Métodos",  GetSetSeparado.Executar},
                {"Props - Classes e Métodos",  Props.Executar},
                {"Readonly - Classes e Métodos",  Readonly.Executar},
                {"Enum - Classes e Métodos",  ExemploEnum.Executar},
                {"Struct - Classes e Métodos",  ExemploStruct.Executar},
                {"Struct Vs Classe - Classes e Métodos",  StructVsClasse.Executar},

            });

            central.SelecionarEExecutar();
        }
    }
}