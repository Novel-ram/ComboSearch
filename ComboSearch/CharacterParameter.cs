using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboSearch.CharacterList
{

    public partial class CharacterParameter : Form
    {
        public CharacterParameter()
        {
            InitializeComponent();
        }

        private void SelectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void RegisterItemButton_Click(object sender, EventArgs e)
        {
            var dialog = new RegisterCharacterDialog();
            dialog.Show();
        }
    }
}
