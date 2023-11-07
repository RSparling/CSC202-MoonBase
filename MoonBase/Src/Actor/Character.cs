using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace MoonBase.Src.Actor
{
    public class Character : Actor
    {
        public Character(int currentLocation, string name, string dialog, Image image, string title, bool canTalk = false)
        { 
            this.currentLocation = currentLocation;
            this.name = name;
            this.dialog = dialog;
            this.sprite = image;
            jobTitle = title;
            this.canTalk = canTalk;
        }
        private int currentLocation;
        private string dialog;
        private string name;
        private Image sprite;
        private string jobTitle;
        private bool canTalk;

        public bool CanTalk { get { return canTalk; } }
        public string GetJobTitle()
        {
            return jobTitle;
        }
        public string Name { get { return name; } }
        public Image getImage { get { return sprite; } }
        public int getLocationID { get { return currentLocation; } }
        public override void Interact()
        {
            throw new NotImplementedException();
        }

        public override void OnSceneChange(int id)
        {
            return;
        }

        public override string Talk()
        {
            return dialog;
        }
    }
}