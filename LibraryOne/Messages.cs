using System;

namespace LibraryOne
{
    public class Messages
    {
        public string FirstMessage()
        {
            return "Hello, world!";
        }

        private string[] messages = {
            "Works on my machine",
            "Did you reboot?",
            "refresh the browser.",
            "Restart the Service",
        };

        private static Random rnd = new Random();
        public string HelpfullMessage()
        {
            return messages[rnd.Next(messages.Length)];
        }
    }
}
