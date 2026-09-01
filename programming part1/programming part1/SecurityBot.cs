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

                Console.Write("\nEnter a topic number or type exit: ");
                string topicChoice = Console.ReadLine()?.Trim() ?? "";

                
                if (topicChoice.Equals("exit", StringComparison.OrdinalIgnoreCase) ||
                    topicChoice.Equals("stop", StringComparison.OrdinalIgnoreCase) ||
                    topicChoice.Equals("quit", StringComparison.OrdinalIgnoreCase))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"\nBot: Goodbye, {userName}! I am glad I could help. Remember to stay safe online.");
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

                
                bool topicRunning = true;

                while (topicRunning)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"\n===== {selectedTopic.ToUpper()} =====");
                    Console.ResetColor();

                    Console.WriteLine("Type your question about this topic.");
                    Console.WriteLine("Type 'back' to return to the main topics.");

                    Console.Write("\nYou: ");
                    string question = Console.ReadLine()?.Trim() ?? "";

                    // Return to main topics
                    if (question.Equals("back", StringComparison.OrdinalIgnoreCase))
                    {
                        topicRunning = false;
                        continue;
                    }

                    if (question == "")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nBot: Please type a question.");
                        Console.ResetColor();
                        continue;
                    }

                    
                    string answer = GetAnswer(selectedTopic, question);

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\nBot: " + answer);
                    Console.ResetColor();
                }
            }
        }

        private string GetAnswer(string topic, string question)
        {
            question = question.ToLower();

            
            if (topic == "Multi-factor authentication")
            {
                if (question.Contains("what") && question.Contains("multi"))
                {
                    return "Multi-factor authentication is a security method that requires two or more forms of verification before allowing access to an account or system.";
                }

                if (question.Contains("why") && question.Contains("important"))
                {
                    return "Multi-factor authentication is important because it adds an extra layer of security. Even if someone gets your password, they may still be unable to access your account.";
                }

                if (question.Contains("protect"))
                {
                    return "Multi-factor authentication protects users by requiring additional verification, such as a security code or authentication app.";
                }

                return "Multi-factor authentication helps protect accounts by requiring more than one method of verification.";
            }


            
            if (topic == "Social engineering")
            {
                if (question.Contains("what"))
                {
                    return "Social engineering is a cyberattack technique that manipulates people into revealing confidential information or performing unsafe actions.";
                }

                if (question.Contains("how") && question.Contains("work"))
                {
                    return "Social engineering works through deception and manipulation. Attackers may pretend to be trusted people or organisations to convince victims to share information.";
                }

                if (question.Contains("protect") || question.Contains("prevent"))
                {
                    return "Protect yourself by being cautious with unexpected requests, verifying identities, avoiding sharing sensitive information, and thinking carefully before clicking links.";
                }

                return "Be careful with unexpected requests for information and always verify who you are communicating with.";
            }


            
            if (topic == "Malware")
            {
                if (question.Contains("what"))
                {
                    return "Malware is malicious software designed to harm a computer system, steal information, disrupt operations, or gain unauthorized access.";
                }

                if (question.Contains("type") || question.Contains("types"))
                {
                    return "Common types of malware include viruses, worms, trojans, spyware, and ransomware.";
                }

                if (question.Contains("protect") || question.Contains("prevent"))
                {
                    return "Protect yourself from malware by keeping software updated, using trusted security software, avoiding suspicious links and downloads, and installing applications from trusted sources.";
                }

                return "Malware is harmful software, so avoid suspicious downloads and links and keep your device protected.";
            }


            
            if (topic == "Ransomware")
            {
                if (question.Contains("what"))
                {
                    return "Ransomware is malicious software that prevents users from accessing files or systems and demands payment from the victim.";
                }

                if (question.Contains("affect") || question.Contains("happen"))
                {
                    return "Ransomware can make important files or systems unavailable and may cause data loss, financial costs, and interruption of work.";
                }

                if (question.Contains("protect") || question.Contains("prevent"))
                {
                    return "Protect yourself by keeping software updated, avoiding suspicious links and attachments, using reliable security software, and regularly backing up important files.";
                }

                return "Regular backups and good security practices can help reduce the impact of ransomware.";
            }


            
            if (topic == "Public Wi-Fi")
            {
                if (question.Contains("what"))
                {
                    return "Public Wi-Fi is a wireless internet connection available for many people to use in places such as libraries, restaurants, airports, and shopping centres.";
                }

                if (question.Contains("risk") || question.Contains("danger"))
                {
                    return "Public Wi-Fi can be risky because attackers may attempt to intercept information or create fake networks that appear legitimate.";
                }

                if (question.Contains("safe") || question.Contains("protect"))
                {
                    return "Stay safe on public Wi-Fi by using secure websites, keeping your device updated, avoiding sensitive activities when possible, and disconnecting when finished.";
                }

                return "Be careful when using public Wi-Fi and avoid entering sensitive information on untrusted networks.";
            }


            
            if (topic == "Privacy")
            {
                if (question.Contains("what"))
                {
                    return "Online privacy is the protection of your personal information and activities when using the internet.";
                }

                if (question.Contains("why") && question.Contains("important"))
                {
                    return "Online privacy is important because personal information can be misused and may lead to identity theft, scams, or unauthorized access.";
                }

                if (question.Contains("protect"))
                {
                    return "Protect your privacy by using strong passwords, reviewing privacy settings, limiting personal information you share, and being careful about the websites and applications you use.";
                }

                return "Protect your privacy by controlling what personal information you share online.";
            }


            
            if (topic == "Social media")
            {
                if (question.Contains("risk") || question.Contains("danger"))
                {
                    return "Social media can expose users to scams, identity theft, cyberbullying, privacy breaches, and unauthorized access to accounts.";
                }

                if (question.Contains("protect"))
                {
                    return "Protect your social media accounts by using strong passwords, enabling multi-factor authentication, reviewing privacy settings, and avoiding suspicious links.";
                }

                if (question.Contains("share") || question.Contains("information"))
                {
                    return "Avoid sharing passwords, financial details, home addresses, or other sensitive personal information.";
                }

                return "Use privacy settings and be careful about what personal information you share on social media.";
            }


            
            if (topic == "Online scams")
            {
                if (question.Contains("what"))
                {
                    return "Online scams are fraudulent activities carried out through the internet to trick people into giving away money, personal information, passwords, or account details.";
                }

                if (question.Contains("identify") || question.Contains("recognize"))
                {
                    return "You can identify an online scam by looking for unrealistic offers, suspicious links, requests for personal information, pressure to act quickly, and messages from unknown sources.";
                }

                if (question.Contains("protect") || question.Contains("prevent"))
                {
                    return "Protect yourself by verifying information before responding, avoiding suspicious links, and never sharing sensitive information with unknown people.";
                }

                return "Be cautious of unexpected offers, suspicious messages, and requests for personal or financial information.";
            }


            
            if (topic == "Software updates")
            {
                if (question.Contains("why") || question.Contains("important"))
                {
                    return "Software updates can fix security weaknesses, correct errors, improve performance, and add new features.";
                }

                if (question.Contains("happen") || question.Contains("not updated"))
                {
                    return "If software is not updated, known security weaknesses may remain unprotected and attackers may use them to compromise devices or information.";
                }

                if (question.Contains("safe") || question.Contains("update"))
                {
                    return "Update software using the official update feature provided by the developer or operating system. Avoid suspicious update websites.";
                }

                return "Keeping software updated helps protect devices from known security threats.";
            }


            
            if (topic == "Safe downloading")
            {
                if (question.Contains("what"))
                {
                    return "Safe downloading means obtaining files, applications, and software from trusted and legitimate sources.";
                }

                if (question.Contains("risk") || question.Contains("danger"))
                {
                    return "Unsafe downloads can contain malware or viruses that may damage a device, steal information, or provide unauthorized access.";
                }

                if (question.Contains("safe") || question.Contains("protect"))
                {
                    return "Download files from official websites or trusted app stores, avoid suspicious links, and check files before opening them.";
                }

                return "Always download software and files from trusted and official sources.";
            }


            
            if (topic == "Email security")
            {
                if (question.Contains("why") || question.Contains("important"))
                {
                    return "Email security is important because email accounts can contain personal information and may be targeted by attackers.";
                }

                if (question.Contains("suspicious") || question.Contains("phishing"))
                {
                    return "Identify suspicious emails by checking the sender's address, unexpected attachments or links, unusual requests, and messages that create a strong sense of urgency.";
                }

                if (question.Contains("protect"))
                {
                    return "Protect your email by using a strong unique password, enabling multi-factor authentication, avoiding suspicious links, and keeping recovery information updated.";
                }

                return "Be cautious with unexpected emails, attachments, and links.";
            }


            
            if (topic == "Device security")
            {
                if (question.Contains("what"))
                {
                    return "Device security is the protection of computers, smartphones, tablets, and other devices from unauthorized access, malware, data loss, and cybersecurity threats.";
                }

                if (question.Contains("why") || question.Contains("important"))
                {
                    return "Device security is important because devices store personal information and provide access to online accounts.";
                }

                if (question.Contains("protect"))
                {
                    return "Protect your devices by using strong passwords or screen locks, keeping software updated, using trusted security software, and avoiding suspicious downloads.";
                }

                return "Keep your devices secure by using screen locks, updates, and trusted security software.";
            }


            
            if (topic == "Backups")
            {
                if (question.Contains("what"))
                {
                    return "A backup is a copy of important files and data stored separately from the original data.";
                }

                if (question.Contains("why") || question.Contains("important"))
                {
                    return "Backups are important because they help prevent permanent data loss if a device is damaged, lost, or affected by malware.";
                }

                if (question.Contains("create") || question.Contains("secure"))
                {
                    return "Create secure backups by regularly copying important files to trusted external storage or a secure cloud service.";
                }

                return "Regular backups help you recover important files if your original data is lost or damaged.";
            }


            
            if (topic == "Identity theft")
            {
                if (question.Contains("what"))
                {
                    return "Identity theft occurs when someone uses another person's personal information without permission, often to commit fraud or gain unauthorized access to accounts.";
                }

                if (question.Contains("happen") || question.Contains("cause"))
                {
                    return "Identity theft can happen when criminals obtain personal information through phishing, scams, data breaches, stolen documents, or compromised accounts.";
                }

                if (question.Contains("protect") || question.Contains("prevent"))
                {
                    return "Protect yourself by keeping personal information private, using strong passwords, enabling multi-factor authentication, monitoring your accounts, and being cautious when sharing information online.";
                }

                return "Keep your personal information private and use strong security measures to reduce the risk of identity theft.";
            }


            
            return $"I don't have a specific answer for that question about {topic}. Try asking about what it is, why it is important, its risks, or how to protect yourself.";
        }
    }
}