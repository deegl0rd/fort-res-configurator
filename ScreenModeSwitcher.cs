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
    public partial class ScreenModeSwitcher : Form
    {
        private int moving;
        private int mouseX;
        private int mouseY;

        private void switchToMainWindow()
        {
            Hide();
            FortResConfigWindow.getInstance().Show();
            FortResConfigWindow.getInstance().logBox.ScrollToCaret();
        }
        public ScreenModeSwitcher()
        {
            InitializeComponent();
        }

        private void ScreenModeSwitcher_Load(object sender, EventArgs e)
        {
            label1.Parent = bkgPicture;
            swchformHead.BackColor = Color.FromArgb(210, 57, 57, 57);
            swchformHead.Parent = bkgPicture;
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

        private void button4_Click(object sender, EventArgs e)
        {
            switchToMainWindow();
        }

        private void ScreenModeSwitcher_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FortResConfigWindow.getInstance().changeRes(FortResConfigWindow.getInstance().widthNum, FortResConfigWindow.getInstance().heightNum, 0);
            switchToMainWindow();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FortResConfigWindow.getInstance().changeRes(FortResConfigWindow.getInstance().widthNum, FortResConfigWindow.getInstance().heightNum, 1);
            switchToMainWindow();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FortResConfigWindow.getInstance().changeRes(FortResConfigWindow.getInstance().widthNum, FortResConfigWindow.getInstance().heightNum, 2);
            switchToMainWindow();
        }
    }
}
