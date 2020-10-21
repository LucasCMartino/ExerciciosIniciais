using System;
using System.Collections.Generic;
using System.Text;

namespace CursoNelioAlves.Parte_7
{
    class Nullable
    {
       public static void Fui()
        {
            double? x = null;
            double? y = 10;
            Console.WriteLine(x.GetValueOrDefault()); //Pega o valor ou o padrão
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue); //qual valor
            Console.WriteLine(y.HasValue);
            if (x.HasValue) Console.WriteLine("X is Null ...");
            else Console.WriteLine(x.Value);
            if (y.HasValue) Console.WriteLine("Y is Null ....");
            else Console.WriteLine(y.Value);

            double? s = null;
            double? d = 10;
            double a = s ?? 5; //OPERADOR DE coalescência 
            double b = d ?? 5; //se d = nulo, entao vai recebe 5
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
