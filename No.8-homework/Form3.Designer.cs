namespace No._8_homework
{
    partial class Form3
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
            this.ordernumbox = new System.Windows.Forms.TextBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.customerbox = new System.Windows.Forms.TextBox();
            this.goodsnamebox = new System.Windows.Forms.TextBox();
            this.orderamountbox = new System.Windows.Forms.TextBox();
            this.orderitembox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ordernumbox
            // 
            this.ordernumbox.Location = new System.Drawing.Point(152, 36);
            this.ordernumbox.Name = "ordernumbox";
            this.ordernumbox.Size = new System.Drawing.Size(96, 25);
            this.ordernumbox.TabIndex = 0;
            // 
            // addbutton
            // 
            this.addbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addbutton.Location = new System.Drawing.Point(544, 332);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(86, 48);
            this.addbutton.TabIndex = 1;
            this.addbutton.Text = "添加";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // customerbox
            // 
            this.customerbox.Location = new System.Drawing.Point(152, 274);
            this.customerbox.Name = "customerbox";
            this.customerbox.Size = new System.Drawing.Size(102, 25);
            this.customerbox.TabIndex = 2;
            // 
            // goodsnamebox
            // 
            this.goodsnamebox.Location = new System.Drawing.Point(152, 196);
            this.goodsnamebox.Name = "goodsnamebox";
            this.goodsnamebox.Size = new System.Drawing.Size(96, 25);
            this.goodsnamebox.TabIndex = 3;
            // 
            // orderamountbox
            // 
            this.orderamountbox.Location = new System.Drawing.Point(152, 116);
            this.orderamountbox.Name = "orderamountbox";
            this.orderamountbox.Size = new System.Drawing.Size(96, 25);
            this.orderamountbox.TabIndex = 4;
            // 
            // orderitembox
            // 
            this.orderitembox.Location = new System.Drawing.Point(483, 36);
            this.orderitembox.Multiline = true;
            this.orderitembox.Name = "orderitembox";
            this.orderitembox.Size = new System.Drawing.Size(124, 129);
            this.orderitembox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "ordernum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "orderamount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "goodsname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "customer:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "orderitem:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderitembox);
            this.Controls.Add(this.orderamountbox);
            this.Controls.Add(this.goodsnamebox);
            this.Controls.Add(this.customerbox);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.ordernumbox);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ordernumbox;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.TextBox customerbox;
        private System.Windows.Forms.TextBox goodsnamebox;
        private System.Windows.Forms.TextBox orderamountbox;
        private System.Windows.Forms.TextBox orderitembox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}