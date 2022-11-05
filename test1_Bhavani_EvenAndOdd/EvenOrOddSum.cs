using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1_Bhavani_EvenAndOdd
{
    public  class EvenOrOddSum
    {
        int evenSum;
        int oddSum;
        string even;
        string  odd;
        int i;
        public void EvenOrOddMethod()
        {
            Console.WriteLine("Enter value:");
            int n=Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    even = even + "      " + i;
                    evenSum = evenSum + i;
                }
                else
                {
                    odd = odd + "    " + i;
                    oddSum = oddSum + i;
                }
            }    
             Console.WriteLine("Even Numbers:" + even);
             Console.WriteLine(("sum of the even numbers:" + evenSum));
             Console.WriteLine("odd Numbers:" + odd);
             Console.WriteLine(("sum of the odd numbers:" + oddSum));

        }

        

    }
}
