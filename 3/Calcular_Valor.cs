using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Calcular_Valor
    {

        #region Propriedades

        public double Custo { get; set; }
        public double Distribuidor { get; set; }
        public double Impostos { get; set; }


        #endregion Propriedades


        #region Metodos

        public double Valor_Final()
        {
            double imposto = Custo + (Custo *(Impostos/100));
            double distribuidor = (Distribuidor/100);

            double final = (imposto + (imposto*(Distribuidor / 100)));

            return final;
        }

        #endregion Metodos

    }
}
