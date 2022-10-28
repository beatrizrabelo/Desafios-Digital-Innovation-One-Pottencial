using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioInterUm
{
    //1 - Dado um array nums de tamanho n, retorne o elemento majoritário, isto é, o elemento que aparece o maior número de vezes no seu array.
    public class ElementoMarjoritario
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] num = new int[n];

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(MajorityElement(num));
        }

        public static int MajorityElement(int[] nums)
        {
            //   2        2
            int major = nums[0];
            int count = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != major)
                {
                    major = nums[i];
                    count--;
                }
                else
                {
                    if (major == nums[i])
                    {
                        count++;
                    }
                    else
                    {
                        count--;
                    }
                }
            }

            return major;
        }
    }
}