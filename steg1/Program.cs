// Uppgift 1 

//if (6 >= 3) {
 // Console.WriteLine("Hello World!");
 //}

 //Console.WriteLine("David");


// Uppgift 2 och 3 
//string password = "12345";
//string name = "Kalleanka";
//Console.WriteLine("Write your username");

//string answername = Console.ReadLine();


//Console.WriteLine("Write your password");
//string answerpassword = Console.ReadLine();


//if(name == answername && password == answerpassword)
//{
//  Console.WriteLine("Welcome!");
//}
//else //
//{
//  Console.WriteLine("Wrong password or username!");
//}

//Console.ReadLine();



// Uppgift 4 
//string Hello = "Hello, World";
//for (int i = 0; i < 32; i++)
//{
//  Console.WriteLine(Hello);
//}
//Console.ReadLine();


// Uppgift 5

//using System;

//class Program
//{
//    static void Main()
//    {
//        string correctPassword = "1234"; // Det rätta lösenordet
//        string userInput = "";
//
//        // Loopar så länge användarens inmatning inte är det rätta lösenordet
//        while (userInput != correctPassword)
//        {
//            Console.Write("Enter password: ");
//            userInput = Console.ReadLine();
//
//            if (userInput != correctPassword)
//            {
//                Console.WriteLine("Wrong password, try agian.");
//            }
//        }
//
//        Console.WriteLine("Correct password, welcome!");
//        Console.ReadLine();
//    }
//    
//}


// Uppgift 6 

//using System;

//class Program
//{
//    static void Main()
//    {
//        for (int i = 0; i < 5; i++) // Loopen körs 5 gånger
////        {
   //         Console.Write("Ange ett tal: ");
   //         string input = Console.ReadLine(); // Läser in användarens inmatning
//
  //          // Försöker konvertera inmatningen till ett heltal
    //        if (int.TryParse(input, out int number))
  //          {
 //               if (number > 5) // Kontrollerar om talet är högre än 5
 //               {
 //                   Console.WriteLine("Högre än 5!");
 //               }
 //               else
 //               {
 //                   Console.WriteLine("Inte högre än 5.");
 //               }
 //           }
 //           else
 //           {
 //               Console.WriteLine("Ogiltig inmatning. Försök igen.");
 //           }
 //       }
//
 //       Console.WriteLine("Loopen är klar!");
//    }
//}


// Uppgift 7

//using System;

//class Program
//{
//    static void Main()
//    {
//        bool isValidNumber = false;
//
//        while (!isValidNumber)//
//        {
//            Console.Write("Ange ett heltal: ");
//            string userInput = Console.ReadLine();
//
 //           if (int.TryParse(userInput, out int result))//
 //           {
 //               Console.WriteLine($"Tack! Du angav det giltiga talet: {result}");
 //               isValidNumber = true; 
 //               Console.ReadLine();
 //           }
 //           else
 //           {
 //               Console.WriteLine("Ogiltig, försök igen.");
 //               Console.ReadLine();
 //           }
 //       }
 //   }
//}

// Uppgift 8 

using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int targetNumber = random.Next(1, 51);

        int userGuess = -1; 
        bool isCorrect = false;

        Console.WriteLine("Välkommen till 'Gissa siffran'!");
        Console.WriteLine("Jag har valt ett tal mellan 1 och 50. Kan du gissa vilket det är?");

        while (!isCorrect)
        {
            Console.Write("Ange din gissning: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out userGuess))
            {
                if (userGuess < targetNumber)
                {
                    Console.WriteLine("För lågt! Försök igen.");
                }
                else if (userGuess > targetNumber)
                {
                    Console.WriteLine("För högt! Försök igen.");
                }
                else
                {
                    Console.WriteLine("Grattis! Du gissade rätt!");
                    isCorrect = true;
                }
            }
            else
            {
                Console.WriteLine("Ogiltig inmatning. Ange ett heltal.");
            }
        }

        Console.WriteLine("Tack för att du spelade!");
        Console.ReadLine();
    }

}