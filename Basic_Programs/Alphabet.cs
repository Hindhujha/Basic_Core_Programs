using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core.Alphabet
{
    internal class Alphabet
    {
        public void Alph()
        {
            Console.WriteLine("ENTER AN ALPHABET: ");

            char alphabet = Console.ReadKey(true).KeyChar;
            switch (alphabet)
            {
                case 'a':
                case 'A':
                case 'e':
                case 'E':
                case 'i':
                case 'I':
                case 'o':
                case 'O':
                case 'u':
                case 'U':
                    Console.WriteLine( "VOWEL");
                    break;
                default:
                    Console.WriteLine(alphabet + "CONSONANT");
                    break;
            }
        }
    }
}

