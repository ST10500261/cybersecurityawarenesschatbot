using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CybersecurityAwarenessChatbot
{
    public class AnswerManager
    {
        public static void GetAnswer(string userInput, string user)
        {
            string question = userInput.ToLower().Trim();


            if (question == "hello" || question == "hi" || question == "hey")
            {
                Console.WriteLine($"Bot: Hello {user}! Welcome . What cybersecurity topic would you like to learn about?");
                return;
            }


            if (question.Contains("how are you"))
            {
                Console.WriteLine($"Bot: I'm doing great, {user}! I'm ready to help you learn how to stay safe online.");
                return;
            }


            if (question.Contains("purpose") || question.Contains("what do you do"))
            {
                Console.WriteLine("Bot: My purpose is to provide basic cybersecurity awareness and help users understand how to protect their information, accounts and devices online.t allows users to ask questions and receive helpful responses, helping them develop safer online habits and become more aware of common cybersecurity threats.");
                return;
            }

            // Multi-factor authentication
            if (question.Contains("mfa") ||
                question.Contains("multi-factor") ||
                question.Contains("two factor") ||
                question.Contains("2fa"))
            {
                Console.WriteLine("Bot: Multi-factor authentication, also called MFA, adds an extra layer of security when logging into an account. Instead of relying only on a password, it may require another verification method, such as a code or authentication app. MFA can help protect your account even if someone discovers your password.");
                return;
            }

            // Social engineering
            if (question.Contains("social engineering") ||
                question.Contains("manipulate people"))
            {
                Console.WriteLine("Bot: Social engineering is when criminals manipulate people into giving away information or performing actions that could put their security at risk. Common examples include fake messages, impersonation and urgent requests. Always verify unexpected requests before responding.");
                return;
            }

            // Malware
            if (question.Contains("malware") ||
                question.Contains("malicious software"))
            {
                Console.WriteLine("Bot: Malware is malicious software designed to harm a device, steal information or gain unauthorised access. Examples include viruses, spyware and other harmful programs. Avoid suspicious downloads and keep your software updated.");
                return;
            }

            // Ransomware
            if (question.Contains("ransomware"))
            {
                Console.WriteLine("Bot: Ransomware is a type of malware that can prevent users from accessing their files or systems. Attackers may demand payment to restore access. Regular backups, software updates and careful handling of suspicious files can reduce the risk.");
                return;
            }

            // Password safety
            if (question.Contains("password") ||
                question.Contains("password safety"))
            {
                Console.WriteLine("Bot: Use strong and unique passwords for your accounts. Avoid using easily guessed information such as your name or birthday. A password manager can help you create and store different passwords safely. MFA is also recommended when available.");
                return;
            }

            // Phishing
            if (question.Contains("phishing"))
            {
                Console.WriteLine("Bot: Phishing is a scam where criminals pretend to be a trusted person or organisation to trick you into revealing information or clicking a harmful link. Check the sender carefully, avoid suspicious links and never share passwords or security codes through unexpected messages.");
                return;
            }

            // Public Wi-Fi
            if (question.Contains("public wifi") ||
                question.Contains("public wi-fi"))
            {
                Console.WriteLine("Bot: Public Wi-Fi can be less secure than a trusted private network. Avoid entering sensitive information on unknown networks, use secure websites and disconnect from networks you do not trust.");
                return;
            }

            // Privacy
            if (question.Contains("privacy") ||
                question.Contains("personal information"))
            {
                Console.WriteLine("Bot: Protect your privacy by limiting the personal information you share online. Review the privacy settings on your accounts and be careful about sharing information such as your address, phone number or other sensitive details.");
                return;
            }

            // Social media
            if (question.Contains("social media"))
            {
                Console.WriteLine("Bot: Be careful about what you share on social media. Avoid posting sensitive personal information and review your privacy settings. Be cautious when accepting requests or messages from people you do not know.");
                return;
            }

            // Online scams
            if (question.Contains("online scam") ||
                question.Contains("scam"))
            {
                Console.WriteLine("Bot: Online scams are attempts to trick people into giving away money, passwords or personal information. Be careful with unexpected prizes, urgent requests and offers that seem too good to be true. Verify information before taking action.");
                return;
            }

            // Safe browsing
            if (question.Contains("safe browsing") ||
                question.Contains("browsing"))
            {
                Console.WriteLine("Bot: Safe browsing means using the internet carefully. Visit trusted websites, check website addresses before entering information and avoid suspicious links or pop-ups. Keep your browser updated for better security.");
                return;
            }

            // Software updates
            if (question.Contains("software update") ||
                question.Contains("software updates") ||
                question == "update" ||
                question == "updates")
            {
                Console.WriteLine("Bot: Software updates often contain important security fixes. Keeping your operating system, browser and applications updated can help protect your device against known security problems.");
                return;
            }

            // Safe downloading
            if (question.Contains("download") ||
                question.Contains("safe download"))
            {
                Console.WriteLine("Bot: Only download files and applications from trusted sources. Avoid suspicious websites, unknown attachments and unexpected downloads. Check the source before installing anything.");
                return;
            }

            // Email security
            if (question.Contains("email security") ||
                question.Contains("suspicious email"))
            {
                Console.WriteLine("Bot: For safer email use, check the sender and be careful with links and attachments. Do not open unexpected files or provide sensitive information in response to suspicious messages. When unsure, verify the message using a trusted method.");
                return;
            }

            // Device security
            if (question.Contains("device security") ||
                question.Contains("protect my phone") ||
                question.Contains("protect my computer"))
            {
                Console.WriteLine("Bot: Protect your devices with a screen lock, strong passwords and regular software updates. Only install trusted applications and avoid leaving your device unlocked where others can access it.");
                return;
            }

            // Backups
            if (question.Contains("backup") ||
                question.Contains("back up"))
            {
                Console.WriteLine("Bot: A backup is a separate copy of important information. Backups can help you recover files if your device is lost, damaged or affected by malware. Important files should be backed up regularly.");
                return;
            }

            // Identity theft
            if (question.Contains("identity theft") ||
                question.Contains("stolen identity"))
            {
                Console.WriteLine("Bot: Identity theft happens when someone uses another person's personal information without permission. Protect sensitive information, use strong passwords and monitor your accounts for unusual activity.");
                return;
            }

            // Unknown question
            Console.WriteLine("Bot: I'm not sure I understand that. Please choose one of the topics above or try asking about passwords, phishing, malware, privacy or safe browsing.");
        }
    }
}
    

