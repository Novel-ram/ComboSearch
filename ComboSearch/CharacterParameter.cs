using ComboSearch;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboSerch.Parameter
{

    public partial class CharacterParameter : Form
    {
        public List<ComboInfo> ParameterList = new List<ComboInfo>();

        public CharacterParameter()
        {
            InitializeComponent();
        }

        /// <summary>
        /// リストボックスの内容を更新する
        /// </summary>
        void UpdateListBox()
        {
            ComboRoute.Items.Clear();
            foreach (var info in ParameterList)
            {
                ComboRoute.Items.Add(info);
            }
        }
         /// <summary>
         /// カテゴリを登録する
         /// </summary>
         /// <param name="name"></param>
        void RegisterCharacter(string name)
        {

        }

        /// <summary>
        /// コンボ登録ボタンを押したとき
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterItemButton_Click(object sender, EventArgs e)
        {

            var dialog = new RegisterCharacterDialog();
            dialog.Text = Text;
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                ParameterList.Add(dialog.Info);
                RegisterCharacter(dialog.Info.Character);
            }
            UpdateListBox();

        }

        private void SelectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CharacterParameter_Load(object sender, EventArgs e)
        {

        }
    }

}
