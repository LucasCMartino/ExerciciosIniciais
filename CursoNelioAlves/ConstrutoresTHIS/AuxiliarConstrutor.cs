using System;
using System.Globalization;
using System.Reflection.PortableExecutable;
using System.Text;

namespace CursoNelioAlves.ConstrutoresTHIS
{
    class AuxiliarConstrutor
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Quarto { get; set; }
        public double Price { get; set; }


        public string Nome;
        public double Preco;
        public int Quantidade;

        public AuxiliarConstrutor() { }
        public AuxiliarConstrutor(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public AuxiliarConstrutor(string nome, double preco) //Sobrecarga de construtor
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 0; //opcional no caso for 0 pq por padrão já seria numero 0
        }


        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public static double Calculadora(ref double x)
        {
            return x = x * 3;
        }


    }
    //public override string ToString()
    //{
    //    return Nome
    //    + ", $ "
    //    + Preco.ToString("F2", CultureInfo.InvariantCulture)
    //    + ", "
    //    + Quantidade
    //    + " unidades, Total: $ "
    //    + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
}