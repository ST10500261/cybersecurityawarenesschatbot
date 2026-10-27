# CyberShield – Part 3

## Project Overview

CyberShield is a C# WPF desktop application designed to promote cybersecurity awareness and help users learn about online safety. Part 3 builds on the existing CyberShield chatbot by introducing additional interactive features that improve user engagement, productivity, and cybersecurity learning.

The application uses a graphical user interface with a purple and lavender design for the additional Part 3 features.

## Features

### 1. Cybersecurity Awareness Chatbot

The chatbot provides information about common cybersecurity topics, including:

- Multi-Factor Authentication
- Social Engineering
- Malware
- Ransomware
- Public Wi-Fi
- Privacy
- Social Media
- Online Scams
- Software Updates
- Safe Downloading
- Email Security
- Device Security
- Backups
- Identity Theft

Users can enter their names, ask cybersecurity questions, select topics, receive random safety tips, view chat history, and clear the conversation.

### 2. Task Assistant with Reminders

The Task Assistant helps users organise their activities by allowing them to:

- Create tasks.
- Add task descriptions.
- Set reminder dates.
- Mark tasks as completed.
- Delete tasks.

The current version stores tasks in memory while the application is running.

### 3. Cybersecurity Mini-Game

The Cybersecurity Quiz tests users' knowledge of online safety and cybersecurity principles.

Features include:

- 14 quiz questions.
- Five answer options per question.
- Previous and Next navigation.
- Score calculation.
- Results display.
- An option to restart the quiz.

The quiz encourages users to review their cybersecurity knowledge interactively.

### 4. NLP Simulation

The Natural Language Processing (NLP) Simulation uses keyword and phrase matching to recognise different ways users can ask cybersecurity questions.

For example, users can ask how to protect themselves online or how to secure their passwords. The chatbot checks the input against predefined patterns and provides a relevant response.

This is a basic NLP simulation based on programmed rules rather than a machine-learning language model.

### 5. Activity Log

The Activity Log records selected activities performed during a session.

It includes:
- Activity descriptions.
- Date and time stamps.
- A window for viewing recorded activities.
- A Clear Log button.

The current implementation stores activity entries in memory, so the log resets when the application closes.

### 6. Additional Chatbot Features

- Personalised greeting.
- Greeting sound playback.
- Chat history window.
- Clear Chat functionality.
- Topic selection.
- Random cybersecurity tips.

## Technologies Used

- C#
- .NET
- Windows Presentation Foundation (WPF)
- XAML
- Visual Studio

## Requirements

- A Windows computer.
- Visual Studio with the .NET desktop development workload.
- A compatible .NET SDK and target framework for the project.
- The `greeting.wav` file for greeting sound playback.

## How to Run the Application

1. Clone or download this repository from GitHub.
2. Open the solution file (`.sln`) in Visual Studio.
3. Ensure the required project files and `greeting.wav` file are included.
4. Restore any required dependencies.
5. Build the solution.
6. Run the application.
7. Enter your name when prompted.
8. Explore the chatbot, cybersecurity quiz, Task Assistant, NLP Simulation, and Activity Log.

## Learning Outcomes

This project demonstrates the use of:

- Object-oriented programming.
- Classes, objects, methods, and properties.
- Collections and dictionaries.
- Conditional statements.
- String manipulation and keyword matching.
- Event handling in WPF.
- GUI development using XAML.
- User input validation.
- Randomised cybersecurity tips.
- Basic NLP simulation.
- Date and time handling.
- Activity tracking.
- Separation of application features into different windows and classes.

## Future Improvements

Possible improvements include:

- Saving tasks and activity logs to files or a database.
- Implementing persistent reminders.
- Improving natural-language recognition.
- Adding more cybersecurity quiz questions.
- Enhancing the user interface and accessibility.

## Conclusion

CyberShield Part 3 extends the original cybersecurity awareness chatbot with a quiz, a Task Assistant with reminders, an NLP Simulation, and an Activity Log. These features demonstrate practical C# programming and WPF development while encouraging users to learn about cybersecurity and online safety.

This project was developed for educational purposes.
