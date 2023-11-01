namespace MoonBase
{
    partial class MoonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.locationInformation = new System.Windows.Forms.GroupBox();
            this.areaDescriptionLabel = new System.Windows.Forms.Label();
            this.areaNameLabel = new System.Windows.Forms.Label();
            this.areaDescription = new System.Windows.Forms.TextBox();
            this.areaName = new System.Windows.Forms.TextBox();
            this.Naviagtor = new System.Windows.Forms.GroupBox();
            this.button_nav1 = new System.Windows.Forms.Button();
            this.button_nav3 = new System.Windows.Forms.Button();
            this.button_nav2 = new System.Windows.Forms.Button();
            this.button_nav4 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.buttonTalk = new System.Windows.Forms.Button();
            this.groupBoxDialog = new System.Windows.Forms.GroupBox();
            this.textBoxDialog = new System.Windows.Forms.TextBox();
            this.Image_Character = new System.Windows.Forms.PictureBox();
            this.Map = new System.Windows.Forms.GroupBox();
            this.loc_CentralCorridor2 = new System.Windows.Forms.RadioButton();
            this.loc_Workshop = new System.Windows.Forms.RadioButton();
            this.loc_MessHall = new System.Windows.Forms.RadioButton();
            this.loc_MedBay = new System.Windows.Forms.RadioButton();
            this.loc_Habitat = new System.Windows.Forms.RadioButton();
            this.loc_CentralCorridor1 = new System.Windows.Forms.RadioButton();
            this.loc_EntryWay = new System.Windows.Forms.RadioButton();
            this.loc_Exterior = new System.Windows.Forms.RadioButton();
            this.mapImage = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.locationInformation.SuspendLayout();
            this.Naviagtor.SuspendLayout();
            this.groupBoxActions.SuspendLayout();
            this.groupBoxDialog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_Character)).BeginInit();
            this.Map.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapImage)).BeginInit();
            this.SuspendLayout();
            // 
            // locationInformation
            // 
            this.locationInformation.Controls.Add(this.areaDescriptionLabel);
            this.locationInformation.Controls.Add(this.areaNameLabel);
            this.locationInformation.Controls.Add(this.areaDescription);
            this.locationInformation.Controls.Add(this.areaName);
            this.locationInformation.Location = new System.Drawing.Point(1415, 730);
            this.locationInformation.Name = "locationInformation";
            this.locationInformation.Size = new System.Drawing.Size(420, 288);
            this.locationInformation.TabIndex = 0;
            this.locationInformation.TabStop = false;
            this.locationInformation.Text = "Location Information";
            // 
            // areaDescriptionLabel
            // 
            this.areaDescriptionLabel.AutoSize = true;
            this.areaDescriptionLabel.Location = new System.Drawing.Point(32, 95);
            this.areaDescriptionLabel.Name = "areaDescriptionLabel";
            this.areaDescriptionLabel.Size = new System.Drawing.Size(85, 13);
            this.areaDescriptionLabel.TabIndex = 3;
            this.areaDescriptionLabel.Text = "Area Description";
            // 
            // areaNameLabel
            // 
            this.areaNameLabel.AutoSize = true;
            this.areaNameLabel.Location = new System.Drawing.Point(32, 30);
            this.areaNameLabel.Name = "areaNameLabel";
            this.areaNameLabel.Size = new System.Drawing.Size(60, 13);
            this.areaNameLabel.TabIndex = 2;
            this.areaNameLabel.Text = "Area Name";
            // 
            // areaDescription
            // 
            this.areaDescription.Location = new System.Drawing.Point(30, 111);
            this.areaDescription.Multiline = true;
            this.areaDescription.Name = "areaDescription";
            this.areaDescription.ReadOnly = true;
            this.areaDescription.Size = new System.Drawing.Size(325, 155);
            this.areaDescription.TabIndex = 1;
            // 
            // areaName
            // 
            this.areaName.Location = new System.Drawing.Point(30, 47);
            this.areaName.Name = "areaName";
            this.areaName.ReadOnly = true;
            this.areaName.Size = new System.Drawing.Size(325, 20);
            this.areaName.TabIndex = 0;
            this.areaName.Text = "Room";
            // 
            // Naviagtor
            // 
            this.Naviagtor.Controls.Add(this.button_nav1);
            this.Naviagtor.Controls.Add(this.button_nav3);
            this.Naviagtor.Controls.Add(this.button_nav2);
            this.Naviagtor.Controls.Add(this.button_nav4);
            this.Naviagtor.Location = new System.Drawing.Point(63, 794);
            this.Naviagtor.Name = "Naviagtor";
            this.Naviagtor.Size = new System.Drawing.Size(227, 224);
            this.Naviagtor.TabIndex = 1;
            this.Naviagtor.TabStop = false;
            this.Naviagtor.Text = "Navigator";
            // 
            // button_nav1
            // 
            this.button_nav1.Location = new System.Drawing.Point(77, 32);
            this.button_nav1.Name = "button_nav1";
            this.button_nav1.Size = new System.Drawing.Size(63, 25);
            this.button_nav1.TabIndex = 6;
            this.button_nav1.Text = "North";
            this.button_nav1.UseVisualStyleBackColor = true;
            this.button_nav1.Click += new System.EventHandler(this.button_nav1_Click);
            // 
            // button_nav3
            // 
            this.button_nav3.Location = new System.Drawing.Point(77, 193);
            this.button_nav3.Name = "button_nav3";
            this.button_nav3.Size = new System.Drawing.Size(63, 25);
            this.button_nav3.TabIndex = 5;
            this.button_nav3.Text = "South";
            this.button_nav3.UseVisualStyleBackColor = true;
            // 
            // button_nav2
            // 
            this.button_nav2.Location = new System.Drawing.Point(146, 109);
            this.button_nav2.Name = "button_nav2";
            this.button_nav2.Size = new System.Drawing.Size(75, 25);
            this.button_nav2.TabIndex = 4;
            this.button_nav2.Text = "East";
            this.button_nav2.UseVisualStyleBackColor = true;
            // 
            // button_nav4
            // 
            this.button_nav4.Location = new System.Drawing.Point(6, 109);
            this.button_nav4.Name = "button_nav4";
            this.button_nav4.Size = new System.Drawing.Size(70, 25);
            this.button_nav4.TabIndex = 3;
            this.button_nav4.Text = "West";
            this.button_nav4.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.buttonTalk);
            this.groupBoxActions.Location = new System.Drawing.Point(365, 794);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(168, 224);
            this.groupBoxActions.TabIndex = 2;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Actions";
            this.groupBoxActions.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonTalk
            // 
            this.buttonTalk.Location = new System.Drawing.Point(8, 22);
            this.buttonTalk.Name = "buttonTalk";
            this.buttonTalk.Size = new System.Drawing.Size(72, 31);
            this.buttonTalk.TabIndex = 0;
            this.buttonTalk.Text = "Talk";
            this.buttonTalk.UseVisualStyleBackColor = true;
            // 
            // groupBoxDialog
            // 
            this.groupBoxDialog.Controls.Add(this.textBoxDialog);
            this.groupBoxDialog.Location = new System.Drawing.Point(567, 796);
            this.groupBoxDialog.Name = "groupBoxDialog";
            this.groupBoxDialog.Size = new System.Drawing.Size(569, 222);
            this.groupBoxDialog.TabIndex = 3;
            this.groupBoxDialog.TabStop = false;
            this.groupBoxDialog.Text = "Name";
            this.groupBoxDialog.Visible = false;
            // 
            // textBoxDialog
            // 
            this.textBoxDialog.Location = new System.Drawing.Point(14, 20);
            this.textBoxDialog.Multiline = true;
            this.textBoxDialog.Name = "textBoxDialog";
            this.textBoxDialog.ReadOnly = true;
            this.textBoxDialog.Size = new System.Drawing.Size(526, 187);
            this.textBoxDialog.TabIndex = 0;
            // 
            // Image_Character
            // 
            this.Image_Character.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Image_Character.BackColor = System.Drawing.Color.Transparent;
            this.Image_Character.Location = new System.Drawing.Point(567, 269);
            this.Image_Character.Name = "Image_Character";
            this.Image_Character.Size = new System.Drawing.Size(569, 749);
            this.Image_Character.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Image_Character.TabIndex = 4;
            this.Image_Character.TabStop = false;
            this.Image_Character.Visible = false;
            // 
            // Map
            // 
            this.Map.Controls.Add(this.loc_CentralCorridor2);
            this.Map.Controls.Add(this.loc_Workshop);
            this.Map.Controls.Add(this.loc_MessHall);
            this.Map.Controls.Add(this.loc_MedBay);
            this.Map.Controls.Add(this.loc_Habitat);
            this.Map.Controls.Add(this.loc_CentralCorridor1);
            this.Map.Controls.Add(this.loc_EntryWay);
            this.Map.Controls.Add(this.loc_Exterior);
            this.Map.Controls.Add(this.mapImage);
            this.Map.Location = new System.Drawing.Point(31, 27);
            this.Map.Name = "Map";
            this.Map.Size = new System.Drawing.Size(300, 318);
            this.Map.TabIndex = 5;
            this.Map.TabStop = false;
            this.Map.Text = "Map";
            this.Map.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // loc_CentralCorridor2
            // 
            this.loc_CentralCorridor2.AutoSize = true;
            this.loc_CentralCorridor2.Location = new System.Drawing.Point(143, 79);
            this.loc_CentralCorridor2.Name = "loc_CentralCorridor2";
            this.loc_CentralCorridor2.Size = new System.Drawing.Size(14, 13);
            this.loc_CentralCorridor2.TabIndex = 8;
            this.loc_CentralCorridor2.TabStop = true;
            this.loc_CentralCorridor2.UseVisualStyleBackColor = true;
            // 
            // loc_Workshop
            // 
            this.loc_Workshop.AutoSize = true;
            this.loc_Workshop.Location = new System.Drawing.Point(217, 95);
            this.loc_Workshop.Name = "loc_Workshop";
            this.loc_Workshop.Size = new System.Drawing.Size(14, 13);
            this.loc_Workshop.TabIndex = 7;
            this.loc_Workshop.TabStop = true;
            this.loc_Workshop.UseVisualStyleBackColor = true;
            // 
            // loc_MessHall
            // 
            this.loc_MessHall.AutoSize = true;
            this.loc_MessHall.Location = new System.Drawing.Point(63, 95);
            this.loc_MessHall.Name = "loc_MessHall";
            this.loc_MessHall.Size = new System.Drawing.Size(14, 13);
            this.loc_MessHall.TabIndex = 6;
            this.loc_MessHall.TabStop = true;
            this.loc_MessHall.UseVisualStyleBackColor = true;
            // 
            // loc_MedBay
            // 
            this.loc_MedBay.AutoSize = true;
            this.loc_MedBay.Location = new System.Drawing.Point(217, 167);
            this.loc_MedBay.Name = "loc_MedBay";
            this.loc_MedBay.Size = new System.Drawing.Size(14, 13);
            this.loc_MedBay.TabIndex = 5;
            this.loc_MedBay.TabStop = true;
            this.loc_MedBay.UseVisualStyleBackColor = true;
            // 
            // loc_Habitat
            // 
            this.loc_Habitat.AutoSize = true;
            this.loc_Habitat.Location = new System.Drawing.Point(63, 153);
            this.loc_Habitat.Name = "loc_Habitat";
            this.loc_Habitat.Size = new System.Drawing.Size(14, 13);
            this.loc_Habitat.TabIndex = 4;
            this.loc_Habitat.TabStop = true;
            this.loc_Habitat.UseVisualStyleBackColor = true;
            // 
            // loc_CentralCorridor1
            // 
            this.loc_CentralCorridor1.AutoSize = true;
            this.loc_CentralCorridor1.Location = new System.Drawing.Point(143, 153);
            this.loc_CentralCorridor1.Name = "loc_CentralCorridor1";
            this.loc_CentralCorridor1.Size = new System.Drawing.Size(14, 13);
            this.loc_CentralCorridor1.TabIndex = 3;
            this.loc_CentralCorridor1.TabStop = true;
            this.loc_CentralCorridor1.UseVisualStyleBackColor = true;
            // 
            // loc_EntryWay
            // 
            this.loc_EntryWay.AutoSize = true;
            this.loc_EntryWay.Location = new System.Drawing.Point(109, 219);
            this.loc_EntryWay.Name = "loc_EntryWay";
            this.loc_EntryWay.Size = new System.Drawing.Size(14, 13);
            this.loc_EntryWay.TabIndex = 2;
            this.loc_EntryWay.TabStop = true;
            this.loc_EntryWay.UseVisualStyleBackColor = true;
            // 
            // loc_Exterior
            // 
            this.loc_Exterior.AutoSize = true;
            this.loc_Exterior.Location = new System.Drawing.Point(202, 276);
            this.loc_Exterior.Name = "loc_Exterior";
            this.loc_Exterior.Size = new System.Drawing.Size(14, 13);
            this.loc_Exterior.TabIndex = 1;
            this.loc_Exterior.TabStop = true;
            this.loc_Exterior.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loc_Exterior.UseVisualStyleBackColor = true;
            // 
            // mapImage
            // 
            this.mapImage.BackgroundImage = global::MoonBase.Properties.Resources.img_Map;
            this.mapImage.Location = new System.Drawing.Point(0, 19);
            this.mapImage.Name = "mapImage";
            this.mapImage.Size = new System.Drawing.Size(300, 300);
            this.mapImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mapImage.TabIndex = 0;
            this.mapImage.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // MoonBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.Map);
            this.Controls.Add(this.groupBoxDialog);
            this.Controls.Add(this.groupBoxActions);
            this.Controls.Add(this.Naviagtor);
            this.Controls.Add(this.locationInformation);
            this.Controls.Add(this.Image_Character);
            this.Name = "MoonBase";
            this.Text = "Moon Base Theta";
            this.locationInformation.ResumeLayout(false);
            this.locationInformation.PerformLayout();
            this.Naviagtor.ResumeLayout(false);
            this.groupBoxActions.ResumeLayout(false);
            this.groupBoxDialog.ResumeLayout(false);
            this.groupBoxDialog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_Character)).EndInit();
            this.Map.ResumeLayout(false);
            this.Map.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox locationInformation;
        private System.Windows.Forms.Label areaNameLabel;
        private System.Windows.Forms.TextBox areaDescription;
        private System.Windows.Forms.TextBox areaName;
        private System.Windows.Forms.Label areaDescriptionLabel;
        private System.Windows.Forms.GroupBox Naviagtor;
        private System.Windows.Forms.Button button_nav1;
        private System.Windows.Forms.Button button_nav3;
        private System.Windows.Forms.Button button_nav2;
        private System.Windows.Forms.Button button_nav4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.Button buttonTalk;
        private System.Windows.Forms.GroupBox groupBoxDialog;
        private System.Windows.Forms.TextBox textBoxDialog;
        private System.Windows.Forms.PictureBox Image_Character;
        private System.Windows.Forms.GroupBox Map;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox mapImage;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.RadioButton loc_CentralCorridor1;
        private System.Windows.Forms.RadioButton loc_EntryWay;
        private System.Windows.Forms.RadioButton loc_Exterior;
        private System.Windows.Forms.RadioButton loc_Workshop;
        private System.Windows.Forms.RadioButton loc_MessHall;
        private System.Windows.Forms.RadioButton loc_MedBay;
        private System.Windows.Forms.RadioButton loc_Habitat;
        private System.Windows.Forms.RadioButton loc_CentralCorridor2;
    }
}

