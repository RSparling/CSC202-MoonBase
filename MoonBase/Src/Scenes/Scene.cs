using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoonBase.Src;

namespace MoonBase.Scenes
{
    //abstract class is used to allow scenes to be used agnostically by the scene manager
    internal class Scene
    {
        public Scene(string shortName, string title, string description, Image image, int sceneID, int[] connectedScenes)
        {
            this.shortName = shortName;
            this.title = title;
            this.description = description;
            this.image = image;
            this.sceneID = sceneID;


            northSceneID = connectedScenes[0] != -1 ? connectedScenes[0] : -1;
            eastSceneID = connectedScenes[1] != -1 ? connectedScenes[1] : -1;
            southSceneID = connectedScenes[2] != -1 ? connectedScenes[2] : -1;
            westSceneID = connectedScenes[3] != -1 ? connectedScenes[3] : -1;
        }

        public string description;
        public string title;

        public int northSceneID { get; }
        public int southSceneID { get; }
        public int eastSceneID { get; }
        public int westSceneID { get; }

        //non-modifiable variables
        public string shortName { get; }
        public Image image { get; }
        public int sceneID { get; }
        
        //scenes are setup like a state machine, with each scene having an enter, execute, and exit function.

        //virtual methods
        //virtual methods are used to allow for extensibility in the future.
        
       
        public virtual void OnSceneEnter(int previousScene) {
            //play sound effect if entering facility
            if ((this.sceneID == 0 && previousScene == 0) || this.sceneID == 0 && previousScene == 7)
            {
                SoundManager.GetSoundManagerInstance().PlaySoundEffect(0);
            }

            
        }
        public virtual void OnSceneExecute()
        {
            SoundManager.GetSoundManagerInstance().PlayAmbience(this.sceneID);
        }

        public virtual void OnSceneExit(int nextScene) { 
            if((this.sceneID == 7 && nextScene == 0) || this.sceneID == 0 && nextScene == 7)
            {
                SoundManager.GetSoundManagerInstance().PlaySoundEffect(0);
            }
        }
        //virtual methods
        public virtual string GetTitle() { return title; }
        public virtual string GetDescription() { return description; }
    }
}
