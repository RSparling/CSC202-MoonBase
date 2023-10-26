using MoonBase.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MoonBase.Scenes
{
    internal class SceneManager
    {
        //consts of botton names in the form in to make reduce chance of typo
        private const string buttonHabitat = "buttonHabitat";
        private const string buttonExterior = "buttonExterior";
        private const string buttonWorkshop = "buttonWorkshop";
        private const string buttonDinningHall = "buttonDiningHall";

        //reference to form to allow for enabling and disabling button.
        private MoonBase form;

        //List of all scenes, used for extensibility in the future.
        List<Scene> scenes;

        //currently selected scene
        Scene currentScene;
        //uses dependency injection in order to change elements of the form.
        public SceneManager(MoonBase form)
        {
            this.form = form;
            BuildScenes();
            currentScene = scenes.First(obj => obj.shortName == "exterior");
            form.UpdateLocationData(currentScene.title, currentScene.description);
            form.BackgroundImage = currentScene.image;
            form.DisableLocation(currentScene.shortName);
        }

        
        //Intiializes all scenes
        private void BuildScenes()
        {
            scenes = new List<Scene>();
            scenes.Add(new Scene("exterior", Resources.ExteriorTitle, Resources.ExteriorText, Resources.img_exterior));
            scenes.Add(new Scene("dininghall", Resources.DininghallTitle, Resources.DininghallText, Resources.img_dininghall));
            scenes.Add(new Scene("habitat", Resources.HabitatTitle, Resources.HabitatText, Resources.img_habitat));
            scenes.Add(new Scene("workshop", Resources.WorkshopTitle, Resources.WorkshopText, Resources.img_workshop));
        }

        //designed to be more modular and extensible
        public void OnButtonClick(object sender, System.EventArgs e)
        {
            string senderName = (sender as Button)?.Name; //gets the name of the button, the '?' ensures that it's not null.

            switch (senderName)
            {
                case buttonHabitat:
                    ChangeScene("habitat");
                    return;

                case buttonExterior:
                    ChangeScene("exterior");
                    return;

                case buttonWorkshop:
                    ChangeScene("workshop");
                    return;

                case buttonDinningHall:
                    ChangeScene("dininghall");
                    return;
                default://non-button event senders result in no action.
                    return;
            }
        }

        //handles the scene change and calling the respecting functions on the Form.MoonBase
        private void ChangeScene(string shortName) 
        {
            try {
                //re-enables the current location
                form.EnableLocation(currentScene.shortName);
                currentScene = scenes.First(obj => obj.shortName == shortName);
                //disables new current location
                form.DisableLocation(currentScene.shortName);

                //set image and text
                form.BackgroundImage = currentScene.image;
                form.UpdateLocationData(currentScene.title, currentScene.description);
            }
            catch //catch incase something goes wrong for some reason.
            {
                MessageBox.Show("Attempted to get invalid scene of shortname: " + shortName);
                return;
            }


        }
    }
}