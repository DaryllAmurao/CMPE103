using System;

namespace BigBikes
{
class Program {
  static void Main() {
    Console.WriteLine("**Welcome to Ride City!**");
    Console.ReadLine();
    Console.WriteLine("Check out our bikes!");
    Console.WriteLine("*****************");

    //call
    listOfBikes();
    switch (userInput)
    {
        case "1":
            caseOne();
            break;
         
        case "2":
             caseTwo();
;            break;
            
        case "3":
             caseThree();
             break;   
            
        case "4":
            caseFour();
            break;
        
        case "5":
            caseFive();
            break;
    }

    Console.WriteLine("Do you want to book for test ride? ");
    Console.WriteLine("A. Yes");
    Console.WriteLine("B. No, thanks");
    
    string userInputOne = Console.ReadLine();
    
    if (userInputOne == "A")
    {
        Console.WriteLine("Please write your number.");
        Console.ReadLine();
        Console.WriteLine("Enter the date for your test ride(DD-MM-YYYY):");
        Console.ReadLine();
        Console.WriteLine("We appreciate it, our staff will reach you within 24 hours.");
		
    }   
    
    if(userInputOne == "B")
    {    
        Console.WriteLine();
        Console.WriteLine("Alright!");
    }
  }

    static void listOfBikes()
    {
            var listOfBikes = new list<string>()
            {
            "1. Kawasaki Z1000R ","2. 2023 Kawasaki Z H2", "3. Ducati Panigale V4",
            "4. 2023 Honda CB650r", "5. 2023 Suzuki Hayabusa"
            };
            foreach (string i in listOfBikes) 
            { 
                Console.WriteLine( i ); 
            }
            Console.WriteLine("*****************");
            Console.WriteLine("Kindly enter the number of the chosen bike: ");
            string userInput = Console.ReadLine();
    }
    static void caseOne()
        {
            var caseOne = new list<string>()
            {
            "Kawasaki Z1000R:","   - Liquid Cooled", "   - In-line Four","   - 1043cc",
            "   - 142 HP @ 10,000 rpm", "   - 6-Speed manual transmission", "   - 17L Fuel Capacity",
            "   - SRP: Php 710,000 "
            }
            foreach (string i in caseOne)
            { 
             Console.Write( i ); 
            }
        }
    static void caseTwo()
    {
            var caseTwo = new list<string>()
            {
            "2023 Kawasaki Z H2", "   - Liquid Cooled", "   - In-line Four","   - 998cc",
            "   - 197.4 HP @ 11,000 rpm","   - 6-Speed manual transmission", "   - 19L Fuel Capacity",
            "   - SRP: Php 920,000 "
            };
            foreach (string i in caseTwo)
            {
                Console.Write(i);
            }
    }
    static void caseThree()
    {
            var caseThree = new list<string>()
            { "Ducati Panigale V4", "   - Liquid Cooled", "   - V4 Engine", "   - 1103cc",
            "   - 215.5 HP @ 13,000 rpm", "   - 6-Speed manual transmission", "   - 16L Fuel Capacity",
            "   - SRP: Php 1,990,000 "
            };
            foreach (string i in caseThree)
            {
                Console.Write(i);
            }

    }
    static void caseFour() 
    { 
            var caseFour =  new list<string>()
            { "2023 Honda CB650r", "   - Liquid Cooled", "   - In-line Four", "   - 649cc",
            "   - 94HP @ 12,000 rpm", "   - 6-Speed manual transmission", "   - 15.4L Fuel Capacity",
            "   - SRP: Php 519,000 "
            }
            foreach (string i in caseFour)
            {
                Console.WriteLine(i);   
            }
 
    }
    static void caseFive()
        { 
            var caseFive = new list<string>()
            {
             "2023 Suzuki Hayabusa", "   - Liquid Cooled", "   - In-line Four", "   - 1340cc", "   - 187HP @ 9,700 rpm",
             "   - 6-Speed manual transmission", "   - 20L Fuel Capacity", "   - SRP: Php 1,199,000 "
            }
            foreach (string i in caseFive)
            {
             Console.Writeline(i);
            }
      
        }
  }
}