using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Calcular_Valor calculo = new Calcular_Valor();


            Console.WriteLine("Custo...");
            calculo.Custo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Imposto");
            calculo.Impostos = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Distribuidor");
            calculo.Distribuidor = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Total...");

            Calcular(calculo);


            Console.ReadKey();

        }

        public static void Calcular(Calcular_Valor calculo)
        {
            Console.WriteLine(calculo.Valor_Final());
        }
    }
}
