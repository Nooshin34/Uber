namespace UberApp.Forms
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            registrationToolStripMenuItem = new ToolStripMenuItem();
            userRegistrationToolStripMenuItem = new ToolStripMenuItem();
            carRegistrationToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Black;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { registrationToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // registrationToolStripMenuItem
            // 
            registrationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { userRegistrationToolStripMenuItem, carRegistrationToolStripMenuItem });
            registrationToolStripMenuItem.ForeColor = SystemColors.Control;
            registrationToolStripMenuItem.Name = "registrationToolStripMenuItem";
            registrationToolStripMenuItem.Size = new Size(122, 29);
            registrationToolStripMenuItem.Text = "Registration";
            // 
            // userRegistrationToolStripMenuItem
            // 
            userRegistrationToolStripMenuItem.Name = "userRegistrationToolStripMenuItem";
            userRegistrationToolStripMenuItem.Size = new Size(270, 34);
            userRegistrationToolStripMenuItem.Text = "User registration";
            userRegistrationToolStripMenuItem.Click += userRegistrationToolStripMenuItem_Click;
            // 
            // carRegistrationToolStripMenuItem
            // 
            carRegistrationToolStripMenuItem.Name = "carRegistrationToolStripMenuItem";
            carRegistrationToolStripMenuItem.Size = new Size(270, 34);
            carRegistrationToolStripMenuItem.Text = "Car registration";
            carRegistrationToolStripMenuItem.Click += carRegistrationToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem registrationToolStripMenuItem;
        private ToolStripMenuItem userRegistrationToolStripMenuItem;
        private ToolStripMenuItem carRegistrationToolStripMenuItem;
    }
}
