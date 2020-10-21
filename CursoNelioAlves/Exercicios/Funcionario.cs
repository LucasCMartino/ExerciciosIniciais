using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CursoNelioAlves.Parte_7
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public int ID { get; set; }
        public double Salario { get; set; }

        public Funcionario()
        {

        }

        public Funcionario(string nome, int id, double salario)
        {
            Nome = nome;
            ID = id;
            Salario = salario;
        }

        public override string ToString()
        {
            return ID
                          + ", "
                          + Nome
                          + ", "
                          + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
        public void AumentoSalario(double percentage)
        {
            Salario += Salario * percentage / 100.0;
        }
    }
}
