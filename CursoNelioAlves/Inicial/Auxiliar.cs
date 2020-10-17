using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CursoNelioAlves
{
    class Auxiliar
    {
        public string Nome;
        public int Idade;
        public double Salario;
    }
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarQuantidade(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverQuantidade(int quantidade)
        {
            Quantidade -= quantidade;   
        }
        public override string ToString()
        {
            return Nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + " " + Quantidade + " unidades , Total $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
