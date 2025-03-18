using ComboSearch.CharacterList;
using System.Reflection.Metadata;

namespace ComboSearch
{
    public partial class CharacterSelect : Form
    {
        public CharacterSelect()
        {
            InitializeComponent();
        }

        /// <summary>
        /// どれかのキャラクターボタンを押したとき
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Luke_Click(object sender, EventArgs e)
        {
            var Parameter = new CharacterParameter();
            Parameter.Show();
            Parameter.Text = "ルーク";
        }

        private void Jamie_Click(object sender, EventArgs e )
        {
            var Parameter = new CharacterParameter();
            Parameter.Show();
            Parameter.Text = "ジェイミー";
        }

        private void ManonButton_Click(object sender, EventArgs e)
        {
            var Parameter = new CharacterParameter();
            Parameter.Show();
            Parameter.Text = "マノン";
        }

        private void Kimberlybutton_Click(object sender, EventArgs e)
        {
            var Parameter = new CharacterParameter();
            Parameter.Show();
            Parameter.Text = "キンバリー";
        }

        private void MarisaButton_Click(object sender, EventArgs e)
        {
            var Parameter = new CharacterParameter();
            Parameter.Show();
            Parameter.Text = "マリーザ";
        }

        private void LilyButton_Click(object sender, EventArgs e)
        {
            var Parameter = new CharacterParameter();
            Parameter.Show();
            Parameter.Text = "リリー";
        }

        private void JPbutton_Click(object sender, EventArgs e)
        {
            var Parameter = new CharacterParameter();
            Parameter.Show();
            Parameter.Text = "JP";
        }

        private void Juributton_Click(object sender, EventArgs e)
        {
            var Parameter = new CharacterParameter();
            Parameter.Show();
            Parameter.Text = "ジュリ";
        }

        private void Deejaybutton_Click(object sender, EventArgs e)
        {
            var Parameter = new CharacterParameter();
            Parameter.Show();
            Parameter.Text = "ディージェイ";
        }

        private void CammyButton_Click(object sender, EventArgs e)
        {
            var Parameter = new CharacterParameter();
            Parameter.Show();
            Parameter.Text = "キンバリー";
        }

        private void RyuButton_Click(object sender, EventArgs e)
        {
            var Parameter = new CharacterParameter();
            Parameter.Show();
            Parameter.Text = "リュウ";
        }

        private void KenButton_Click(object sender, EventArgs e)
        {
            var Parameter = new CharacterParameter();
            Parameter.Show();
            Parameter.Text = "ケン";
        }

        private void E_hondaButton_Click(object sender, EventArgs e)
        {
            var Parameter = new CharacterParameter();
            Parameter.Show();
            Parameter.Text = "E.本田";
        }

        private void BlankaButton_Click(object sender, EventArgs e)
        {
            var Parameter = new CharacterParameter();
            Parameter.Show();
            Parameter.Text = "ブランカ";
        }

        private void GuileButton_Click(object sender, EventArgs e)
        {
            var Parameter = new CharacterParameter();
            Parameter.Show();
            Parameter.Text = "ガイル";
        }

        private void Chun_liButton_Click(object sender, EventArgs e)
        {
            var Parameter = new CharacterParameter();
            Parameter.Show();
            Parameter.Text = "春麗";
        }

        private void ZangiefButton_Click(object sender, EventArgs e)
        {
            var Parameter = new CharacterParameter();
            Parameter.Show();
            Parameter.Text = "ザンギエフ";
        }

        private void DhalsimButton_Click(object sender, EventArgs e)
        {
            var Parameter = new CharacterParameter();
            Parameter.Show();
            Parameter.Text = "ダルシム";
        }

        private void RashidButton_Click(object sender, EventArgs e)
        {
            var Parameter = new CharacterParameter();
            Parameter.Show();
            Parameter.Text = "ラシード";
        }

        private void AKIButton_Click(object sender, EventArgs e)
        {
            var Parameter = new CharacterParameter();
            Parameter.Show();
            Parameter.Text = "A.K.I";
        }

        private void EDButton_Click(object sender, EventArgs e)
        {
            var Parameter = new CharacterParameter();
            Parameter.Show();
            Parameter.Text = "エド";
        }

        private void GoukiButton_Click(object sender, EventArgs e)
        {
            var Parameter = new CharacterParameter();
            Parameter.Show();
            Parameter.Text = "豪鬼";
        }

        private void BegaButton_Click(object sender, EventArgs e)
        {
            var Parameter = new CharacterParameter();
            Parameter.Show();
            Parameter.Text = "ベガ";
        }

        private void TerryButton_Click(object sender, EventArgs e)
        {
            var Parameter = new CharacterParameter();
            Parameter.Show();
            Parameter.Text = "テリー";
        }

        private void MaiButton_Click(object sender, EventArgs e)
        {
            var Parameter = new CharacterParameter();
            Parameter.Show();
            Parameter.Text = "不知火舞";
        }
    }
}
