using System;
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

			
          A:  Console.Write("Enter option:");
			int c =Convert.ToInt32( Console.ReadLine() );
            
            if (c > 2)
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
				

            }
			
			
		}
	}
}