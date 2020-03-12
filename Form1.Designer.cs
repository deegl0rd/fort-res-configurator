namespace Fortnite_Res_Configurator
{
    partial class FortResConfigWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FortResConfigWindow));
            this.mainLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.logLabel = new System.Windows.Forms.Label();
            this.logBox = new System.Windows.Forms.TextBox();
            this.formHead = new System.Windows.Forms.Panel();
            this.socYouTubeButton = new System.Windows.Forms.Button();
            this.socTwitchButton = new System.Windows.Forms.Button();
            this.gusHelpButton = new System.Windows.Forms.Button();
            this.dividerPanel = new System.Windows.Forms.Panel();
            this.gusLabel = new System.Windows.Forms.Label();
            this.gusBox = new System.Windows.Forms.TextBox();
            this.buttonFullHD = new System.Windows.Forms.Button();
            this.button1440P = new System.Windows.Forms.Button();
            this.button1080x1080 = new System.Windows.Forms.Button();
            this.button600x1080 = new System.Windows.Forms.Button();
            this.button2560x1080 = new System.Windows.Forms.Button();
            this.button2560x1440 = new System.Windows.Forms.Button();
            this.button4K = new System.Windows.Forms.Button();
            this.buttonCustomRes = new System.Windows.Forms.Button();
            this.resBoxStretched = new System.Windows.Forms.GroupBox();
            this.button1280x1080 = new System.Windows.Forms.Button();
            this.resBoxStandard = new System.Windows.Forms.GroupBox();
            this.resBoxOther = new System.Windows.Forms.GroupBox();
            this.rdButtonWindow = new System.Windows.Forms.RadioButton();
            this.rdButtonWindowFullscreen = new System.Windows.Forms.RadioButton();
            this.rdButtonFullscreen = new System.Windows.Forms.RadioButton();
            this.axisYlabel = new System.Windows.Forms.Label();
            this.axisXlabel = new System.Windows.Forms.Label();
            this.axisXchooser = new System.Windows.Forms.NumericUpDown();
            this.axisYchooser = new System.Windows.Forms.NumericUpDown();
            this.programStartTimer = new System.Windows.Forms.Timer(this.components);
            this.programStopTimer = new System.Windows.Forms.Timer(this.components);
            this.extContentLabel = new System.Windows.Forms.Label();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.fortPicBox = new System.Windows.Forms.PictureBox();
            this.formHead.SuspendLayout();
            this.resBoxStretched.SuspendLayout();
            this.resBoxStandard.SuspendLayout();
            this.resBoxOther.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axisXchooser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axisYchooser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fortPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLabel
            // 
            this.mainLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainLabel.BackColor = System.Drawing.Color.Transparent;
            this.mainLabel.Font = new System.Drawing.Font("Burbank Big Cd Bd", 25F, System.Drawing.FontStyle.Bold);
            this.mainLabel.ForeColor = System.Drawing.Color.White;
            this.mainLabel.Location = new System.Drawing.Point(12, 206);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(658, 41);
            this.mainLabel.TabIndex = 0;
            this.mainLabel.Text = "Resolution Configurator v1.0";
            this.mainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Burbank Big Cd Bd", 40F, System.Drawing.FontStyle.Bold);
            this.exitButton.Location = new System.Drawing.Point(629, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(53, 53);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // logLabel
            // 
            this.logLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.logLabel.AutoSize = true;
            this.logLabel.Font = new System.Drawing.Font("Burbank Big Cd Bd", 15.75F, System.Drawing.FontStyle.Italic);
            this.logLabel.Location = new System.Drawing.Point(352, 408);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(33, 21);
            this.logLabel.TabIndex = 7;
            this.logLabel.Text = "Log";
            // 
            // logBox
            // 
            this.logBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.logBox.Location = new System.Drawing.Point(350, 432);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logBox.Size = new System.Drawing.Size(320, 126);
            this.logBox.TabIndex = 8;
            // 
            // formHead
            // 
            this.formHead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formHead.BackColor = System.Drawing.Color.Gray;
            this.formHead.Controls.Add(this.socYouTubeButton);
            this.formHead.Controls.Add(this.socTwitchButton);
            this.formHead.Controls.Add(this.gusHelpButton);
            this.formHead.Controls.Add(this.exitButton);
            this.formHead.Location = new System.Drawing.Point(0, 0);
            this.formHead.Name = "formHead";
            this.formHead.Size = new System.Drawing.Size(682, 53);
            this.formHead.TabIndex = 9;
            this.formHead.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formhead_MouseDown);
            this.formHead.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formhead_MouseMove);
            this.formHead.MouseUp += new System.Windows.Forms.MouseEventHandler(this.formhead_MouseUp);
            // 
            // socYouTubeButton
            // 
            this.socYouTubeButton.BackColor = System.Drawing.Color.Crimson;
            this.socYouTubeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.socYouTubeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.socYouTubeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.socYouTubeButton.Font = new System.Drawing.Font("Burbank Big Cd Bd", 40F, System.Drawing.FontStyle.Bold);
            this.socYouTubeButton.Image = global::Fortnite_Res_Configurator.Properties.Resources._512;
            this.socYouTubeButton.Location = new System.Drawing.Point(52, 0);
            this.socYouTubeButton.Name = "socYouTubeButton";
            this.socYouTubeButton.Size = new System.Drawing.Size(53, 53);
            this.socYouTubeButton.TabIndex = 21;
            this.socYouTubeButton.UseVisualStyleBackColor = false;
            this.socYouTubeButton.Click += new System.EventHandler(this.socYouTubeButton_Click);
            // 
            // socTwitchButton
            // 
            this.socTwitchButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.socTwitchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.socTwitchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.socTwitchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.socTwitchButton.Font = new System.Drawing.Font("Burbank Big Cd Bd", 40F, System.Drawing.FontStyle.Bold);
            this.socTwitchButton.Image = global::Fortnite_Res_Configurator.Properties.Resources.gnome_twitch_icon;
            this.socTwitchButton.Location = new System.Drawing.Point(0, 0);
            this.socTwitchButton.Name = "socTwitchButton";
            this.socTwitchButton.Size = new System.Drawing.Size(53, 53);
            this.socTwitchButton.TabIndex = 20;
            this.socTwitchButton.UseVisualStyleBackColor = false;
            this.socTwitchButton.Click += new System.EventHandler(this.socTwitchButton_Click);
            // 
            // gusHelpButton
            // 
            this.gusHelpButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.gusHelpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.gusHelpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.gusHelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gusHelpButton.Font = new System.Drawing.Font("Burbank Big Cd Bd", 40F, System.Drawing.FontStyle.Bold);
            this.gusHelpButton.Image = global::Fortnite_Res_Configurator.Properties.Resources.foldericon;
            this.gusHelpButton.Location = new System.Drawing.Point(577, 0);
            this.gusHelpButton.Name = "gusHelpButton";
            this.gusHelpButton.Size = new System.Drawing.Size(53, 53);
            this.gusHelpButton.TabIndex = 19;
            this.gusHelpButton.UseVisualStyleBackColor = false;
            this.gusHelpButton.Click += new System.EventHandler(this.gusHelpButton_Click);
            // 
            // dividerPanel
            // 
            this.dividerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dividerPanel.BackColor = System.Drawing.Color.Black;
            this.dividerPanel.Location = new System.Drawing.Point(0, 246);
            this.dividerPanel.Name = "dividerPanel";
            this.dividerPanel.Size = new System.Drawing.Size(683, 2);
            this.dividerPanel.TabIndex = 10;
            // 
            // gusLabel
            // 
            this.gusLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gusLabel.AutoSize = true;
            this.gusLabel.Font = new System.Drawing.Font("Burbank Big Cd Bd", 15.75F, System.Drawing.FontStyle.Italic);
            this.gusLabel.Location = new System.Drawing.Point(8, 408);
            this.gusLabel.Name = "gusLabel";
            this.gusLabel.Size = new System.Drawing.Size(165, 21);
            this.gusLabel.TabIndex = 6;
            this.gusLabel.Text = "Screen display content";
            // 
            // gusBox
            // 
            this.gusBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gusBox.Location = new System.Drawing.Point(12, 432);
            this.gusBox.Multiline = true;
            this.gusBox.Name = "gusBox";
            this.gusBox.ReadOnly = true;
            this.gusBox.Size = new System.Drawing.Size(320, 126);
            this.gusBox.TabIndex = 5;
            // 
            // buttonFullHD
            // 
            this.buttonFullHD.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonFullHD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.buttonFullHD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.buttonFullHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFullHD.Font = new System.Drawing.Font("Burbank Big Cd Bd", 15F, System.Drawing.FontStyle.Bold);
            this.buttonFullHD.Location = new System.Drawing.Point(6, 19);
            this.buttonFullHD.Name = "buttonFullHD";
            this.buttonFullHD.Size = new System.Drawing.Size(89, 46);
            this.buttonFullHD.TabIndex = 19;
            this.buttonFullHD.Text = "1920x1080";
            this.buttonFullHD.UseVisualStyleBackColor = false;
            this.buttonFullHD.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1440P
            // 
            this.button1440P.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1440P.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.button1440P.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.button1440P.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1440P.Font = new System.Drawing.Font("Burbank Big Cd Bd", 15F, System.Drawing.FontStyle.Bold);
            this.button1440P.Location = new System.Drawing.Point(114, 71);
            this.button1440P.Name = "button1440P";
            this.button1440P.Size = new System.Drawing.Size(89, 46);
            this.button1440P.TabIndex = 20;
            this.button1440P.Text = "1440x1080";
            this.button1440P.UseVisualStyleBackColor = false;
            this.button1440P.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1080x1080
            // 
            this.button1080x1080.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1080x1080.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.button1080x1080.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.button1080x1080.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1080x1080.Font = new System.Drawing.Font("Burbank Big Cd Bd", 15F, System.Drawing.FontStyle.Bold);
            this.button1080x1080.Location = new System.Drawing.Point(6, 71);
            this.button1080x1080.Name = "button1080x1080";
            this.button1080x1080.Size = new System.Drawing.Size(89, 46);
            this.button1080x1080.TabIndex = 21;
            this.button1080x1080.Text = "1080x1080";
            this.button1080x1080.UseVisualStyleBackColor = false;
            this.button1080x1080.Click += new System.EventHandler(this.button3_Click);
            // 
            // button600x1080
            // 
            this.button600x1080.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button600x1080.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.button600x1080.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.button600x1080.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button600x1080.Font = new System.Drawing.Font("Burbank Big Cd Bd", 15F, System.Drawing.FontStyle.Bold);
            this.button600x1080.Location = new System.Drawing.Point(6, 19);
            this.button600x1080.Name = "button600x1080";
            this.button600x1080.Size = new System.Drawing.Size(89, 46);
            this.button600x1080.TabIndex = 22;
            this.button600x1080.Text = "600x1080";
            this.button600x1080.UseVisualStyleBackColor = false;
            this.button600x1080.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button2560x1080
            // 
            this.button2560x1080.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button2560x1080.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.button2560x1080.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.button2560x1080.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2560x1080.Font = new System.Drawing.Font("Burbank Big Cd Bd", 15F, System.Drawing.FontStyle.Bold);
            this.button2560x1080.Location = new System.Drawing.Point(6, 71);
            this.button2560x1080.Name = "button2560x1080";
            this.button2560x1080.Size = new System.Drawing.Size(89, 46);
            this.button2560x1080.TabIndex = 23;
            this.button2560x1080.Text = "2560x1080";
            this.button2560x1080.UseVisualStyleBackColor = false;
            this.button2560x1080.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2560x1440
            // 
            this.button2560x1440.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button2560x1440.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.button2560x1440.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.button2560x1440.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2560x1440.Font = new System.Drawing.Font("Burbank Big Cd Bd", 15F, System.Drawing.FontStyle.Bold);
            this.button2560x1440.Location = new System.Drawing.Point(114, 19);
            this.button2560x1440.Name = "button2560x1440";
            this.button2560x1440.Size = new System.Drawing.Size(89, 46);
            this.button2560x1440.TabIndex = 24;
            this.button2560x1440.Text = "2560x1440";
            this.button2560x1440.UseVisualStyleBackColor = false;
            this.button2560x1440.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4K
            // 
            this.button4K.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button4K.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.button4K.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.button4K.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4K.Font = new System.Drawing.Font("Burbank Big Cd Bd", 15F, System.Drawing.FontStyle.Bold);
            this.button4K.Location = new System.Drawing.Point(114, 71);
            this.button4K.Name = "button4K";
            this.button4K.Size = new System.Drawing.Size(89, 46);
            this.button4K.TabIndex = 25;
            this.button4K.Text = "3840x2160";
            this.button4K.UseVisualStyleBackColor = false;
            this.button4K.Click += new System.EventHandler(this.button7_Click);
            // 
            // buttonCustomRes
            // 
            this.buttonCustomRes.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonCustomRes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.buttonCustomRes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.buttonCustomRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustomRes.Font = new System.Drawing.Font("Burbank Big Cd Bd", 21F, System.Drawing.FontStyle.Bold);
            this.buttonCustomRes.Location = new System.Drawing.Point(6, 84);
            this.buttonCustomRes.Name = "buttonCustomRes";
            this.buttonCustomRes.Size = new System.Drawing.Size(216, 33);
            this.buttonCustomRes.TabIndex = 26;
            this.buttonCustomRes.Text = "Set";
            this.buttonCustomRes.UseVisualStyleBackColor = false;
            this.buttonCustomRes.Click += new System.EventHandler(this.buttonCustomRes_Click);
            // 
            // resBoxStretched
            // 
            this.resBoxStretched.Controls.Add(this.button1280x1080);
            this.resBoxStretched.Controls.Add(this.button600x1080);
            this.resBoxStretched.Controls.Add(this.button1080x1080);
            this.resBoxStretched.Controls.Add(this.button1440P);
            this.resBoxStretched.Font = new System.Drawing.Font("Burbank Big Cd Bd", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resBoxStretched.Location = new System.Drawing.Point(12, 254);
            this.resBoxStretched.Name = "resBoxStretched";
            this.resBoxStretched.Size = new System.Drawing.Size(209, 129);
            this.resBoxStretched.TabIndex = 27;
            this.resBoxStretched.TabStop = false;
            this.resBoxStretched.Text = "Stretched (Fullscreen!)";
            // 
            // button1280x1080
            // 
            this.button1280x1080.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1280x1080.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.button1280x1080.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.button1280x1080.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1280x1080.Font = new System.Drawing.Font("Burbank Big Cd Bd", 15F, System.Drawing.FontStyle.Bold);
            this.button1280x1080.Location = new System.Drawing.Point(114, 19);
            this.button1280x1080.Name = "button1280x1080";
            this.button1280x1080.Size = new System.Drawing.Size(89, 46);
            this.button1280x1080.TabIndex = 26;
            this.button1280x1080.Text = "1280x1080";
            this.button1280x1080.UseVisualStyleBackColor = false;
            this.button1280x1080.Click += new System.EventHandler(this.button1_Click);
            // 
            // resBoxStandard
            // 
            this.resBoxStandard.Controls.Add(this.buttonFullHD);
            this.resBoxStandard.Controls.Add(this.button2560x1080);
            this.resBoxStandard.Controls.Add(this.button2560x1440);
            this.resBoxStandard.Controls.Add(this.button4K);
            this.resBoxStandard.Font = new System.Drawing.Font("Burbank Big Cd Bd", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resBoxStandard.Location = new System.Drawing.Point(227, 254);
            this.resBoxStandard.Name = "resBoxStandard";
            this.resBoxStandard.Size = new System.Drawing.Size(209, 129);
            this.resBoxStandard.TabIndex = 28;
            this.resBoxStandard.TabStop = false;
            this.resBoxStandard.Text = "Standard (16:9, 21:9)";
            // 
            // resBoxOther
            // 
            this.resBoxOther.Controls.Add(this.rdButtonWindow);
            this.resBoxOther.Controls.Add(this.rdButtonWindowFullscreen);
            this.resBoxOther.Controls.Add(this.rdButtonFullscreen);
            this.resBoxOther.Controls.Add(this.axisYlabel);
            this.resBoxOther.Controls.Add(this.buttonCustomRes);
            this.resBoxOther.Controls.Add(this.axisXlabel);
            this.resBoxOther.Controls.Add(this.axisXchooser);
            this.resBoxOther.Controls.Add(this.axisYchooser);
            this.resBoxOther.Font = new System.Drawing.Font("Burbank Big Cd Bd", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.resBoxOther.Location = new System.Drawing.Point(442, 254);
            this.resBoxOther.Name = "resBoxOther";
            this.resBoxOther.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.resBoxOther.Size = new System.Drawing.Size(228, 129);
            this.resBoxOther.TabIndex = 29;
            this.resBoxOther.TabStop = false;
            this.resBoxOther.Text = "Custom Resolution Panel";
            // 
            // rdButtonWindow
            // 
            this.rdButtonWindow.AutoSize = true;
            this.rdButtonWindow.Font = new System.Drawing.Font("Burbank Big Cd Bd", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.rdButtonWindow.Location = new System.Drawing.Point(6, 59);
            this.rdButtonWindow.Name = "rdButtonWindow";
            this.rdButtonWindow.Size = new System.Drawing.Size(64, 19);
            this.rdButtonWindow.TabIndex = 33;
            this.rdButtonWindow.TabStop = true;
            this.rdButtonWindow.Text = "Window";
            this.rdButtonWindow.UseVisualStyleBackColor = true;
            // 
            // rdButtonWindowFullscreen
            // 
            this.rdButtonWindowFullscreen.AutoSize = true;
            this.rdButtonWindowFullscreen.Font = new System.Drawing.Font("Burbank Big Cd Bd", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.rdButtonWindowFullscreen.Location = new System.Drawing.Point(6, 39);
            this.rdButtonWindowFullscreen.Name = "rdButtonWindowFullscreen";
            this.rdButtonWindowFullscreen.Size = new System.Drawing.Size(128, 19);
            this.rdButtonWindowFullscreen.TabIndex = 32;
            this.rdButtonWindowFullscreen.TabStop = true;
            this.rdButtonWindowFullscreen.Text = "Windowed fullscreen";
            this.rdButtonWindowFullscreen.UseVisualStyleBackColor = true;
            // 
            // rdButtonFullscreen
            // 
            this.rdButtonFullscreen.AutoSize = true;
            this.rdButtonFullscreen.Font = new System.Drawing.Font("Burbank Big Cd Bd", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.rdButtonFullscreen.Location = new System.Drawing.Point(6, 19);
            this.rdButtonFullscreen.Name = "rdButtonFullscreen";
            this.rdButtonFullscreen.Size = new System.Drawing.Size(75, 19);
            this.rdButtonFullscreen.TabIndex = 31;
            this.rdButtonFullscreen.TabStop = true;
            this.rdButtonFullscreen.Text = "Fullscreen";
            this.rdButtonFullscreen.UseVisualStyleBackColor = true;
            // 
            // axisYlabel
            // 
            this.axisYlabel.AutoSize = true;
            this.axisYlabel.Location = new System.Drawing.Point(146, 55);
            this.axisYlabel.Name = "axisYlabel";
            this.axisYlabel.Size = new System.Drawing.Size(17, 19);
            this.axisYlabel.TabIndex = 30;
            this.axisYlabel.Text = "Y";
            // 
            // axisXlabel
            // 
            this.axisXlabel.AutoSize = true;
            this.axisXlabel.Location = new System.Drawing.Point(146, 23);
            this.axisXlabel.Name = "axisXlabel";
            this.axisXlabel.Size = new System.Drawing.Size(17, 19);
            this.axisXlabel.TabIndex = 29;
            this.axisXlabel.Text = "X";
            // 
            // axisXchooser
            // 
            this.axisXchooser.Location = new System.Drawing.Point(169, 19);
            this.axisXchooser.Maximum = new decimal(new int[] {
            7680,
            0,
            0,
            0});
            this.axisXchooser.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.axisXchooser.Name = "axisXchooser";
            this.axisXchooser.Size = new System.Drawing.Size(53, 26);
            this.axisXchooser.TabIndex = 27;
            this.axisXchooser.Value = new decimal(new int[] {
            1600,
            0,
            0,
            0});
            // 
            // axisYchooser
            // 
            this.axisYchooser.Location = new System.Drawing.Point(169, 51);
            this.axisYchooser.Maximum = new decimal(new int[] {
            4320,
            0,
            0,
            0});
            this.axisYchooser.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.axisYchooser.Name = "axisYchooser";
            this.axisYchooser.Size = new System.Drawing.Size(53, 26);
            this.axisYchooser.TabIndex = 28;
            this.axisYchooser.Value = new decimal(new int[] {
            900,
            0,
            0,
            0});
            // 
            // programStartTimer
            // 
            this.programStartTimer.Interval = 5;
            this.programStartTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // programStopTimer
            // 
            this.programStopTimer.Interval = 5;
            this.programStopTimer.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // extContentLabel
            // 
            this.extContentLabel.AutoSize = true;
            this.extContentLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.extContentLabel.Font = new System.Drawing.Font("Burbank Big Cd Bd", 10F, System.Drawing.FontStyle.Italic);
            this.extContentLabel.Location = new System.Drawing.Point(423, 386);
            this.extContentLabel.Name = "extContentLabel";
            this.extContentLabel.Size = new System.Drawing.Size(247, 14);
            this.extContentLabel.TabIndex = 30;
            this.extContentLabel.Text = "This program uses external utility made by \"Nocksoft\".";
            this.extContentLabel.Click += new System.EventHandler(this.extContentLabel_Click);
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.copyrightLabel.Font = new System.Drawing.Font("Burbank Big Cd Bd", 10F, System.Drawing.FontStyle.Italic);
            this.copyrightLabel.Location = new System.Drawing.Point(554, 400);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(116, 14);
            this.copyrightLabel.TabIndex = 31;
            this.copyrightLabel.Text = "Author: deegl0rd @ 2019";
            this.copyrightLabel.Click += new System.EventHandler(this.copyrightLabel_Click);
            // 
            // fortPicBox
            // 
            this.fortPicBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fortPicBox.Image = global::Fortnite_Res_Configurator.Properties.Resources.fortnite;
            this.fortPicBox.Location = new System.Drawing.Point(0, 0);
            this.fortPicBox.Name = "fortPicBox";
            this.fortPicBox.Size = new System.Drawing.Size(682, 248);
            this.fortPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fortPicBox.TabIndex = 1;
            this.fortPicBox.TabStop = false;
            // 
            // FortResConfigWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(682, 570);
            this.ControlBox = false;
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.extContentLabel);
            this.Controls.Add(this.resBoxOther);
            this.Controls.Add(this.resBoxStandard);
            this.Controls.Add(this.dividerPanel);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.logLabel);
            this.Controls.Add(this.gusLabel);
            this.Controls.Add(this.gusBox);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.formHead);
            this.Controls.Add(this.fortPicBox);
            this.Controls.Add(this.resBoxStretched);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FortResConfigWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fortnite Resolution Configurator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.formHead.ResumeLayout(false);
            this.resBoxStretched.ResumeLayout(false);
            this.resBoxStandard.ResumeLayout(false);
            this.resBoxOther.ResumeLayout(false);
            this.resBoxOther.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axisXchooser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axisYchooser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fortPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.PictureBox fortPicBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label logLabel;
        private System.Windows.Forms.Panel formHead;
        private System.Windows.Forms.Panel dividerPanel;
        private System.Windows.Forms.Button gusHelpButton;
        private System.Windows.Forms.Label gusLabel;
        private System.Windows.Forms.TextBox gusBox;
        private System.Windows.Forms.Button buttonFullHD;
        private System.Windows.Forms.Button button1440P;
        private System.Windows.Forms.Button button1080x1080;
        private System.Windows.Forms.Button button600x1080;
        private System.Windows.Forms.Button button2560x1080;
        private System.Windows.Forms.Button button2560x1440;
        private System.Windows.Forms.Button button4K;
        private System.Windows.Forms.Button buttonCustomRes;
        private System.Windows.Forms.GroupBox resBoxStretched;
        private System.Windows.Forms.Button button1280x1080;
        private System.Windows.Forms.GroupBox resBoxStandard;
        private System.Windows.Forms.GroupBox resBoxOther;
        public System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.Label axisYlabel;
        private System.Windows.Forms.Label axisXlabel;
        private System.Windows.Forms.NumericUpDown axisXchooser;
        private System.Windows.Forms.NumericUpDown axisYchooser;
        private System.Windows.Forms.RadioButton rdButtonWindow;
        private System.Windows.Forms.RadioButton rdButtonWindowFullscreen;
        private System.Windows.Forms.RadioButton rdButtonFullscreen;
        private System.Windows.Forms.Timer programStartTimer;
        private System.Windows.Forms.Timer programStopTimer;
        private System.Windows.Forms.Label extContentLabel;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.Button socTwitchButton;
        private System.Windows.Forms.Button socYouTubeButton;
    }
}

