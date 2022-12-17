using System;
using DemoClasses.Math;
namespace DemoClasses
{	
	
	class Program
	{
		static void Main(string[] args)
		{
			//creating object
            var person = new Person();
            person.firstName = "Prasiddha";
            person.lastName = "Shrestha";
			var Calculator = new Calculator();
	
          A:  Console.Write("Enter option:");
			int c =Convert.ToInt32( Console.ReadLine() );
            
            if (c > 3)
            {
                Console.WriteLine("wrong input");
              
                goto A;
            }
            switch (c)
			{
				case 1:
                    person.Introduce();//accessing method creating object
					break;

				case 2:
					Person.Introduc("Prasiddha","Shrestha");//accessing method directly from class
					break;

				case 3:
					int result=Calculator.Add(3,4);
					Console.WriteLine(result);
					break;
            }
		}
	}
}