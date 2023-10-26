using MoonBase.Scenes;
using MoonBase.Src.Actor;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MoonBase
{
    //should only perform functions for changing the visual form, should hold no data about the scenes.
    public partial class MoonBase : Form
    {
        //Scene managers that contains all logic and data regarding the scene
        private SceneManager sceneManager;

        private Player player;

        private CharacterManager characterManager;

        public MoonBase()
        {
            InitializeComponent();
            sceneManager = new SceneManager(this);
            player = new Player(sceneManager); //needs scene manager ref for movement
            characterManager = new CharacterManager(this); //need scene manager for passing dialog and image changes

            //subscribing player to listeners
            this.buttonDiningHall.Click += player.OnButtonClick;
            this.buttonExterior.Click += player.OnButtonClick;
            this.buttonWorkshop.Click += player.OnButtonClick;
            this.buttonHabitat.Click += player.OnButtonClick;
            this.buttonTalk.Click += player.OnButtonClick;
            sceneManager.ForcePushSceneUpdate();//makes sure everything is setup.
        }

        public void DisableLocation(string location)
        {
            switch (location.ToLower())
            {
                case "habitat":
                    buttonHabitat.Enabled = false;
                    return;

                case "workshop":
                    buttonWorkshop.Enabled = false;
                    return;

                case "exterior":
                    buttonExterior.Enabled = false;
                    return;

                case "dininghall":
                    buttonDiningHall.Enabled = false;
                    return;

                default:
                    throw new ArgumentException(String.Format("{0} is invalid button string.", location.ToLower()), "location"); // location is not of valid
            }
        }

        public void EnableLocation(string location)
        {
            switch (location.ToLower())
            {
                case "habitat":
                    buttonHabitat.Enabled = true;
                    return;

                case "workshop":
                    buttonWorkshop.Enabled = true;
                    return;

                case "exterior":
                    buttonExterior.Enabled = true;
                    return;

                case "dininghall":
                    buttonDiningHall.Enabled = true;
                    return;

                default:
                    throw new ArgumentException(String.Format("{0} is invalid button string.", location.ToLower()), "location"); // location is not of valid
            }
        }

        public void UpdateLocationData(string areaName, string description)
        {
            this.areaName.Text = areaName;
            this.areaDescription.Text = description;
            this.groupBoxDialog.Visible = false;
            this.groupBoxDialog.Visible = false;
        }

        public void UpdateDialogBox(string text, string name)
        {
            this.groupBoxDialog.Visible = true;
            this.groupBoxDialog.Text = name;
            this.textBoxDialog.Text = text;
            groupBoxDialog.BringToFront();
        }

        public void UpdatePresentActor(Image image)
        {
            Image_Character.Image = image;
            Image_Character.Visible = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}