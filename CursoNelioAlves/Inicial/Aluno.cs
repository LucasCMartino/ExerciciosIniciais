using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CursoNelioAlves
{
    class Aluno
    {
        public static void Executar()
        {
            var aluno = new AuxiliarAluno();
            Console.Write("Nome do Aluno : ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno : ");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            var notaFinal = aluno.CalcularNota();
            Console.WriteLine("Nota Final = {0}", notaFinal);
        }
    }
}
