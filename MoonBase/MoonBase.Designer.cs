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
            this.buttonHabitat = new System.Windows.Forms.Button();
            this.buttonExterior = new System.Windows.Forms.Button();
            this.buttonDiningHall = new System.Windows.Forms.Button();
            this.buttonWorkshop = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.buttonTalk = new System.Windows.Forms.Button();
            this.groupBoxDialog = new System.Windows.Forms.GroupBox();
            this.textBoxDialog = new System.Windows.Forms.TextBox();
            this.Image_Character = new System.Windows.Forms.PictureBox();
            this.locationInformation.SuspendLayout();
            this.Naviagtor.SuspendLayout();
            this.groupBoxActions.SuspendLayout();
            this.groupBoxDialog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_Character)).BeginInit();
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
            this.Naviagtor.Controls.Add(this.buttonHabitat);
            this.Naviagtor.Controls.Add(this.buttonExterior);
            this.Naviagtor.Controls.Add(this.buttonDiningHall);
            this.Naviagtor.Controls.Add(this.buttonWorkshop);
            this.Naviagtor.Location = new System.Drawing.Point(63, 794);
            this.Naviagtor.Name = "Naviagtor";
            this.Naviagtor.Size = new System.Drawing.Size(227, 224);
            this.Naviagtor.TabIndex = 1;
            this.Naviagtor.TabStop = false;
            this.Naviagtor.Text = "Navigator";
            // 
            // buttonHabitat
            // 
            this.buttonHabitat.Location = new System.Drawing.Point(77, 32);
            this.buttonHabitat.Name = "buttonHabitat";
            this.buttonHabitat.Size = new System.Drawing.Size(63, 25);
            this.buttonHabitat.TabIndex = 6;
            this.buttonHabitat.Text = "Habitat";
            this.buttonHabitat.UseVisualStyleBackColor = true;
            // 
            // buttonExterior
            // 
            this.buttonExterior.Location = new System.Drawing.Point(77, 193);
            this.buttonExterior.Name = "buttonExterior";
            this.buttonExterior.Size = new System.Drawing.Size(63, 25);
            this.buttonExterior.TabIndex = 5;
            this.buttonExterior.Text = "Exterior";
            this.buttonExterior.UseVisualStyleBackColor = true;
            // 
            // buttonDiningHall
            // 
            this.buttonDiningHall.Location = new System.Drawing.Point(146, 109);
            this.buttonDiningHall.Name = "buttonDiningHall";
            this.buttonDiningHall.Size = new System.Drawing.Size(75, 25);
            this.buttonDiningHall.TabIndex = 4;
            this.buttonDiningHall.Text = "Dining Hall";
            this.buttonDiningHall.UseVisualStyleBackColor = true;
            // 
            // buttonWorkshop
            // 
            this.buttonWorkshop.Location = new System.Drawing.Point(6, 109);
            this.buttonWorkshop.Name = "buttonWorkshop";
            this.buttonWorkshop.Size = new System.Drawing.Size(70, 25);
            this.buttonWorkshop.TabIndex = 3;
            this.buttonWorkshop.Text = "Workshop";
            this.buttonWorkshop.UseVisualStyleBackColor = true;
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
            // MoonBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox locationInformation;
        private System.Windows.Forms.Label areaNameLabel;
        private System.Windows.Forms.TextBox areaDescription;
        private System.Windows.Forms.TextBox areaName;
        private System.Windows.Forms.Label areaDescriptionLabel;
        private System.Windows.Forms.GroupBox Naviagtor;
        private System.Windows.Forms.Button buttonHabitat;
        private System.Windows.Forms.Button buttonExterior;
        private System.Windows.Forms.Button buttonDiningHall;
        private System.Windows.Forms.Button buttonWorkshop;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.Button buttonTalk;
        private System.Windows.Forms.GroupBox groupBoxDialog;
        private System.Windows.Forms.TextBox textBoxDialog;
        private System.Windows.Forms.PictureBox Image_Character;
    }
}

