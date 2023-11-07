using MoonBase.Scenes;

namespace MoonBase.Src
{
    internal class Map
    {
        private MoonBase moonBase;

        //constructor
        public Map(MoonBase moonBase)
        {
            this.moonBase = moonBase;
            SceneManager.OnSceneChange += OnSceneChange;
        }

        //updates map marker
        void OnSceneChange(int id)
        {
            moonBase.ClearAllLocationMarkers();
            moonBase.SetLocationMarker(id);
        }
    }
}