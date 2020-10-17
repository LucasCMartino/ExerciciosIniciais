using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http.Headers;
using System.Text;

namespace CursoNelioAlves.ConstrutoresTHIS
{
    class ProdutoConstrutor
    {
        public static void Executar()
        {
            Console.Write("Nome : ");
            var nome = Console.ReadLine();
            Console.Write("Preço : ");
            var preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade : ");
            var quantidade = int.Parse(Console.ReadLine());
            AuxiliarConstrutor p2 = new AuxiliarConstrutor(nome,preco,quantidade) // outra maneira de cria obj
            {
                Nome = "TV",
                Preco = 700.00,
                Quantidade = 5
            };
            Console.WriteLine(p2);
            AuxiliarConstrutor p = new AuxiliarConstrutor(nome, preco,quantidade);
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
