using System;
using System.Collections.Generic;
using System.Text;

namespace CursoNelioAlves
{
    class Duracao
    {
        public static void Executar()
        {
            Console.WriteLine("Qual hora começou o jogo ? ");
            var horaInicial = double.Parse(Console.ReadLine());
            Console.WriteLine("Que horas terminou o jogo ? ");
            var horaFinal = double.Parse(Console.ReadLine());
            double duracao = 0.0;
            if(horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }else
            {
                duracao = 24 - horaInicial + horaFinal;
            }
            Console.WriteLine($"O Jogo durou {duracao} Hora(s) ");
        }
    }
}
