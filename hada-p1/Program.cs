using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace hada_p1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                imprimirMenu();
                string seleccion = Console.ReadLine();
                if(seleccion == "0") { break; }
                Console.WriteLine("Introduce valor a convertir: ");
                double val = Convert.ToDouble(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
                
                double resul = 0;
                switch (seleccion)
                {
                    case "1": resul = HadaP1.Seconds2Minutes(val); break;
                    case "2": resul = HadaP1.Minutes2Seconds(val); break;
                    case "3": resul = HadaP1.Hours2Minutes(val); break;
                    default: break;
                }
                Console.WriteLine("Resultado: " + resul);
                Console.WriteLine("---------------------------------------------------");
            }
        }

        public static void imprimirMenu()
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("0.Exit");
            Console.WriteLine("1.Convertir de segundos a minutos");
            Console.WriteLine("2.Convertir de minutos a segundos");
            Console.WriteLine("3.Convertir de horas a minutos");
            Console.WriteLine("Selección:");
        }
    }
}
