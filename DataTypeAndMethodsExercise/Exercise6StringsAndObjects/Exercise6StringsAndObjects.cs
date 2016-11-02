using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Exercise6StringsAndObjects
{
    static void Main(string[] args)
    {
        string firstWord = "Hello";
        string secondWord = "World";
        object sentence = firstWord + " " + secondWord;
        string casted = (string)sentence;
        Console.WriteLine(casted);
    }
}

