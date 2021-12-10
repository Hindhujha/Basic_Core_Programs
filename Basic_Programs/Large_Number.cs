using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core.Largest
{
    public class Large_Number
    {
        public void large()
        {
            float n1, n2, n3;
            Console.WriteLine("ENTER ANY THREE NUMBERS");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = Convert.ToInt32(Console.ReadLine());

            if (n1 >= n2 && n1 >= n3)
            {
                Console.WriteLine("Largest Number is :" + n1);
            }
            if (n2 >= n1 && n2 >= n3)
            {
                Console.WriteLine("Largest Number is :" + n2);
            }
            if (n3 >= n2 && n3 >= n1)
            {
                Console.WriteLine("Largest Number is :" + n3);
            }
        }
    }
}
