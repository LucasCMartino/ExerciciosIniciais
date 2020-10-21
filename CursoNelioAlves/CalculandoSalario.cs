using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CursoNelioAlves
{
    class CalculandoSalario
    {
        public static void Executar()
        {
            var funcionario = new AuxiliarSalario();
            Console.Write("Nome : ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salário Bruto : ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto : ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(funcionario);
            Console.Write("Digite a Porcentagem para aumentar o salário do {0} : ", funcionario.Nome);
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Dados atualizados : " + funcionario);
        }
    }
}
