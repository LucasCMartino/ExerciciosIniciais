using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace CursoNelioAlves
{
    class Challenger
    {
        public static void Executar()
        {

            List<Auxiliar> auxiliars = new List<Auxiliar>();
            Console.Write("Informe quantas pessoas deseja comparar : ");
            var numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < numero; i++)
            {
                var aux = new Auxiliar();
                Console.Write("Nome : ");
                aux.Nome = Console.ReadLine();
                Console.Write("Salário : ");
                aux.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                auxiliars.Add(aux);
            }
            var maior = auxiliars.Max(aux => aux.Salario);
          
            Console.WriteLine($"O Maior Salário é R${maior}, e pertence ao ");

            //Auxiliar a = new Auxiliar();
            //Auxiliar b = new Auxiliar();
            //Auxiliar c = new Auxiliar();
            //Auxiliar d = new Auxiliar();
            //Auxiliar e = new Auxiliar();
            //Auxiliar f = new Auxiliar();
            //Auxiliar g = new Auxiliar();
            //Auxiliar h = new Auxiliar();
            //Console.Write("Informe o nome do 1º funcionario : ");
            //a.Nome = Console.ReadLine();
            //Console.Write("Informe o salário 1º funcionário : ");
            //a.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.Write("Informe o nome do 2º funcionario : ");
            //b.Nome = Console.ReadLine();
            //Console.Write("Informe o salário 2º funcionário : ");
            //b.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.Write("Informe o nome do 3º funcionario : ");
            //c.Nome = Console.ReadLine();
            //Console.Write("Informe o salário 3º funcionário : ");
            //c.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.Write("Informe o nome do 4º funcionario : ");
            //d.Nome = Console.ReadLine();
            //Console.Write("Informe o salário 4º funcionário : ");
            //d.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.Write("Informe o nome do 5º funcionario : ");
            //e.Nome = Console.ReadLine();
            //Console.Write("Informe o salário 5º funcionário : ");
            //e.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.Write("Informe o nome do 6º funcionario : ");
            //f.Nome = Console.ReadLine();
            //Console.Write("Informe o salário 6º funcionário : ");
            //f.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.Write("Informe o nome do 7º funcionario : ");
            //g.Nome = Console.ReadLine();
            //Console.Write("Informe o salário 7º funcionário : ");
            //g.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.Write("Informe o nome do 8º funcionario : ");
            //h.Nome = Console.ReadLine();
            //Console.Write("Informe o salário 8º funcionário : ");
            //h.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //if (a.Salario > b.Salario && a.Salario > c.Salario && a.Salario > d.Salario && a.Salario > e.Salario && a.Salario > f.Salario && a.Salario > g.Salario && a.Salario > h.Salario)
            //{
            //    Console.WriteLine($"{a.Nome} têm o maior salario : R$ {a.Salario}");
            //}else if (b.Salario > c.Salario && b.Salario > d.Salario && b.Salario > e.Salario && b.Salario > f.Salario && b.Salario > g.Salario && b.Salario > h.Salario)
            //{
            //    Console.WriteLine($"{b.Nome} têm o maior salario : R$ {b.Salario}");
            //}else if(c.Salario > d.Salario && c.Salario > e.Salario && c.Salario > f.Salario && c.Salario > g.Salario && c.Salario > h.Salario)
            //{
            //    Console.WriteLine($"{c.Nome} têm o maior salario : R$ {c.Salario}");
            //}else if(d.Salario > e.Salario && d.Salario > f.Salario && d.Salario > g.Salario && d.Salario > h.Salario)
            //{
            //    Console.WriteLine($"{d.Nome} têm o maior salario : R$ {d.Salario}");
            //}else if(e.Salario > f.Salario && e.Salario > g.Salario && e.Salario > h.Salario)
            //{
            //    Console.WriteLine($"{e.Nome} têm o maior salario : R$ {e.Salario}");
            //}else if(f.Salario > g.Salario && f.Salario > h.Salario)
            //{
            //    Console.WriteLine($"{f.Nome} têm o maior salario : R$ {f.Salario}");
            //}else if(g.Salario > h.Salario)
            //{
            //    Console.WriteLine($"{g.Nome} têm o maior salario : R$ {g.Salario}");
            //}else Console.WriteLine($"{h.Nome} têm o maior salario : R$ {h.Salario}");

        }
    }
}
