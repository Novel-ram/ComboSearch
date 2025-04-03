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
            components = new System.ComponentModel.Container();
            ItemEditButton = new Button();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            menuStrip1 = new MenuStrip();
            ファイルToolStripMenuItem = new ToolStripMenuItem();
            ReadToolStripMenuItem = new ToolStripMenuItem();
            SaveToolStripMenuItem = new ToolStripMenuItem();
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
            RclickContextMenuStrip = new ContextMenuStrip(components);
            DeleteToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            RclickContextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // ItemEditButton
            // 
            ItemEditButton.Location = new Point(230, 497);
            ItemEditButton.Name = "ItemEditButton";
            ItemEditButton.Size = new Size(201, 49);
            ItemEditButton.TabIndex = 0;
            ItemEditButton.Text = "編集";
            ItemEditButton.UseVisualStyleBackColor = true;
            ItemEditButton.Click += ItemEditButton_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            openFileDialog.Filter = "XMLファイル|*.xml|すべてのファイル|*.*";
            openFileDialog.FileOk += OpenFileDialog_FileOk;
            // 
            // saveFileDialog
            // 
            saveFileDialog.FileName = "saveFileDialog";
            saveFileDialog.Filter = "XMLファイル|*.xml|すべてのファイル|*.*";
            saveFileDialog.FileOk += SaveFileDialog_FileOk;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ファイルToolStripMenuItem, SelectToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(461, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            ファイルToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ReadToolStripMenuItem, SaveToolStripMenuItem });
            ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            ファイルToolStripMenuItem.Size = new Size(53, 20);
            ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // ReadToolStripMenuItem
            // 
            ReadToolStripMenuItem.Name = "ReadToolStripMenuItem";
            ReadToolStripMenuItem.Size = new Size(120, 22);
            ReadToolStripMenuItem.Text = "読み込み";
            ReadToolStripMenuItem.Click += ReadToolStripMenuItem_Click;
            // 
            // SaveToolStripMenuItem
            // 
            SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            SaveToolStripMenuItem.Size = new Size(120, 22);
            SaveToolStripMenuItem.Text = "保存";
            SaveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            // 
            // SelectToolStripMenuItem
            // 
            SelectToolStripMenuItem.Name = "SelectToolStripMenuItem";
            SelectToolStripMenuItem.Size = new Size(68, 20);
            SelectToolStripMenuItem.Text = "キャラ選択";
            SelectToolStripMenuItem.Click += SelectToolStripMenuItem_Click;
            // 
            // CategoryComboComboBox
            // 
            CategoryComboComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoryComboComboBox.FormattingEnabled = true;
            CategoryComboComboBox.Location = new Point(22, 167);
            CategoryComboComboBox.Name = "CategoryComboComboBox";
            CategoryComboComboBox.Size = new Size(188, 23);
            CategoryComboComboBox.TabIndex = 2;
            CategoryComboComboBox.SelectedIndexChanged += CategoryComboComboBox_SelectedIndexChanged;
            // 
            // ComboRouteLIstBox
            // 
            ComboRouteLIstBox.FormattingEnabled = true;
            ComboRouteLIstBox.ItemHeight = 15;
            ComboRouteLIstBox.Location = new Point(230, 90);
            ComboRouteLIstBox.Name = "ComboRouteLIstBox";
            ComboRouteLIstBox.Size = new Size(201, 349);
            ComboRouteLIstBox.TabIndex = 3;
            ComboRouteLIstBox.DoubleClick += ComboRouteLIstBox_DoubleClick;
            ComboRouteLIstBox.MouseUp += ComboRouteLIstBox_MouseUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 149);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 4;
            label1.Text = "■状況";
            // 
            // AttributeComboBox
            // 
            AttributeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            AttributeComboBox.FormattingEnabled = true;
            AttributeComboBox.Location = new Point(22, 244);
            AttributeComboBox.Name = "AttributeComboBox";
            AttributeComboBox.Size = new Size(188, 23);
            AttributeComboBox.TabIndex = 5;
            AttributeComboBox.SelectedIndexChanged += AttributeComboBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 226);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 6;
            label2.Text = "■属性";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 303);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 7;
            label3.Text = "■始動技";
            // 
            // BeginMoveComboBox
            // 
            BeginMoveComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            BeginMoveComboBox.FormattingEnabled = true;
            BeginMoveComboBox.Location = new Point(22, 321);
            BeginMoveComboBox.Name = "BeginMoveComboBox";
            BeginMoveComboBox.Size = new Size(188, 23);
            BeginMoveComboBox.TabIndex = 8;
            // 
            // RegisterItemButton
            // 
            RegisterItemButton.Location = new Point(22, 497);
            RegisterItemButton.Name = "RegisterItemButton";
            RegisterItemButton.Size = new Size(188, 49);
            RegisterItemButton.TabIndex = 9;
            RegisterItemButton.Text = "コンボの登録";
            RegisterItemButton.UseVisualStyleBackColor = true;
            RegisterItemButton.Click += RegisterItemButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(230, 72);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 10;
            label4.Text = "コンボルート";
            // 
            // NoteComboBox
            // 
            NoteComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            NoteComboBox.FormattingEnabled = true;
            NoteComboBox.Location = new Point(22, 401);
            NoteComboBox.Name = "NoteComboBox";
            NoteComboBox.Size = new Size(188, 23);
            NoteComboBox.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 383);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 12;
            label5.Text = "■メモ";
            // 
            // DamageComboBox
            // 
            DamageComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DamageComboBox.FormattingEnabled = true;
            DamageComboBox.Location = new Point(22, 90);
            DamageComboBox.Name = "DamageComboBox";
            DamageComboBox.Size = new Size(188, 23);
            DamageComboBox.TabIndex = 13;
            DamageComboBox.SelectedIndexChanged += DamageComboBox_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 72);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 14;
            label6.Text = "■ダメージ";
            // 
            // RclickContextMenuStrip
            // 
            RclickContextMenuStrip.Items.AddRange(new ToolStripItem[] { DeleteToolStripMenuItem });
            RclickContextMenuStrip.Name = "contextMenuStrip1";
            RclickContextMenuStrip.Size = new Size(99, 26);
            // 
            // DeleteToolStripMenuItem
            // 
            DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            DeleteToolStripMenuItem.Size = new Size(98, 22);
            DeleteToolStripMenuItem.Text = "削除";
            DeleteToolStripMenuItem.Click += DeleteToolStripMenuItem_Click;
            // 
            // CharacterParameter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 569);
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
            Controls.Add(ItemEditButton);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "CharacterParameter";
            Load += CharacterParameter_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            RclickContextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ItemEditButton;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ファイルToolStripMenuItem;
        private ToolStripMenuItem ReadToolStripMenuItem;
        private ToolStripMenuItem SaveToolStripMenuItem;
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
        private ContextMenuStrip RclickContextMenuStrip;
        private ToolStripMenuItem DeleteToolStripMenuItem;
    }
}