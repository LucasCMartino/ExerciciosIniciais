using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CursoNelioAlves
{
    class MaiorEntre
    { static int Maior(int a,int b, int c) //Construindo Função 
        {
            int m;
            if (a > b && a > c) m = a;
            else if (b > c) m = b;
            else m = c;
            return m;
        }
        public static void Executar()
        {
            Console.WriteLine("Digite três números : ");
            var n1 = int.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());
            var n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3);
            Console.WriteLine("Maior = {0}",resultado);


            //if (n1 > n2 && n1 > n3) Console.WriteLine($"Maior = {n1}");
            //else if (n2 > n3) Console.WriteLine($"Maior = {n2}");
            //else Console.WriteLine($"Maior = {n3}");
        }
    }
}
