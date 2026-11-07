using System;
using System.IO;

namespace CursoCSharp.Api
{
    // Classe de extensão para traduzir o "~" para o diretório do usuário
    public static class ExtensaoAString
    {
        public static string ParseHome(this string path)
        {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.MacOSX)
                  ? Environment.GetEnvironmentVariable("HOME")
                  : Environment.GetEnvironmentVariable("USERPROFILE");

            return path.Replace("~", home);
        }
    }

    public class PrimeiroArquivo
    {
        public static void Executar()
        {
            // Traduz o caminho usando o método de extensão
            var path = @"~/primeiro_arquivo.txt".ParseHome();

            // 1. Criando o arquivo e escrevendo o conteúdo inicial
            using (var sw = File.CreateText(path))
            {
                sw.WriteLine("Esse é");
                sw.WriteLine("o nosso");
                sw.WriteLine("primeiro");
                sw.WriteLine("arquivo!");
            }

            Console.WriteLine("Arquivo criado com sucesso!");

            // 2. Adicionando mais linhas no final do arquivo (sem apagar o que já tem)
            using (var sw = File.AppendText(path))
            {
                sw.WriteLine("---");
                sw.WriteLine("Linha adicionada posteriormente com AppendText.");
            }

            Console.WriteLine("Novas linhas adicionadas com sucesso!");

            // Exibe o caminho completo no console para você saber onde ele foi salvo
            Console.WriteLine($"Caminho do arquivo: {path}");
        }
    }
}