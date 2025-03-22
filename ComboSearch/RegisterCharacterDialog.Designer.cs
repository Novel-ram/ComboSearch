namespace ComboSerch
{
    partial class RegisterCharacterDialog
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
            RegisterButton = new Button();
            ComboTextBox = new TextBox();
            CategoryComboTextBox = new TextBox();
            AttributeTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            NoteTextBox = new TextBox();
            DamegeSelectBox = new TextBox();
            CancelButton = new Button();
            SuspendLayout();
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(22, 548);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(182, 51);
            RegisterButton.TabIndex = 0;
            RegisterButton.Text = "登録";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // ComboTextBox
            // 
            ComboTextBox.Location = new Point(34, 72);
            ComboTextBox.Name = "ComboTextBox";
            ComboTextBox.Size = new Size(242, 23);
            ComboTextBox.TabIndex = 2;
            // 
            // CategoryComboTextBox
            // 
            CategoryComboTextBox.Location = new Point(34, 235);
            CategoryComboTextBox.Name = "CategoryComboTextBox";
            CategoryComboTextBox.Size = new Size(242, 23);
            CategoryComboTextBox.TabIndex = 3;
            // 
            // AttributeTextBox
            // 
            AttributeTextBox.Location = new Point(34, 315);
            AttributeTextBox.Name = "AttributeTextBox";
            AttributeTextBox.Size = new Size(242, 23);
            AttributeTextBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 130);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 7;
            label1.Text = "■ダメージ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 54);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 8;
            label2.Text = "■コンボ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 217);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 9;
            label3.Text = "■状況";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 298);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 10;
            label4.Text = "■属性";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 377);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 11;
            label5.Text = "■メモ";
            // 
            // NoteTextBox
            // 
            NoteTextBox.Location = new Point(34, 395);
            NoteTextBox.Multiline = true;
            NoteTextBox.Name = "NoteTextBox";
            NoteTextBox.Size = new Size(389, 134);
            NoteTextBox.TabIndex = 12;
            // 
            // DamegeSelectBox
            // 
            DamegeSelectBox.Location = new Point(37, 148);
            DamegeSelectBox.Name = "DamegeSelectBox";
            DamegeSelectBox.Size = new Size(242, 23);
            DamegeSelectBox.TabIndex = 13;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(255, 548);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(182, 51);
            CancelButton.TabIndex = 14;
            CancelButton.Text = "キャンセル";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // RegisterCharacterDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 611);
            Controls.Add(CancelButton);
            Controls.Add(DamegeSelectBox);
            Controls.Add(NoteTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AttributeTextBox);
            Controls.Add(CategoryComboTextBox);
            Controls.Add(ComboTextBox);
            Controls.Add(RegisterButton);
            Name = "RegisterCharacterDialog";
            Load += RegisterCharacterDialog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RegisterButton;
        private TextBox ComboTextBox;
        private TextBox CategoryComboTextBox;
        private TextBox AttributeTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox NoteTextBox;
        private TextBox DamegeSelectBox;
        private Button CancelButton;
    }
}