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
            ItemEditButton.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            ItemEditButton.Location = new Point(462, 810);
            ItemEditButton.Name = "ItemEditButton";
            ItemEditButton.Size = new Size(276, 62);
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
            menuStrip1.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ファイルToolStripMenuItem, SelectToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(814, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            ファイルToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ReadToolStripMenuItem, SaveToolStripMenuItem });
            ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            ファイルToolStripMenuItem.Size = new Size(78, 29);
            ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // ReadToolStripMenuItem
            // 
            ReadToolStripMenuItem.Name = "ReadToolStripMenuItem";
            ReadToolStripMenuItem.Size = new Size(156, 30);
            ReadToolStripMenuItem.Text = "読み込み";
            ReadToolStripMenuItem.Click += ReadToolStripMenuItem_Click;
            // 
            // SaveToolStripMenuItem
            // 
            SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            SaveToolStripMenuItem.Size = new Size(156, 30);
            SaveToolStripMenuItem.Text = "保存";
            SaveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            // 
            // SelectToolStripMenuItem
            // 
            SelectToolStripMenuItem.Name = "SelectToolStripMenuItem";
            SelectToolStripMenuItem.Size = new Size(102, 29);
            SelectToolStripMenuItem.Text = "キャラ選択";
            // 
            // CategoryComboComboBox
            // 
            CategoryComboComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoryComboComboBox.Font = new Font("Yu Gothic UI", 14.25F);
            CategoryComboComboBox.FormattingEnabled = true;
            CategoryComboComboBox.Location = new Point(12, 203);
            CategoryComboComboBox.Name = "CategoryComboComboBox";
            CategoryComboComboBox.Size = new Size(327, 33);
            CategoryComboComboBox.TabIndex = 2;
            CategoryComboComboBox.SelectedIndexChanged += CategoryComboComboBox_SelectedIndexChanged;
            // 
            // ComboRouteLIstBox
            // 
            ComboRouteLIstBox.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            ComboRouteLIstBox.FormattingEnabled = true;
            ComboRouteLIstBox.ItemHeight = 25;
            ComboRouteLIstBox.Location = new Point(370, 90);
            ComboRouteLIstBox.Name = "ComboRouteLIstBox";
            ComboRouteLIstBox.ScrollAlwaysVisible = true;
            ComboRouteLIstBox.Size = new Size(432, 704);
            ComboRouteLIstBox.TabIndex = 3;
            ComboRouteLIstBox.DoubleClick += ComboRouteLIstBox_DoubleClick;
            ComboRouteLIstBox.MouseUp += ComboRouteLIstBox_MouseUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 14.25F);
            label1.Location = new Point(12, 175);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 4;
            label1.Text = "■状況";
            // 
            // AttributeComboBox
            // 
            AttributeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            AttributeComboBox.Font = new Font("Yu Gothic UI", 14.25F);
            AttributeComboBox.FormattingEnabled = true;
            AttributeComboBox.Location = new Point(12, 316);
            AttributeComboBox.Name = "AttributeComboBox";
            AttributeComboBox.Size = new Size(327, 33);
            AttributeComboBox.TabIndex = 5;
            AttributeComboBox.SelectedIndexChanged += AttributeComboBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 14.25F);
            label2.Location = new Point(12, 288);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 6;
            label2.Text = "■属性";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 14.25F);
            label3.Location = new Point(12, 401);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 7;
            label3.Text = "■始動技";
            // 
            // BeginMoveComboBox
            // 
            BeginMoveComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            BeginMoveComboBox.Font = new Font("Yu Gothic UI", 14.25F);
            BeginMoveComboBox.FormattingEnabled = true;
            BeginMoveComboBox.Location = new Point(12, 429);
            BeginMoveComboBox.Name = "BeginMoveComboBox";
            BeginMoveComboBox.Size = new Size(327, 33);
            BeginMoveComboBox.TabIndex = 8;
            // 
            // RegisterItemButton
            // 
            RegisterItemButton.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            RegisterItemButton.Location = new Point(92, 810);
            RegisterItemButton.Name = "RegisterItemButton";
            RegisterItemButton.Size = new Size(276, 62);
            RegisterItemButton.TabIndex = 9;
            RegisterItemButton.Text = "コンボの登録";
            RegisterItemButton.UseVisualStyleBackColor = true;
            RegisterItemButton.Click += RegisterItemButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label4.Location = new Point(370, 62);
            label4.Name = "label4";
            label4.Size = new Size(96, 25);
            label4.TabIndex = 10;
            label4.Text = "コンボルート";
            // 
            // NoteComboBox
            // 
            NoteComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            NoteComboBox.Font = new Font("Yu Gothic UI", 14.25F);
            NoteComboBox.FormattingEnabled = true;
            NoteComboBox.Location = new Point(12, 544);
            NoteComboBox.Name = "NoteComboBox";
            NoteComboBox.Size = new Size(327, 33);
            NoteComboBox.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 14.25F);
            label5.Location = new Point(12, 516);
            label5.Name = "label5";
            label5.Size = new Size(58, 25);
            label5.TabIndex = 12;
            label5.Text = "■メモ";
            // 
            // DamageComboBox
            // 
            DamageComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DamageComboBox.Font = new Font("Yu Gothic UI", 14.25F);
            DamageComboBox.FormattingEnabled = true;
            DamageComboBox.Location = new Point(12, 90);
            DamageComboBox.Name = "DamageComboBox";
            DamageComboBox.Size = new Size(327, 33);
            DamageComboBox.TabIndex = 13;
            DamageComboBox.SelectedIndexChanged += DamageComboBox_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label6.Location = new Point(12, 62);
            label6.Name = "label6";
            label6.Size = new Size(84, 25);
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
            ClientSize = new Size(814, 889);
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