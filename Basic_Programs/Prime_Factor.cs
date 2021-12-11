using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core.PrimeFactor
{
    public class Prime_Factor
    {
        public void primefactor()
        {
            int j;
            Console.WriteLine("ENTER A NUMBER");
            int N=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Prime Factor of" + N, "are: ");
            for (j=1;j*j<=N;j++)
            {
          
                
                if(N%j==0)
                {
                    
                    Console.WriteLine(j);
                    
                }
              
            }
        }
    }
}
