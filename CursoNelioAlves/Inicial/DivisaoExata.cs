using System;
using System.Collections.Generic;
using System.Text;

namespace CursoNelioAlves
{
    class DivisaoExata
    {
        public static void Executar()
        {
            Console.Write("Informe quantas operações deseja fazer : ");
            var x = int.Parse(Console.ReadLine());
            double resultado = 0;
            for (int i = 0; i < x; i++)
            {
                Console.Write("Primeiro numero para divisão : ");
                double numero1 = double.Parse(Console.ReadLine());
                Console.Write("Segundo número para divisão : ");
                double numero2 = double.Parse(Console.ReadLine());
                if (numero2 == 0)
                {
                    Console.WriteLine("Divisão Impossível");
                }
                else { resultado = numero1 / numero2; }
                Console.WriteLine(resultado);
            }

        }
    }
}
