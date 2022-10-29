using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioInterUm
{
    public class ElementoMarjoritario
    {
        public static void Main(String[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] num = new int[n];

            // TODO: Crie as outras condições necessárias para a resolução do desafio:
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(MajorityElement(num));

        }
        public static int MajorityElement(int[] nums)
        {
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