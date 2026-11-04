using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class ValorVsReferencia
    {
        public static void Executar()
        {
            var array = new int[3] { 1, 2, 3 };
            Console.WriteLine("Array original: " + string.Join(", ", array));
            // Passando o array para o método
            ModificarArray(array);
            Console.WriteLine("Array após modificação: " + string.Join(", ", array));
        }
        static void ModificarArray(int[] arr)
        {
            // Modificando o primeiro elemento do array
            arr[0] = 99;
        }
    }
}
