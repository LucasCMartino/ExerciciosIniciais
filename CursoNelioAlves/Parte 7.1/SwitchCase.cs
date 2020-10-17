using System;
using System.Collections.Generic;
using System.Text;

namespace CursoNelioAlves.Parte_7._1
{
    class SwitchCase
    {
        public static void Executar()
        {
            Console.Write("Choose day from Week : ");
            int x = int.Parse(Console.ReadLine());
            string day;
            switch (x)
            {
                case 1:
                    day = "Sunday";
                    break;
                case 2:
                    day = "Monday";
                    break;
                case 3:
                    day = "Tuesday";
                    break;
                case 4:
                    day = "Wednesday";
                    break;
                case 5:
                    day = "Thursday";
                    break;
                case 6:
                    day = "Friday";
                    break;
                case 7:
                    day = "Saturday";
                    break;
                default:
                    day = "Invalid Day";
                    break;
            }
            Console.WriteLine("Day the Week : " + day);
        }
    }
}
