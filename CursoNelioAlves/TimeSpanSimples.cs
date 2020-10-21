using System;
using System.Collections.Generic;
using System.Text;

namespace CursoNelioAlves.Parte_7._1
{
    class TimeSpanSimples
    {
        public static void Executar()
        {
            TimeSpan t1 = new TimeSpan(0, 1, 30);//Hora > Minuto > Segundo
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(02,04,23);
            TimeSpan t4 = new TimeSpan(09,02,04,23);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
        }
    }
}
