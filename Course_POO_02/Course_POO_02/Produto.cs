﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course_POO_02
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmStoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }

        public override string ToString()
        {
            return Nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture)
                +", " + Quantidade + " unidades, Total: $ "
                + ValorTotalEmStoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
