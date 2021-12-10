using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core.LeapYear
{
    public class LeapYear
    {
        public void years()
        {
            Console.WriteLine("ENTER A YEAR");
            int year=Convert.ToInt32(Console.ReadLine());
            if( (year%400==0) || (year%100!=0 && year%4==0) )
            {
                Console.WriteLine("IT IS A LEAP YEAR");
            }
            else
            {
                Console.WriteLine("IT IS NOT A LEAP YEAR");
            }
        
        }
    }
}
