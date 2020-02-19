using System;

namespace References_Fixed
{
    class Program
    {
        static void Main(string[] args)
        {
            var ninjas = new [] { "Itachi", "Kisame", "Naruto"};
            for(var i = 0; i < 3 ; i++)
            {
                AddGreeting(ref ninjas[i]);
            }
            foreach(var ninja in ninjas)
            {
                Console.WriteLine(ninja);
            }

            int n = 5;

            PassagemPorValor(n);
            Console.WriteLine($"Passagem de parâmetros por valor: {n}");

            PassagemPorReferencia(ref n);

            Console.WriteLine($"Passagem de parâmetros por referência: {n}");


        }


        //O ref é para passar o argumento por referência, ou seja, em vez de passar o seu valor,
        //passa-se um apontador que indica onde está o valor.Desta forma quando o parâmetro tiver
        //alterado seu valor, estará alterando o valor do argumento já que eles estão na
        //mesma posição de memória.
        static void AddGreeting(ref string ninja)
        {
            ninja = "Greetings " + ninja;
        }



        //O valor é recebido, é alocado um outro espaço na memória que recebe o valor, porém quando
        //termina o método este espaço na memério é zerado e é impresso o valor 5
        static void PassagemPorValor(int a)
        {
            a = 10;
        }


        //O valor int a é recebido por referência, ou seja é alocado somente um espaço de memória
        //no momento que a = 10 neste mesmo espaço de memória ele é substituído pelo novo valor
        //desta forma ele é modificado.
        static void PassagemPorReferencia(ref int a)
        {
            a = 10;
        }
    }
}
