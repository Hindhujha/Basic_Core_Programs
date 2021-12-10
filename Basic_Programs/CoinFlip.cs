using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core.CoinFlip
{
    internal class CoinFlip
    {
        public void coin()
        {
            Double count1=0, count2=0;
            Double tail_percent, head_percent;
            Console.WriteLine("ENTER NUMBER OF TIMES TO COIN FLIP");
            int coinflip = Convert.ToInt32(Console.ReadLine());
           for(int i=1;i<=coinflip;i++)
            {
                Random rand = new Random();
                Double value = rand.NextDouble();
                Console.WriteLine("RANDOM VALUE IS:" + Math.Round(value,1));
                if (value < 0.5)
                {
                    Console.WriteLine("TAILS");
                    count1 += value;
                    
                }
                else
                {
                    Console.WriteLine("HEADS");
                    count2 += value;
                
                }
            }

            tail_percent = (count1/coinflip) * 100;
            head_percent = (count2/coinflip) * 100;
            Console.WriteLine("TAIL PERCENTAGE : " + Math.Round(tail_percent,2)); 
            Console.WriteLine("HEAD PERCENTAGE : " + Math.Round(head_percent,2));
        
        }
    }
}
