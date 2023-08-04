using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciocio_poo06
{
    internal class ConversorDeMoeda
    {
        public static double ValorASerPago(double cot, double quant) {
            return cot * quant + (0.06 * (cot * quant));
        }
        

        }

    }

