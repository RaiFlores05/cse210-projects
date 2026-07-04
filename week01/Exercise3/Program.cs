using System;

class Program
{
    static void Main(string[] args)
    {
       
    //Console.Write("What is the magic number?");
    //int magicNumber = int.Parse(Console.ReadLine());

    Random randomGenerator = new Random();
    int number = randomGenerator.Next(1, 11);

    Console.WriteLine("Welcome to the Number Guessing Game!");
    Console.WriteLine("Please guess a number between 1 and 11");
    

    
    
    int guess = 0;

        // We could also use a do-while loop here...
        while (guess != number)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            

            if (number > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (number < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }                    

    }
    
}