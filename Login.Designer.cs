namespace Quizzgame
{
    partial class Login
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
            bt_login = new Button();
            lb_username = new Label();
            lb_password = new Label();
            lb_role = new Label();
            tb_username = new TextBox();
            tb_password = new TextBox();
            cb_role = new ComboBox();
            SuspendLayout();
            // 
            // bt_login
            // 
            bt_login.Location = new Point(372, 629);
            bt_login.Margin = new Padding(7, 8, 7, 8);
            bt_login.Name = "bt_login";
            bt_login.Size = new Size(182, 63);
            bt_login.TabIndex = 0;
            bt_login.Text = "Login";
            bt_login.UseVisualStyleBackColor = true;
            bt_login.Click += bt_login_Click;
            // 
            // lb_username
            // 
            lb_username.AutoSize = true;
            lb_username.Location = new Point(66, 221);
            lb_username.Margin = new Padding(7, 0, 7, 0);
            lb_username.Name = "lb_username";
            lb_username.Size = new Size(152, 41);
            lb_username.TabIndex = 1;
            lb_username.Text = "Username";
            // 
            // lb_password
            // 
            lb_password.AutoSize = true;
            lb_password.Location = new Point(66, 358);
            lb_password.Margin = new Padding(7, 0, 7, 0);
            lb_password.Name = "lb_password";
            lb_password.Size = new Size(143, 41);
            lb_password.TabIndex = 2;
            lb_password.Text = "Password";
            // 
            // lb_role
            // 
            lb_role.AutoSize = true;
            lb_role.Location = new Point(100, 497);
            lb_role.Margin = new Padding(7, 0, 7, 0);
            lb_role.Name = "lb_role";
            lb_role.Size = new Size(76, 41);
            lb_role.TabIndex = 3;
            lb_role.Text = "Role";
            // 
            // tb_username
            // 
            tb_username.Location = new Point(311, 213);
            tb_username.Margin = new Padding(7, 8, 7, 8);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(237, 47);
            tb_username.TabIndex = 4;
            // 
            // tb_password
            // 
            tb_password.Location = new Point(311, 350);
            tb_password.Margin = new Padding(7, 8, 7, 8);
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(237, 47);
            tb_password.TabIndex = 5;
            // 
            // cb_role
            // 
            cb_role.FormattingEnabled = true;
            cb_role.Items.AddRange(new object[] { "Creator", "Player" });
            cb_role.Location = new Point(311, 489);
            cb_role.Margin = new Padding(7, 8, 7, 8);
            cb_role.Name = "cb_role";
            cb_role.Size = new Size(237, 49);
            cb_role.TabIndex = 6;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1071, 1058);
            Controls.Add(cb_role);
            Controls.Add(tb_password);
            Controls.Add(tb_username);
            Controls.Add(lb_role);
            Controls.Add(lb_password);
            Controls.Add(lb_username);
            Controls.Add(bt_login);
            Margin = new Padding(7, 8, 7, 8);
            Name = "Login";
            Text = "LoginForm";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_login;
        private Label lb_username;
        private Label lb_password;
        private Label lb_role;
        private TextBox tb_username;
        private TextBox tb_password;
        private ComboBox cb_role;
    }
}
