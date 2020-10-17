using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CursoNelioAlves.Parte_7._1
{
    class ExercicioTimeSpan
    {
        public static void Executar()
        {
            TimeSpan t = new TimeSpan(2,3,4,5,6);
            Console.WriteLine(t);
            Console.WriteLine("Days : " + t.Days);
            Console.WriteLine("Hours : " + t.Hours);
            Console.WriteLine("Minutes : " + t.Minutes);
            Console.WriteLine("Seconds : " + t.Seconds);
            Console.WriteLine("---------------------------");
            Console.WriteLine("Total Days : " + t.TotalDays);
            Console.WriteLine("Total Hours : " + t.TotalHours);
            Console.WriteLine("Total Minutes : " + t.TotalMinutes);
            Console.WriteLine("Total Seconds : " + t.TotalSeconds);

            TimeSpan t1 = new TimeSpan(1,30,5);
            TimeSpan t2 = new TimeSpan(0,10,5);

            TimeSpan sum = t1.Add(t2);
            var dif = t1.Subtract(t2);
            var mult = t2.Multiply(2.0);
            TimeSpan div = t2.Divide(2.0);
        }
    }
}
