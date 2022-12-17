using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClasses
{
    public class Person
    {
        public string firstName;
        public string lastName;

        public void Introduce()
        {
            Console.WriteLine($"Hello My name is {firstName} {lastName}");
        }
        //using static Modifier
        public static void Introduc(string firstName, string lastName)
        {
            Console.WriteLine($"Hello My name is {firstName} {lastName}");
        }
    }
}
