using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core.EvenorOdd
{
    public  class EvenOdd

    {
        public void EVENODD()
        {
            int n;
            Console.WriteLine("ENTER A NUMBER");
            n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine(n + " IS A EVEN NUMBER");
            }
            else
            {
                Console.WriteLine(n + " IS A ODD NUMBER");
            }
        }
    }
}
