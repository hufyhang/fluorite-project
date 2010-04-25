namespace Fluorite.View
{
    partial class GanzaoUI
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.inputB = new System.Windows.Forms.NumericUpDown();
            this.inputA = new System.Windows.Forms.NumericUpDown();
            this.inputSN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputA)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(587, 360);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.inputB);
            this.tabPage1.Controls.Add(this.inputA);
            this.tabPage1.Controls.Add(this.inputSN);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage1.Size = new System.Drawing.Size(579, 326);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "新流程";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(20, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "蒸汽量     ：";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(20, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "含水率     ：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "确认提交";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputB
            // 
            this.inputB.Location = new System.Drawing.Point(146, 149);
            this.inputB.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.inputB.Name = "inputB";
            this.inputB.Size = new System.Drawing.Size(196, 29);
            this.inputB.TabIndex = 11;
            // 
            // inputA
            // 
            this.inputA.Location = new System.Drawing.Point(146, 89);
            this.inputA.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.inputA.Name = "inputA";
            this.inputA.Size = new System.Drawing.Size(196, 29);
            this.inputA.TabIndex = 10;
            // 
            // inputSN
            // 
            this.inputSN.Location = new System.Drawing.Point(146, 24);
            this.inputSN.Name = "inputSN";
            this.inputSN.ReadOnly = true;
            this.inputSN.Size = new System.Drawing.Size(296, 29);
            this.inputSN.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "流水号    ：";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage2.Size = new System.Drawing.Size(579, 326);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "工作简报";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(579, 326);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "退出登录";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(236, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 35);
            this.button2.TabIndex = 14;
            this.button2.Text = "退出登录";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(5, 5);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(569, 316);
            this.dataGridView.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GanzaoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(587, 360);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "GanzaoUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "干燥工段 - ";
            this.TopMost = true;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputA)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown inputB;
        private System.Windows.Forms.NumericUpDown inputA;
        private System.Windows.Forms.TextBox inputSN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Timer timer1;
    }
}