namespace Exam
{
    partial class RegisterForm
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
            NameTextBox = new TextBox();
            LastnameTextBox = new TextBox();
            SurnameTextBox = new TextBox();
            RolesListBox = new ListBox();
            LoginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            RegisterButton = new Button();
            GoToLoginLinkLabel = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(177, 9);
            label1.Name = "label1";
            label1.Size = new Size(162, 35);
            label1.TabIndex = 0;
            label1.Text = "Регистрация";
            // 
            // NameTextBox
            // 
            NameTextBox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NameTextBox.Location = new Point(106, 74);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(310, 32);
            NameTextBox.TabIndex = 1;
            NameTextBox.Text = "Имя";
            // 
            // LastnameTextBox
            // 
            LastnameTextBox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LastnameTextBox.Location = new Point(106, 131);
            LastnameTextBox.Name = "LastnameTextBox";
            LastnameTextBox.Size = new Size(309, 32);
            LastnameTextBox.TabIndex = 2;
            LastnameTextBox.Text = "Фамилия";
            // 
            // SurnameTextBox
            // 
            SurnameTextBox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SurnameTextBox.Location = new Point(106, 192);
            SurnameTextBox.Name = "SurnameTextBox";
            SurnameTextBox.Size = new Size(309, 32);
            SurnameTextBox.TabIndex = 3;
            SurnameTextBox.Text = "Отчество";
            // 
            // RolesListBox
            // 
            RolesListBox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RolesListBox.FormattingEnabled = true;
            RolesListBox.Items.AddRange(new object[] { "Роль", "Администратор", "Менеджер", "Авторизированный клиент" });
            RolesListBox.Location = new Point(107, 262);
            RolesListBox.Name = "RolesListBox";
            RolesListBox.Size = new Size(307, 28);
            RolesListBox.TabIndex = 4;
            // 
            // LoginTextBox
            // 
            LoginTextBox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginTextBox.Location = new Point(107, 318);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(309, 32);
            LoginTextBox.TabIndex = 5;
            LoginTextBox.Text = "Email";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PasswordTextBox.Location = new Point(107, 380);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(309, 32);
            PasswordTextBox.TabIndex = 6;
            PasswordTextBox.Text = "Пароль";
            PasswordTextBox.TextChanged += PasswordTextBox_TextChanged;
            // 
            // RegisterButton
            // 
            RegisterButton.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RegisterButton.Location = new Point(154, 428);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(204, 36);
            RegisterButton.TabIndex = 7;
            RegisterButton.Text = "Зарегистрироваться";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // GoToLoginLinkLabel
            // 
            GoToLoginLinkLabel.AutoSize = true;
            GoToLoginLinkLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            GoToLoginLinkLabel.Location = new Point(146, 476);
            GoToLoginLinkLabel.Name = "GoToLoginLinkLabel";
            GoToLoginLinkLabel.Size = new Size(219, 24);
            GoToLoginLinkLabel.TabIndex = 8;
            GoToLoginLinkLabel.TabStop = true;
            GoToLoginLinkLabel.Text = "У меня уже есть аккаунт";
            GoToLoginLinkLabel.LinkClicked += GoToLoginLinkLabel_LinkClicked;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 555);
            Controls.Add(GoToLoginLinkLabel);
            Controls.Add(RegisterButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginTextBox);
            Controls.Add(RolesListBox);
            Controls.Add(SurnameTextBox);
            Controls.Add(LastnameTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(label1);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NameTextBox;
        private TextBox LastnameTextBox;
        private TextBox SurnameTextBox;
        private ListBox RolesListBox;
        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private Button RegisterButton;
        private LinkLabel GoToLoginLinkLabel;
    }
}