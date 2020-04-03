namespace No._7_homework
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
            this.button1 = new System.Windows.Forms.Button();
            this.depth = new System.Windows.Forms.TextBox();
            this.leng = new System.Windows.Forms.TextBox();
            this.per1box = new System.Windows.Forms.TextBox();
            this.per2box = new System.Windows.Forms.TextBox();
            this.th1box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.th2box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.penbox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(695, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // depth
            // 
            this.depth.Location = new System.Drawing.Point(512, 39);
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(100, 25);
            this.depth.TabIndex = 1;
            this.depth.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // leng
            // 
            this.leng.Location = new System.Drawing.Point(512, 107);
            this.leng.Name = "leng";
            this.leng.Size = new System.Drawing.Size(100, 25);
            this.leng.TabIndex = 2;
            this.leng.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // per1box
            // 
            this.per1box.Location = new System.Drawing.Point(512, 169);
            this.per1box.Name = "per1box";
            this.per1box.Size = new System.Drawing.Size(100, 25);
            this.per1box.TabIndex = 3;
            this.per1box.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // per2box
            // 
            this.per2box.Location = new System.Drawing.Point(512, 244);
            this.per2box.Name = "per2box";
            this.per2box.Size = new System.Drawing.Size(100, 25);
            this.per2box.TabIndex = 4;
            this.per2box.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // th1box
            // 
            this.th1box.Location = new System.Drawing.Point(512, 313);
            this.th1box.Name = "th1box";
            this.th1box.Size = new System.Drawing.Size(100, 25);
            this.th1box.TabIndex = 5;
            this.th1box.TextChanged += new System.EventHandler(this.th1box_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(519, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "递归深度";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "主干长度";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(519, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "右分支长度比";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(519, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "左分支长度比";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(519, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 10;
            // 
            // th2box
            // 
            this.th2box.Location = new System.Drawing.Point(512, 388);
            this.th2box.Name = "th2box";
            this.th2box.Size = new System.Drawing.Size(100, 25);
            this.th2box.TabIndex = 11;
            this.th2box.TextChanged += new System.EventHandler(this.th2box_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(519, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "右分支角度";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(519, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "左分支角度";
            // 
            // penbox
            // 
            this.penbox.FormattingEnabled = true;
            this.penbox.Items.AddRange(new object[] {
            "蓝色",
            "红色",
            "黑色",
            "紫色"});
            this.penbox.Location = new System.Drawing.Point(664, 39);
            this.penbox.Name = "penbox";
            this.penbox.Size = new System.Drawing.Size(125, 23);
            this.penbox.TabIndex = 14;
            this.penbox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(692, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "画笔颜色";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 450);
            this.Controls.Add(this.depth);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.penbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.th2box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.th1box);
            this.Controls.Add(this.per2box);
            this.Controls.Add(this.per1box);
            this.Controls.Add(this.leng);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox depth;
        private System.Windows.Forms.TextBox leng;
        private System.Windows.Forms.TextBox per1box;
        private System.Windows.Forms.TextBox per2box;
        private System.Windows.Forms.TextBox th1box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox th2box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox penbox;
        private System.Windows.Forms.Label label8;
    }
}

