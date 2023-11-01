using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

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

        //virtual methods
        public virtual string GetTitle() { return title; }
        public virtual string GetDescription() { return description; }
    }
}
