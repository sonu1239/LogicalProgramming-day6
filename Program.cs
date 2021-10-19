using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your program name");

            Console.WriteLine("1.fibonacci\n2.perfect no\n3.prime no\n4.reverseNumber\n5.stopwatch");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Fibonicci play = new Fibonicci();
                    play.checkSeries();
                    break;

                case 2:
                    perfectNo play1 = new perfectNo();
                    play1.checkPerfectNo();
                    break;

                case 3:
                    PrimeNo play3 = new PrimeNo();
                    play3.primeNoCheck();
                    break;

                case 4:
                    ReverseNo play4 = new ReverseNo();
                    play4.reverseNo();
                    break;

                case 5:
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.stopWatch();
                    break;



            }
        }
    }
}