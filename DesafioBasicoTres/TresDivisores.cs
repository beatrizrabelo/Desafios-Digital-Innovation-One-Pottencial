using System;

namespace DesafioBasicoTres
{
    public class TresDivisores
    {
        // 3 - Dado um numero inteiro, retorne true se o numero tiver exatamente tres divisores positivos. Caso contrario, retorne false.
        public static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    count++;
                }
                if (count > 3)
                {
                    Console.WriteLine(false);
                }
            }

            Console.WriteLine(count == 3);
        }
    }
}