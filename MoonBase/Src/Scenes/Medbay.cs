using MoonBase.Scenes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonBase.Src.Scenes
{
    internal class Medbay : Scene
    {
        List<string> potentialDescriptors = new List<string>();
        Random random = new Random();
        public Medbay(string shortName, string title, string description, Image image, int sceneID, int[] connectedScenes) : base(shortName, title, description, image, sceneID, connectedScenes)
        {
            potentialDescriptors.Add("The moon looks hungry;");
            potentialDescriptors.Add("The moon is... calling;");
            potentialDescriptors.Add("I think I can see myself on the moon;");
            potentialDescriptors.Add("The moon demanded us;");
            potentialDescriptors.Add("Its cratered surface is like a celestial puzzle;");
            potentialDescriptors.Add("The moon's silver glow fills the med bay;");
            potentialDescriptors.Add("It seems to be whispering secrets;");
            potentialDescriptors.Add("The moon's serene beauty captivates me;");
            potentialDescriptors.Add("A sense of lunar tranquility pervades the room;");
            potentialDescriptors.Add("I can almost feel the moon's gravitational pull;");
            potentialDescriptors.Add("The moon appears to be watching over us;");
            potentialDescriptors.Add("Its light bathes everything in a soft, ethereal glow;");
            potentialDescriptors.Add("The med bay is bathed in lunar radiance;");
            potentialDescriptors.Add("I wonder what mysteries the moon holds;");
            potentialDescriptors.Add("The moon's tranquility contrasts with the med bay's hustle;");
            potentialDescriptors.Add("I feel a strange connection to the lunar landscape;");
            potentialDescriptors.Add("It's as if the moon is beckoning us to explore;");
            potentialDescriptors.Add("The moon's allure is impossible to resist;");
            potentialDescriptors.Add("Its presence in the med bay is otherworldly;");
        }

        public override string GetDescription()
        {
            return description + GetRandomDescription();
        }

        string GetRandomDescription()
        {
            int i = random.Next(0,potentialDescriptors.Count);
            return potentialDescriptors[i];
        }
    }
}
