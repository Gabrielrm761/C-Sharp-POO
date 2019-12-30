using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
