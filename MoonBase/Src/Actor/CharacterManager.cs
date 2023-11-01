using MoonBase.Properties;
using MoonBase.Scenes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoonBase.Src.Actor
{
    internal class CharacterManager
    {
        List<Character> characterList = new List<Character>();
        Character sceneCharacter;
        MoonBase moonBase;

        public static CharacterManager instance = null;
        public CharacterManager(MoonBase moonBase) {
            if (instance != null)
                return;
            instance = this;
            SceneManager.OnSceneChange += OnSceneChange;
            BuildCharacters();
            this.moonBase = moonBase;
        }

        //initializes characters
        void BuildCharacters()
        {
            characterList.Add(new Character(0, "Noelle", Resources.dialog_Noelle, Resources.img_Noelle));
            characterList.Add(new Character(1, "Rajan", Resources.dialog_Rajan, Resources.img_Rajan));
            characterList.Add(new Character(2, "Lira", Resources.dialog_Lira,Resources.img_Lira));
            characterList.Add(new Character(3, "Dante", Resources.dialog_Dante, Resources.img_Dante));
        }

        //change character present when scene changes.
        void OnSceneChange(int id)
        {
            UpdateCharacterAtLocation(id);
        }

        //get character at current location
        public void UpdateCharacterAtLocation(int location_id)
        {
            if (characterList.Any<Character>(c => c.getLocationID == location_id))
            {
                sceneCharacter = characterList.First<Character>(c => c.getLocationID == location_id); //get character by ID, first used due to id being unique
                moonBase.UpdatePresentActor(sceneCharacter.getImage);
                return;
            }

            sceneCharacter = null;
            moonBase.UpdatePresentActor(null);
  
        }

        public void TalkToCharacter()
        {
            if (sceneCharacter == null)//early exit flag
                return;

            string text = sceneCharacter.Talk();
            string name = sceneCharacter.Name;
            moonBase.UpdateDialogBox(text, name);
        }
    }
}
