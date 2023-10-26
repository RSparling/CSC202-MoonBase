using MoonBase.Scenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonBase.Src.Actor
{
    public abstract class Actor
    {
        int id;

        static int nextId = 0;

        public Actor()
        {
            id = nextId++;
            //allows each actor to be subscribed to and listen for sceene changes.
            SceneManager.OnSceneChange += OnSceneChange;
        }

        public abstract void Interact();

        public abstract string Talk();

        public abstract void OnSceneChange(int id);

        public int getId() { return id; }
    }
}
