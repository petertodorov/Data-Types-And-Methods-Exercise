using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;



class Exercise10CenturiesToNanoseconds
{
    static void Main(string[] args)
    {
        int century = int.Parse(Console.ReadLine());
        double year = century * 100;
        double days = Math.Floor(year * 365.2422);
        double hours = Math.Floor(days * 24);
        double minutes = Math.Floor(hours * 60);
        long seconds =(long) Math.Floor(minutes * 60);
        long miliseconds = (long)(seconds * 1000);
        long microseconds = (long)(miliseconds * 10000);
        BigInteger nanoseconds =new BigInteger(microseconds * 100000);

        Console.WriteLine($"{century} centuries = {year} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {miliseconds} miliseconds = {microseconds} microseconds = {nanoseconds}");
       
    }
}
