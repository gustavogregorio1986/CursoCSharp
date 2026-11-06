using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    public class Comida
    {
        public double Peso;

        public Comida(double peso)
        {
            this.Peso = peso;
        }
    }

    public class Feijao : Comida
    {
        public Feijao(double peso) : base(peso)
        {
        }
    }

    public class Arroz : Comida
    {
        public Arroz(double peso) : base(peso)
        {
        }
    }

    public class Carne : Comida
    {
        public Carne(double peso) : base(peso)
        {
        }
    }

    public class Pessoa
    {

        public double Peso;

        public void Comer(Feijao feijao)
        {
            this.Peso += feijao.Peso;
        }

        public void Comer(Arroz arroz)
        {
            this.Peso += arroz.Peso;
        }

        public void Comer(Carne carne)
        {
            this.Peso += carne.Peso;
        }

    }

    public class Polimorfismo
    {
        public static void Executar()
        {
            // Instancia a pessoa com um peso inicial (ex: 80.2 kg)
            Pessoa cliente = new Pessoa();
            cliente.Peso = 80.2;

            // Instancia os alimentos passando o peso em kg
            Arroz ingrediente1 = new Arroz(0.3);
            Feijao ingrediente2 = new Feijao(0.2);
            Carne ingrediente3 = new Carne(0.4);

            Console.WriteLine($"Peso inicial da pessoa: {cliente.Peso}kg");

            // A pessoa come cada alimento usando a sobrecarga de métodos
            cliente.Comer(ingrediente1);
            cliente.Comer(ingrediente2);
            cliente.Comer(ingrediente3);

            // Exibe o peso final após comer
            Console.WriteLine($"Peso após comer: {cliente.Peso}kg");
        }
    }
}
