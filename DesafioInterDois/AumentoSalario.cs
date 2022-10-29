using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioInterDois
{
    //2 - Leia o salário do funcionário e calcule e mostre o novo salário, bem como o valor de reajuste ganho e o índice reajustado, em percentual.
    public class AumentoSalario
    {
        //1 - Dado um array nums de tamanho n, retorne o elemento majoritário, isto é, o elemento que aparece o maior número de vezes no seu array.
        public static void Main(string[] args)
        {
            double salario = 0.00;
            double reajuste = 0.00;
            double novoSalario = 0.00;
            double percentual = 0.00;

            salario = Convert.ToDouble(Console.ReadLine());

            if (salario < 0)
            {
                return;
            }
            else if (salario <= 400.00)
            {
                percentual = 15.0 / 100;
                reajuste = salario * percentual;
                novoSalario = salario + reajuste;
            }
            else if (salario <= 800.00)
            {
                percentual = 12.0 / 100;
                reajuste = salario * percentual;
                novoSalario = salario + reajuste;
            }
            else if (salario <= 1200.00)
            {
                percentual = 10.0 / 100;
                reajuste = salario * percentual;
                novoSalario = salario + reajuste;
            }
            else if (salario <= 2000.00)
            {
                percentual = 7.0 / 100;
                reajuste = salario * percentual;
                novoSalario = salario + reajuste;
            }
            else
            {
                percentual = 4.0 / 100;
                reajuste = salario * percentual;
                novoSalario = salario + reajuste;
            }

            Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
            Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
            Console.WriteLine("Em percentual: {0}%", percentual * 100);

        }
    }
}