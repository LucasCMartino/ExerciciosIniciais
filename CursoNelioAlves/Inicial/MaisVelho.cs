using System;
using System.Collections.Generic;
using System.Text;

namespace CursoNelioAlves
{
    class MaisVelho
    {
        public static void Executar()
        {
            Auxiliar a = new Auxiliar();
            Auxiliar b = new Auxiliar();
            Console.Write("Digite o Nome da Pessoa : ");
            a.Nome = Console.ReadLine();
            Console.Write("Informe a Idade da Pessoa : ");
            a.Idade = int.Parse(Console.ReadLine());
            Console.Write("Digite o Nome da Pessoa : ");
            b.Nome = Console.ReadLine();
            Console.Write("Informe a Idade da Pessoa : ");
            b.Idade = int.Parse(Console.ReadLine());
            if (a.Idade > b.Idade)
            {
                Console.WriteLine($"{a.Nome} é mais velho(a)");
            }
            else { Console.WriteLine($"{b.Nome} é mais velho(a)"); }

        }
    }
}
