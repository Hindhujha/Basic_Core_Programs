using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//prints a table of pwwers of 2 that are less than/equal to 2^N
namespace Basic_Core.Power_Of_2
{
    public class Power_of2
    {
        public void power()
        {
            int count=0;
            int powof2 = 1; //power of 2
            Console.WriteLine("ENTER A VALUE FOR N");
            int N=Convert.ToInt32(Console.ReadLine());
            if(0<=N && N<31)
            {
                while(count<=N)
                {
                    Console.WriteLine("POWER OF 2=" + powof2);
                    powof2 = 2 * powof2;
                    count += 1;
                }
            }

        }
    }
}
