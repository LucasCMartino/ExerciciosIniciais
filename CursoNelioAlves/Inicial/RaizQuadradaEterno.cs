using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CursoNelioAlves
{
    class RaizQuadradaEterno
    {
        public static void Executar()
        {
            Console.Write("Digite um número : ");
            var x = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            var raiz = Math.Sqrt(x);
            
            while (x >= 0.0)
            {
                raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3",CultureInfo.InvariantCulture));
                Console.Write("Digite outro número : ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Número Negativo !");
        }
    }
}
