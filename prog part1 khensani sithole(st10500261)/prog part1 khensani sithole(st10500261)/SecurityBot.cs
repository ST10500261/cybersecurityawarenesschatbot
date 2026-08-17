using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CybersecurityAwarenessChatbot
{
    public class SecurityBot
    {
        private string userName;

        public SecurityBot(string name)
        {
            userName = name;
        }


        public void StartConversation()
        {
            ConsoleManager.ShowTopics();

            bool chatbotRunning = true;

            while (chatbotRunning)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{userName}: ");
                Console.ResetColor();

                string userInput = Console.ReadLine()?.Trim() ?? "";

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Bot: Please enter a question or choose a topic.");
                    Console.ResetColor();
                    continue;
                }

                if (userInput.Equals("exit", StringComparison.OrdinalIgnoreCase) ||
                    userInput.Equals("stop", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"Bot: Goodbye, {userName}! Stay safe online.");
                    Console.ResetColor();

                    chatbotRunning = false;
                    continue;
                }

                // Send the user's question to the answer manager
                AnswerManager.GetAnswer(userInput, userName);

                Console.WriteLine();
            }
        }
    }
}
                
            
        
    
    

