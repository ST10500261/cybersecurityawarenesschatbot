using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace programming_part1
{
    public class AnswerManager
    {
        public static void GetAnswer(string userInput, string userName)
        {
            string question = userInput.ToLower().Trim();

            
            if (question == "hello" ||
                question == "hi" ||
                question == "hey")
            {
                Console.WriteLine($"Bot: Hello {userName}! Welcome back. What cybersecurity topic would you like to learn about?");
                return;
            }

            
            if (question.Contains("how are you"))
            {
                Console.WriteLine($"Bot: I'm doing great, {userName}! I'm ready to help you learn how to stay safe online.");
                return;
            }

            
            if (question.Contains("purpose") || question.Contains("what do you do"))
            {
                Console.WriteLine("Bot: My purpose is to provide basic cybersecurity awareness and help users understand how to protect their information, accounts and devices online.");
                return;
            }

            
            if (question == "exit" || question == "stop" || question == "quit")
            {
                Console.WriteLine($"Bot: Goodbye, {userName}! Remember to stay safe online.");
                return;
            }

            
            if (question.Contains("cybersecurity") || question.Contains("cyber security"))
            {
                Console.WriteLine("Bot: Cybersecurity is the practice of protecting computers, devices, networks, accounts and information from unauthorized access, attacks and other online threats.");
                return;
            }

            // Unknown question
            Console.WriteLine("Bot: I'm not sure I understand that. Please choose one of the cybersecurity topics from the menu.");
        }
    }
}
