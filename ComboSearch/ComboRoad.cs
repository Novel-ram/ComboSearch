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
    public partial class ComboRoad: Form
    {
        public CharacterParameter CharacterParameter = new CharacterParameter();

        public List<ComboInfo> ParameterList = new List<ComboInfo>();


        public ComboRoad()
        {

            InitializeComponent();
        }

        private void ComboRoad_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// コンボルートリストボックスをダブルクリックしたとき
        /// </summary>
        public void ComboDoubleClick(bool editable)
        {
            if (editable == true)
            {
                ComboTextBox.ReadOnly = true;
                ComboTextBox.BorderStyle = BorderStyle.None;
                ComboTextBox.Enabled = false;

                DamageTextBox.ReadOnly = true;
                DamageTextBox.BorderStyle = BorderStyle.None;
                DamageTextBox.Enabled = false;

                CategoryComboTextBox.ReadOnly = true;
                CategoryComboTextBox.BorderStyle = BorderStyle.None;
                CategoryComboTextBox.Enabled = false;

                AttributeTextBox.ReadOnly = true;
                AttributeTextBox.BorderStyle = BorderStyle.None;
                AttributeTextBox.Enabled = false;

                NoteTextBox.ReadOnly = true;
                NoteTextBox.BorderStyle = BorderStyle.None;
                NoteTextBox.Enabled = false;

            }


        }

        /// <summary>
        /// 編集ボタンを押した時
        /// </summary>
        /// <param name="editable"></param>
        public void ComboEdita(bool editable)
        {
            if (editable == false)
            {
                ComboTextBox.ReadOnly = false;
                ComboTextBox.BorderStyle = BorderStyle.Fixed3D;
                ComboTextBox.Enabled = true;

                DamageTextBox.ReadOnly = false;
                DamageTextBox.BorderStyle = BorderStyle.Fixed3D;
                DamageTextBox.Enabled = true;

                CategoryComboTextBox.ReadOnly = false;
                CategoryComboTextBox.BorderStyle = BorderStyle.Fixed3D;
                CategoryComboTextBox.Enabled = true;

                AttributeTextBox.ReadOnly = false;
                AttributeTextBox.BorderStyle = BorderStyle.Fixed3D;
                AttributeTextBox.Enabled = true;

                NoteTextBox.ReadOnly = false;
                NoteTextBox.BorderStyle = BorderStyle.Fixed3D;
                NoteTextBox.Enabled = true;
            }
        }

    }
}
