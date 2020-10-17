using System;
using System.Collections.Generic;
using System.Text;

namespace CursoNelioAlves.Parte_7._1
{
    class ExercicioDateTime
    {
        public static void Executar()
        {
            DateTime d = new DateTime(1994, 07, 12, 16, 45, 53);
            Console.WriteLine(d);
            Console.WriteLine("1) Date : " + d.Date);
            Console.WriteLine("2) Day : "+ d.Day);
            Console.WriteLine("3) DayOfWeek : " +d.DayOfWeek);
            Console.WriteLine("4) DayOfYear : " + d.DayOfYear);
            Console.WriteLine("5) TimeOfDay : " + d.TimeOfDay);
            Console.WriteLine("6) Month : " + d.Month);
            Console.WriteLine("7) Year : " + d.Year);
            Console.WriteLine("8) Hour : "+ d.Hour);
            Console.WriteLine("9) Minutes : " + d.Minute);
            Console.WriteLine("10) Seconds : " + d.Second);
            Console.WriteLine("11) Kind : " + d.Kind);

            Console.WriteLine(d.ToLongDateString());
            Console.WriteLine(d.ToString("yyyy-MM-dd HH:mm"));

            DateTime d1 = DateTime.Now;
            DateTime d2 = d1.AddDays(7); // exemplo de data acrescida de dias, tipo boleto
            Console.WriteLine(d1);
            Console.WriteLine(d2);
        }
    }
}
