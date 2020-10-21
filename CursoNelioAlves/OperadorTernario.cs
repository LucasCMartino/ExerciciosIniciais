using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CursoNelioAlves.Parte_7._1
{
    class OperadorTernario
    {
        public static void Executar()
        {
            Console.Write("Write price : ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double discount = (price < 20.0) ? price * 0.1 : price * 0.05;
            //                condição   Se for verdadeiro    Se for falso
            Console.Write("Price for Discount : " + discount);
        }
    }
}
