using System;

namespace BigBikes
{
class Program {
  static void Main() {
    Console.WriteLine("Welcome to Ride City!");
    Console.ReadLine();
    Console.WriteLine("Check out our bikes!");
    Console.WriteLine("*****************");
    
    //Name of Bigbikes
    Console.WriteLine("1. Kawasaki Z1000R ");
    Console.WriteLine("2. 2023 Kawasaki Z H2");
    Console.WriteLine("3. Ducati Panigale V4");
    Console.WriteLine("4. 2023 Honda CB650r");
    Console.WriteLine("5. 2023 Suzuki Hayabusa");
    
    Console.WriteLine("*****************");
    Console.WriteLine("Kindly enter the number of the chosen bike: ");
    string userInput = Console.ReadLine();
    
    switch (userInput)
    {
        case "1":
            Console.WriteLine("Kawasaki Z1000R:");
            Console.WriteLine("   - Liquid Cooled");
            Console.WriteLine("   - In-line Four");
            Console.WriteLine("   - 1043cc");
            Console.WriteLine("   - 142 HP @ 10,000 rpm");
            Console.WriteLine("   - 6-Speed manual transmission");
            Console.WriteLine("   - 17L Fuel Capacity");
            Console.WriteLine("   - SRP: Php 710,000 ");
            break;
         
        case "2":
            Console.WriteLine("2023 Kawasaki Z H2");
            Console.WriteLine("   - Liquid Cooled");
            Console.WriteLine("   - In-line Four");
            Console.WriteLine("   - 998cc");
            Console.WriteLine("   - 197.4 HP @ 11,000 rpm");
            Console.WriteLine("   - 6-Speed manual transmission");
            Console.WriteLine("   - 19L Fuel Capacity");
            Console.WriteLine("   - SRP: Php 920,000 ");
            break;
            
        case "3":
            Console.WriteLine("Ducati Panigale V4");
            Console.WriteLine("   - Liquid Cooled");
            Console.WriteLine("   - V4 Engine");
            Console.WriteLine("   - 1103cc");
            Console.WriteLine("   - 215.5 HP @ 13,000 rpm");
            Console.WriteLine("   - 6-Speed manual transmission");
            Console.WriteLine("   - 16L Fuel Capacity");
            Console.WriteLine("   - SRP: Php 1,990,000 ");
            break;   
            
        case "4":
            Console.WriteLine("2023 Honda CB650r");
            Console.WriteLine("   - Liquid Cooled");
            Console.WriteLine("   - In-line Four");
            Console.WriteLine("   - 649cc");
            Console.WriteLine("   - 94HP @ 12,000 rpm");
            Console.WriteLine("   - 6-Speed manual transmission");
            Console.WriteLine("   - 15.4L Fuel Capacity");
            Console.WriteLine("   - SRP: Php 519,000 ");
            break;
        
        case "5":
            Console.WriteLine("2023 Suzuki Hayabusa");
            Console.WriteLine("   - Liquid Cooled");
            Console.WriteLine("   - In-line Four");
            Console.WriteLine("   - 1340cc");
            Console.WriteLine("   - 187HP @ 9,700 rpm");
            Console.WriteLine("   - 6-Speed manual transmission");
            Console.WriteLine("   - 20L Fuel Capacity");
            Console.WriteLine("   - SRP: Php 1,199,000 ");
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
    }   
    
    if(userInputOne == "B")
    {    
        Console.WriteLine("Alright, thanks!");
    }
   }
  }
}