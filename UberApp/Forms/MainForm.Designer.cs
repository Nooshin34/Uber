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
            uberAppToolStripMenuItem = new ToolStripMenuItem();
            taxiToolStripMenuItem = new ToolStripMenuItem();
            mToolStripMenuItem = new ToolStripMenuItem();
            foodToolStripMenuItem = new ToolStripMenuItem();
            hotelToolStripMenuItem = new ToolStripMenuItem();
            driverRegistrationToolStripMenuItem = new ToolStripMenuItem();
            userRegistrationToolStripMenuItem = new ToolStripMenuItem();
            driverRegistrationToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Black;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { uberAppToolStripMenuItem, driverRegistrationToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // uberAppToolStripMenuItem
            // 
            uberAppToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { taxiToolStripMenuItem, mToolStripMenuItem, foodToolStripMenuItem, hotelToolStripMenuItem });
            uberAppToolStripMenuItem.ForeColor = SystemColors.Control;
            uberAppToolStripMenuItem.Name = "uberAppToolStripMenuItem";
            uberAppToolStripMenuItem.Size = new Size(102, 29);
            uberAppToolStripMenuItem.Text = "Uber app";
            // 
            // taxiToolStripMenuItem
            // 
            taxiToolStripMenuItem.Name = "taxiToolStripMenuItem";
            taxiToolStripMenuItem.Size = new Size(270, 34);
            taxiToolStripMenuItem.Text = "Taxi";
            // 
            // mToolStripMenuItem
            // 
            mToolStripMenuItem.Name = "mToolStripMenuItem";
            mToolStripMenuItem.Size = new Size(270, 34);
            mToolStripMenuItem.Text = "Motor";
            mToolStripMenuItem.Click += mToolStripMenuItem_Click;
            // 
            // foodToolStripMenuItem
            // 
            foodToolStripMenuItem.Name = "foodToolStripMenuItem";
            foodToolStripMenuItem.Size = new Size(270, 34);
            foodToolStripMenuItem.Text = "Food";
            // 
            // hotelToolStripMenuItem
            // 
            hotelToolStripMenuItem.Name = "hotelToolStripMenuItem";
            hotelToolStripMenuItem.Size = new Size(270, 34);
            hotelToolStripMenuItem.Text = "Hotel";
            // 
            // driverRegistrationToolStripMenuItem
            // 
            driverRegistrationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { userRegistrationToolStripMenuItem, driverRegistrationToolStripMenuItem1 });
            driverRegistrationToolStripMenuItem.ForeColor = SystemColors.Control;
            driverRegistrationToolStripMenuItem.Name = "driverRegistrationToolStripMenuItem";
            driverRegistrationToolStripMenuItem.Size = new Size(122, 29);
            driverRegistrationToolStripMenuItem.Text = "Registration";
            driverRegistrationToolStripMenuItem.Click += driverRegistrationToolStripMenuItem_Click;
            // 
            // userRegistrationToolStripMenuItem
            // 
            userRegistrationToolStripMenuItem.Name = "userRegistrationToolStripMenuItem";
            userRegistrationToolStripMenuItem.Size = new Size(270, 34);
            userRegistrationToolStripMenuItem.Text = "User registration";
            userRegistrationToolStripMenuItem.Click += userRegistrationToolStripMenuItem_Click;
            // 
            // driverRegistrationToolStripMenuItem1
            // 
            driverRegistrationToolStripMenuItem1.Name = "driverRegistrationToolStripMenuItem1";
            driverRegistrationToolStripMenuItem1.Size = new Size(270, 34);
            driverRegistrationToolStripMenuItem1.Text = "Driver registration";
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
        private ToolStripMenuItem uberAppToolStripMenuItem;
        private ToolStripMenuItem taxiToolStripMenuItem;
        private ToolStripMenuItem mToolStripMenuItem;
        private ToolStripMenuItem foodToolStripMenuItem;
        private ToolStripMenuItem hotelToolStripMenuItem;
        private ToolStripMenuItem driverRegistrationToolStripMenuItem;
        private ToolStripMenuItem userRegistrationToolStripMenuItem;
        private ToolStripMenuItem driverRegistrationToolStripMenuItem1;
    }
}