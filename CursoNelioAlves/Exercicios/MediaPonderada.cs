using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CursoNelioAlves
{
    class MediaPonderada
    {
        public static void Executar()
        {
            Console.Write("Informe quantos casos de media deseja realizar : ");
            var casos = int.Parse(Console.ReadLine());
            double nota1 = 0;
            double nota2 = 0;
            double nota3 = 0;
            for (int i = 0; i < casos; i++)
            {
                Console.Write("Informe a primeira nota : ");
                nota1 = double.Parse(Console.ReadLine());
                Console.Write("Informe a segunda nota : ");
                nota2 = double.Parse(Console.ReadLine());
                Console.Write("Informe a terceira nota : ");
                nota3 = double.Parse(Console.ReadLine());
            }
            double media = (nota1 * 2.0 + nota2 * 3.0 + nota3 * 5.0) / 10.0;
            Console.WriteLine(media);
        }
    }
}
