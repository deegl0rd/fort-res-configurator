namespace Fortnite_Res_Configurator
{
    partial class ScreenModeSwitcher
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
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.swchformHead = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.gusHelpButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bkgPicture = new System.Windows.Forms.PictureBox();
            this.swchformHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bkgPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Font = new System.Drawing.Font("Burbank Big Cd Bd", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(12, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Fullscreen";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button3.Font = new System.Drawing.Font("Burbank Big Cd Bd", 15.75F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(300, 123);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 52);
            this.button3.TabIndex = 2;
            this.button3.Text = "Window";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button2.Font = new System.Drawing.Font("Burbank Big Cd Bd", 14F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(156, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 52);
            this.button2.TabIndex = 3;
            this.button2.Text = "Windowed fullscreen";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // swchformHead
            // 
            this.swchformHead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.swchformHead.BackColor = System.Drawing.Color.DarkGray;
            this.swchformHead.Controls.Add(this.button4);
            this.swchformHead.Controls.Add(this.gusHelpButton);
            this.swchformHead.Controls.Add(this.exitButton);
            this.swchformHead.Location = new System.Drawing.Point(0, 0);
            this.swchformHead.Name = "swchformHead";
            this.swchformHead.Size = new System.Drawing.Size(446, 53);
            this.swchformHead.TabIndex = 10;
            this.swchformHead.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formhead_MouseDown);
            this.swchformHead.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formhead_MouseMove);
            this.swchformHead.MouseUp += new System.Windows.Forms.MouseEventHandler(this.formhead_MouseUp);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Burbank Big Cd Bd", 40F, System.Drawing.FontStyle.Bold);
            this.button4.Image = global::Fortnite_Res_Configurator.Properties.Resources.backarrow;
            this.button4.Location = new System.Drawing.Point(393, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(53, 53);
            this.button4.TabIndex = 11;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // gusHelpButton
            // 
            this.gusHelpButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.gusHelpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gusHelpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gusHelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gusHelpButton.Font = new System.Drawing.Font("Burbank Big Cd Bd", 40F, System.Drawing.FontStyle.Bold);
            this.gusHelpButton.Location = new System.Drawing.Point(577, 0);
            this.gusHelpButton.Name = "gusHelpButton";
            this.gusHelpButton.Size = new System.Drawing.Size(53, 53);
            this.gusHelpButton.TabIndex = 19;
            this.gusHelpButton.UseVisualStyleBackColor = false;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Burbank Big Cd Bd", 40F, System.Drawing.FontStyle.Bold);
            this.exitButton.Location = new System.Drawing.Point(629, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(0, 53);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Burbank Big Cd Bd", 32F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 55);
            this.label1.TabIndex = 11;
            this.label1.Text = "Choose screen display mode!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bkgPicture
            // 
            this.bkgPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bkgPicture.Image = global::Fortnite_Res_Configurator.Properties.Resources.fortnite;
            this.bkgPicture.Location = new System.Drawing.Point(0, 0);
            this.bkgPicture.Name = "bkgPicture";
            this.bkgPicture.Size = new System.Drawing.Size(446, 187);
            this.bkgPicture.TabIndex = 4;
            this.bkgPicture.TabStop = false;
            // 
            // ScreenModeSwitcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(446, 187);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.swchformHead);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bkgPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "ScreenModeSwitcher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScreenModeSwitcher";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ScreenModeSwitcher_FormClosed);
            this.Load += new System.EventHandler(this.ScreenModeSwitcher_Load);
            this.swchformHead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bkgPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox bkgPicture;
        private System.Windows.Forms.Panel swchformHead;
        private System.Windows.Forms.Button gusHelpButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
    }
}