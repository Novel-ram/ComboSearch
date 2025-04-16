using ComboSearch;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
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
        public string FileName = "";


        public CharacterParameter()
        {
            InitializeComponent();

            UpdateComboBox();
        }

        /// <summary>
        /// コンボボックスの内容を更新する
        /// </summary>
        void UpdateComboBox()
        {
            DamageComboBox.Items.Clear();
            DamageRegisterCategory("すべて");

            CategoryComboComboBox.Items.Clear();
            CategoryRegisterCategory("すべて");

            AttributeComboBox.Items.Clear();
            AttributeReagisterCategory("すべて");

            foreach (var info in ParameterList)
            {
                DamageRegisterCategory(info.Damage);
                CategoryRegisterCategory(info.CategoryCombo);
                AttributeReagisterCategory(info.Attribute);
            }
        }

        /// <summary>
        /// コンボルートリストの内容とformのテキスト を更新する
        /// </summary>
        void UpdateListBox()
        {
            ComboRouteLIstBox.Items.Clear();
            foreach (var info in ParameterList)
            {
                
                if (info.Damage == DamageComboBox.Text ||
                    DamageComboBox.Text == "すべて")
                {
                    ComboRouteLIstBox.Items.Add(info);
                }

                if (info.CategoryCombo == CategoryComboComboBox.Text ||
                    CategoryComboComboBox.Text == "すべて")
                {
                    ComboRouteLIstBox.Items.Add(info);
                }

                if (info.Attribute == AttributeComboBox.Text ||
                    AttributeComboBox.Text == "すべて")
                {
                    ComboRouteLIstBox.Items.Add(info);
                }
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
                dialog.Text = "コンボ登録";
                dialog.Info.Name = this.Text;
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                
                    ParameterList.Add(dialog.Info);
                    UpdateComboBox();
                    DamageComboBox.Text = dialog.Info.Damage;
                    CategoryComboComboBox.Text = dialog.Info.CategoryCombo;
                    AttributeComboBox.Text = dialog.Info.Attribute;
                    UpdateListBox();

                    SaveComboList(FileName);
                
            }
        }


        /// <summary>
        /// キャラ選択ボタンを押したとき
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            if (info != null)
            {
                road.Text = Text;
                road.Controls["ComboTextBox"].Text = info.Combo;
                road.Controls["DamageTextBox"].Text = info.Damage;
                road.Controls["CategoryComboTextBox"].Text = info.CategoryCombo;
                road.Controls["AttributeTextBox"].Text = info.Attribute;
                road.Controls["NoteTextBox"].Text = info.Note;
                road.ComboDoubleClick(true);
                road.Show();
            }
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
            if (info != null)
            {
                road.Text = Text + "編集";
                road.Controls["ComboTextBox"].Text = info.Combo;
                road.Controls["DamageTextBox"].Text = info.Damage;
                road.Controls["CategoryComboTextBox"].Text = info.CategoryCombo;
                road.Controls["AttributeTextBox"].Text = info.Attribute;
                road.Controls["NoteTextBox"].Text = info.Note;
                road.ComboEdita(false);
                var result = road.ShowDialog();
                if (result == DialogResult.OK)
                {
                    info.Combo = road.Controls["ComboTextBox"].Text;
                    info.Damage = road.Controls["DamageTextBox"].Text;
                    info.CategoryCombo = road.Controls["CategoryComboTextBox"].Text;
                    info.Attribute = road.Controls["AttributeTextBox"].Text;
                    info.Note = road.Controls["NoteTextBox"].Text;
                    UpdateComboBox();
                    UpdateListBox();
                    SaveComboList(FileName);
                }
            }
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
        /// パスワードをファイルに保存する
        /// </summary>
        /// <param name="filename"></param>
        void SaveComboList(string filename)
        {
            bool ret = string.IsNullOrEmpty(filename);
            if (ret == false)
            {
                var doc = new XDocument();
                var writer = XmlWriter.Create(doc.CreateWriter());

                var serializer = new XmlSerializer(typeof(List<ComboInfo>));
                serializer.Serialize(writer, ParameterList);
                writer.Close();

                var sw = new StreamWriter(filename);
                sw.Write(doc.ToString());
                sw.Close();
            }
        }

        /// <summary>
        /// ファイルを保存するとき
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            SaveComboList(saveFileDialog.FileName);
            FileName = saveFileDialog.FileName;
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

            FileName = openFileDialog.FileName;

            UpdateComboBox();
            UpdateListBox();
        }

        /// <summary>
        /// ダメージカテゴリの選択を変更したとき
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DamageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DamageComboBox.SelectedIndex > -1)
            {
                CategoryComboComboBox.SelectedIndex = -1;
                AttributeComboBox.SelectedIndex = -1;
                UpdateListBox();
            }
        }

        /// <summary>
        /// 状況カテゴリの選択を変更したとき
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CategoryComboComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoryComboComboBox.SelectedIndex > -1)
            {
                DamageComboBox.SelectedIndex = -1;
                AttributeComboBox.SelectedIndex = -1;
                UpdateListBox();
            }
        }

        /// <summary>
        /// 属性カテゴリの選択を変更したとき
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AttributeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AttributeComboBox.SelectedIndex > -1)
            {
                DamageComboBox.SelectedIndex = -1;
                CategoryComboComboBox.SelectedIndex = -1;
                UpdateListBox();
            }
        }

        /// <summary>
        /// リストボックスの上でマウスを離した時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboRouteLIstBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point pt = ComboRouteLIstBox.PointToScreen(e.Location);
                int idx = ComboRouteLIstBox.IndexFromPoint(e.Location);
                ComboRouteLIstBox.SelectedIndex = idx;
                if (idx >= 0 && idx <= ComboRouteLIstBox.Items.Count - 1)
                {
                    RclickContextMenuStrip.Show(pt);
                }
            }
        }

        /// <summary>
        /// 右クリックメニューの「削除」を選択した時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("本当に削除しますか？", "確認", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                var info = (ComboInfo)ComboRouteLIstBox.SelectedItem;
                ParameterList.Remove(info);
                UpdateComboBox();
                UpdateListBox();

                SaveComboList(FileName);
            }
        }
    }

}
