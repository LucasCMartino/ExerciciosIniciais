using System;
using System.Collections.Generic;
using System.Text;

namespace CursoNelioAlves
{
    class Vetor
    {
        public static void Executar()
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            string[] c = Console.ReadLine().Split(' ');
            string d = c[0];
            string e = c[1];
            string f = c[2];
            string g = c[3];


            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
        }
    }
}
