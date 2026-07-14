namespace UberApp.Forms
{
    partial class RequestTaxiForm
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
            fullNameLabel = new Label();
            idLabel = new Label();
            fullNameTextBox = new TextBox();
            idTextBox = new TextBox();
            SuspendLayout();
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new Point(318, 45);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(91, 25);
            fullNameLabel.TabIndex = 0;
            fullNameLabel.Text = "Full Name";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(37, 45);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(28, 25);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id";
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.Enabled = false;
            fullNameTextBox.Location = new Point(435, 39);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(239, 31);
            fullNameTextBox.TabIndex = 2;
            // 
            // idTextBox
            // 
            idTextBox.Enabled = false;
            idTextBox.Location = new Point(113, 39);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(78, 31);
            idTextBox.TabIndex = 3;
            // 
            // RequestTaxiForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(737, 439);
            Controls.Add(idTextBox);
            Controls.Add(fullNameTextBox);
            Controls.Add(idLabel);
            Controls.Add(fullNameLabel);
            Name = "RequestTaxiForm";
            Text = "RequestTaxiForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label fullNameLabel;
        private Label idLabel;
        private TextBox fullNameTextBox;
        private TextBox idTextBox;
    }
}