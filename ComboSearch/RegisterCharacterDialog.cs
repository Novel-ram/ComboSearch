using ComboSearch;
using ComboSerch.Parameter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboSerch
{
    public partial class RegisterCharacterDialog : Form
    {
        public ComboInfo Info { get; set; }

        public RegisterCharacterDialog()
        {
            InitializeComponent();

            Info = new ComboInfo();

        }


        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Info.Damage = DamegeSelectBox.Text;
            Info.Combo = ComboTextBox.Text;
            Info.CategoryCombo = CategoryComboTextBox.Text;
            Info.Attribute = AttributeTextBox.Text;
            Info.Note = NoteTextBox.Text;


            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void RegisterCharacterDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
