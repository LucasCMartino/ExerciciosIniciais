using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CursoNelioAlves
{
    class Produtos
    {
        public static void Executar()
        {
            Produto a = new Produto();
            Console.WriteLine("Entre com os dados do produto : ");
            Console.Write("Nome : ");
            a.Nome = Console.ReadLine();
            Console.Write("Preço : ");
            a.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade : ");
            a.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto : " + a);
            Console.Write("\nDigite o número de produtos a ser adicionado(s) : ");
            int qnt = int.Parse(Console.ReadLine());
            a.AdicionarQuantidade(qnt);
            Console.WriteLine("\nDados Atualizados : " + a);
            Console.Write("Digite o número de produtos a ser removido(s) : ");
            qnt = int.Parse(Console.ReadLine());
            a.RemoverQuantidade(qnt);
            Console.WriteLine("\nDados Atualizados : " + a);
        }
    }
}
