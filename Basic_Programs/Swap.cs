using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core.Swap
{
   public class Swap
    {
        public void Swap2_numbers()
        {
            int num1, num2, temp;
            Console.WriteLine("BEFORE SWAPPING: ");
            Console.WriteLine("ENTER TWO NUMBERS");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("AFTER SWAPPING: ");
            Console.WriteLine("FIRST NUMBER: " + num1);
            Console.WriteLine("SECOND NUMBER: " + num2);

        }

    }
}
