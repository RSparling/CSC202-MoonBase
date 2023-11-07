using MoonBase.Properties;
using MoonBase.Scenes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MoonBase.Src.Actor
{
    internal class CharacterManager
    {
        private List<Character> characterList = new List<Character>();
        private Character sceneCharacter;

        private MoonBase moonBase;

        public static CharacterManager instance = null;
        Random random = new Random();
        public CharacterManager(MoonBase moonBase)
        {
            if (instance != null)
                return;
            instance = this;
            SceneManager.OnSceneChange += OnSceneChange;
            BuildCharacters();
            this.moonBase = moonBase;
        }

        //initializes characters
        private void BuildCharacters()
        {
            characterList.Add(new Character(0, "Noelle", Resources.dialog_Noelle, Resources.img_Noelle, "Scientist"));
            characterList.Add(new Character(1, "Rajan", Resources.dialog_Rajan, Resources.img_Rajan, "Engineer"));
            characterList.Add(new Character(2, "Lira", Resources.dialog_Lira, Resources.img_Lira, "Doctor"));
            characterList.Add(new Character(3, "Dante", Resources.dialog_Dante, Resources.img_Dante, "Technician"));
            for(int i = 0; i < 10; i++)
            {
                characterList.Add(GenerateRandomCharacter());
            }
        }

        //change character present when scene changes.
        private void OnSceneChange(int id)
        {
            UpdateCharacterAtLocation(id);
            List<Character> present = characterList.FindAll(c => c.getLocationID == id); //creates a list of all characters present at the scene
            moonBase.UpdateListBox(present);
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

        public Character GenerateRandomCharacter()
        {
            List<string> namesList = new List<string>()
            {
                "Emma",
                "Liam",
                "Olivia",
                "Noah",
                "Ava",
                "Isabella",
                "Sophia",
                "Mia",
                "Charlotte",
                "Amelia",
                "Harper",
                "Evelyn",
                "Abigail",
                "Emily",
                "Elizabeth",
                "Sofia",
                "Avery",
                "Ella",
                "Scarlett",
                "Grace",
                "Chloe",
                "Victoria",
                "Lily",
                "Madison",
                "Eleanor",
                "Hannah",
                "Addison",
                "Aubrey",
                "Brooklyn",
                "Zoe",
                "Penelope",
                "Layla",
                "Natalie",
                "Leah",
                "Savannah",
                "Zoey",
                "Stella",
                "Hazel",
                "Aurora",
                "Violet",
                "Samantha",
                "Aria",
                "Claire",
                "Lucy",
                "Anna",
                "Sarah",
                "Nora",
                "Maya",
                "Eva",
                "Alice"
            };
            List<string> jobTitle = new List<string>()
            {
                    "Lunar Geologist",
                    "Astrobiologist",
                    "Space Engineer",
                    "Energy Systems Technician",
                    "Moonbase Security Officer",
                    "Remote Operations Specialist",
                    "Lunar Hydroponics Specialist",
                    "Communications Technician",
                    "Extraterrestrial Resource Miner",
                    "Zero-Gravity Medical Doctor"
            };
            int name = random.Next(0, namesList.Count);
            int title = random.Next(0, jobTitle.Count);
            int location = random.Next(0, 7);
            return new Character(location, namesList[name], "I dont want to talk to you.", null, jobTitle[title]);
        }
    }
}