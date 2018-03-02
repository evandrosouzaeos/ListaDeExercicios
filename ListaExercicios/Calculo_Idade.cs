using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios
{
    class Calculo_Idade
    {

        #region Propriedades
        public int Anos { get; set; }
        public int Meses { get; set; }
        public int Dias { get; set; }

        #endregion Propriedades

        #region Metodos

        public int CalcularDias()
        {
            int resultado;
            resultado = ((Anos*365) + (Meses*30) + Dias);

            return resultado;
        }
        #endregion

    }
}
