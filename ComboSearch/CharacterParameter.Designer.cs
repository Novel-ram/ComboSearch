namespace ComboSerch.Parameter
{
    partial class CharacterParameter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ItemRoadButton = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            menuStrip1 = new MenuStrip();
            ファイルToolStripMenuItem = new ToolStripMenuItem();
            新規作成ToolStripMenuItem = new ToolStripMenuItem();
            読み込みToolStripMenuItem = new ToolStripMenuItem();
            保存ToolStripMenuItem = new ToolStripMenuItem();
            SelectToolStripMenuItem = new ToolStripMenuItem();
            CategoryComboComboBox = new ComboBox();
            ComboRouteLIstBox = new ListBox();
            label1 = new Label();
            AttributeComboBox = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            BeginMoveComboBox = new ComboBox();
            RegisterItemButton = new Button();
            label4 = new Label();
            NoteComboBox = new ComboBox();
            label5 = new Label();
            DamageComboBox = new ComboBox();
            label6 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ItemRoadButton
            // 
            ItemRoadButton.Location = new Point(299, 508);
            ItemRoadButton.Name = "ItemRoadButton";
            ItemRoadButton.Size = new Size(225, 49);
            ItemRoadButton.TabIndex = 0;
            ItemRoadButton.Text = "読み込み";
            ItemRoadButton.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ファイルToolStripMenuItem, SelectToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(584, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            ファイルToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 新規作成ToolStripMenuItem, 読み込みToolStripMenuItem, 保存ToolStripMenuItem });
            ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            ファイルToolStripMenuItem.Size = new Size(53, 20);
            ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // 新規作成ToolStripMenuItem
            // 
            新規作成ToolStripMenuItem.Name = "新規作成ToolStripMenuItem";
            新規作成ToolStripMenuItem.Size = new Size(122, 22);
            新規作成ToolStripMenuItem.Text = "新規作成";
            // 
            // 読み込みToolStripMenuItem
            // 
            読み込みToolStripMenuItem.Name = "読み込みToolStripMenuItem";
            読み込みToolStripMenuItem.Size = new Size(122, 22);
            読み込みToolStripMenuItem.Text = "読み込み";
            // 
            // 保存ToolStripMenuItem
            // 
            保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            保存ToolStripMenuItem.Size = new Size(122, 22);
            保存ToolStripMenuItem.Text = "保存";
            // 
            // SelectToolStripMenuItem
            // 
            SelectToolStripMenuItem.Name = "SelectToolStripMenuItem";
            SelectToolStripMenuItem.Size = new Size(68, 20);
            SelectToolStripMenuItem.Text = "キャラ選択";
            // 
            // CategoryComboComboBox
            // 
            CategoryComboComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoryComboComboBox.FormattingEnabled = true;
            CategoryComboComboBox.Location = new Point(45, 167);
            CategoryComboComboBox.Name = "CategoryComboComboBox";
            CategoryComboComboBox.Size = new Size(174, 23);
            CategoryComboComboBox.TabIndex = 2;
            // 
            // ComboRouteLIstBox
            // 
            ComboRouteLIstBox.FormattingEnabled = true;
            ComboRouteLIstBox.ItemHeight = 15;
            ComboRouteLIstBox.Location = new Point(268, 90);
            ComboRouteLIstBox.Name = "ComboRouteLIstBox";
            ComboRouteLIstBox.Size = new Size(256, 334);
            ComboRouteLIstBox.TabIndex = 3;
            ComboRouteLIstBox.SelectedIndexChanged += ComboRoute_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 149);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 4;
            label1.Text = "■状況";
            // 
            // AttributeComboBox
            // 
            AttributeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            AttributeComboBox.FormattingEnabled = true;
            AttributeComboBox.Location = new Point(45, 244);
            AttributeComboBox.Name = "AttributeComboBox";
            AttributeComboBox.Size = new Size(174, 23);
            AttributeComboBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 226);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 6;
            label2.Text = "■属性";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 303);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 7;
            label3.Text = "■始動技";
            // 
            // BeginMoveComboBox
            // 
            BeginMoveComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            BeginMoveComboBox.FormattingEnabled = true;
            BeginMoveComboBox.Location = new Point(45, 321);
            BeginMoveComboBox.Name = "BeginMoveComboBox";
            BeginMoveComboBox.Size = new Size(174, 23);
            BeginMoveComboBox.TabIndex = 8;
            // 
            // RegisterItemButton
            // 
            RegisterItemButton.Location = new Point(35, 508);
            RegisterItemButton.Name = "RegisterItemButton";
            RegisterItemButton.Size = new Size(225, 49);
            RegisterItemButton.TabIndex = 9;
            RegisterItemButton.Text = "コンボの登録";
            RegisterItemButton.UseVisualStyleBackColor = true;
            RegisterItemButton.Click += RegisterItemButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(268, 72);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 10;
            label4.Text = "コンボルート";
            // 
            // NoteComboBox
            // 
            NoteComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            NoteComboBox.FormattingEnabled = true;
            NoteComboBox.Location = new Point(45, 398);
            NoteComboBox.Name = "NoteComboBox";
            NoteComboBox.Size = new Size(174, 23);
            NoteComboBox.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 383);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 12;
            label5.Text = "■メモ";
            // 
            // DamageComboBox
            // 
            DamageComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DamageComboBox.FormattingEnabled = true;
            DamageComboBox.Location = new Point(45, 90);
            DamageComboBox.Name = "DamageComboBox";
            DamageComboBox.Size = new Size(174, 23);
            DamageComboBox.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 72);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 14;
            label6.Text = "■ダメージ";
            // 
            // CharacterParameter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 611);
            Controls.Add(label6);
            Controls.Add(DamageComboBox);
            Controls.Add(label5);
            Controls.Add(NoteComboBox);
            Controls.Add(label4);
            Controls.Add(RegisterItemButton);
            Controls.Add(BeginMoveComboBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(AttributeComboBox);
            Controls.Add(label1);
            Controls.Add(ComboRouteLIstBox);
            Controls.Add(CategoryComboComboBox);
            Controls.Add(ItemRoadButton);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "CharacterParameter";
            Load += CharacterParameter_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ItemRoadButton;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ファイルToolStripMenuItem;
        private ToolStripMenuItem 新規作成ToolStripMenuItem;
        private ToolStripMenuItem 読み込みToolStripMenuItem;
        private ToolStripMenuItem 保存ToolStripMenuItem;
        private ComboBox CategoryComboComboBox;
        private ListBox ComboRouteLIstBox;
        private Label label1;
        private ComboBox AttributeComboBox;
        private Label label2;
        private Label label3;
        private ComboBox BeginMoveComboBox;
        private Button RegisterItemButton;
        private Label label4;
        private ToolStripMenuItem SelectToolStripMenuItem;
        private ComboBox NoteComboBox;
        private Label label5;
        private ComboBox DamageComboBox;
        private Label label6;
    }
}