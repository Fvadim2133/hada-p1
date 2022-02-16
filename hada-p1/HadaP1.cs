using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    class HadaP1
    {
        public static double Seconds2Minutes(double s)
        {
            return (s == 0) ? 0 : s * 60;
        }

        public static double Minutes2Seconds(double m)
        {
            return m/60;
        }
    }
}
