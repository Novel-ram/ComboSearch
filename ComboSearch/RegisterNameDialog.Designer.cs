namespace ComboSearch
{
    partial class RegisterNameDialog
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
            RegisterNameTextBox = new TextBox();
            RegisterButton = new Button();
            SuspendLayout();
            // 
            // RegisterNameTextBox
            // 
            RegisterNameTextBox.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            RegisterNameTextBox.Location = new Point(162, 144);
            RegisterNameTextBox.Name = "RegisterNameTextBox";
            RegisterNameTextBox.Size = new Size(200, 33);
            RegisterNameTextBox.TabIndex = 0;
            // 
            // RegisterButton
            // 
            RegisterButton.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            RegisterButton.Location = new Point(186, 234);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(153, 47);
            RegisterButton.TabIndex = 1;
            RegisterButton.Text = "決定";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // RegisterNameDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 321);
            Controls.Add(RegisterButton);
            Controls.Add(RegisterNameTextBox);
            Name = "RegisterNameDialog";
            Text = "キャラクター名を入力してください";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox RegisterNameTextBox;
        private Button RegisterButton;
    }
}