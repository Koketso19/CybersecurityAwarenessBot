using System;

namespace CybersecurityAwarenessBot
{
    public class ResponseHandler
    {
        public string GetResponse(string input, string userName)
        {
            // Convert to lower case to handle uppercase/lowercase inputs easily
            string cleanedInput = input.ToLower().Trim();

            // Basic Response System
            if (cleanedInput.Contains("how are you"))
            {
                return $"I'm functioning perfectly, {userName}! I'm here to help you stay safe online.";
            }
            else if (cleanedInput.Contains("purpose"))
            {
                return "My purpose is to educate South African citizens about cybersecurity threats like phishing, malware, and safe browsing.";
            }
            else if (cleanedInput.Contains("password"))
            {
                return "Password Safety Tip: Use a mix of uppercase, lowercase, numbers, and symbols. Never reuse passwords across different sites!";
            }
            else if (cleanedInput.Contains("phishing"))
            {
                return "Phishing Tip: Never click on suspicious links in emails or SMS. Always check the sender's email address carefully.";
            }
            else if (cleanedInput.Contains("safe browsing"))
            {
                return "Safe Browsing Tip: Look for 'https://' in the URL before entering personal information. Avoid using public Wi-Fi for banking.";
            }
            else if (cleanedInput.Contains("menu") || cleanedInput.Contains("ask"))
            {
                return GetMenu();
            }
            else if (cleanedInput.Contains("exit") || cleanedInput.Contains("bye"))
            {
                return "EXIT";
            }
            else
            {
                // Default response for invalid inputs
                return "I didn't quite understand that. Could you please rephrase? Type 'menu' to see what I can help with.";
            }
        }

        public string GetMenu()
        {
            return @"
Here is what I can help you with:
1. Password Safety
2. Phishing
3. Safe Browsing
Type your question or the topic name.";
        }
    }
}