using System;
using System.Collections.Generic;
using System.Text;

namespace Course_POO_03_exec01
{
    class ConversorDeMoeda
    {
        public static double Iof = 6.0;
        public static double Valor(double cotacao, double dolar)
        {
            double total = cotacao * dolar;
            return total + total * Iof / 100;
        }
    }
}
