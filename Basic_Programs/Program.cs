
using System;

namespace Basic_Core
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BASIC_CORE_PROGRAMS");
            Console.WriteLine("1.EVEN/ODD");
            Console.WriteLine("2.VOWEL/CONSONANT");
            int select=Convert.ToInt32(Console.ReadLine());
          
            while (true)
            {
                switch(select)
                {
                    case 1:
                        EvenorOdd.EvenOdd evenOdd = new  EvenorOdd.EvenOdd();
                        evenOdd.EVENODD();
                        break;
                        case 2:
                            Alphabet.Alphabet alpha=new Alphabet.Alphabet();
                        alpha.Alph();
                        break;
                    default:
                        break;

                }
            }
        }
    }
}