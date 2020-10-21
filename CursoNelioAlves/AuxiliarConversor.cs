using System;
using System.Collections.Generic;
using System.Text;

namespace CursoNelioAlves
{
    class AuxiliarConversor
    {
        public static double Iof = 6.0;
        public static double ConversorParaDolar(double quantia, double cotacao)
        {
            double total = quantia * cotacao;
            return total + total * Iof / 100;
        }
    }
}
