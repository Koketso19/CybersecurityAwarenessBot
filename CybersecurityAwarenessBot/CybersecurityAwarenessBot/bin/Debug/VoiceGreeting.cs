using System;
using System.Media; // Required for playing audio

namespace CybersecurityAwarenessBot
{
    public class VoiceGreeting
    {
        public void PlayGreeting()
        {
            try
            {
                // Make sure you save your .wav file in the project folder and set "Copy to Output Directory" to "Copy if newer"
                SoundPlayer player = new SoundPlayer("greeting.wav");
                player.PlaySync(); // PlaySync waits for the audio to finish before continuing
            }
            catch (Exception)
            {
                Console.WriteLine("[Audio file 'greeting.wav' not found. Continuing without voice greeting.]");
            }
        }
    }
}