using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    /// <summary>
    /// Esta clase contiene métodos para convertir de segundos a minutos y viceversa
    /// </summary>
    class HadaP1
    {
        /// <summary>
        /// Este metodo convierte de segundos a minutos
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static double Seconds2Minutes(double s)
        {
            return (s == 0) ? 0 : s * 60;
        }
        //
        /// <summary>
        /// Este metodo convierte de minutos a segundos
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public static double Minutes2Seconds(double m)
        {
            return m/60;
        }
    }
}
