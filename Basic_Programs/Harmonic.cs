using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core.Harmonic
{
    internal class Harmonic
    {
        public void Harmonic_Number()
        {
            double sum = 0,result=0;
            double i;
            Console.WriteLine("ENTER THE HARMONIC NUMBER");
           int N = Convert.ToInt32(Console.ReadLine());
            if(N!=0)
            {
                for(i=1;i<=N;i++)
                {
                    sum+=(1/i);
                    result = sum;

                }
            }
            else
            {
                Console.WriteLine("ENTER NON-ZERO NUMBER");
            }
            Console.WriteLine("Nth HARMONIC VALUE IS : " + Math.Round(result,2));
        }
    }
}
