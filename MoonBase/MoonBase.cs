using MoonBase.Scenes;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace MoonBase
{
    //should only perform functions for changing the visual form, should hold no data about the scenes.
    public partial class MoonBase : Form
    {
        //Scene managers that contains all logic and data regarding the scene
        private SceneManager sceneManager;

        public MoonBase()
        {
            InitializeComponent();
            sceneManager = new SceneManager(this);
            this.buttonDiningHall.Click += sceneManager.OnButtonClick;
            this.buttonExterior.Click += sceneManager.OnButtonClick;
            this.buttonWorkshop.Click += sceneManager.OnButtonClick;
            this.buttonHabitat.Click += sceneManager.OnButtonClick;
        }

        public void DisableLocation(string location)
        {
            switch(location.ToLower())
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
                    throw new ArgumentException(String.Format("{0} is invalid button string.",location.ToLower()),"location"); // location is not of valid 
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
        }
    }
}