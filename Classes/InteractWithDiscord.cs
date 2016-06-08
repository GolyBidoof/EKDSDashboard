using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibErmiiKart.Discord;

namespace BuildScript.Classes
{
    public static class InteractWithDiscord
    {
        
        public static void Interact(string text)
        {
            EKBuildBot bot = new EKBuildBot();
            string discordResponse = text;
            bot.SendMessageInDevelopmentChannel(discordResponse);
            bot.Disconnect();
        }
       
    }
}
