using MoonBase.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MoonBase.Scenes
{
    internal class SceneManager
    {

        //reference to form to allow for enabling and disabling button.
        private MoonBase form;

        //List of all scenes, used for extensibility in the future.
        List<Scene> scenes;

        //currently selected scene
        Scene currentScene;

        //Creation of delegate to allow for updating of anything that needs information on a scene change
        public delegate void OnSceneChangeEvent(int newSceneID);
        //static so that classes can subscribe without needed a reference to the class itself.
        static public OnSceneChangeEvent OnSceneChange;

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
            scenes.Add(new Scene("exterior", Resources.ExteriorTitle, Resources.ExteriorText, Resources.img_exterior, 0));
            scenes.Add(new Scene("dininghall", Resources.DininghallTitle, Resources.DininghallText, Resources.img_dininghall, 1));
            scenes.Add(new Scene("habitat", Resources.HabitatTitle, Resources.HabitatText, Resources.img_habitat, 2));
            scenes.Add(new Scene("workshop", Resources.WorkshopTitle, Resources.WorkshopText, Resources.img_workshop, 3));
        }

        //handles the scene change and calling the respecting functions on the Form.MoonBase
        public int ChangeScene(string shortName) 
        {
                //re-enables the current location
                form.EnableLocation(currentScene.shortName);
                currentScene = scenes.First(obj => obj.shortName == shortName);
                //disables new current location
                form.DisableLocation(currentScene.shortName);

                //set image and text
                form.BackgroundImage = currentScene.image;
                form.UpdateLocationData(currentScene.title, currentScene.description);
                OnSceneChange?.Invoke(currentScene.sceneID); //makes sure it's not null before invoking
                return currentScene.sceneID;
        }

        public void ForcePushSceneUpdate()
        {
            OnSceneChange?.Invoke(currentScene.sceneID);
        }
    }
}