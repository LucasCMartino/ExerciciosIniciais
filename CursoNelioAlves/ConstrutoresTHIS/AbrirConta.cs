using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CursoNelioAlves.ConstrutoresTHIS
{
    class AbrirConta
    {
        public static void Executar()
        {
            double saldo = 0;
            Console.Write("Entre com o número da conta : ");
            var numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta : ");
            var nome = Console.ReadLine();
            Console.Write("Haverá um depósito inicial ? (s/n) ");
            var resposta = Console.ReadLine();
            if (resposta == "s"|| resposta == "S" )
            {
                Console.Write("Entre o valor de depósito inicial :");
                saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            ContaBancaria conta = new ContaBancaria(numeroConta, nome, saldo);

            Console.WriteLine();
            Console.WriteLine("Dados da Conta :\n" + conta.ToString());
            Console.WriteLine();
            Console.Write("Entre com um valor para depósito : ");
            conta.AumentarSaldo(double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da Conta Atualizados :\n" + conta.ToString());
            Console.WriteLine();
            Console.Write("Entre com um valor para saque : ");
            conta.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da Conta Atualizados :\n" + conta.ToString());
        }
    }
}
