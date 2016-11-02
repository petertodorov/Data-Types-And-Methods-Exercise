using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Exercise8EmployeeData
{
    static void Main(string[] args)
    {
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        char gender =char.Parse (Console.ReadLine());
        long  personalId = long.Parse(Console.ReadLine());
        uint uniqueEmployeeNumber = uint.Parse(Console.ReadLine());
        Console.WriteLine($"First name: {firstName}\nLast name: {lastName}\nAge: {age}\nGender: {gender}\nPersonal ID: {personalId}\nUnique Employee number: {uniqueEmployeeNumber}");
        }
}

