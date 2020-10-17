using System;
using System.Collections.Generic;
using System.Text;

namespace CursoNelioAlves
{
    class ExemploCasting
    {
        public static void Executar()
        {
            float c = 4.5f;
            int d = (int) c ; //Exemplo de Casting

            int a = 5; //pode usa tipo 5.0 pra indica q eh do tipo double, assim n precisa de cast
            int b = 2;
            double resultado = (double)a / b; //Exemplo de Casting
            Console.WriteLine("{0}",resultado);
        }
    }
}
