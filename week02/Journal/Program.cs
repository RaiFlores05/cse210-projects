// EXCEEDING REQUIREMENTS
// The Journal program includes an additional menu option, number 5, called "Clear Journal".
// This new option asks for the name of the text file and then clears all journal entries 
// both from the text file and the RAM, keeping "Quit" as the final option.
// To achieve this, I created a new method in Journal.cs called ClearTextFile.


using System;
using System.IO; 
class Program
{
    static void Main(string[] args)
    {   
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        

        while(true)
        {   
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Clear Journal");
            Console.WriteLine("6. Quit");

            Console.Write("What would you like to do? ");
            int userChoise = int.Parse( Console.ReadLine());

            if (userChoise == 6)
            {
                Console.Write("Good bye");
                break;
            }

            if(userChoise == 1)
            {

                string promptText = promptGenerator.GetRandomPrompt();
                Console.WriteLine(promptText);

                string userResponse = Console.ReadLine();

                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                Entry entry = new Entry();

                entry._date = dateText;
                entry._promptText = promptText;
                entry._entryText = userResponse;
                
                journal.AddEntry(entry);
                
            }

            else if(userChoise == 2)
            {
                journal.DisplayAll();
            }
            
            else if(userChoise == 3)
            {
                Console.WriteLine("What is the filename? ");
                string filename = Console.ReadLine();

                journal.LoadFromFile(filename);
            }
            
            else if(userChoise == 4)
            {
                Console.WriteLine("What is the filename? ");
                string filename = Console.ReadLine();

                journal.SaveToFile(filename);
            }

            else if(userChoise == 5)
            {
                Console.WriteLine("What is the filename? ");
                string filename = Console.ReadLine();
                journal.ClearTextFile(filename);
                
                journal._entries.Clear();

                Console.WriteLine("The file and current journal have been cleared successfully.");
            }
            else 
            {
                Console.WriteLine("Please, write a number from 1 to 6\n");
                
            }
        }

        

        
    }
}