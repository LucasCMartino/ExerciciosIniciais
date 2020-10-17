using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CursoNelioAlves
{
    class ConversorMoeda
    {
        public static void Executar()
        {
            Console.Write("Qual a cotação do dólar ? ");
            var cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você irá comprar ? ");
            var quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            var result = AuxiliarConversor.ConversorParaDolar(quantia, cotacao);
             Console.WriteLine("Valor a ser pagos em reias : {0}", result.ToString("F2" , CultureInfo.InvariantCulture));
        }
    }
}
