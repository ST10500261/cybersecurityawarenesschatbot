using System;
namespace CybersecurityAwarenessChatbot
{
    class Program
    {
        static void Main(string[] args)
        {

        Console.Title = "Cybersecurity Awareness Bot";

            ConsoleManager.ShowLogo();
            ConsoleManager.ShowWelcome();
            

            string name = ConsoleManager.GetUserName();

        SecurityBot bot = new SecurityBot(name);
        bot.StartConversation();
        }
}
}