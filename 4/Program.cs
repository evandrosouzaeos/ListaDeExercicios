using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Calcular_Salario calculo = new Calcular_Salario();


            Console.WriteLine("Fixo...");
            calculo.Fixo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Comissao...");
            calculo.Comissao = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Quantidade...");
            calculo.Quantidade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Valor...");
            calculo.Valor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Total...");

            Calcular(calculo);


            Console.ReadKey();


        }

        public static void Calcular(Calcular_Salario calculo)
        {
            Console.WriteLine(calculo.Salario_Final());
        }
    }
}
