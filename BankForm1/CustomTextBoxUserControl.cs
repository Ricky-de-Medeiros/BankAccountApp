using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankForm1
{
    public partial class CustomTextBoxUserControl : UserControl
    {
        public string LabelText
        {
            get
            {
                return CustomLabel.Text;
            }
            set
            {
                CustomLabel.Text = value;
            }
        }
        public string TextInput
        {
            get
            {
                return CustomTextBox.Text;
            }
            set
            {
                CustomTextBox.Text = value;
            }
        }
        public CustomTextBoxUserControl()
        {
            InitializeComponent();
        }
    }
}
