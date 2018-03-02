using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Calcular_Salario
    {
        #region Propriedades

        public double Fixo { get; set; }
        public double Quantidade { get; set; }
        public double Valor { get; set; }
        public double Comissao { get; set; }



        #endregion Propriedades

        #region Metodos

        public double Salario_Final()
        {
            
            double comissao_fixa = Comissao * Quantidade;
            double comissao_variavel = (Valor / 100) * 5;

            double salario_final = comissao_fixa + comissao_variavel + Fixo;

            return salario_final;
        }


        #endregion Metodos



    }
}
