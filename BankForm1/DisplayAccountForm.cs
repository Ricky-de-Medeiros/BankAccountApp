using BankClassLibrary3;
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
    public partial class DisplayAccountForm : Form
    {
       private DisplayAccountForm() { }

        public DisplayAccountForm(Account aAccount)
        {
            InitializeComponent();
        }

        private void DisplayAccountForm_Load(object sender, EventArgs e)
        {

        }
    }
}
