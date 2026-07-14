using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UberApp.Forms
{
    public partial class RequestTaxiForm : Form
    {
        public RequestTaxiForm()
        {
            
        }
        public RequestTaxiForm(long id, string fullName) : base()
        {
            InitializeComponent();
            idTextBox.Text = id.ToString();
            fullNameTextBox.Text = fullName;
        }
    }
}
