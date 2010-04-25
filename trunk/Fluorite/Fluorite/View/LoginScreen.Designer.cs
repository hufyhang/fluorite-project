namespace Fluorite.View
{
    partial class LoginScreen
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
            this.inputWorkGroup = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputPassword = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.inputUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputWorkGroup
            // 
            this.inputWorkGroup.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.inputWorkGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputWorkGroup.FormattingEnabled = true;
            this.inputWorkGroup.Location = new System.Drawing.Point(393, 224);
            this.inputWorkGroup.Margin = new System.Windows.Forms.Padding(5);
            this.inputWorkGroup.Name = "inputWorkGroup";
            this.inputWorkGroup.Size = new System.Drawing.Size(199, 29);
            this.inputWorkGroup.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(309, 227);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "工作组：";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(293, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "登录密码：";
            // 
            // inputPassword
            // 
            this.inputPassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.inputPassword.Location = new System.Drawing.Point(393, 319);
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.PasswordChar = '●';
            this.inputPassword.Size = new System.Drawing.Size(199, 29);
            this.inputPassword.TabIndex = 2;
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.loginButton.Location = new System.Drawing.Point(366, 375);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(78, 38);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "登录";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.exitButton.Location = new System.Drawing.Point(488, 375);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(78, 38);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "退出";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // inputUsername
            // 
            this.inputUsername.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.inputUsername.Location = new System.Drawing.Point(393, 268);
            this.inputUsername.Name = "inputUsername";
            this.inputUsername.Size = new System.Drawing.Size(199, 29);
            this.inputUsername.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(293, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "登录用户：";
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(885, 539);
            this.Controls.Add(this.inputUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.inputPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputWorkGroup);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "LoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox inputWorkGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputPassword;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox inputUsername;
        private System.Windows.Forms.Label label3;
    }
}