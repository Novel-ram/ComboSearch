using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboSearch
{
    public partial class RegisterNameDialog : Form
    {
        public ComboInfo Info = new ComboInfo();
        public RegisterNameDialog()
        {
            InitializeComponent();
            
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Info.Name = RegisterNameTextBox.Text;
            Close();

        }
    }
}
