namespace UberApp.Forms
{
    partial class CarRegistrationForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            ownerLabel = new Label();
            ownerComboBox = new ComboBox();
            brandLabel = new Label();
            brandTextBox = new TextBox();
            modelLabel = new Label();
            modelTextBox = new TextBox();
            colorLabel = new Label();
            colorTextBox = new TextBox();
            plateLabel = new Label();
            plateTextBox = new TextBox();
            yearLabel = new Label();
            yearTextBox = new TextBox();
            addCarButton = new Button();
            editCarButton = new Button();
            deleteCarButton = new Button();
            carDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)carDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ownerLabel
            // 
            ownerLabel.AutoSize = true;
            ownerLabel.ForeColor = SystemColors.Control;
            ownerLabel.Location = new Point(51, 42);
            ownerLabel.Name = "ownerLabel";
            ownerLabel.Size = new Size(62, 25);
            ownerLabel.TabIndex = 0;
            ownerLabel.Text = "Owner";
            // 
            // ownerComboBox
            // 
            ownerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ownerComboBox.FormattingEnabled = true;
            ownerComboBox.Location = new Point(201, 39);
            ownerComboBox.Name = "ownerComboBox";
            ownerComboBox.Size = new Size(286, 33);
            ownerComboBox.TabIndex = 1;
            ownerComboBox.SelectedIndexChanged += ownerComboBox_SelectedIndexChanged;
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.ForeColor = SystemColors.Control;
            brandLabel.Location = new Point(51, 99);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new Size(59, 25);
            brandLabel.TabIndex = 2;
            brandLabel.Text = "Brand";
            // 
            // brandTextBox
            // 
            brandTextBox.Location = new Point(201, 96);
            brandTextBox.Name = "brandTextBox";
            brandTextBox.Size = new Size(286, 31);
            brandTextBox.TabIndex = 3;
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.ForeColor = SystemColors.Control;
            modelLabel.Location = new Point(51, 159);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new Size(62, 25);
            modelLabel.TabIndex = 4;
            modelLabel.Text = "Model";
            // 
            // modelTextBox
            // 
            modelTextBox.Location = new Point(201, 156);
            modelTextBox.Name = "modelTextBox";
            modelTextBox.Size = new Size(286, 31);
            modelTextBox.TabIndex = 5;
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.ForeColor = SystemColors.Control;
            colorLabel.Location = new Point(51, 223);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new Size(54, 25);
            colorLabel.TabIndex = 6;
            colorLabel.Text = "Color";
            // 
            // colorTextBox
            // 
            colorTextBox.Location = new Point(201, 220);
            colorTextBox.Name = "colorTextBox";
            colorTextBox.Size = new Size(286, 31);
            colorTextBox.TabIndex = 7;
            // 
            // plateLabel
            // 
            plateLabel.AutoSize = true;
            plateLabel.ForeColor = SystemColors.Control;
            plateLabel.Location = new Point(51, 289);
            plateLabel.Name = "plateLabel";
            plateLabel.Size = new Size(124, 25);
            plateLabel.TabIndex = 8;
            plateLabel.Text = "Plate Number";
            // 
            // plateTextBox
            // 
            plateTextBox.Location = new Point(201, 286);
            plateTextBox.Name = "plateTextBox";
            plateTextBox.Size = new Size(286, 31);
            plateTextBox.TabIndex = 9;
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.ForeColor = SystemColors.Control;
            yearLabel.Location = new Point(51, 352);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(47, 25);
            yearLabel.TabIndex = 10;
            yearLabel.Text = "Year";
            // 
            // yearTextBox
            // 
            yearTextBox.Location = new Point(201, 349);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(286, 31);
            yearTextBox.TabIndex = 11;
            // 
            // addCarButton
            // 
            addCarButton.BackColor = Color.CornflowerBlue;
            addCarButton.ForeColor = SystemColors.Control;
            addCarButton.Location = new Point(51, 430);
            addCarButton.Name = "addCarButton";
            addCarButton.Size = new Size(140, 63);
            addCarButton.TabIndex = 12;
            addCarButton.Text = "Add Car";
            addCarButton.UseVisualStyleBackColor = false;
            addCarButton.Click += addCarButton_Click;
            // 
            // editCarButton
            // 
            editCarButton.BackColor = Color.Peru;
            editCarButton.ForeColor = SystemColors.Control;
            editCarButton.Location = new Point(207, 430);
            editCarButton.Name = "editCarButton";
            editCarButton.Size = new Size(140, 63);
            editCarButton.TabIndex = 13;
            editCarButton.Text = "Edit Car";
            editCarButton.UseVisualStyleBackColor = false;
            editCarButton.Click += editCarButton_Click;
            // 
            // deleteCarButton
            // 
            deleteCarButton.BackColor = Color.IndianRed;
            deleteCarButton.ForeColor = SystemColors.Control;
            deleteCarButton.Location = new Point(363, 430);
            deleteCarButton.Name = "deleteCarButton";
            deleteCarButton.Size = new Size(140, 63);
            deleteCarButton.TabIndex = 14;
            deleteCarButton.Text = "Delete Car";
            deleteCarButton.UseVisualStyleBackColor = false;
            deleteCarButton.Click += deleteCarButton_Click;
            // 
            // carDataGridView
            // 
            carDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            carDataGridView.Location = new Point(547, 42);
            carDataGridView.Name = "carDataGridView";
            carDataGridView.RowHeadersWidth = 62;
            carDataGridView.Size = new Size(572, 451);
            carDataGridView.TabIndex = 15;
            carDataGridView.CellClick += carDataGridView_CellClick;
            // 
            // CarRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1170, 560);
            Controls.Add(carDataGridView);
            Controls.Add(deleteCarButton);
            Controls.Add(editCarButton);
            Controls.Add(addCarButton);
            Controls.Add(yearTextBox);
            Controls.Add(yearLabel);
            Controls.Add(plateTextBox);
            Controls.Add(plateLabel);
            Controls.Add(colorTextBox);
            Controls.Add(colorLabel);
            Controls.Add(modelTextBox);
            Controls.Add(modelLabel);
            Controls.Add(brandTextBox);
            Controls.Add(brandLabel);
            Controls.Add(ownerComboBox);
            Controls.Add(ownerLabel);
            Name = "CarRegistrationForm";
            Text = "Car Registration";
            ((System.ComponentModel.ISupportInitialize)carDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ownerLabel;
        private ComboBox ownerComboBox;
        private Label brandLabel;
        private TextBox brandTextBox;
        private Label modelLabel;
        private TextBox modelTextBox;
        private Label colorLabel;
        private TextBox colorTextBox;
        private Label plateLabel;
        private TextBox plateTextBox;
        private Label yearLabel;
        private TextBox yearTextBox;
        private Button addCarButton;
        private Button editCarButton;
        private Button deleteCarButton;
        private DataGridView carDataGridView;
    }
}
