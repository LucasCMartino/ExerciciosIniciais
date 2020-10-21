using CursoNelioAlves.ConstrutoresTHIS;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CursoNelioAlves.Parte_7
{
    class VetorClass
    {
        public static void Executar()
        {
            Console.Write("Informe o número de produtos : ");
            var n = int.Parse(Console.ReadLine());
            AuxiliarConstrutor[] vect = new AuxiliarConstrutor[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Informe o Nome : ");
                string name = Console.ReadLine();
                Console.Write("Informe o Preço : ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new AuxiliarConstrutor { Name = name, Price = price };//pra instancia com classe
            }
            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma += vect[i].Price;//tem q usa . pra puxa algum atributo construido
            }
            double avg = soma / n;
            Console.Write("AVERAGE PRICE : " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
