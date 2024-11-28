using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ParProgrammeringChatBot
{
    internal class TheBot

    {
        private List<string> botReplies = new List<string> { };
        public string botName = "";

        public void Run()
        {
            Console.WriteLine("Hello! What would you like to do: (select a number)");
            Console.WriteLine("1. Name Me?");
            Console.WriteLine("2. Add Replies to Chat Mode?");
            Console.WriteLine("3. Enter Chat Mode?");

            string inputNum = Console.ReadLine();

            switch (inputNum)
            {
                case "1":
                    NameBot();
                    break;
                case "2":
                    AddReplies();
                    break;
                case "3":
                    ChatMode();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Wrong input. Try again.");
                    Run();
                    break;
                    
            }


        }

        public void NameBot()
        {
            Console.WriteLine("Please Input Your Bot's Name:");
            string newName = Console.ReadLine();
            botName = newName;
            Run();


        }

        public void AddReplies()
        {

            Console.WriteLine("Write A Reply For Your Bot:");
            string newReplies = Console.ReadLine();
            botReplies.Add(newReplies);
            Console.WriteLine("Thanks for your reply. You will now be launched back to the main menu.");
            Run();


        }
        public string GetRandomReply()
        {
            Random randomAnswer = new Random();
            int i = randomAnswer.Next(0, botReplies.Count);

            return botReplies[i];


        }
        public void ChatMode()
        {
            string input = Console.ReadLine();
            Console.WriteLine($"{botName}: {GetRandomReply()}");
            if (input == "0")
            {
                Run();
            }
            else{ChatMode();}
        }
    }


}
