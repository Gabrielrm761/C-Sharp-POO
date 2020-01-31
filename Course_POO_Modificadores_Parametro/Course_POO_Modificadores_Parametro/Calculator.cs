using System;
using System.Collections.Generic;
using System.Text;

namespace Course_POO_Modificadores_Parametro
{
    class Calculator
    {
        public static int Sum(params int[] numbers) //o params vai avisar ao compilador que você quer uma função que possa receber uma quantia varaivel de valores.
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
