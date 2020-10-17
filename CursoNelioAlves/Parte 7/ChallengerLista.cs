using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CursoNelioAlves.Parte_7
{
    class ChallengerLista
    {
        private readonly static FuncionarioFactory _factoryFuncionario = new FuncionarioFactory();

        public ChallengerLista()
        {
        }

        public static void Executar()
        {
            Console.Write("Entre com o número de funcionários : ");
            int n = int.Parse(Console.ReadLine());
            List<Funcionario> funcionarios = new List<Funcionario>(n);

            for (int i = 1; i <= n; i++)
            {
                funcionarios.Add(_factoryFuncionario.CreateFuncionario(i));
            }

            Console.Write("Informe o ID de um funcionário para receber um aumento de salário : ");
            int idAumento = int.Parse(Console.ReadLine());

            Funcionario func = funcionarios.Find(x => x.ID == idAumento);
            if (func != null)
            {
                Console.Write("Entre com a porcentagem de aumento : ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                func.AumentoSalario(porcentagem);
            }
            else Console.Write("Funcionário não existente ! ");
            Console.WriteLine("Lista atualizada de funcionários : ");
            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine(funcionario);
            }
        }
    }
}
