using MoonBase.Scenes;

namespace MoonBase.Src
{
    internal class Map
    {
        private MoonBase moonBase;

        public Map(MoonBase moonBase)
        {
            this.moonBase = moonBase;
            SceneManager.OnSceneChange += OnSceneChange;
        }

        void OnSceneChange(int id)
        {
            moonBase.ClearAllLocationMarkers();
            moonBase.SetLocationMarker(id);
        }
    }
}