using System;

namespace DesafioBasicoDois
{
    public class EncaixaNaoEncaixa
    {
        // 2 - Paulinho tem em suas mãos um novo problema. Agora a sua professora lhe pediu que construisse um programa para verificar, a partir de dois valores muito grandes A e B, se B corresponde aos últimos digitos de A.
        public static void Main(string[] args)
        {
            int quantidade = int.Parse(Console.ReadLine());

            string[] valor = new string[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                valor = Console.ReadLine().Split(" ");

                string a = valor[0];
                string b = valor[1];

                if (b.Length > a.Length)
                    Console.WriteLine("não encaixa");
                else if (a.EndsWith(b))
                    Console.WriteLine("encaixa");
                else
                    Console.WriteLine("não encaixa");

            }
        }
    }
}