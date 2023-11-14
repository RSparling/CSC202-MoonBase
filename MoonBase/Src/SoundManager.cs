using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using MoonBase.Properties;

namespace MoonBase.Src
{
    public class SoundManager
    {
        //multiple sounds plays for different types of audio
        SoundPlayer ambience;
        SoundPlayer soundEffect;
       
        //uses singleton pattern to ensure only one instance of the sound manager is created.
        public static SoundManager GetSoundManagerInstance()
        {
            if (instance == null)
                instance = new SoundManager();
            return SoundManager.instance;
        }

        static SoundManager instance;
        public SoundManager()
        {
            ambience = new SoundPlayer();
            soundEffect = new SoundPlayer();
        }

        //plays the ambience sound for the scene
       public void PlayAmbience(int id)
        {
            ambience.Stop();
            try
            {
                System.IO.Stream stream = GetAmbience(id);
                ambience = new SoundPlayer(stream);
                ambience.PlayLooping();
            }
            catch
            {
                throw new Exception("Sound file not found");
            }
        }

        //plays the sound effect for the scene
        public void PlaySoundEffect(int id)
        {
            //stops the sound effect if it is already playing
            soundEffect.Stop();
            //tries to play the sound effect
            try
            {
                System.IO.Stream stream = GetSoundEffect(id);
                soundEffect = new SoundPlayer(stream);
                soundEffect.Play();
            }
            catch//if the sound effect is not found, throw an exception
            {
                throw new Exception("Sound file not found");
            }
        }
        //gets the ambience sound for the scene
        System.IO.Stream GetAmbience(int id)
        {
            //switch statement to get the correct sound for the scene
            System.IO.Stream str = null;
            //switch statement to get the correct sound for the scene
            switch (id)
            {
                case 0:
                    str = Resources.wavFan;
                    break;
                case 1:
                    str = Resources.wavcrowdTalking1;
                    break;
                case 2:
                    str = Resources.wavcrowdTalking2;
                    break;
                case 3:
                    str = Resources.wavworkshop;
                    break;
                case 4:
                    str = Resources.wavMedbay;
                    break;
                case 5:
                    str = Resources.wavRoomAmbience;
                    break;
                case 6:
                    str = Resources.wavRoomAmbience;
                    break;
                case 7:
                    str = Resources.wavRoomAmbience;
                    break;
                default:
                    break;
            }

            return str;
        }
        //gets the sound effect for the scene
        System.IO.Stream GetSoundEffect(int id)
        {
            //switch statement to get the correct sound for the scene
            System.IO.Stream str = null;
            //switch statement to get the correct sound for the scene
            switch (id)
            {
                case 0:
                    str = Resources.wavairlock;
                    break;
                default:
                    break;
            }

            return str;
        }
    }
}
