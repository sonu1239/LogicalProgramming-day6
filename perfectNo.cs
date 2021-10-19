using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    class perfectNo
    {
        public void checkPerfectNo()
        {
            Console.WriteLine("enter number :");
            int num = Convert.ToInt32(Console.ReadLine());

            //Local Variables
            int num1 = num / 2;
            int sum = 0;
            int sum1;

            for (int i = 1; i <= num1; i++)
            {
                sum1 = num % i;
                if (sum1 == 0)
                {
                    sum = sum + i;
                    Console.WriteLine("{0}", i);
                }
            }


            if (sum == num)
            {
                Console.WriteLine("The Given Number Is Perfect Number.");
            }
            else
            {
                Console.WriteLine("The Given Number Is Not Perfect Number.");
            }

        }
    }
}
