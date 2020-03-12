using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fortnite_Res_Configurator
{
    public partial class FortResConfigWindow : Form
    {
        //Initial variables.
        private int moving;
        private int mouseX;
        private int mouseY;
        public int widthNum;
        public int heightNum;
        public static int fscNum;
        bool valid = false;
        private static ScreenModeSwitcher formSwitcher;
        private static FortResConfigWindow instance;
        public static bool alreadySelected = false;
        INIFile ini;
        string filePath;

        //Instance getter
        public static FortResConfigWindow getInstance()
        {
            return instance;
        }

        //Basic logger method.
        private void log(TextBox logArea, String text)
        {
            logArea.AppendText("[Log] [" + DateTime.Now.ToString("h:mm:ss") + "] " + text);
            logArea.AppendText(Environment.NewLine);
        }

        //Expanded logger solution.
        private void log(int prefixChanger, TextBox logArea, String text)
        {
            if (prefixChanger == 0)
            {
                logArea.AppendText("[Log] [" + DateTime.Now.ToString("h:mm:ss") + "] " + text);
                logArea.AppendText(Environment.NewLine);
            }
            else if (prefixChanger == 1)
            {
                logArea.AppendText(text);
                logArea.AppendText(Environment.NewLine);
            }
        }

        //switch between the two forms
        private void switchToScreenModeWindow()
        {
            formSwitcher.Show();
            Hide();
        }

        //GameUserSettings.ini logbox recalculator method.
        public void recalcGus()
        {
            //Resetting GameUserSettings.ini logbox text.
            gusBox.Text = "";

            //Reading the GameUserSettings.ini file.
            foreach (string s in System.IO.File.ReadAllLines(filePath))
            {
                if ((s.Contains("FullscreenMode") || s.Contains("Resolution")))
                {
                    if ((!s.Contains("sg.ResolutionQuality")) && (!s.Contains("bUseDynamicResolution")))
                    {
                        //Validating GameUserSettings.ini.
                        valid = true;
                    }
                }
            }
            if (valid == true)
            {
                //Printing GameUserSettings.ini data
                switch (ini.GetValue("/Script/FortniteGame.FortGameUserSettings", "FullscreenMode"))
                {
                    case "0":
                        log(1, gusBox, "Window mode: FULLSCREEN");
                        break;
                    case "1":
                        log(1, gusBox, "Window mode: WINDOWED FULLSCREEN");
                        break;
                    case "2":
                        log(1, gusBox, "Window mode: WINDOW");
                        break;
                }
                switch (ini.GetValue("/Script/FortniteGame.FortGameUserSettings", "LastConfirmedFullscreenMode"))
                {
                    case "0":
                        log(1, gusBox, "Last Confirmed Window mode: FULLSCREEN");
                        break;
                    case "1":
                        log(1, gusBox, "Last Confirmed Window mode: WINDOWED FULLSCREEN");
                        break;
                    case "2":
                        log(1, gusBox, "Last Confirmed Window mode: WINDOW");
                        break;
                }
                switch (ini.GetValue("/Script/FortniteGame.FortGameUserSettings", "PreferredFullscreenMode"))
                {
                    case "0":
                        log(1, gusBox, "Preferred Window mode: FULLSCREEN");
                        break;
                    case "1":
                        log(1, gusBox, "Preferred Window mode: WINDOWED FULLSCREEN");
                        break;
                    case "2":
                        log(1, gusBox, "Preferred Window mode: WINDOW");
                        break;
                }
                log(1, gusBox, "Resolution X axis: " + ini.GetValue("/Script/FortniteGame.FortGameUserSettings", "ResolutionSizeX", false));
                log(1, gusBox, "Resolution Y axis: " + ini.GetValue("/Script/FortniteGame.FortGameUserSettings", "ResolutionSizeY", false));
                log(1, gusBox, "Last Confirmed Resolution X axis: " + ini.GetValue("/Script/FortniteGame.FortGameUserSettings", "LastUserConfirmedResolutionSizeX", false));
                log(1, gusBox, "Last Confirmed Resolution Y axis: " + ini.GetValue("/Script/FortniteGame.FortGameUserSettings", "LastUserConfirmedResolutionSizeY", false));
            }
            else
            {
                //Printing out that file doesnt contain valid data.
                valid = false;
                log(1, logBox, "--------------------------------------------------------------------------------------------------");
                log(logBox, "GameUserSettings.ini file is invalid! Click folder icon to check GameUserSettings.ini folder!");
                log(1, logBox, "--------------------------------------------------------------------------------------------------");
                log(logBox, "Location: " + filePath);
            }
        }

        //RESOLUTION CHANGING METHOD
        public void changeRes(int resX, int resY)
        {
            //Check if the GameUserSettings.ini file doesn't exist.
            if (!System.IO.File.Exists(filePath))
            {
                gusBox.Text = "";
                log(1, logBox, "--------------------------------------------------------------------------------------------------");
                log(logBox, "GameUserSettings.ini file doesn't exist. Run Fortnite to generate a new one.");
                log(1, gusBox, "GameUserSettings.ini file doesn't exist. Run Fortnite to generate a new one.");
                return;
            }

            if (valid == true)
            {
                //Resolution changing methods using INIFile.cs made by Nocksoft (check INIFile.cs for more information)
                ini.SetValue("/Script/FortniteGame.FortGameUserSettings", "FullscreenMode", "0", false);
                ini.SetValue("/Script/FortniteGame.FortGameUserSettings", "LastConfirmedFullscreenMode", "0", false);
                ini.SetValue("/Script/FortniteGame.FortGameUserSettings", "PreferredFullscreenMode", "0", false);
                ini.SetValue("/Script/FortniteGame.FortGameUserSettings", "ResolutionSizeX", resX.ToString(), false);
                ini.SetValue("/Script/FortniteGame.FortGameUserSettings", "ResolutionSizeY", resY.ToString(), false);
                ini.SetValue("/Script/FortniteGame.FortGameUserSettings", "LastUserConfirmedResolutionSizeX", resX.ToString(), false);
                ini.SetValue("/Script/FortniteGame.FortGameUserSettings", "LastUserConfirmedResolutionSizeY", resY.ToString(), false);

                //Log the successful resolution changing.
                log(1, logBox, "--------------------------------------------------------------------------------------------------");
                log(logBox, "Resolution was successfully changed to " + resX.ToString() + "x" + resY.ToString() + " FULLSCREEN");

                //Call method to recalculate Screen display content textbox.
                recalcGus();
            }
            else
            {
                //Printing out that file doesnt contain valid data.
                valid = false;
                log(1, logBox, "--------------------------------------------------------------------------------------------------");
                log(logBox, "GameUserSettings.ini file is invalid! Click folder icon to check GameUserSettings.ini folder!");
                log(1, logBox, "--------------------------------------------------------------------------------------------------");
                log(logBox, "Location: " + filePath);
            }
        }

        //Resolution changer method.
        public void changeRes(int resX, int resY, int fscmode)
        {
            //Check if the GameUserSettings.ini file doesn't exist.
            if (!System.IO.File.Exists(filePath))
            {
                gusBox.Text = "";
                log(1, logBox, "--------------------------------------------------------------------------------------------------");
                log(logBox, "GameUserSettings.ini file doesn't exist. Run Fortnite to generate a new one.");
                log(1, gusBox, "GameUserSettings.ini file doesn't exist. Run Fortnite to generate a new one.");
                return;
            }

            if (valid == true)
            {
                //Resolution changing methods using INIFile.cs made by Nocksoft (check INIFile.cs for more information)
                ini.SetValue("/Script/FortniteGame.FortGameUserSettings", "FullscreenMode", fscmode.ToString(), false);
                ini.SetValue("/Script/FortniteGame.FortGameUserSettings", "LastConfirmedFullscreenMode", fscmode.ToString(), false);
                ini.SetValue("/Script/FortniteGame.FortGameUserSettings", "PreferredFullscreenMode", fscmode.ToString(), false);
                ini.SetValue("/Script/FortniteGame.FortGameUserSettings", "ResolutionSizeX", resX.ToString(), false);
                ini.SetValue("/Script/FortniteGame.FortGameUserSettings", "ResolutionSizeY", resY.ToString(), false);
                ini.SetValue("/Script/FortniteGame.FortGameUserSettings", "LastUserConfirmedResolutionSizeX", resX.ToString(), false);
                ini.SetValue("/Script/FortniteGame.FortGameUserSettings", "LastUserConfirmedResolutionSizeY", resY.ToString(), false);

                //Log the successful resolution changing.
                log(1, logBox, "--------------------------------------------------------------------------------------------------");
                switch (fscmode.ToString())
                {
                    case "0":
                        log(logBox, "Resolution was successfully changed to " + resX.ToString() + "x" + resY.ToString() + " FULLSCREEN");
                        break;
                    case "1":
                        log(logBox, "Resolution was successfully changed to " + resX.ToString() + "x" + resY.ToString() + " WINDOWED FULLSCREEN");
                        break;
                    case "2":
                        log(logBox, "Resolution was successfully changed to " + resX.ToString() + "x" + resY.ToString() + " WINDOW");
                        break;
                }

                //Call method to recalculate Screen display content textbox.
                recalcGus();
            }
        }

        //CONSTRUCTOR
        public FortResConfigWindow()
        {
            InitializeComponent();
        }

        //OPENING TASKS
        private void Form1_Load(object sender, EventArgs e)
        {
            //initialize variables
            filePath = Environment.GetEnvironmentVariable("LocalAppData") + "\\FortniteGame\\Saved\\Config\\WindowsClient\\GameUserSettings.ini";
            ini = new INIFile(filePath, false);
            instance = this;
            formSwitcher = new ScreenModeSwitcher();
            
            //form lookout settings
            mainLabel.Parent = fortPicBox;
            formHead.BackColor = Color.FromArgb(240, 57, 57, 57);
            formHead.Parent = fortPicBox;

            //form fade-in
            Opacity = 0.0;
            programStartTimer.Start();
            programStartTimer.Enabled = true;

            //load up basic information
            log(1, logBox, "FORTNITE RESOLUTION CONFIGURATOR v1.0");

            //Check if the GameUserSettings.ini file doesn't exist.
            if (!System.IO.File.Exists(filePath))
            {
                gusBox.Text = "";
                log(1, logBox, "--------------------------------------------------------------------------------------------------");
                log(logBox, "GameUserSettings.ini file doesn't exist. Run Fortnite to generate a new one.");
                log(1, gusBox, "GameUserSettings.ini file doesn't exist. Run Fortnite to generate a new one.");
                return;
            }

            //print out updated statistics about GameUserSettings.ini file
            recalcGus();

            //Printing out validation message.
            if (valid == true)
            {
                log(1, logBox, "--------------------------------------------------------------------------------------------------");
                log(logBox, "GameUserSettings.ini file was successfully read. Click folder icon to check GameUserSettings.ini folder!");
                log(1, logBox, "--------------------------------------------------------------------------------------------------");
                log(logBox, "Location: " + filePath);
            }
        }

        //EXIT BUTTON
        private void exitButton_Click(object sender, EventArgs e)
        {
            //quit app
            programStopTimer.Start();
        }

        private void formhead_MouseDown(object sender, MouseEventArgs e)
        {
            //Form head movement enter
            moving = 1;
            mouseX = e.X;
            mouseY = e.Y;
        }

        private void formhead_MouseUp(object sender, MouseEventArgs e)
        {
            //Form head movement cancel
            moving = 0;
        }

        private void formhead_MouseMove(object sender, MouseEventArgs e)
        {
            //Form head movement control
            if (moving == 1) SetDesktopLocation(MousePosition.X - mouseX, MousePosition.Y - mouseY);
        }

        //Blinker for radiobuttons.
        private async void blink(int delay)
        {
            rdButtonFullscreen.Enabled = false;
            rdButtonWindowFullscreen.Enabled = false;
            rdButtonWindow.Enabled = false;

            rdButtonFullscreen.Text = "";
            rdButtonWindowFullscreen.Text = "";
            rdButtonWindow.Text = "";
            await Task.Delay(delay);
            rdButtonFullscreen.Text = "Fullscreen";
            rdButtonWindowFullscreen.Text = "Windowed fullscreen";
            rdButtonWindow.Text = "Window";
            await Task.Delay(delay);
            rdButtonFullscreen.Text = "";
            rdButtonWindowFullscreen.Text = "";
            rdButtonWindow.Text = "";
            await Task.Delay(delay);
            rdButtonFullscreen.Text = "Fullscreen";
            rdButtonWindowFullscreen.Text = "Windowed fullscreen";
            rdButtonWindow.Text = "Window";
            await Task.Delay(delay);
            rdButtonFullscreen.Text = "";
            rdButtonWindowFullscreen.Text = "";
            rdButtonWindow.Text = "";
            await Task.Delay(delay);
            rdButtonFullscreen.Text = "Fullscreen";
            rdButtonWindowFullscreen.Text = "Windowed fullscreen";
            rdButtonWindow.Text = "Window";

            rdButtonFullscreen.Enabled = true;
            rdButtonWindowFullscreen.Enabled = true;
            rdButtonWindow.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //1920x1080 BUTTON NORMAL
            widthNum = 1920;
            heightNum = 1080;
            switchToScreenModeWindow();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //1440x1080 BUTTON
            widthNum = 1440;
            heightNum = 1080;
            changeRes(widthNum, heightNum);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //1080x1080 BUTTON
            widthNum = 1080;
            heightNum = 1080;
            changeRes(widthNum, heightNum);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //600x1080 BUTTON
            widthNum = 600;
            heightNum = 1080;
            changeRes(widthNum, heightNum);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //2560x1080 BUTTON NORMAL
            widthNum = 2560;
            heightNum = 1080;
            switchToScreenModeWindow();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //2560x1440 BUTTON NORMAL
            widthNum = 2560;
            heightNum = 1440;
            switchToScreenModeWindow();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //3840x2160 BUTTON NORMAL
            widthNum = 3840;
            heightNum = 2160;
            switchToScreenModeWindow();
        }

        //HELP BUTTON
        private void gusHelpButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(System.IO.Path.GetDirectoryName(filePath));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1280x1080 BUTTON
            widthNum = 1280;
            heightNum = 1080;
            changeRes(widthNum, heightNum);
        }

        private void buttonCustomRes_Click(object sender, EventArgs e)
        {
            widthNum = Decimal.ToInt32(axisXchooser.Value);
            heightNum = Decimal.ToInt32(axisYchooser.Value);

            if (rdButtonFullscreen.Checked || rdButtonWindowFullscreen.Checked || rdButtonWindow.Checked)
            {
                if (rdButtonFullscreen.Checked)
                {
                    fscNum = 0;
                }
                else if (rdButtonWindowFullscreen.Checked)
                {
                    fscNum = 1;
                }
                else if (rdButtonWindow.Checked)
                {
                    fscNum = 2;
                }
                changeRes(widthNum, heightNum, fscNum);

                rdButtonFullscreen.Checked = false;
                rdButtonWindow.Checked = false;
                rdButtonWindowFullscreen.Checked = false;
            }
            else
            {
                blink(125);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity <= 1.0)
            {
                Opacity += 0.050;
            }
            if (Opacity == 1.0)
            {
                programStartTimer.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Opacity <= 1.0)
            {
                Opacity -= 0.050;
            }
            if (Opacity == 0)
            {
                programStopTimer.Stop();
                Application.Exit();
            }
        }

        private void copyrightLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using my program!" + Environment.NewLine + "Author: deegl0rd" + Environment.NewLine + "@ 2019 @", "Fortnite Resolution Configurator", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void socTwitchButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.twitch.tv/virtuosohun");
        }

        private void socYouTubeButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/c/virtuosohun");
        }

        private void extContentLabel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://nocksoft.de/");
        }
    }
}
