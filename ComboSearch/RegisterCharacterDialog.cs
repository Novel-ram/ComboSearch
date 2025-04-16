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

        /// <summary>
        /// キャラ名を登録する
        /// </summary>
        void RegisterName()
        {
            if (Info.Name == string.Empty)
            {
                var dialog = new RegisterNameDialog();
                var rssult = dialog.ShowDialog();
                if (rssult == DialogResult.OK)
                {
                    Info.Name = dialog.Info.Name;
                    DialogResult = DialogResult.OK;

                    Close();
                }
                else
                {
                    return;
                }
            }
        }

        /// <summary>
        /// 登録する
        /// </summary>
        void RegisterCategory()
        {            
            Info.Damage = DamegeSelectBox.Text;
            Info.Combo = ComboTextBox.Text;
            Info.CategoryCombo = CategoryComboTextBox.Text;
            Info.Attribute = AttributeTextBox.Text;
            Info.Note = NoteTextBox.Text;
        }


        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (Info.Name != string.Empty)
            {
                RegisterCategory();
                DialogResult = DialogResult.OK;

                Close();
            }
            else 
            { 
                RegisterCategory();
                RegisterName();                         
            }
              
            
            
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
