namespace gateExeDemo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox_ret = new System.Windows.Forms.TextBox();
            this.textBox_first = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_second = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_timeout = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox_first = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_second = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox_openDoor = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "端口：";
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(59, 6);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(68, 21);
            this.textBox_port.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "连接闸机";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(249, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "断开闸机";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(14, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "初始化";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox_ret
            // 
            this.textBox_ret.Location = new System.Drawing.Point(1, 221);
            this.textBox_ret.Multiline = true;
            this.textBox_ret.Name = "textBox_ret";
            this.textBox_ret.ReadOnly = true;
            this.textBox_ret.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_ret.Size = new System.Drawing.Size(580, 212);
            this.textBox_ret.TabIndex = 5;
            // 
            // textBox_first
            // 
            this.textBox_first.Location = new System.Drawing.Point(214, 50);
            this.textBox_first.Name = "textBox_first";
            this.textBox_first.Size = new System.Drawing.Size(42, 21);
            this.textBox_first.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "第一道门超时时间：";
            // 
            // textBox_second
            // 
            this.textBox_second.Location = new System.Drawing.Point(375, 50);
            this.textBox_second.Name = "textBox_second";
            this.textBox_second.Size = new System.Drawing.Size(45, 21);
            this.textBox_second.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "第二道门超时时间:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "系统超时时间:";
            // 
            // textBox_timeout
            // 
            this.textBox_timeout.Location = new System.Drawing.Point(516, 50);
            this.textBox_timeout.Name = "textBox_timeout";
            this.textBox_timeout.Size = new System.Drawing.Size(53, 21);
            this.textBox_timeout.TabIndex = 11;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(14, 79);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "设置/获取参数";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox_first
            // 
            this.comboBox_first.FormattingEnabled = true;
            this.comboBox_first.Location = new System.Drawing.Point(217, 81);
            this.comboBox_first.Name = "comboBox_first";
            this.comboBox_first.Size = new System.Drawing.Size(61, 20);
            this.comboBox_first.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "第一门工作模式:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(293, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "第二门工作模式:";
            // 
            // comboBox_second
            // 
            this.comboBox_second.FormattingEnabled = true;
            this.comboBox_second.Location = new System.Drawing.Point(395, 81);
            this.comboBox_second.Name = "comboBox_second";
            this.comboBox_second.Size = new System.Drawing.Size(66, 20);
            this.comboBox_second.TabIndex = 16;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(479, 84);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "设置工作模式";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBox_openDoor
            // 
            this.comboBox_openDoor.FormattingEnabled = true;
            this.comboBox_openDoor.Location = new System.Drawing.Point(14, 109);
            this.comboBox_openDoor.Name = "comboBox_openDoor";
            this.comboBox_openDoor.Size = new System.Drawing.Size(121, 20);
            this.comboBox_openDoor.TabIndex = 18;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(153, 109);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 19;
            this.button6.Text = "开门操作";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(14, 136);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(96, 23);
            this.button7.TabIndex = 20;
            this.button7.Text = "查询闸机状态";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(13, 177);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 21;
            this.button8.Text = "清除数据";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(249, 109);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(105, 23);
            this.button9.TabIndex = 22;
            this.button9.Text = "报警超时指令";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(375, 109);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(107, 23);
            this.button10.TabIndex = 23;
            this.button10.Text = "服务端断开连接";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 429);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.comboBox_openDoor);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.comboBox_second);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_first);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox_timeout);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_second);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_first);
            this.Controls.Add(this.textBox_ret);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_port);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "闸机测试demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox_ret;
        private System.Windows.Forms.TextBox textBox_first;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_second;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_timeout;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox_first;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_second;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox_openDoor;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}

