using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class Moto
    {
        // Campos privados
        private string marca;
        private string modelo;
        private int cilindrada;

        // Construtor
        public Moto(string marca, string modelo, int cilindrada)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.cilindrada = cilindrada;
        }

        // Métodos Get e Set para Marca
        public string GetMarca()
        {
            return marca;
        }

        public void SetMarca(string marca)
        {
            this.marca = marca;
        }

        // Métodos Get e Set para Modelo
        public string GetModelo()
        {
            return modelo;
        }

        public void SetModelo(string modelo)
        {
            this.modelo = modelo;
        }

        // Métodos Get e Set para Cilindrada
        public int GetCilindrada()
        {
            return cilindrada;
        }

        public void SetCilindrada(int cilindrada)
        {
            this.cilindrada = cilindrada;
        }
    }

    public class GetSetSeparado
    {
        public static void Executar()
        {
            var moto1 = new Moto("Honda", "CG 125", 125);

            // Usando os métodos Get para ler os valores
            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());

            // Exemplo usando o Set para alterar um valor depois
            moto1.SetCilindrada(160);
            Console.WriteLine(moto1.GetCilindrada());
        }
    }
}