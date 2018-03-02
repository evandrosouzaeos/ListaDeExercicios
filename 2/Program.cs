using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {

            Calculo_Votacao calculo = new Calculo_Votacao();

            Console.WriteLine("Eleitores...");
            calculo.Eleitores = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Brancos...");
            calculo.Brancos = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nulos...");
            calculo.Nulos = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Validos...");
            calculo.Validos = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Resultados...");

            Calcular(calculo);

            Console.ReadKey();



        }

        public static void Calcular(Calculo_Votacao calculo)
        {
            Console.WriteLine("Brancos..." + calculo.Percentual_Brancos());
            Console.WriteLine("Nulos..." + calculo.Percentual_Nulos());
            Console.WriteLine("Validos..." + calculo.Percentual_Validos());
            
        }
    }

}
