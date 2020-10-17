using System;
using System.Collections.Generic;
using System.Text;

namespace CursoNelioAlves
{
    class AuxiliarAluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double CalcularNota()
        {
            return  (Nota1 + Nota2 + Nota3) / 3;
        }
    }
}
