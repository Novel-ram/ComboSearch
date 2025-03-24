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
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

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
        /// コンボルートの内容を更新する
        /// </summary>
        void UpdateListBox()
        {
            ComboRouteLIstBox.Items.Clear();
            foreach (var info in ParameterList)
            {
                ComboRouteLIstBox.Items.Add(info);
                Text = info.Name;
            }
        }

        /// <summary>
        /// ダメージカテゴリを登録する
        /// </summary>
        /// <param name="name"></param>
        void DamageRegisterCategory(string name)
        {
            foreach (string categoryName in DamageComboBox.Items)
            {
                if (categoryName == name)
                {
                    return;
                }
            }

            DamageComboBox.Items.Add(name);

        }

        /// <summary>
        /// 状況カテゴリを登録する
        /// </summary>
        /// <param name="name"></param>
        void CategoryRegisterCategory(string name)
        {
            foreach (string categoryName in CategoryComboComboBox.Items)
            {
                if (categoryName == name)
                {
                    return;
                }
            }
            CategoryComboComboBox.Items.Add(name);
        }

        /// <summary>
        /// 属性カテゴリを登録する
        /// </summary>
        /// <param name="name"></param>
        void AttributeReagisterCategory(string name)
        {

            foreach (string categoryName in AttributeComboBox.Items)
            {
                if (categoryName == name)
                {
                    return;
                }
            }
            AttributeComboBox.Items.Add(name);
        }

        /// <summary>
        /// コンボ登録ボタンを押したとき
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterItemButton_Click(object sender, EventArgs e)
        {

            var dialog = new RegisterCharacterDialog();
            dialog.Text = Text + "の登録";
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                ParameterList.Add(dialog.Info);
                DamageRegisterCategory(dialog.Info.Damage);
                CategoryRegisterCategory(dialog.Info.CategoryCombo);
                AttributeReagisterCategory(dialog.Info.Attribute);
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

        /// <summary>
        /// コンボルートリストボックスをダブルクリックしたとき
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboRouteLIstBox_DoubleClick(object sender, EventArgs e)
        {
            var road = new ComboRoad();
            ComboInfo info = (ComboInfo)ComboRouteLIstBox.SelectedItem;
            road.Text = Text;
            road.Controls["ComboTextBox"].Text = info.Combo;
            road.Controls["DamageTextBox"].Text = info.Damage;
            road.Controls["CategoryComboTextBox"].Text = info.CategoryCombo;
            road.Controls["AttributeTextBox"].Text = info.Attribute;
            road.Controls["NoteTextBox"].Text = info.Note;
            road.ComboDoubleClick(true);
            road.Show();
        }
        /// <summary>
        /// 編集ボタンを押したとき
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemEditButton_Click(object sender, EventArgs e)
        {
            ComboRoad road = new ComboRoad();
            ComboInfo info = (ComboInfo)ComboRouteLIstBox.SelectedItem;
            road.Text = Text;
            road.Controls["ComboTextBox"].Text = info.Combo;
            road.Controls["DamageTextBox"].Text = info.Damage;
            road.Controls["CategoryComboTextBox"].Text = info.CategoryCombo;
            road.Controls["AttributeTextBox"].Text = info.Attribute;
            road.Controls["NoteTextBox"].Text = info.Note;
            road.ComboEdita(false);
            road.ShowDialog();
        }

        /// <summary>
        /// メニューの保存を選択したとき
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }

        /// <summary>
        /// メニューの読み込みを選択したとき
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        /// <summary>
        /// ファイルを保存するとき
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            var doc = new XDocument();
            var writer = XmlWriter.Create(doc.CreateWriter());

            var serializer = new XmlSerializer(typeof(List<ComboInfo>));
            serializer.Serialize(writer, ParameterList);
            writer.Close();

            var sw = new StreamWriter(saveFileDialog.FileName);
            sw.Write(doc.ToString());
            sw.Close();
        }

        /// <summary>
        /// ファイルを開くとき
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            var serializer = new XmlSerializer(typeof(List<ComboInfo>));
            var sr = new StreamReader(openFileDialog.FileName);
            ParameterList = (List<ComboInfo>)serializer.Deserialize(sr);
            sr.Close();

            UpdateListBox();
        }
    }

}
