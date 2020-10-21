using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CursoNelioAlves
{
    class MaiorSalario
    {
        public static void Executar()
        {
            Auxiliar a = new Auxiliar();
            Auxiliar b = new Auxiliar();
            Console.WriteLine("Informe o nome do infeliz : ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Informe o salario do {0} ",a.Nome);
            a.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Informe o nome do infeliz : ");
            b.Nome = Console.ReadLine();
            Console.WriteLine("Informe o salario do {0} ",a.Nome);
            b.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) ;
            if (a.Salario > b.Salario)
            {
                Console.WriteLine($"{a.Nome} tem o maior salário");
            }
            else { Console.WriteLine($"{b.Nome} tem o maior salário "); }
            var media = (a.Salario + b.Salario) / 2;
            Console.WriteLine($"Média salarial = {media}");
        }
    }
}
