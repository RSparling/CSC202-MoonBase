using MoonBase.Properties;
using MoonBase.Src.Scenes;
using System.Collections.Generic;
using System.Linq;

namespace MoonBase.Scenes
{
    internal class SceneManager
    {
        //reference to form to allow for enabling and disabling button.
        private MoonBase form;

        //List of all scenes, used for extensibility in the future.
        private List<Scene> scenes;

        //currently selected scene
        private Scene currentScene;

        //Creation of delegate to allow for updating of anything that needs information on a scene change
        public delegate void OnSceneChangeEvent(int newSceneID);

        //static so that classes can subscribe without needed a reference to the class itself.
        public static OnSceneChangeEvent OnSceneChange;

        //uses dependency injection in order to change elements of the form.
        public SceneManager(MoonBase form)
        {
            this.form = form;
            BuildScenes();
            currentScene = scenes.First(obj => obj.shortName == "exterior");
            form.UpdateLocationData(currentScene.GetTitle(), currentScene.GetDescription());
            form.BackgroundImage = currentScene.image;
            form.DisableLocation(currentScene.shortName);
        }

        //Intiializes all scenes
        private void BuildScenes()
        {
            scenes = new List<Scene>();

            //exterior
            int[] arr = { 7, -1, -1, -1 };
            scenes.Add(new Scene("exterior", Resources.ExteriorTitle, Resources.ExteriorText, Resources.img_exterior, 0, arr));

            //dining hall
            arr = new int[] { -1, 5, -1, -1 };
            scenes.Add(new Scene("dininghall", Resources.DininghallTitle, Resources.DininghallText, Resources.img_dininghall, 1, arr));

            //habitat
            arr = new int[] { -1, 6, -1, -1 };
            scenes.Add(new Scene("habitat", Resources.HabitatTitle, Resources.HabitatText, Resources.img_habitat, 2, arr));

            //workshop
            arr = new int[] { -1, -1, -1, 5 };
            scenes.Add(new Scene("workshop", Resources.WorkshopTitle, Resources.WorkshopText, Resources.img_workshop, 3, arr));

            //medbay
            arr = new int[] { -1, -1, -1, 6 };
            scenes.Add(new Medbay("medbay", Resources.MedBay_Title, Resources.MedBay_Text, Resources.img_MedBay, 4, arr));

            //main hallway2
            arr = new int[] { -1, 3, 6, 1 };
            scenes.Add(new Scene("mainhall2", Resources.MainHall_Title, Resources.MainHall_Text, Resources.img_MainCorridor2, 5, arr));

            //main hallway 1
            arr = new int[] { 5, 4, 7, 2 };
            scenes.Add(new Scene("mainhall1", Resources.MainHall_Title, Resources.MainHall_Text, Resources.img_MainCorridor1, 6, arr));

            //entryway
            arr = new int[] { 6, -1, 0, -1 };
            scenes.Add(new Scene("entryway", Resources.EntryWay_Title, Resources.EntryWay_Text, Resources.img_EntryWay, 7, arr));
        }

        public Scene GetSceneByID(int id)
        {
            Scene scene = scenes.First(obj => obj.sceneID == id);
            return scene;
        }

        //handles the scene change and calling the respecting functions on the Form.MoonBase
        public int ChangeScene(string direction)
        {
            int nextSceneID = -1;
            int previousScene = currentScene.sceneID; //used for triggering specific conditions when moving from one scene to another

            switch (direction)
            {
                case "Up":
                    nextSceneID = currentScene.northSceneID; break;
                case "Down":
                    nextSceneID = currentScene.southSceneID; break;
                case "Left":
                    nextSceneID = currentScene.eastSceneID; break;
                case "Right":
                    nextSceneID = currentScene.westSceneID; break;
                default:
                    return -1;
            }

            if (nextSceneID == -1)
                return currentScene.sceneID;

            currentScene.OnSceneExit(nextSceneID);
            currentScene = scenes.First<Scene>(s => s.sceneID == nextSceneID);
            currentScene.OnSceneEnter(previousScene);
            currentScene.OnSceneExecute();
            
            SetNavigatinoButtons();

            //set image and text
            form.BackgroundImage = currentScene.image;
            form.UpdateLocationData(currentScene.GetTitle(), currentScene.GetDescription());
            OnSceneChange?.Invoke(currentScene.sceneID); //makes sure it's not null before invoking
            return currentScene.sceneID;
        }

        void SetNavigatinoButtons()
        {
            if (currentScene.northSceneID == -1)
                form.DisableLocation("North");
            else
                form.EnableLocation("North");

            if (currentScene.eastSceneID == -1)
                form.DisableLocation("East");
            else
                form.EnableLocation("East");

            if (currentScene.southSceneID == -1)
                form.DisableLocation("South");
            else
                form.EnableLocation("South");

            if (currentScene.westSceneID == -1)
                form.DisableLocation("West");
            else
                form.EnableLocation("West");
        }
        public void ForcePushSceneUpdate()
        {
            OnSceneChange?.Invoke(currentScene.sceneID);
            SetNavigatinoButtons();
            form.BackgroundImage = currentScene.image;
            form.UpdateLocationData(currentScene.GetTitle(), currentScene.GetDescription());
        }
    }
}