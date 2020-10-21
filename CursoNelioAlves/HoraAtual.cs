using System;
using System.Collections.Generic;
using System.Text;

namespace CursoNelioAlves
{
    class HoraAtual
    {
        public static void Executar()
        {
            Console.WriteLine("Informe a Hora Atual : ");
            var hora = double.Parse(Console.ReadLine());
            if(hora > 0 && hora <= 6)
            {
                Console.WriteLine("Ainda é Madrugada!");
            }
            else if (hora <= 12)
            {
                Console.WriteLine("Bom Dia !!");
            }
            else if (hora <= 18)
            {
                Console.WriteLine("Boa Tarde !!");
            }
            else if (hora <= 24)
            {
                Console.WriteLine("Boa Noite !!");
            }

        }
    }
}
