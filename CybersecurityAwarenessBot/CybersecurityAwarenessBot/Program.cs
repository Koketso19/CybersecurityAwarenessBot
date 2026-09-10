using System;

namespace CybersecurityAwarenessBot
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Play Voice Greeting
            VoiceGreeting greeting = new VoiceGreeting();
            greeting.PlayGreeting();

            // 2. Display ASCII Art
            AsciiArt.DisplayLogo();

            // 3. Start the ChatBot
            ChatBot bot = new ChatBot();
            bot.Start();
        }
    }
}