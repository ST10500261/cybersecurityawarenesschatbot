using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace programming_part1
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
            bool chatbotRunning = true;

            while (chatbotRunning)
            {
                
                ConsoleManager.ShowTopics();

                
                Console.Write("\nEnter a topic number or ask me a question: \");topic you want: ");
                string topicChoice = Console.ReadLine()?.Trim() ?? "";

                
                if (topicChoice.Equals("exit", StringComparison.OrdinalIgnoreCase) ||
                    topicChoice.Equals("stop", StringComparison.OrdinalIgnoreCase) ||
                    topicChoice.Equals("quit", StringComparison.OrdinalIgnoreCase))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"\nBot: Goodbye, {userName}!  Am glad i could  help !!Remember to stay safe online.");
                    Console.ResetColor();
                    break;
                }
                
                


                string selectedTopic = "";

                switch (topicChoice)
                {
                    case "1":
                        selectedTopic = "Multi-factor authentication";
                        break;

                    case "2":
                        selectedTopic = "Social engineering";
                        break;

                    case "3":
                        selectedTopic = "Malware";
                        break;

                    case "4":
                        selectedTopic = "Ransomware";
                        break;

                    case "5":
                        selectedTopic = "Public Wi-Fi";
                        break;

                    case "6":
                        selectedTopic = "Privacy";
                        break;

                    case "7":
                        selectedTopic = "Social media";
                        break;

                    case "8":
                        selectedTopic = "Online scams";
                        break;

                    case "9":
                        selectedTopic = "Software updates";
                        break;

                    case "10":
                        selectedTopic = "Safe downloading";
                        break;

                    case "11":
                        selectedTopic = "Email security";
                        break;

                    case "12":
                        selectedTopic = "Device security";
                        break;

                    case "13":
                        selectedTopic = "Backups";
                        break;

                    case "14":
                        selectedTopic = "Identity theft";
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nBot: Invalid option. Please choose a number from 1 to 14.");
                        Console.ResetColor();
                        continue;
                }

                
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"\nBot: You selected {selectedTopic}.");
                Console.ResetColor();


               

                if (topicChoice == "1")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n===== MULTI-FACTOR AUTHENTICATION MENU =====");
                    Console.WriteLine("1. What is multi-factor authentication?");
                    Console.WriteLine("2. Why is multi-factor authentication important?");
                    Console.WriteLine("3. How does multi-factor authentication protect users?");
                    Console.ResetColor();

                    Console.Write("\nEnter your choice: ");
                    string questionChoice = Console.ReadLine()?.Trim() ?? "";

                    switch (questionChoice)
                    {
                        case "1":
                            Console.WriteLine("\nBot: Multi-factor authentication is a security method that requires a user to provide two or more forms of verification before gaining access to an account or system.");
                            break;

                        case "2":
                            Console.WriteLine("\nBot: Multi-factor authentication is important because it provides an extra layer of security. Even if someone obtains your password, they may still be unable to access your account without the additional verification method.");
                            break;

                        case "3":
                            Console.WriteLine("\nBot: Multi-factor authentication protects users by requiring additional verification, such as a security code or authentication app. This makes it more difficult for unauthorized people to access an account.");
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nBot: Invalid option. Please choose a number from 1 to 3.");
                            Console.ResetColor();
                            break;
                    }

                    Console.WriteLine("\nPress ENTER to return to the main topics...");
                    Console.ReadLine();
                }


                

                if (topicChoice == "2")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n===== SOCIAL ENGINEERING MENU =====");
                    Console.WriteLine("1. What is social engineering?");
                    Console.WriteLine("2. How does social engineering work?");
                    Console.WriteLine("3. How can you protect yourself from social engineering?");
                    Console.ResetColor();

                    Console.Write("\nEnter your choice: ");
                    string questionChoice = Console.ReadLine()?.Trim() ?? "";

                    switch (questionChoice)
                    {
                        case "1":
                            Console.WriteLine("\nBot: Social engineering is a cyberattack technique that manipulates people into revealing confidential information or performing actions that could compromise their security.");
                            break;

                        case "2":
                            Console.WriteLine("\nBot: Social engineering works by using deception and manipulation to make people trust the attacker. Attackers may pretend to be trusted individuals or organisations to convince victims to share information or take an unsafe action.");
                            break;

                        case "3":
                            Console.WriteLine("\nBot: You can protect yourself from social engineering by being cautious with unexpected requests, verifying people's identities, avoiding sharing sensitive information, and thinking carefully before clicking links or opening attachments.");
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nBot: Invalid option. Please choose a number from 1 to 3.");
                            Console.ResetColor();
                            break;
                    }

                    Console.WriteLine("\nPress ENTER to return to the main topics...");
                    Console.ReadLine();
                }


                

                if (topicChoice == "3")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n===== MALWARE MENU =====");
                    Console.WriteLine("1. What is malware?");
                    Console.WriteLine("2. What are the common types of malware?");
                    Console.WriteLine("3. How can you protect yourself from malware?");
                    Console.ResetColor();

                    Console.Write("\nEnter your choice: ");
                    string questionChoice = Console.ReadLine()?.Trim() ?? "";

                    switch (questionChoice)
                    {
                        case "1":
                            Console.WriteLine("\nBot: Malware is malicious software designed to harm a computer system, steal information, disrupt operations, or gain unauthorized access to a device.");
                            break;

                        case "2":
                            Console.WriteLine("\nBot: Common types of malware include viruses, worms, trojans, spyware, and ransomware. Each type can affect devices in different ways and may cause damage or compromise information.");
                            break;

                        case "3":
                            Console.WriteLine("\nBot: You can protect yourself from malware by keeping your software updated, using trusted security software, avoiding suspicious links and downloads, and only installing applications from trusted sources.");
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nBot: Invalid option. Please choose a number from 1 to 3.");
                            Console.ResetColor();
                            break;
                    }

                    Console.WriteLine("\nPress ENTER to return to the main topics...");
                    Console.ReadLine();
                }


                

                if (topicChoice == "4")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n===== RANSOMWARE MENU =====");
                    Console.WriteLine("1. What is ransomware?");
                    Console.WriteLine("2. How does ransomware affect users?");
                    Console.WriteLine("3. How can you protect yourself from ransomware?");
                    Console.ResetColor();

                    Console.Write("\nEnter your choice: ");
                    string questionChoice = Console.ReadLine()?.Trim() ?? "";

                    switch (questionChoice)
                    {
                        case "1":
                            Console.WriteLine("\nBot: Ransomware is a type of malicious software that prevents users from accessing their files or systems and demands payment from the victim.");
                            break;

                        case "2":
                            Console.WriteLine("\nBot: Ransomware can disrupt normal activities by making important files or systems unavailable. It can result in data loss, financial costs, and interruption of work or services.");
                            break;

                        case "3":
                            Console.WriteLine("\nBot: You can protect yourself from ransomware by keeping software updated, using reliable security software, avoiding suspicious links and attachments, and regularly backing up important files.");
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nBot: Invalid option. Please choose a number from 1 to 3.");
                            Console.ResetColor();
                            break;
                    }

                    Console.WriteLine("\nPress ENTER to return to the main topics...");
                    Console.ReadLine();
                }


                

                if (topicChoice == "5")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n===== PUBLIC WI-FI MENU =====");
                    Console.WriteLine("1. What is public Wi-Fi?");
                    Console.WriteLine("2. What are the risks of using public Wi-Fi?");
                    Console.WriteLine("3. How can you stay safe on public Wi-Fi?");
                    Console.ResetColor();

                    Console.Write("\nEnter your choice: ");
                    string questionChoice = Console.ReadLine()?.Trim() ?? "";

                    switch (questionChoice)
                    {
                        case "1":
                            Console.WriteLine("\nBot: Public Wi-Fi is a wireless internet connection that is available for many people to use in places such as libraries, restaurants, airports, and shopping centres.");
                            break;

                        case "2":
                            Console.WriteLine("\nBot: Public Wi-Fi can be risky because attackers may attempt to intercept information or create fake networks that look legitimate. This can put personal information and accounts at risk.");
                            break;

                        case "3":
                            Console.WriteLine("\nBot: You can stay safe on public Wi-Fi by avoiding sensitive activities when possible, using secure websites, keeping your device updated, and disconnecting from the network when you are finished.");
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nBot: Invalid option. Please choose a number from 1 to 3.");
                            Console.ResetColor();
                            break;
                    }

                    Console.WriteLine("\nPress ENTER to return to the main topics...");
                    Console.ReadLine();
                }


                

                if (topicChoice == "6")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n===== PRIVACY MENU =====");
                    Console.WriteLine("1. What is online privacy?");
                    Console.WriteLine("2. Why is online privacy important?");
                    Console.WriteLine("3. How can you protect your privacy online?");
                    Console.ResetColor();

                    Console.Write("\nEnter your choice: ");
                    string questionChoice = Console.ReadLine()?.Trim() ?? "";

                    switch (questionChoice)
                    {
                        case "1":
                            Console.WriteLine("\nBot: Online privacy is the protection of your personal information and activities when using the internet. It involves controlling what information you share and who can access it.");
                            break;

                        case "2":
                            Console.WriteLine("\nBot: Online privacy is important because personal information can be misused by criminals, companies, or other people. Protecting your privacy can help reduce the risk of identity theft, scams, and unauthorized access to your accounts.");
                            break;

                        case "3":
                            Console.WriteLine("\nBot: You can protect your privacy online by using strong passwords, reviewing privacy settings, limiting the personal information you share, and being careful about the websites and applications you use.");
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nBot: Invalid option. Please choose a number from 1 to 3.");
                            Console.ResetColor();
                            break;
                    }

                    Console.WriteLine("\nPress ENTER to return to the main topics...");
                    Console.ReadLine();
                }


               

                if (topicChoice == "7")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n===== SOCIAL MEDIA MENU =====");
                    Console.WriteLine("1. What are the risks of social media?");
                    Console.WriteLine("2. How can you protect your social media accounts?");
                    Console.WriteLine("3. What information should you avoid sharing?");
                    Console.ResetColor();

                    Console.Write("\nEnter your choice: ");
                    string questionChoice = Console.ReadLine()?.Trim() ?? "";

                    switch (questionChoice)
                    {
                        case "1":
                            Console.WriteLine("\nBot: Social media can expose users to risks such as scams, identity theft, cyberbullying, privacy breaches, and unauthorized access to accounts.");
                            break;

                        case "2":
                            Console.WriteLine("\nBot: You can protect your social media accounts by using strong and unique passwords, enabling multi-factor authentication, reviewing privacy settings, and being careful about suspicious links and messages.");
                            break;

                        case "3":
                            Console.WriteLine("\nBot: Avoid sharing sensitive information such as passwords, financial details, home addresses, or other private information that could be used to compromise your safety or accounts.");
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nBot: Invalid option. Please choose a number from 1 to 3.");
                            Console.ResetColor();
                            break;
                    }

                    Console.WriteLine("\nPress ENTER to return to the main topics...");
                    Console.ReadLine();
                }


                

                if (topicChoice == "8")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n===== ONLINE SCAMS MENU =====");
                    Console.WriteLine("1. What are online scams?");
                    Console.WriteLine("2. How can you identify an online scam?");
                    Console.WriteLine("3. How can you protect yourself from online scams?");
                    Console.ResetColor();

                    Console.Write("\nEnter your choice: ");
                    string questionChoice = Console.ReadLine()?.Trim() ?? "";

                    switch (questionChoice)
                    {
                        case "1":
                            Console.WriteLine("\nBot: Online scams are fraudulent activities carried out through the internet to trick people into giving away money, personal information, passwords, or account details.");
                            break;

                        case "2":
                            Console.WriteLine("\nBot: You can identify an online scam by looking for unrealistic offers, requests for personal information, suspicious links, pressure to act quickly, and messages from unknown or untrusted sources.");
                            break;

                        case "3":
                            Console.WriteLine("\nBot: You can protect yourself from online scams by verifying information before responding, avoiding suspicious links, not sharing sensitive information with unknown people, and using trusted websites and services.");
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nBot: Invalid option. Please choose a number from 1 to 3.");
                            Console.ResetColor();
                            break;
                    }

                    Console.WriteLine("\nPress ENTER to return to the main topics...");
                    Console.ReadLine();
                }


             

                if (topicChoice == "9")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n===== SOFTWARE UPDATES MENU =====");
                    Console.WriteLine("1. Why are software updates important?");
                    Console.WriteLine("2. What can happen if software is not updated?");
                    Console.WriteLine("3. How should you update your software safely?");
                    Console.ResetColor();

                    Console.Write("\nEnter your choice: ");
                    string questionChoice = Console.ReadLine()?.Trim() ?? "";

                    switch (questionChoice)
                    {
                        case "1":
                            Console.WriteLine("\nBot: Software updates are important because they can fix security weaknesses, correct errors, improve performance, and add new features. Keeping software updated helps protect devices from known security threats.");
                            break;

                        case "2":
                            Console.WriteLine("\nBot: If software is not updated, known security weaknesses may remain unprotected. Attackers can take advantage of these weaknesses to compromise devices, accounts, or personal information.");
                            break;

                        case "3":
                            Console.WriteLine("\nBot: You should update software using the official update feature provided by the developer or operating system. Avoid downloading updates from suspicious websites or unknown sources.");
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nBot: Invalid option. Please choose a number from 1 to 3.");
                            Console.ResetColor();
                            break;
                    }

                    Console.WriteLine("\nPress ENTER to return to the main topics...");
                    Console.ReadLine();
                }


                

                if (topicChoice == "10")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n===== SAFE DOWNLOADING MENU =====");
                    Console.WriteLine("1. What is safe downloading?");
                    Console.WriteLine("2. What are the risks of unsafe downloads?");
                    Console.WriteLine("3. How can you download files safely?");
                    Console.ResetColor();

                    Console.Write("\nEnter your choice: ");
                    string questionChoice = Console.ReadLine()?.Trim() ?? "";

                    switch (questionChoice)
                    {
                        case "1":
                            Console.WriteLine("\nBot: Safe downloading means obtaining files, applications, and software from trusted and legitimate sources while checking that the download is safe before opening or installing it.");
                            break;

                        case "2":
                            Console.WriteLine("\nBot: Unsafe downloads can contain malware, viruses, or other harmful software. They may damage a device, steal information, or give unauthorized people access to your system.");
                            break;

                        case "3":
                            Console.WriteLine("\nBot: You can download files safely by using official websites or trusted app stores, checking the file before opening it, avoiding suspicious links, and keeping your security software updated.");
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nBot: Invalid option. Please choose a number from 1 to 3.");
                            Console.ResetColor();
                            break;
                    }

                    Console.WriteLine("\nPress ENTER to return to the main topics...");
                    Console.ReadLine();
                }


                

                if (topicChoice == "11")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n===== EMAIL SECURITY MENU =====");
                    Console.WriteLine("1. Why is email security important?");
                    Console.WriteLine("2. How can you identify a suspicious email?");
                    Console.WriteLine("3. How can you protect your email account?");
                    Console.ResetColor();

                    Console.Write("\nEnter your choice: ");
                    string questionChoice = Console.ReadLine()?.Trim() ?? "";

                    switch (questionChoice)
                    {
                        case "1":
                            Console.WriteLine("\nBot: Email security is important because email accounts can contain personal information and may be targeted by attackers attempting to steal information, spread malware, or gain access to other accounts.");
                            break;

                        case "2":
                            Console.WriteLine("\nBot: You can identify a suspicious email by checking the sender's address, looking for unexpected attachments or links, watching for unusual requests, and being careful with messages that create a strong sense of urgency.");
                            break;

                        case "3":
                            Console.WriteLine("\nBot: You can protect your email account by using a strong and unique password, enabling multi-factor authentication, avoiding suspicious links and attachments, and keeping your recovery information up to date.");
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nBot: Invalid option. Please choose a number from 1 to 3.");
                            Console.ResetColor();
                            break;
                    }

                    Console.WriteLine("\nPress ENTER to return to the main topics...");
                    Console.ReadLine();
                }


               

                if (topicChoice == "12")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n===== DEVICE SECURITY MENU =====");
                    Console.WriteLine("1. What is device security?");
                    Console.WriteLine("2. Why is device security important?");
                    Console.WriteLine("3. How can you protect your devices?");
                    Console.ResetColor();

                    Console.Write("\nEnter your choice: ");
                    string questionChoice = Console.ReadLine()?.Trim() ?? "";

                    switch (questionChoice)
                    {
                        case "1":
                            Console.WriteLine("\nBot: Device security is the protection of computers, smartphones, tablets, and other devices from unauthorized access, malware, data loss, and other cybersecurity threats.");
                            break;

                        case "2":
                            Console.WriteLine("\nBot: Device security is important because devices store personal information and are used to access online accounts. Protecting them helps prevent unauthorized access, data loss, and security threats.");
                            break;

                        case "3":
                            Console.WriteLine("\nBot: You can protect your devices by using strong passwords or screen locks, keeping software updated, using trusted security software, avoiding suspicious downloads, and keeping your device physically secure.");
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nBot: Invalid option. Please choose a number from 1 to 3.");
                            Console.ResetColor();
                            break;
                    }

                    Console.WriteLine("\nPress ENTER to return to the main topics...");
                    Console.ReadLine();
                }


                

                if (topicChoice == "13")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n===== BACKUPS MENU =====");
                    Console.WriteLine("1. What is a backup?");
                    Console.WriteLine("2. Why are backups important?");
                    Console.WriteLine("3. How can you create a secure backup?");
                    Console.ResetColor();

                    Console.Write("\nEnter your choice: ");
                    string questionChoice = Console.ReadLine()?.Trim() ?? "";

                    switch (questionChoice)
                    {
                        case "1":
                            Console.WriteLine("\nBot: A backup is a copy of important files and data that is stored separately from the original data. Backups can be used to recover information if the original files are lost, damaged, or deleted.");
                            break;

                        case "2":
                            Console.WriteLine("\nBot: Backups are important because they help prevent permanent data loss. If a device is damaged, lost, or affected by malware, a backup can help you recover important files.");
                            break;

                        case "3":
                            Console.WriteLine("\nBot: You can create a secure backup by regularly copying important files to a trusted external storage device or secure cloud service. Backups should be protected from unauthorized access and checked regularly.");
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nBot: Invalid option. Please choose a number from 1 to 3.");
                            Console.ResetColor();
                            break;
                    }

                    Console.WriteLine("\nPress ENTER to return to the main topics...");
                    Console.ReadLine();
                }


               

                if (topicChoice == "14")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n===== IDENTITY THEFT MENU =====");
                    Console.WriteLine("1. What is identity theft?");
                    Console.WriteLine("2. How can identity theft happen?");
                    Console.WriteLine("3. How can you protect yourself from identity theft?");
                    Console.ResetColor();

                    Console.Write("\nEnter your choice: ");
                    string questionChoice = Console.ReadLine()?.Trim() ?? "";

                    switch (questionChoice)
                    {
                        case "1":
                            Console.WriteLine("\nBot: Identity theft occurs when someone uses another person's personal information without permission, often to commit fraud or gain unauthorized access to accounts.");
                            break;

                        case "2":
                            Console.WriteLine("\nBot: Identity theft can happen when criminals obtain personal information through phishing, scams, data breaches, stolen documents, or compromised accounts.");
                            break;

                        case "3":
                            Console.WriteLine("\nBot: You can protect yourself from identity theft by keeping personal information private, using strong passwords, enabling multi-factor authentication, monitoring your accounts, and being cautious when sharing information online.");
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nBot: Invalid option. Please choose a number from 1 to 3.");
                            Console.ResetColor();
                            break;
                    }

                    Console.WriteLine("\nPress ENTER to return to the main topics...");
                    Console.ReadLine();
                }
            }
        }
    }
}