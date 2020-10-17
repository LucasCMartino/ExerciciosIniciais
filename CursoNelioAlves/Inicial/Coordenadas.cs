using System;
using System.Collections.Generic;
using System.Text;

namespace CursoNelioAlves
{
    class Coordenadas
    {
        public static void Executar()
        {
            Console.Write("Informe a coordenada X : ");
            var x = int.Parse(Console.ReadLine());
            Console.Write("Informe a coordenada Y : ");
            var y = int.Parse(Console.ReadLine());
            while (x != 0 || y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("\t\t\tprimeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("\t\t\tsegundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("\t\t\tterceiro");
                }
                else
                {
                    Console.WriteLine("\t\t\tquarto");
                }
                Console.Write("Informe a coordenada X : ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Informe a coordenada Y : ");
                y = int.Parse(Console.ReadLine());
            }
        }
    }
}
