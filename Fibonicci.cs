using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    class Fibonicci
    {
        public void checkSeries()

        {
            Console.WriteLine("enter number :");
            int num = Convert.ToInt32(Console.ReadLine());

            int n1 = 0;
            int n2 = 1;
            int n3;

            for (int i = 1; i < num; i++)
            {
                n3 = n1 + n2;
                Console.WriteLine("calculation of series" + n3);
                n1 = n2;
                n2 = n3;

            }
        }

    }
}
