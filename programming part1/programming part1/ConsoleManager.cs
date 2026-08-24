using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programming_part1
{
    public class ConsoleManager
    {
        public static void ShowLogo()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("==============================================");
            Console.WriteLine("       CYBERSECURITY AWARENESS CHATBOT");
            Console.WriteLine("==============================================");
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("==============================================");
            Console.WriteLine("      ____  _   _ ____  _____ ____  ");
            Console.WriteLine("     / ___|| | | | __ )| ____|  _ \\ ");
            Console.WriteLine("   \\___ \\| | | |  _ \\|  _| | |_) |");
            Console.WriteLine("      ___) | |_| | |_) | |___|  _ < ");
            Console.WriteLine("     |____/ \\___/|____/|_____|_| \\_\\");
            Console.WriteLine();
            Console.WriteLine("              [CYBER SHIELD]");
            Console.WriteLine("           CYBERSECURITY BOT");
            Console.WriteLine("        >>> STAY SAFE ONLINE <<<");
            Console.WriteLine("==============================================");

            Console.ResetColor();
            Console.WriteLine();
        }




        public static void ShowWelcome()
        {
            Console.WriteLine("Welcome to the Cybersecurity Awareness ChatBox!");
            Console.WriteLine("I will be guiding you through cybersecurity topics on how to stay safe online.");
            Console.WriteLine();
        }

        public static string GetUserName()
        {
            string name;

            do
            {
                Console.Write("Please enter your name: ");
                name = Console.ReadLine()?.Trim();

                if (string.IsNullOrWhiteSpace(name))
                {



                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Please enter a valid name.");
                    Console.ResetColor();
                }

            } while (string.IsNullOrWhiteSpace(name));

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\nHello, {name}! Welcome!");
            Console.ResetColor();

            return name;
        }


        public static void ShowTopics()
        {
            Console.WriteLine();
            Console.WriteLine("========================================");
            Console.WriteLine("        CYBERSECURITY TOPICS");
            Console.WriteLine("========================================");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("1. Multi-factor authentication");
            Console.WriteLine("2. Social engineering");
            Console.WriteLine("3. Malware");
            Console.WriteLine("4. Ransomware");
            Console.WriteLine("5. Public Wi-Fi");
            Console.WriteLine("6. Privacy");
            Console.WriteLine("7. Social media");
            Console.WriteLine("8. Online scams");
            Console.WriteLine("9. Software updates");
            Console.WriteLine("10. Safe downloading");
            Console.WriteLine("11. Email security");
            Console.WriteLine("12. Device security");
            Console.WriteLine("13. Backups");
            Console.WriteLine("14. Identity theft");
            Console.ResetColor();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Type 'exit' or 'stop' or 'quit' to leave.");
            Console.WriteLine();
        }
    }
}



    
