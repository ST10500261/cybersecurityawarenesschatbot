Cyber Shield – Cybersecurity Awareness Chatbot

Project Overview

Cyber Shield is a cybersecurity awareness chatbot developed using C# and .NET. The project was developed in two parts, starting with a console-based application and progressing to a graphical user interface (GUI) using Windows Presentation Foundation (WPF).

The chatbot educates users about common cybersecurity threats and provides practical advice on how to stay safe online.

Project Purpose

The purpose of Cyber Shield is to help users understand cybersecurity risks and learn how to protect their personal information, accounts and devices.

The project also demonstrates C# programming concepts and the development of interactive applications.

Features

- Personalised greetings using the user's name
- Voice greeting using a WAV audio file
- 14 cybersecurity awareness topics
- Keyword recognition for cybersecurity-related questions
- Automated responses to user messages
- Random cybersecurity safety tips
- Interactive graphical user interface
- Chat history displayed in a separate window
- Clear Chat functionality
- Keyboard support for sending messages
- Input validation and basic error handling

Cybersecurity Topics

1. Multi-Factor Authentication
2. Social Engineering
3. Malware
4. Ransomware
5. Public Wi-Fi Safety
6. Online Privacy
7. Social Media Security
8. Online Scams
9. Software Updates
10. Safe Downloading
11. Email Security
12. Device Security
13. Backups
14. Identity Theft

Technologies Used

- C# – application logic and chatbot functionality
- .NET – application development framework
- WPF – graphical user interface
- XAML – interface design and styling
- Visual Studio – development environment
- System.Media – WAV greeting audio playback
- Git and GitHub – version control and project hosting

Project Structure

Part 1: Console Application

The first part introduced the chatbot through a console-based interface.

- "Program.cs" – starts the application and plays the greeting sound.
- "SecurityBot.cs" – manages the conversation and user interaction.
- "AnswerManager.cs" – manages cybersecurity questions and responses.
- "ConsoleManager.cs" – displays the ASCII logo, welcome message and console formatting.
- "greeting.wav" – contains the voice greeting.

Part 2: WPF GUI Application

The second part improved the chatbot by introducing a graphical interface.

- "MainWindow.xaml" – defines the layout, colours, topic buttons, chat area and action buttons.
- "MainWindow.xaml.cs" – handles messages, keyword recognition, cybersecurity responses, greeting audio and button events.
- "ChatMessage" class – stores message details and controls how messages appear in the chat interface.
- "greeting.wav" – provides the welcome sound when the application starts.

How to Run the Project

1. Clone or download the repository from GitHub.
2. Open the appropriate solution or project file in Visual Studio.
3. Ensure the required .NET components are installed.
4. Confirm that "greeting.wav" is available in the application's output directory.
5. Build the solution and check for errors.
6. Run the application.
7. Enter your name when prompted.
8. Select a cybersecurity topic or type a question.
9. Use Chat History to review the conversation or Clear Chat to clear the displayed messages.

Learning Outcomes

This project demonstrates the use of:

- Variables, strings and methods
- Classes and objects
- Dictionaries and arrays
- Conditional statements and loops
- User input and input validation
- Keyword recognition
- Event handling
- GUI development using WPF and XAML
- Collections and chat history management
- Audio playback
- Git and GitHub version control

Version Control

Git and GitHub were used to manage the project's source code and development history.

Development improvements included the initial console application, cybersecurity responses, voice greeting, interface design, topic buttons, keyword recognition, personalised interaction and chat history.

Cybersecurity Awareness

The information provided by Cyber Shield is intended for educational and awareness purposes. The chatbot aims to improve users' understanding of common cybersecurity threats and encourage safer online behaviour.

Conclusion

Cyber Shield demonstrates how a basic console chatbot can be developed into an interactive desktop application. Through both parts, I gained practical experience in C# programming, user interaction, graphical interface development and cybersecurity awareness.

This project was developed as part of my programming coursework.
