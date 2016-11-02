using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Exercise9ReverseCharacters
{
    static void Main(string[] args)
    {
        string[] toReverse = new string[3];        
        for (int j = 0; j < toReverse.Length; j++)
        {
            toReverse[j] = Console.ReadLine();
        }
        Array.Reverse(toReverse);
        for (int i = 0; i < toReverse.Length; i++)
        {
            Console.Write(toReverse[i]);
        }
    }
}
