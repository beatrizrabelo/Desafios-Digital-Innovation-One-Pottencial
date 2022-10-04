using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioBasicoUm
{
    public class SubtracaoSomaProduto
    {

        //1 - Dado um número inteiro  retorne a diferença entre o produto de seus digitos e a soma de seus dígitos.

        public static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());
            int produto = 1, soma = 0;
            while (numero > 0)
            {
                int mod = numero % 10;

                produto *= mod;
                soma += mod;
                numero /= 10;
            }

            Console.WriteLine(produto - soma);
        }
    }
}