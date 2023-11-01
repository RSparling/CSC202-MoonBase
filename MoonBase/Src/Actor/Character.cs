using System;
using System.Drawing;

namespace MoonBase.Src.Actor
{
    internal class Character : Actor
    {
        public Character(int currentLocation, string name, string dialog, Image image)
        { 
            this.currentLocation = currentLocation;
            this.name = name;
            this.dialog = dialog;
            this.sprite = image;
        }
        private int currentLocation;
        private string dialog;
        private string name;
        private Image sprite;

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