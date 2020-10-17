using System;
using System.Globalization;
using System.Text;

namespace CursoNelioAlves
{
    class Cardapio
    {
        public static void Executar()
        {
            Console.WriteLine("Qual seu pedido ? ");
            double pedido = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas unidades ? ");
            double quantidade = int.Parse(Console.ReadLine());
            double total = 0;
            if(pedido == 1)
            {
                total = quantidade * 4.0;
            }else if (pedido ==2)
            {
                total = quantidade *4.5;
            }
            else if (pedido == 3)
            {
                total = quantidade * 5.0;
            }
            else if (pedido == 4)
            {
                total = quantidade * 2.0;
            }
            else if (pedido == 5)
            {
                total = quantidade * 1.5;
            }
            Console.WriteLine("Total do seu pedido deu R${0}",total.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
