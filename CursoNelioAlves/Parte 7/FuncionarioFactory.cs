using System;
using System.Globalization;

namespace CursoNelioAlves.Parte_7
{
    public class FuncionarioFactory
    {
        public Funcionario CreateFuncionario(int index)
        {
            Funcionario fulano = new Funcionario();

            Console.WriteLine("Funcionário #" + index);

            Console.Write("Id : ");

            fulano.ID = int.Parse(Console.ReadLine());

            Console.Write("Nome : ");

            fulano.Nome = Console.ReadLine();

            Console.Write("Salário : ");

            fulano.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(" ");

            return fulano;
        }
    }
}
