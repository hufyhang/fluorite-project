namespace Fluorite.View
{
    partial class HomeScreenUI
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelUsername = new System.Windows.Forms.Label();
            this.buttonSystem = new System.Windows.Forms.Button();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picviewerIcon = new System.Windows.Forms.PictureBox();
            this.movIcon = new System.Windows.Forms.PictureBox();
            this.notepadIcon = new System.Windows.Forms.PictureBox();
            this.dataIcon = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.labelAnnouncement = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.textBoxMessage = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.button4 = new System.Windows.Forms.Button();
            this.timerAnnouncement = new System.Windows.Forms.Timer(this.components);
            this.labelMessage = new ZBobb.AlphaBlendTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pluginIcon = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picviewerIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notepadIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataIcon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pluginIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBoxX1);
            this.panel1.Controls.Add(this.labelUsername);
            this.panel1.Controls.Add(this.buttonSystem);
            this.panel1.Controls.Add(this.labelDateTime);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 35);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(271, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "搜索";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxX1
            // 
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBoxX1.Location = new System.Drawing.Point(36, 2);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(232, 29);
            this.textBoxX1.TabIndex = 3;
            this.textBoxX1.WatermarkText = "本地资源检索";
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(439, 6);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(52, 22);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "USER";
            // 
            // buttonSystem
            // 
            this.buttonSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSystem.ForeColor = System.Drawing.Color.White;
            this.buttonSystem.Location = new System.Drawing.Point(0, 1);
            this.buttonSystem.Name = "buttonSystem";
            this.buttonSystem.Size = new System.Drawing.Size(33, 31);
            this.buttonSystem.TabIndex = 1;
            this.buttonSystem.Text = "↓";
            this.buttonSystem.UseVisualStyleBackColor = true;
            this.buttonSystem.Click += new System.EventHandler(this.buttonSystem_Click);
            // 
            // labelDateTime
            // 
            this.labelDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDateTime.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelDateTime.ForeColor = System.Drawing.Color.White;
            this.labelDateTime.Location = new System.Drawing.Point(737, 6);
            this.labelDateTime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(205, 21);
            this.labelDateTime.TabIndex = 0;
            this.labelDateTime.Text = "Loading...";
            this.labelDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picviewerIcon
            // 
            this.picviewerIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picviewerIcon.BackColor = System.Drawing.Color.Transparent;
            this.picviewerIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picviewerIcon.Image = global::Fluorite.Properties.Resources.JPEG_File;
            this.picviewerIcon.Location = new System.Drawing.Point(25, 441);
            this.picviewerIcon.Name = "picviewerIcon";
            this.picviewerIcon.Size = new System.Drawing.Size(73, 75);
            this.picviewerIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picviewerIcon.TabIndex = 1;
            this.picviewerIcon.TabStop = false;
            this.picviewerIcon.Click += new System.EventHandler(this.icon_DoubleClick);
            // 
            // movIcon
            // 
            this.movIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.movIcon.BackColor = System.Drawing.Color.Transparent;
            this.movIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.movIcon.Image = global::Fluorite.Properties.Resources.MOV_File;
            this.movIcon.Location = new System.Drawing.Point(25, 331);
            this.movIcon.Name = "movIcon";
            this.movIcon.Size = new System.Drawing.Size(73, 75);
            this.movIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.movIcon.TabIndex = 2;
            this.movIcon.TabStop = false;
            this.movIcon.Click += new System.EventHandler(this.icon_DoubleClick);
            // 
            // notepadIcon
            // 
            this.notepadIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.notepadIcon.BackColor = System.Drawing.Color.Transparent;
            this.notepadIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.notepadIcon.Image = global::Fluorite.Properties.Resources.TXT_File;
            this.notepadIcon.Location = new System.Drawing.Point(25, 222);
            this.notepadIcon.Name = "notepadIcon";
            this.notepadIcon.Size = new System.Drawing.Size(73, 75);
            this.notepadIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.notepadIcon.TabIndex = 3;
            this.notepadIcon.TabStop = false;
            this.notepadIcon.Click += new System.EventHandler(this.icon_DoubleClick);
            // 
            // dataIcon
            // 
            this.dataIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataIcon.BackColor = System.Drawing.Color.Transparent;
            this.dataIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataIcon.Image = global::Fluorite.Properties.Resources.Network_Server;
            this.dataIcon.Location = new System.Drawing.Point(25, 550);
            this.dataIcon.Name = "dataIcon";
            this.dataIcon.Size = new System.Drawing.Size(73, 75);
            this.dataIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dataIcon.TabIndex = 4;
            this.dataIcon.TabStop = false;
            this.dataIcon.Click += new System.EventHandler(this.icon_DoubleClick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // labelAnnouncement
            // 
            this.labelAnnouncement.BackColor = System.Drawing.Color.Transparent;
            this.labelAnnouncement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAnnouncement.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAnnouncement.ForeColor = System.Drawing.Color.White;
            this.labelAnnouncement.Location = new System.Drawing.Point(10, 32);
            this.labelAnnouncement.Name = "labelAnnouncement";
            this.labelAnnouncement.Size = new System.Drawing.Size(252, 562);
            this.labelAnnouncement.TabIndex = 6;
            this.labelAnnouncement.Text = "Loading...";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.labelAnnouncement);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(665, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(272, 604);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "信息公告";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 625);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "数据记录";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 519);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "图片查看器";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "媒体播放器";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(33, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "记事本";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(1, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(163, 79);
            this.panel2.TabIndex = 12;
            this.panel2.Visible = false;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(3, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 31);
            this.button3.TabIndex = 6;
            this.button3.Text = "退出系统";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 31);
            this.button2.TabIndex = 5;
            this.button2.Text = "退出登录";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.AcceptsTab = true;
            this.textBoxMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBoxMessage.Border.Class = "TextBoxBorder";
            this.textBoxMessage.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBoxMessage.Location = new System.Drawing.Point(352, 618);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(248, 29);
            this.textBoxMessage.TabIndex = 14;
            this.textBoxMessage.WatermarkText = "输入信息...";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(606, 616);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(53, 31);
            this.button4.TabIndex = 5;
            this.button4.Text = "发送";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // timerAnnouncement
            // 
            this.timerAnnouncement.Enabled = true;
            this.timerAnnouncement.Interval = 10000;
            this.timerAnnouncement.Tick += new System.EventHandler(this.timerAnnouncement_Tick);
            // 
            // labelMessage
            // 
            this.labelMessage.AcceptsReturn = true;
            this.labelMessage.AcceptsTab = true;
            this.labelMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMessage.BackAlpha = 30;
            this.labelMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.labelMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelMessage.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelMessage.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelMessage.ForeColor = System.Drawing.Color.White;
            this.labelMessage.Location = new System.Drawing.Point(352, 358);
            this.labelMessage.Multiline = true;
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.ReadOnly = true;
            this.labelMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.labelMessage.Size = new System.Drawing.Size(307, 252);
            this.labelMessage.TabIndex = 15;
            this.labelMessage.Text = "Connection established...";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(33, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 22);
            this.label5.TabIndex = 17;
            this.label5.Text = "增值项";
            // 
            // pluginIcon
            // 
            this.pluginIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pluginIcon.BackColor = System.Drawing.Color.Transparent;
            this.pluginIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pluginIcon.Image = global::Fluorite.Properties.Resources.Debugging;
            this.pluginIcon.Location = new System.Drawing.Point(25, 113);
            this.pluginIcon.Name = "pluginIcon";
            this.pluginIcon.Size = new System.Drawing.Size(73, 75);
            this.pluginIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pluginIcon.TabIndex = 16;
            this.pluginIcon.TabStop = false;
            this.pluginIcon.Click += new System.EventHandler(this.icon_DoubleClick);
            // 
            // HomeScreenUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = global::Fluorite.Properties.Resources.Wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(949, 659);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pluginIcon);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataIcon);
            this.Controls.Add(this.notepadIcon);
            this.Controls.Add(this.movIcon);
            this.Controls.Add(this.picviewerIcon);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "HomeScreenUI";
            this.Text = "HomeScreenUI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picviewerIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notepadIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataIcon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pluginIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSystem;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.PictureBox picviewerIcon;
        private System.Windows.Forms.PictureBox movIcon;
        private System.Windows.Forms.PictureBox notepadIcon;
        private System.Windows.Forms.PictureBox dataIcon;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label labelAnnouncement;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer3;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxMessage;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timerAnnouncement;
        private ZBobb.AlphaBlendTextBox labelMessage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pluginIcon;
    }
}