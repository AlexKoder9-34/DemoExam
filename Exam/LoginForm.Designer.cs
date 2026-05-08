namespace Exam
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            EmailTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            GoToRegisterLinkLabel = new LinkLabel();
            ExitButton = new Button();
            LoginButton = new Button();
            GuestButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 16F);
            label1.Location = new Point(162, 9);
            label1.Name = "label1";
            label1.Size = new Size(164, 33);
            label1.TabIndex = 0;
            label1.Text = "Авторизация";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(85, 53);
            label2.Name = "label2";
            label2.Size = new Size(67, 24);
            label2.TabIndex = 1;
            label2.Text = "Логин:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(85, 134);
            label3.Name = "label3";
            label3.Size = new Size(78, 24);
            label3.TabIndex = 2;
            label3.Text = "Пароль:";
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(87, 88);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(296, 27);
            EmailTextBox.TabIndex = 3;
            EmailTextBox.Text = "Email";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(90, 170);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(293, 27);
            PasswordTextBox.TabIndex = 4;
            PasswordTextBox.Text = "Пароль";
            PasswordTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // GoToRegisterLinkLabel
            // 
            GoToRegisterLinkLabel.AutoSize = true;
            GoToRegisterLinkLabel.Location = new Point(118, 211);
            GoToRegisterLinkLabel.Name = "GoToRegisterLinkLabel";
            GoToRegisterLinkLabel.Size = new Size(231, 20);
            GoToRegisterLinkLabel.TabIndex = 5;
            GoToRegisterLinkLabel.TabStop = true;
            GoToRegisterLinkLabel.Text = "Нет аккаунта? Зарегестрируйся!";
            GoToRegisterLinkLabel.LinkClicked += GoToRegisterLinkLabel_LinkClicked;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(20, 398);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(119, 34);
            ExitButton.TabIndex = 6;
            ExitButton.Text = "Выход";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(94, 255);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(103, 36);
            LoginButton.TabIndex = 7;
            LoginButton.Text = "Войти";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // GuestButton
            // 
            GuestButton.Location = new Point(224, 254);
            GuestButton.Name = "GuestButton";
            GuestButton.Size = new Size(155, 37);
            GuestButton.TabIndex = 8;
            GuestButton.Text = "Войти как гость";
            GuestButton.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 450);
            Controls.Add(GuestButton);
            Controls.Add(LoginButton);
            Controls.Add(ExitButton);
            Controls.Add(GoToRegisterLinkLabel);
            Controls.Add(PasswordTextBox);
            Controls.Add(EmailTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox EmailTextBox;
        private TextBox PasswordTextBox;
        private LinkLabel GoToRegisterLinkLabel;
        private Button ExitButton;
        private Button LoginButton;
        private Button GuestButton;
    }
}
