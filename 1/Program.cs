using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculo_Idade calculo = new Calculo_Idade();

            Console.WriteLine("Anos...");
            calculo.Anos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Meses...");
            calculo.Meses = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dias...");
            calculo.Dias = Convert.ToInt32(Console.ReadLine());

            Calcular(calculo);

            Console.ReadKey();            

        }

        private static void Calcular(Calculo_Idade calculo)
        {
            Console.WriteLine("Dias total...");
            Console.WriteLine(calculo.CalcularDias());
        }
    }
}
