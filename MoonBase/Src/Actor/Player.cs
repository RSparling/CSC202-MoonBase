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
        private const string button_Up = "button_nav1";
        private const string button_Left = "button_nav2";
        private const string button_Down = "button_nav3";
        private const string button_Right = "button_nav4";

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
                case button_Up:
                    sceneManager.ChangeScene("Up");
                    return;

                case button_Left:
                    newLocation = sceneManager.ChangeScene("Left");
                    return;

                case button_Down:
                    newLocation = sceneManager.ChangeScene("Down");
                    return;

                case button_Right:
                    newLocation = sceneManager.ChangeScene("Right");
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
