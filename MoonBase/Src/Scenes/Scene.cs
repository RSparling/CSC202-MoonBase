using System;
using System.Collections.Generic;
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
        public Scene(string shortName, string title, string description, Image image, int sceneID)
        {
            this.shortName = shortName;
            this.title = title;
            this.description = description;
            this.image = image;
            this.sceneID = sceneID;
        }

        //non-modifiable variables
        public string shortName { get; }
        public string title { get; }
        public string description { get; }
        public Image image { get; }
        public int sceneID { get; }
    }
}
