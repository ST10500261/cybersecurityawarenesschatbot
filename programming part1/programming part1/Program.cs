using programming_part1;
using System;
using System.Media;

namespace programming_part1
{
    class Program
    {


    static void Main(string[] args)
    {
        Console.Title = "Cybersecurity Awareness Bot";
            SoundPlayer player = new SoundPlayer("greeting.wav");
            player.Play();
            ConsoleManager.ShowLogo();
        ConsoleManager.ShowWelcome();


            string name = ConsoleManager.GetUserName();

        SecurityBot bot = new SecurityBot(name);
        bot.StartConversation();
    }
}
}



