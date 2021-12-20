using System;
using System.Globalization;

namespace Projeto_2_AED_1
{
    class Produto
    {
        private string Nome;
        private double Preco;
        private int Quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }



        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }

        public void AdicionarProduto(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }

        public override string ToString()
        {
            return Nome +
                ", R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + "\n"
                + Quantidade
                + " Unidades total : R$ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
