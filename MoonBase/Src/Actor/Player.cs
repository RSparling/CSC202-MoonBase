using MoonBase.Scenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MoonBase.Src.Actor
{
    internal class Player : Actor
    {
        //consts of botton names in the form in to make reduce chance of typo

        //location buttons
        private const string buttonHabitat = "buttonHabitat";
        private const string buttonExterior = "buttonExterior";
        private const string buttonWorkshop = "buttonWorkshop";
        private const string buttonDinningHall = "buttonDiningHall";

        //action buttons
        private const string buttonTalk = "buttonTalk";

        //External Depenencies
        SceneManager sceneManager;

        //Variables
        int sceneID;

        public Player(SceneManager sceneManager)
        {
            this.sceneManager = sceneManager;
        }

        //designed to be more modular and extensible
        public void OnButtonClick(object sender, System.EventArgs e)
        {
            string senderName = (sender as Button)?.Name; //gets the name of the button, the '?' ensures that it's not null.
            int newLocation = -1;
            switch (senderName)
            {
                case buttonHabitat:
                    newLocation = sceneManager.ChangeScene("habitat");
                    return;

                case buttonExterior:
                    newLocation = sceneManager.ChangeScene("exterior");
                    return;

                case buttonWorkshop:
                    newLocation = sceneManager.ChangeScene("workshop");
                    return;

                case buttonDinningHall:
                    newLocation = sceneManager.ChangeScene("dininghall");
                    return;
                case buttonTalk:
                    CharacterManager.instance.TalkToCharacter();
                    return;
                default: //non-button event senders result in no action.
                    break;
            }  
        }

        public override void OnSceneChange(int id)
        {
            this.sceneID = id;
        }

        //Not Implemented for Player Class
        public override void Interact()
        {
            throw new NotImplementedException();
        }

        public override string Talk()
        {
            throw new NotImplementedException();
        }
    }
}
