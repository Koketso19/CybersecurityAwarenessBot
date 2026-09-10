using System;

namespace CybersecurityAwarenessBot
{
    public class AsciiArt
    {
        public static void DisplayLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("==================================================");
            Console.WriteLine(@"
   ____      _               _   _                 
  / ___|   _| |__   ___ _ __| |_| |__   ___ _   _ 
 | |  | | | | '_ \ / _ \ '__| __| '_ \ / _ \ | | |
 | |__| |_| | |_) |  __/ |  | |_| | | |  __/ |_| |
  \____\__, |_.__/ \___|_|   \__|_| |_|\___|\__, |
       |___/                                |___/ 
            AWARENESS BOT - PART 1
");
            Console.WriteLine("==================================================");
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}