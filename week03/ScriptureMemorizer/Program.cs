// EXCEEDING REQUIREMENTS
// The program manages a library of scriptures using a List<Scripture> and utilizes the Random class to select and present a different scripture to the user every time the program runs.

using System;

class Program
{
    static void Main(string[] args)
    {   
        List<Scripture> scriptureLibrary = new List<Scripture>();

        scriptureLibrary.Add(new Scripture(new Reference("1 Nephi", 3, 7),"I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."));
        

        scriptureLibrary.Add(new Scripture(new Reference("Proverbs", 3, 5, 6),"Trust in the Lord with all thine heart and lean not unto thine own understanding. In all thy ways acknowledge him and he shall direct thy paths."));


        scriptureLibrary.Add(new Scripture(new Reference("John", 3, 16),"For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."));
        

        Random random = new Random();
        int randomIndex = random.Next(scriptureLibrary.Count);

        Scripture scripture = scriptureLibrary[randomIndex];

        string userInput = "";

        while(userInput.ToLower() != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");

            userInput = Console.ReadLine();

            if (userInput.ToLower() != "quit")
            {
                scripture.HideRandomWords(3);

                if (scripture.IsCompletelyHidden())
                {
                    break;
                }
            }

        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText()); 
        Console.WriteLine("\nGood job! You completed the scripture.");
        //Loop
            //Display, hide, check if  we need to quit
            //Use the functionsin the Scripture class(only)


    }
}