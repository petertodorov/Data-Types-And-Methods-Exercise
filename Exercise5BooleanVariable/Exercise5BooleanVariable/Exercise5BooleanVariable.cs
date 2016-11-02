using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Exercise5BooleanVariable
{
    static void Main(string[] args)
    {
        string state = Console.ReadLine();
        bool converted = Convert.ToBoolean(state);
        if (converted)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

