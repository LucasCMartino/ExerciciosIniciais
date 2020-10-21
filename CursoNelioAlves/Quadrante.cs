using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CursoNelioAlves
{
    class Quadrante
    {
        public static void Executar()
        {
            string[] valores = Console.ReadLine().Split(' ');
            double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double y = double.Parse(valores[0], CultureInfo.InvariantCulture);
            if(x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0) Console.WriteLine("Eixo Y ");
            else if (y == 0) Console.WriteLine("Eixo X ");
            else if (x > 0.0 && y > 0.0) Console.WriteLine("Q1");
            else if (x < 00 && y > 0.0) Console.WriteLine("Q2");
            else if (x < 0.0 && y < 0.0) Console.WriteLine("Q3");
            else Console.WriteLine("Q4");
        }
    }
}
