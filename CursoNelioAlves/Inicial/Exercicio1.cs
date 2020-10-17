using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CursoNelioAlves
{
    class Exercicio1
    {
        public static void Executar()
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";
            byte idade = 30;
            int condigo = 5290;
            char genero = 'F';
            double preco1 = 2100.0;
            double preco2 = 650.50;
            double media = 53.234567;

            Console.WriteLine("Produtos : ");
            Console.WriteLine($"{produto1}, cujo preço é ${preco1.ToString("F2")}");
            Console.WriteLine($"{produto2}, cujo preço é ${preco2}");

            Console.WriteLine($"Registro : {idade} anos de idade, código {condigo} e gênero {genero}");

            Console.WriteLine($"Medida com oito casas decimais : {media.ToString("F8")}");
            Console.WriteLine($"Arredondado {media.ToString("F3")}");
            Console.WriteLine("Separador decimal invariant cultute " + media.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
