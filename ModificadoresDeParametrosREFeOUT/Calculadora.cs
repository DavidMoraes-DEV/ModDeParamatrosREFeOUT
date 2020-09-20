using System;
using System.Collections.Generic;
using System.Text;

namespace ModificadoresDeParametrosREFeOUT
{
    class Calculadora
    {
        /*Ao adicionar a palavra REF no parâmetro da função,
         ela permitirá que a função consiga alterar o valor da
         variável que foi enviado como parâmetro, pois a variável
         da função funcionara como uma referência para a variável
         original, ou seja, ela passará a apontar para a variável
         original, tornando assim possível alterar seu valor,
         possibilitando que o resultado da função exemplo
         seja atribuido a variável original que foi enviada como
         parâmetro para a operação*/

        public static void Triplicar(ref int x)         {
            x = x*3;
        }

        /*Ja o modificador OUT é similar ao REF(faz o parâmetro ser uma referência
         para a variável original), mas a diferencia é que o OUT não exige que a
        variável original seja iniciada. E deve ser atribuido a variavel
        que terá o resultado da função*/

        public static void Triplicar2(int x, out int y) 
        {
            y = x * 3;
        }

    }
}
