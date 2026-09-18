namespace UberApp.Forms
{
    partial class UserRegistrationForm
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
            editButton = new Button();
            isActiveRadioButton = new RadioButton();
            passTextBox = new TextBox();
            passLabel = new Label();
            userDataGridView = new DataGridView();
            addUserButton = new Button();
            phoneTextBox = new TextBox();
            phoneLabel = new Label();
            userNameTextBox = new TextBox();
            userNameLabel = new Label();
            lastNameTextBox = new TextBox();
            lastNameLabel = new Label();
            firstNameTextBox = new TextBox();
            firstNameLabel = new Label();
            requestTaxiButton = new Button();
            manageCarsButton = new Button();
            ((System.ComponentModel.ISupportInitialize)userDataGridView).BeginInit();
            SuspendLayout();
            // 
            // editButton
            // 
            editButton.BackColor = Color.Peru;
            editButton.ForeColor = SystemColors.Control;
            editButton.Location = new Point(320, 522);
            editButton.Name = "editButton";
            editButton.Size = new Size(171, 63);
            editButton.TabIndex = 37;
            editButton.Text = "Edit User";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // isActiveRadioButton
            // 
            isActiveRadioButton.AutoSize = true;
            isActiveRadioButton.ForeColor = SystemColors.Control;
            isActiveRadioButton.Location = new Point(51, 360);
            isActiveRadioButton.Name = "isActiveRadioButton";
            isActiveRadioButton.Size = new Size(85, 29);
            isActiveRadioButton.TabIndex = 35;
            isActiveRadioButton.TabStop = true;
            isActiveRadioButton.Text = "Active";
            isActiveRadioButton.UseVisualStyleBackColor = true;
            // 
            // passTextBox
            // 
            passTextBox.Location = new Point(201, 286);
            passTextBox.Name = "passTextBox";
            passTextBox.Size = new Size(286, 31);
            passTextBox.TabIndex = 30;
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.ForeColor = SystemColors.Control;
            passLabel.Location = new Point(51, 289);
            passLabel.Name = "passLabel";
            passLabel.Size = new Size(87, 25);
            passLabel.TabIndex = 29;
            passLabel.Text = "Password";
            // 
            // userDataGridView
            // 
            userDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userDataGridView.Location = new Point(547, 42);
            userDataGridView.Name = "userDataGridView";
            userDataGridView.RowHeadersWidth = 62;
            userDataGridView.Size = new Size(572, 408);
            userDataGridView.TabIndex = 28;
            userDataGridView.CellClick += userDataGridView_CellClick;
            // 
            // addUserButton
            // 
            addUserButton.BackColor = Color.CornflowerBlue;
            addUserButton.ForeColor = SystemColors.Control;
            addUserButton.Location = new Point(143, 522);
            addUserButton.Name = "addUserButton";
            addUserButton.Size = new Size(171, 63);
            addUserButton.TabIndex = 27;
            addUserButton.Text = "Add User";
            addUserButton.UseVisualStyleBackColor = false;
            addUserButton.Click += addUserButton_Click;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(201, 223);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(286, 31);
            phoneTextBox.TabIndex = 26;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.ForeColor = SystemColors.Control;
            phoneLabel.Location = new Point(51, 226);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(132, 25);
            phoneLabel.TabIndex = 25;
            phoneLabel.Text = "Phone Number";
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(201, 159);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(286, 31);
            userNameTextBox.TabIndex = 24;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.ForeColor = SystemColors.Control;
            userNameLabel.Location = new Point(51, 159);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(94, 25);
            userNameLabel.TabIndex = 23;
            userNameLabel.Text = "UserName";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(201, 99);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(286, 31);
            lastNameTextBox.TabIndex = 22;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.ForeColor = SystemColors.Control;
            lastNameLabel.Location = new Point(51, 99);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(90, 25);
            lastNameLabel.TabIndex = 21;
            lastNameLabel.Text = "LastName";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(201, 42);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(286, 31);
            firstNameTextBox.TabIndex = 20;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.ForeColor = SystemColors.Control;
            firstNameLabel.Location = new Point(51, 42);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(92, 25);
            firstNameLabel.TabIndex = 19;
            firstNameLabel.Text = "FirstName";
            // 
            // requestTaxiButton
            // 
            requestTaxiButton.BackColor = Color.CornflowerBlue;
            requestTaxiButton.ForeColor = SystemColors.Control;
            requestTaxiButton.Location = new Point(497, 522);
            requestTaxiButton.Name = "requestTaxiButton";
            requestTaxiButton.Size = new Size(171, 63);
            requestTaxiButton.TabIndex = 38;
            requestTaxiButton.Text = "Request Taxi";
            requestTaxiButton.UseVisualStyleBackColor = false;
            requestTaxiButton.Click += requestTaxiButton_Click;
            // 
            // manageCarsButton
            // 
            manageCarsButton.BackColor = Color.SeaGreen;
            manageCarsButton.ForeColor = SystemColors.Control;
            manageCarsButton.Location = new Point(674, 522);
            manageCarsButton.Name = "manageCarsButton";
            manageCarsButton.Size = new Size(171, 63);
            manageCarsButton.TabIndex = 39;
            manageCarsButton.Text = "Manage Cars";
            manageCarsButton.UseVisualStyleBackColor = false;
            manageCarsButton.Click += manageCarsButton_Click;
            // 
            // UserRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1170, 628);
            Controls.Add(manageCarsButton);
            Controls.Add(requestTaxiButton);
            Controls.Add(editButton);
            Controls.Add(isActiveRadioButton);
            Controls.Add(passTextBox);
            Controls.Add(passLabel);
            Controls.Add(userDataGridView);
            Controls.Add(addUserButton);
            Controls.Add(phoneTextBox);
            Controls.Add(phoneLabel);
            Controls.Add(userNameTextBox);
            Controls.Add(userNameLabel);
            Controls.Add(lastNameTextBox);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameTextBox);
            Controls.Add(firstNameLabel);
            Name = "UserRegistrationForm";
            Text = "UserRegistrationForm";
            ((System.ComponentModel.ISupportInitialize)userDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button editButton;
        private RadioButton isActiveRadioButton;
        private TextBox passTextBox;
        private Label passLabel;
        private DataGridView userDataGridView;
        private Button addUserButton;
        private TextBox phoneTextBox;
        private Label phoneLabel;
        private TextBox userNameTextBox;
        private Label userNameLabel;
        private TextBox lastNameTextBox;
        private Label lastNameLabel;
        private TextBox firstNameTextBox;
        private Label firstNameLabel;
        private Button requestTaxiButton;
        private Button manageCarsButton;
    }
}