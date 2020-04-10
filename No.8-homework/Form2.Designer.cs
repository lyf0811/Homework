namespace No._8_homework
{
    partial class Form2
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
            this.addbutton = new System.Windows.Forms.Button();
            this.ordernumbox = new System.Windows.Forms.TextBox();
            this.goodsnamebox = new System.Windows.Forms.TextBox();
            this.orderamountbox = new System.Windows.Forms.TextBox();
            this.customerbox = new System.Windows.Forms.TextBox();
            this.orderitembox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.orderitem = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(564, 174);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(86, 48);
            this.addbutton.TabIndex = 0;
            this.addbutton.Text = "添加";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // ordernumbox
            // 
            this.ordernumbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ordernumbox.Location = new System.Drawing.Point(118, 24);
            this.ordernumbox.Name = "ordernumbox";
            this.ordernumbox.Size = new System.Drawing.Size(100, 25);
            this.ordernumbox.TabIndex = 1;
            this.ordernumbox.Text = "0";
            // 
            // goodsnamebox
            // 
            this.goodsnamebox.Location = new System.Drawing.Point(118, 131);
            this.goodsnamebox.Name = "goodsnamebox";
            this.goodsnamebox.Size = new System.Drawing.Size(100, 25);
            this.goodsnamebox.TabIndex = 3;
            this.goodsnamebox.Text = "0";
            // 
            // orderamountbox
            // 
            this.orderamountbox.Location = new System.Drawing.Point(118, 78);
            this.orderamountbox.Name = "orderamountbox";
            this.orderamountbox.Size = new System.Drawing.Size(100, 25);
            this.orderamountbox.TabIndex = 4;
            this.orderamountbox.Text = "0";
            // 
            // customerbox
            // 
            this.customerbox.Location = new System.Drawing.Point(118, 188);
            this.customerbox.Name = "customerbox";
            this.customerbox.Size = new System.Drawing.Size(100, 25);
            this.customerbox.TabIndex = 5;
            this.customerbox.Text = "0";
            // 
            // orderitembox
            // 
            this.orderitembox.Location = new System.Drawing.Point(392, 24);
            this.orderitembox.Multiline = true;
            this.orderitembox.Name = "orderitembox";
            this.orderitembox.Size = new System.Drawing.Size(174, 84);
            this.orderitembox.TabIndex = 6;
            this.orderitembox.Text = "1\r\n2\r\n3\r\n4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "ordernum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "orderamount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "goodsname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "customer";
            // 
            // orderitem
            // 
            this.orderitem.AutoSize = true;
            this.orderitem.Location = new System.Drawing.Point(290, 57);
            this.orderitem.Name = "orderitem";
            this.orderitem.Size = new System.Drawing.Size(55, 15);
            this.orderitem.TabIndex = 11;
            this.orderitem.Text = "label5";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(411, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 48);
            this.button1.TabIndex = 12;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 270);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.orderitem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderitembox);
            this.Controls.Add(this.customerbox);
            this.Controls.Add(this.orderamountbox);
            this.Controls.Add(this.goodsnamebox);
            this.Controls.Add(this.ordernumbox);
            this.Controls.Add(this.addbutton);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.TextBox ordernumbox;
        private System.Windows.Forms.TextBox goodsnamebox;
        private System.Windows.Forms.TextBox orderamountbox;
        private System.Windows.Forms.TextBox customerbox;
        private System.Windows.Forms.TextBox orderitembox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label orderitem;
        private System.Windows.Forms.Button button1;
    }
}