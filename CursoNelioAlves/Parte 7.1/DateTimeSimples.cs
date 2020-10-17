using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CursoNelioAlves.Parte_7._1
{
    class DateTimeSimples
    {
        public static void Executar()
        {
            DateTime d1 = DateTime.Now;
            DateTime d2 = new DateTime(2020, 10, 15);//Ano,Mes,Dia
            DateTime d3 = DateTime.Today;//Cria com o dia, mas hora zerado
            DateTime d4 = DateTime.UtcNow;//cria com hora do GMT(Meridiano de greenwitch)
            DateTime d5 = DateTime.Parse("2000-05-24");//Ou pode usar / pra separar 
            DateTime d6 = DateTime.Parse("2000-05-24 13:04:54");
            DateTime d7 = DateTime.ParseExact("2000-08-14", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d8 = DateTime.ParseExact("2000-08-14 13:05:09", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine(d8);
        }
    }
}
