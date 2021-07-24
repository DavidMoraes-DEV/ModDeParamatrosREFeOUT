using System;

namespace ModificadoresDeParametrosREFeOUT
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10; //A palavra REF exige que a variável seja iniciada, ou seja possua um valor.
            Calculadora.Triplicar(ref a); //Para funcionar a função com a palavra ref tem que adicionar a palavra ref na variável que será enviada também.
            Console.WriteLine(a);

            int origin = 20; //Variável original que possui o valor para a função.
            int result; //Variável de Saída, não iniciada que queremos guardar o resultado da função.
            Calculadora.Triplicar2(origin, out result); //Variável "b" que contém o valor que queremos enviar para a operação, e a variável "c" será a variável que receberá o valor resultado da função.
            Console.WriteLine(result);

            /*
             CONSIDERAÇÕES SOBRE "REF" e "OUT":
            - DIFERENÇA:
            A variável passada como parâmetro "ref" DEVE ter sido iniciada.
            A variável passada como parâmetro "out" não precisa ter sido iniciada.

            - CONCLUSÃO:
            Ambos são muito similares, mas "ref" é uma forma de fazer o compilador
            obrigar o usuário a iniciar a variável.

            - NOTA:
            Ambos são considerados "code smells" (design ruim) e deve ser evitados.

             */
        }
    }
}
