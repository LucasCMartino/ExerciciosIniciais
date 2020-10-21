using System;
using System.Collections.Generic;
using System.Text;

namespace CursoNelioAlves
{
    class EquacaoSegundoGrau
    {
        public static void Executar()
        {
            double a = 1.0, b = -3.0, c = -4.0;
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a); //Lógica da equação 2º Grau
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);

        }
    }
}
