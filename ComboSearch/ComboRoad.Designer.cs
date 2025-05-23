﻿namespace ComboSerch
{
    partial class ComboRoad
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ComboTextBox = new TextBox();
            DamageTextBox = new TextBox();
            CategoryComboTextBox = new TextBox();
            AttributeTextBox = new TextBox();
            NoteTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 40);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "■コンボ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 118);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "■ダメージ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 196);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "■状況";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 274);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 3;
            label4.Text = "■属性";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 341);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 4;
            label5.Text = "■メモ";
            // 
            // ComboTextBox
            // 
            ComboTextBox.BackColor = SystemColors.Window;
            ComboTextBox.BorderStyle = BorderStyle.None;
            ComboTextBox.Enabled = false;
            ComboTextBox.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            ComboTextBox.Location = new Point(29, 58);
            ComboTextBox.Name = "ComboTextBox";
            ComboTextBox.ReadOnly = true;
            ComboTextBox.Size = new Size(341, 20);
            ComboTextBox.TabIndex = 5;
            // 
            // DamageTextBox
            // 
            DamageTextBox.BackColor = SystemColors.Window;
            DamageTextBox.BorderStyle = BorderStyle.None;
            DamageTextBox.Enabled = false;
            DamageTextBox.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            DamageTextBox.Location = new Point(29, 136);
            DamageTextBox.Name = "DamageTextBox";
            DamageTextBox.ReadOnly = true;
            DamageTextBox.Size = new Size(341, 20);
            DamageTextBox.TabIndex = 6;
            // 
            // CategoryComboTextBox
            // 
            CategoryComboTextBox.BackColor = SystemColors.Window;
            CategoryComboTextBox.BorderStyle = BorderStyle.None;
            CategoryComboTextBox.Enabled = false;
            CategoryComboTextBox.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            CategoryComboTextBox.Location = new Point(29, 214);
            CategoryComboTextBox.Name = "CategoryComboTextBox";
            CategoryComboTextBox.ReadOnly = true;
            CategoryComboTextBox.Size = new Size(341, 20);
            CategoryComboTextBox.TabIndex = 7;
            // 
            // AttributeTextBox
            // 
            AttributeTextBox.BackColor = SystemColors.Window;
            AttributeTextBox.BorderStyle = BorderStyle.None;
            AttributeTextBox.Enabled = false;
            AttributeTextBox.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            AttributeTextBox.ImeMode = ImeMode.NoControl;
            AttributeTextBox.Location = new Point(29, 292);
            AttributeTextBox.Name = "AttributeTextBox";
            AttributeTextBox.ReadOnly = true;
            AttributeTextBox.Size = new Size(341, 20);
            AttributeTextBox.TabIndex = 8;
            // 
            // NoteTextBox
            // 
            NoteTextBox.BackColor = SystemColors.Window;
            NoteTextBox.BorderStyle = BorderStyle.None;
            NoteTextBox.Enabled = false;
            NoteTextBox.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            NoteTextBox.Location = new Point(29, 370);
            NoteTextBox.Multiline = true;
            NoteTextBox.Name = "NoteTextBox";
            NoteTextBox.ReadOnly = true;
            NoteTextBox.Size = new Size(341, 166);
            NoteTextBox.TabIndex = 9;
            // 
            // ComboRoad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(400, 566);
            Controls.Add(NoteTextBox);
            Controls.Add(AttributeTextBox);
            Controls.Add(CategoryComboTextBox);
            Controls.Add(DamageTextBox);
            Controls.Add(ComboTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ComboRoad";
            Text = "ComboRoad";
            FormClosing += ComboRoad_FormClosing;
            Load += ComboRoad_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox ComboTextBox;
        private TextBox DamageTextBox;
        private TextBox CategoryComboTextBox;
        private TextBox AttributeTextBox;
        private TextBox NoteTextBox;
    }
}