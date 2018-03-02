using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Calculo_Votacao
    {
        #region Propriedades
        public double Eleitores { get; set; }
        public double Brancos { get; set; }
        public double Nulos { get; set; }
        public double Validos { get; set; }

        #endregion Propriedades

        #region Metodos

        
        public double Total()
        {
            double total = Brancos + Nulos + Validos;
            return total;
        }

        public double Percentual_Brancos()
        {
            double brancos = (Brancos / Eleitores)*100;

            return brancos;
        }

        public double Percentual_Nulos()
        {
            double nulos = (Nulos / Eleitores) * 100;

            return nulos;
        }

        public double Percentual_Validos()
        {
            double validos = (Validos / Eleitores) * 100;

            return validos;
        }


        #endregion Metodos

    }
}
