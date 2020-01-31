using System;
using System.Collections.Generic;
using System.Text;

namespace Course_POO_Modificadores_Parametro
{
    class Calculator
    {
        /*public static void Triple(ref int x) //após usar a palavra ref, o parâmetro 'x' vai se tornar uma variavel referência para a variavel original.
        {
            x = x * 3;
        }*/
        public static void Triple(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}
