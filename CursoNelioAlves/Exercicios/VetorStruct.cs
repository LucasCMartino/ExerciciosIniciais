using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CursoNelioAlves.Parte_7
{
    class VetorStruct
    {
        public static void Executar()
        {
            Console.Write("Informe quantas alturas deseja comparar : ");
            var n = int.Parse(Console.ReadLine());
            double[] vect = new double[n];
            for (int i = 0; i < n; i++)   //Adicionando no vetor
            {
                Console.Write("informe o valor desejado : ");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma += vect[i];
            }
            double resultado = soma / n;
            Console.Write("AVERANGE HEIGHT " + resultado.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
