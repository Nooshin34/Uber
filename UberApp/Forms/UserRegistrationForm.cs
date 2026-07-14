using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UberApp.Domain;

namespace UberApp.Forms
{
    public partial class UserRegistrationForm : Form
    {
        List<User> users = new List<User>();
        User targetUser = null;
        public UserRegistrationForm()
        {
            InitializeComponent();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                User user = User.Create(
                    new Random().Next(1, 1000),
                    userNameTextBox.Text,
                    passTextBox.Text,
                    firstNameTextBox.Text,
                    lastNameTextBox.Text,
                    phoneTextBox.Text,
                    1,//Convert.ToInt32(roleComboBox.SelectedValue),
                    isActiveRadioButton.Checked);

                users.Add(user);
                refreshForm();
                resetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //no one should access to this method so we get it private access modifier
        private void resetForm()
        {
            userNameTextBox.Text = string.Empty;
            passTextBox.Text = string.Empty;
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            phoneTextBox.Text = string.Empty;
            isActiveRadioButton.Checked = false;

        }

        private void refreshForm()
        {
            userDataGridView.DataSource = null;
            userDataGridView.DataSource = users;
            userDataGridView.Refresh();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(targetUser.FirstName))
            {
                MessageBox.Show("لطفا ابتدا یک کاربر را انتخاب نمایید");
                return;
            }
            targetUser.UpdateFirstName(firstNameTextBox.Text);
            targetUser.UpdateLastName(lastNameTextBox.Text);
            refreshForm();
        }

        private void userDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //string userName = userDataGridView.Rows[e.RowIndex].Cells["UserName"].Value.ToString();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = userDataGridView.Rows[e.RowIndex];
                var id = int.Parse(row.Cells["Id"].Value.ToString() ?? "0");
                for (int i = 0; i < users.Count; i++)
                {
                    if (users[i].Id == id)
                    {
                        targetUser = users[i];
                        firstNameTextBox.Text = users[i].FirstName;
                        lastNameTextBox.Text = users[i].LastName;
                        break;
                    }
                }
            }
        }

        private void requestTaxiButton_Click(object sender, EventArgs e)
        {
            if (targetUser is null)
            {
                MessageBox.Show("Please select a user...");
                return;
            }    
            RequestTaxiForm requestTaxiForm = new RequestTaxiForm(targetUser.Id, targetUser.FullName);
            requestTaxiForm.ShowDialog();
        }
    }
}
