using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core.Compute
{
    public class Quotient_Remainder
    {
        public void program()
        {
          
            Console.WriteLine("ENTER A DIVIDEND");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER A DIVISOR");
            int divisor= Convert.ToInt32(Console.ReadLine());
            int quotient=dividend/divisor;
            int remainder=dividend%divisor;
            Console.WriteLine("QUOTIENT IS:" + quotient);
            Console.WriteLine("REMAINDER IS:" + remainder);


        }
    }
}
