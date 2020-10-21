using System;
using System.Globalization;

namespace CursoNelioAlves.ConstrutoresTHIS
{
    class ContaBancaria
    {
        //public int Numero { get; private set; }
        //public string Nome { get; set; }

        //public double Saldo { get; private set; }

        public int NumeroConta;
        public string Nome;
        public double Saldo;

        public ContaBancaria(int numeroConta,string nome,double saldo)
        {
            NumeroConta = numeroConta;
            Nome = nome;
            Saldo = saldo;
        }

        //public void Deposito(double saldo)
        //{
        //    Saldo += saldo;
        //}
        //public void Saque(double saldo)
        //{
        //    Saldo -= saldo + 5.0;
        //} 
        public void AumentarSaldo(double saldo)
        {
            Saldo += saldo;
        }
        public double Saque(double saldo)
        {
            return Saldo -= saldo;
        }
      
        public override string ToString()
        {
            return "Conta " + NumeroConta.ToString() + ", Titular : " + Nome + ", Saldo : $"
                + Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
