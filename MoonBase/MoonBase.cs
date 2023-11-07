using MoonBase.Properties;
using MoonBase.Scenes;
using MoonBase.Src.Actor;
using MoonBase.Src;
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

#pragma warning disable CS0169 //it is used, it's just not used as a vairable within MoonBase.cs
        private Map map;
#pragma warning restore CS0169 //it is used, it's just not used as a vairable within MoonBase.cs

        public MoonBase()
        {
            InitializeComponent();
            sceneManager = new SceneManager(this);
            player = new Player(sceneManager); //needs scene manager ref for movement
            characterManager = new CharacterManager(this); //need scene manager for passing dialog and image changes
            Map map = new Map(this);
            mapImage.Image = Resources.img_Map;
            //subscribing player to listeners
            this.button_nav2.Click += player.OnButtonClick;
            this.button_nav3.Click += player.OnButtonClick;
            this.button_nav4.Click += player.OnButtonClick;
            this.button_nav1.Click += player.OnButtonClick;
            this.buttonTalk.Click += player.OnButtonClick;
            sceneManager.ForcePushSceneUpdate();//makes sure everything is setup.
        }

        public void DisableLocation(string location)
        {
            switch (location.ToLower())
            {
                case "north":
                    button_nav1.Enabled = false;
                    return;

                case "west":
                    button_nav4.Enabled = false;
                    return;

                case "south":
                    button_nav3.Enabled = false;
                    return;

                case "east":
                    button_nav2.Enabled = false;
                    return;

                default:
                    return;
            }
        }

        public void EnableLocation(string location)
        {
            switch (location.ToLower())
            {
                case "north":
                    button_nav1.Enabled = true;
                    return;

                case "west":
                    button_nav4.Enabled = true;
                    return;

                case "south":
                    button_nav3.Enabled = true;
                    return;

                case "east":
                    button_nav2.Enabled = true;
                    return;

                default:
                    return;
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

        public void ClearAllLocationMarkers()
        {
            loc_CentralCorridor1.Checked = false;
            loc_CentralCorridor2.Checked = false;
            loc_EntryWay.Checked = false;
            loc_Exterior.Checked = false;
            loc_Habitat.Checked = false;
            loc_MedBay.Checked = false;
            loc_MessHall.Checked = false;
            loc_Workshop.Checked = false;
        }

        public void SetLocationMarker(int id)
        {
            switch (id)
            {
                case 0:
                    loc_Exterior.Checked = true;
                    return;

                case 1:
                    loc_MessHall.Checked = true;
                    return;

                case 2:
                    loc_Habitat.Checked = true;
                    return;

                case 3:
                    loc_Workshop.Checked = true;
                    return;

                case 4:
                    loc_MedBay.Checked = true;
                    return;

                case 5:
                    loc_CentralCorridor2.Checked = true;
                    return;

                case 6:
                    loc_CentralCorridor1.Checked = true;
                    return;

                case 7:
                    loc_EntryWay.Checked = true;
                    return;

                default:
                    MessageBox.Show("Error Changing Scene, Cannot Find Map Location of Scene ID: " + id);
                    return;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {
        }

        private void button_nav1_Click(object sender, EventArgs e)
        {
        }
    }
}