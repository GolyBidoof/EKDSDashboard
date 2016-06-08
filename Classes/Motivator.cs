using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BuildScript
{
    public class Motivator
    {
        private readonly static string[] motivatingTextsHeader = { "Hola", "Hiya", "Sup", "Aloha", "<yawn> oh hey", "Nice to see you" };
        private readonly static string[] motivatingTextsFooter = { "what you're up to today?", "so what change is it today?", "keep doing awesomeness!", "been a while.", "like the ol' good days, huh?", "what you're doing looks interesting..." };
        private string motivating_string;

        public Motivator(string path) {
            Random randomisedNumber = new Random();
            motivating_string = motivatingTextsHeader[randomisedNumber.Next(6)] + " " + File.ReadAllLines(path)[0] + ", " + motivatingTextsFooter[randomisedNumber.Next(6)];
        }

        public string getMessage()
        {
            return motivating_string;
        }
    }
}
