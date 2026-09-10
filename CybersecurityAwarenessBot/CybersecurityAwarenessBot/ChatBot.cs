using System;
using System.Threading;

namespace CybersecurityAwarenessBot
{
    public class ChatBot
    {
        private UserProfile user;
        private ResponseHandler responder;

        public ChatBot()
        {
            user = new UserProfile();
            responder = new ResponseHandler();
        }

        public void Start()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Bot: Hello! Welcome to the Cybersecurity Awareness Bot.");
            Console.ResetColor();

            // Ask for user's name and validate input
            Console.Write("Bot: Before we begin, what is your name? ");
            string inputName = Console.ReadLine();

            // Input Validation: Prevent empty or numeric names
            while (string.IsNullOrWhiteSpace(inputName) || int.TryParse(inputName, out _))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Bot: Invalid input. Please enter a valid name (letters only): ");
                Console.ResetColor();
                inputName = Console.ReadLine();
            }

            user.Name = inputName;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nBot: Welcome, {user.Name}! I am your cybersecurity awareness assistant.");
            Console.WriteLine("Bot: " + responder.GetMenu());
            Console.ResetColor();

            // Conversation Loop (Using a while loop as requested by lecturer)
            bool keepChatting = true;
            while (keepChatting)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"\n{user.Name}: ");
                string userInput = Console.ReadLine();
                Console.ResetColor();

                // Get response from handler
                string response = responder.GetResponse(userInput, user.Name);

                if (response == "EXIT")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"Bot: Goodbye, {user.Name}! Stay safe online.");
                    Console.ResetColor();
                    keepChatting = false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"Bot: {response}");
                    Console.ResetColor();
                }
            }
        }
    }
}