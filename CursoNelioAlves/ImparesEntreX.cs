using System;
using System.Collections.Generic;
using System.Text;

namespace CursoNelioAlves
{
    class ImparesEntreX
    {
        public static void Executar()
        {
            Console.Write("Informe um número de 1 a 1000 : ");
            var x = int.Parse(Console.ReadLine());
            for (int i = 1; i < x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            
        }
    }
}
