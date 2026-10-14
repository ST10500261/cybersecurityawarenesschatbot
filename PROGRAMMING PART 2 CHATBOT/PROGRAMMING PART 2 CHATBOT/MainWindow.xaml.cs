
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace PROGRAMMING_PART_2_CHATBOT
{
    public class ChatMessage
    {
        public string Sender { get; set; } = "";
        public string Message { get; set; } = "";
        public Brush BubbleColor { get; set; } = Brushes.DarkBlue;
        public Brush SenderColor { get; set; } = Brushes.White;
        public HorizontalAlignment Alignment { get; set; }
    }

    public partial class MainWindow : Window
    {
        private string userName = "";
        private bool awaitingName = true;

        private readonly Random random = new Random();

       
        private readonly List<ChatMessage> chatHistory =
            new List<ChatMessage>();

        private readonly Dictionary<string, string> answers =
            new Dictionary<string, string>(
                StringComparer.OrdinalIgnoreCase)
            {
                {
                    "Multi-Factor Authentication",
                    "Multi-factor authentication (MFA) adds another layer of security to your accounts. It requires two or more forms of verification, such as a password and a code from an authentication app. Enable MFA whenever it is available."
                },
                {
                    "Social Engineering",
                    "Social engineering is when criminals manipulate people into revealing confidential information or performing unsafe actions. Be careful with unexpected requests, verify someone's identity, and never share passwords or verification codes."
                },
                {
                    "Malware",
                    "Malware is harmful software designed to damage devices, steal information, or access systems without permission. Protect yourself by using trusted security software, keeping your device updated, and downloading files only from reliable sources."
                },
                {
                    "Ransomware",
                    "Ransomware is a type of malware that can lock files or systems and demand payment. Reduce your risk by updating your software, avoiding suspicious attachments, and keeping backup copies of important files."
                },
                {
                    "Public Wi-Fi",
                    "Public Wi-Fi networks may not be secure. Avoid accessing sensitive accounts on unfamiliar networks, use secure websites, turn off automatic connections, and consider using a trusted VPN when appropriate."
                },
                {
                    "Privacy",
                    "Online privacy means protecting your personal information. Share only what is necessary, review app permissions, use strong privacy settings, and avoid posting passwords, identification numbers, or your home address."
                },
                {
                    "Social Media",
                    "Protect your social media accounts by using unique passwords and enabling multi-factor authentication. Check your privacy settings, be cautious with unknown friend requests, and think carefully before sharing personal information."
                },
                {
                    "Online Scams",
                    "Online scams attempt to trick people into sharing information or sending money. Be cautious of unexpected prizes, urgent payment requests, and suspicious links. Verify offers through official websites before taking action."
                },
                {
                    "Software Updates",
                    "Software updates often fix security weaknesses and bugs. Install updates for your operating system, browser, and applications from official sources, and enable automatic updates where practical."
                },
                {
                    "Safe Downloading",
                    "Download applications and files only from official stores or trusted websites. Check the publisher, avoid suspicious pop-ups, and do not open unexpected attachments."
                },
                {
                    "Email Security",
                    "Protect your email by using a strong, unique password and enabling multi-factor authentication. Check the sender's address, be suspicious of unexpected attachments, and avoid clicking links in messages that pressure you to act quickly."
                },
                {
                    "Device Security",
                    "Secure your devices with a screen lock, updated software, and trusted security tools. Do not leave devices unattended while unlocked, and install applications only from reliable sources."
                },
                {
                    "Backups",
                    "Backups are extra copies of important files that help you recover information if a device is lost, damaged, or infected by malware. Back up files regularly and make sure you can access your backup when needed."
                },
                {
                    "Identity Theft",
                    "Identity theft happens when someone uses another person's personal information without permission. Keep sensitive information private, use secure passwords, watch for unfamiliar account activity, and report suspicious activity promptly."
                }
            };

        private readonly string[] safetyTips =
        {
            "Use a different strong password for each important account.",
            "Enable multi-factor authentication whenever possible.",
            "Never share your password or one-time verification codes.",
            "Think before clicking unexpected links or attachments.",
            "Keep your devices and applications updated.",
            "Back up important files regularly.",
            "Review privacy settings on your online accounts.",
            "Download software only from trusted sources."
        };

        public MainWindow()
        {
            InitializeComponent();

            Reply("Welcome to Cyber Shield! What is your name?");
            MessageInput.Focus();
        }

        private void AddChatMessage(
            string sender, string message, bool isUser)
        {
            ChatMessage chatMessage = new ChatMessage
            {
                Sender = sender,
                Message = message,

                BubbleColor = isUser
                    ? new SolidColorBrush(Color.FromRgb(18, 54, 90))
                    : new SolidColorBrush(Color.FromRgb(18, 184, 176)),

                SenderColor = isUser
                    ? new SolidColorBrush(Color.FromRgb(18, 216, 208))
                    : new SolidColorBrush(Color.FromRgb(18, 54, 90)),

                Alignment = isUser
                    ? HorizontalAlignment.Right
                    : HorizontalAlignment.Left
            };

            
            chatHistory.Add(chatMessage);

            
            ChatMessages.Items.Add(chatMessage);
            ChatMessages.ScrollIntoView(chatMessage);
        }

        private void Reply(string message)
        {
            AddChatMessage("Cyber Shield", message, false);
        }

        private void SendButton_Click(
            object sender, RoutedEventArgs e)
        {
            SendMessage();
        }

        private void MessageInput_KeyDown(
            object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                SendMessage();
                e.Handled = true;
            }
        }

        private void SendMessage()
        {
            string userInput = MessageInput.Text.Trim();

            if (string.IsNullOrWhiteSpace(userInput))
            {
                return;
            }

            if (awaitingName)
            {
                userName = userInput;
                awaitingName = false;

                AddChatMessage(userName, userInput, true);
                MessageInput.Clear();

                Reply("Nice to meet you, " + userName +
                      "! Select a cybersecurity topic from the left or type a question.");
                return;
            }

            AddChatMessage(userName, userInput, true);
            MessageInput.Clear();

            Reply(GetResponse(userInput));
        }

        private string GetResponse(string userInput)
        {
            string input = userInput.ToLowerInvariant();

            if (input == "exit" || input == "quit" ||
                input == "stop" || input == "bye")
            {
                return "Goodbye, " + userName +
                       "! Stay safe online and protect your information.";
            }

            if (input.Contains("help") || input.Contains("topics"))
            {
                return "You can ask about passwords, phishing, malware, ransomware, public Wi-Fi, privacy, social media, online scams, software updates, safe downloading, email security, device security, backups, identity theft, or multi-factor authentication. You can also select a topic on the left.";
            }

            if (input.Contains("tip") ||
                input.Contains("safety advice"))
            {
                return "Here is a cybersecurity tip: " +
                       safetyTips[random.Next(safetyTips.Length)];
            }

            if (input.Contains("phishing"))
            {
                return "Phishing is a scam in which criminals use fake emails, messages, or websites to trick you into revealing information. Check the sender carefully, avoid suspicious links, and visit official websites directly.";
            }

            if (input.Contains("password"))
            {
                return "Use long, unique passwords for your accounts. A password manager can help you keep track of them. Enable multi-factor authentication and never share your passwords.";
            }

            if (input.Contains("hacked") || input.Contains("hacking"))
            {
                return "If you think an account has been compromised, change its password using the official website or app, enable multi-factor authentication, and review recent account activity.";
            }

            if (input.Contains("virus"))
                return answers["Malware"];

            if (input.Contains("scam") || input.Contains("fraud"))
                return answers["Online Scams"];

            if (input.Contains("wi-fi") || input.Contains("wifi"))
                return answers["Public Wi-Fi"];

            if (input.Contains("backup"))
                return answers["Backups"];

            if (input.Contains("update"))
                return answers["Software Updates"];

            if (input.Contains("privacy"))
                return answers["Privacy"];

            if (input.Contains("identity theft"))
                return answers["Identity Theft"];

            if (input.Contains("social engineering"))
                return answers["Social Engineering"];

            if (input.Contains("multi-factor") || input.Contains("mfa"))
                return answers["Multi-Factor Authentication"];

            if (input.Contains("ransomware"))
                return answers["Ransomware"];

            if (input.Contains("malware"))
                return answers["Malware"];

            if (input.Contains("downloading") || input.Contains("download"))
                return answers["Safe Downloading"];

            if (input.Contains("email"))
                return answers["Email Security"];

            if (input.Contains("device"))
                return answers["Device Security"];

            if (input.Contains("social media"))
                return answers["Social Media"];

            if (input.Contains("thank"))
            {
                return "You're welcome, " + userName +
                       "! Remember to stay safe online.";
            }

            if (input == "hi" || input == "hello" || input == "hey")
            {
                return "Hello, " + userName +
                       "! How can I help you stay safe online today?";
            }

            foreach (KeyValuePair<string, string> topic in answers)
            {
                if (input.Contains(topic.Key.ToLowerInvariant()))
                {
                    return topic.Value;
                }
            }

            return "I'm not sure I understand that question yet. Try asking about passwords, phishing, malware, privacy, public Wi-Fi, or type 'help' to see the available topics.";
        }

        private void TopicButton_Click(
            object sender, RoutedEventArgs e)
        {
            if (!(sender is Button button))
            {
                return;
            }

            if (awaitingName)
            {
                Reply("Please enter your name in the message box first.");
                MessageInput.Focus();
                return;
            }

            string topicName = button.Tag?.ToString()
                               ?? button.Content?.ToString()
                               ?? "";

            if (string.IsNullOrWhiteSpace(topicName))
            {
                return;
            }

            AddChatMessage(userName, topicName, true);

            if (answers.TryGetValue(topicName, out string? answer)
                && answer != null)
            {
                Reply(answer);
            }
            else
            {
                Reply("Sorry, I don't have information about that topic yet.");
            }
        }

       
        private void HistoryButton_Click(
            object sender, RoutedEventArgs e)
        {
            if (chatHistory.Count == 0)
            {
                MessageBox.Show(
                    "There is no chat history yet.",
                    "Chat History",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);

                return;
            }

            StringBuilder historyText = new StringBuilder();

            foreach (ChatMessage item in chatHistory)
            {
                historyText.AppendLine(item.Sender + ":");
                historyText.AppendLine(item.Message);
                historyText.AppendLine();
            }

            Window historyWindow = new Window
            {
                Title = "Cyber Shield - Chat History",
                Width = 550,
                Height = 500,
                MinWidth = 350,
                MinHeight = 300,
                Background = new SolidColorBrush(
                    Color.FromRgb(240, 247, 250)),
                Owner = this,
                WindowStartupLocation = WindowStartupLocation.CenterOwner
            };

            TextBox historyBox = new TextBox
            {
                Text = historyText.ToString(),
                IsReadOnly = true,
                AcceptsReturn = true,
                TextWrapping = TextWrapping.Wrap,
                VerticalScrollBarVisibility = ScrollBarVisibility.Auto,
                HorizontalScrollBarVisibility = ScrollBarVisibility.Disabled,
                Margin = new Thickness(12),
                Padding = new Thickness(10),
                FontSize = 14,
                Background = Brushes.White,
                Foreground = new SolidColorBrush(
                    Color.FromRgb(18, 54, 90))
            };

            historyWindow.Content = historyBox;
            historyWindow.ShowDialog();
        }

        
        private void ClearButton_Click(
            object sender, RoutedEventArgs e)
        {
            ChatMessages.Items.Clear();
            MessageInput.Clear();
            MessageInput.Focus();
        }
    }
}

