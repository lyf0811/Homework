namespace No._8_homework
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
            this.components = new System.ComponentModel.Container();
            this.createButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.funcnumbox = new System.Windows.Forms.ComboBox();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.loadoutbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.searchbutton = new System.Windows.Forms.Button();
            this.loadinbutton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.modifyButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel4 = new System.Windows.Forms.Panel();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderbinding = new System.Windows.Forms.BindingSource(this.components);
            this.ordernumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderitemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.orderitemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderitemBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderbinding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderitemBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderitemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderitemBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(26, 21);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(89, 36);
            this.createButton.TabIndex = 0;
            this.createButton.Text = "新建订单";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.backbutton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.funcnumbox);
            this.panel1.Controls.Add(this.searchbox);
            this.panel1.Controls.Add(this.loadoutbutton);
            this.panel1.Controls.Add(this.deletebutton);
            this.panel1.Controls.Add(this.searchbutton);
            this.panel1.Controls.Add(this.loadinbutton);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.modifyButton);
            this.panel1.Controls.Add(this.createButton);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 104);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // backbutton
            // 
            this.backbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.backbutton.CausesValidation = false;
            this.backbutton.Location = new System.Drawing.Point(766, 65);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(85, 36);
            this.backbutton.TabIndex = 10;
            this.backbutton.Text = "返回";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "根据关键字查询：";
            // 
            // funcnumbox
            // 
            this.funcnumbox.FormattingEnabled = true;
            this.funcnumbox.Items.AddRange(new object[] {
            "订单号",
            "商品名",
            "客户名"});
            this.funcnumbox.Location = new System.Drawing.Point(182, 69);
            this.funcnumbox.Name = "funcnumbox";
            this.funcnumbox.Size = new System.Drawing.Size(121, 23);
            this.funcnumbox.TabIndex = 8;
            this.funcnumbox.SelectedIndexChanged += new System.EventHandler(this.funcnumbox_SelectedIndexChanged);
            // 
            // searchbox
            // 
            this.searchbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchbox.Location = new System.Drawing.Point(350, 69);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(229, 25);
            this.searchbox.TabIndex = 7;
            // 
            // loadoutbutton
            // 
            this.loadoutbutton.CausesValidation = false;
            this.loadoutbutton.Location = new System.Drawing.Point(538, 21);
            this.loadoutbutton.Name = "loadoutbutton";
            this.loadoutbutton.Size = new System.Drawing.Size(85, 36);
            this.loadoutbutton.TabIndex = 6;
            this.loadoutbutton.Text = "导出订单";
            this.loadoutbutton.UseVisualStyleBackColor = true;
            // 
            // deletebutton
            // 
            this.deletebutton.CausesValidation = false;
            this.deletebutton.Location = new System.Drawing.Point(283, 21);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(85, 36);
            this.deletebutton.TabIndex = 5;
            this.deletebutton.Text = "删除订单";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // searchbutton
            // 
            this.searchbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchbutton.CausesValidation = false;
            this.searchbutton.Location = new System.Drawing.Point(633, 65);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(85, 36);
            this.searchbutton.TabIndex = 4;
            this.searchbutton.Text = "查询订单";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // loadinbutton
            // 
            this.loadinbutton.CausesValidation = false;
            this.loadinbutton.Location = new System.Drawing.Point(411, 21);
            this.loadinbutton.Name = "loadinbutton";
            this.loadinbutton.Size = new System.Drawing.Size(85, 36);
            this.loadinbutton.TabIndex = 3;
            this.loadinbutton.Text = "导入订单";
            this.loadinbutton.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(411, 105);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(432, 353);
            this.panel5.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Location = new System.Drawing.Point(0, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(384, 348);
            this.panel3.TabIndex = 0;
            // 
            // modifyButton
            // 
            this.modifyButton.CausesValidation = false;
            this.modifyButton.Location = new System.Drawing.Point(156, 21);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(85, 36);
            this.modifyButton.TabIndex = 1;
            this.modifyButton.Text = "修改订单";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ordernumDataGridViewTextBoxColumn,
            this.orderamountDataGridViewTextBoxColumn,
            this.goodsnameDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderbinding;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(551, 358);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.splitter1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(-1, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(861, 364);
            this.panel2.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dataGridView2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(551, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(310, 364);
            this.panel6.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemDataGridViewTextBoxColumn});
            this.dataGridView2.DataMember = "orderitem";
            this.dataGridView2.DataSource = this.orderbinding;
            this.dataGridView2.Location = new System.Drawing.Point(-3, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(313, 361);
            this.dataGridView2.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(548, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 364);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(548, 364);
            this.panel4.TabIndex = 0;
            // 
            // itemDataGridViewTextBoxColumn
            // 
            this.itemDataGridViewTextBoxColumn.DataPropertyName = "item";
            this.itemDataGridViewTextBoxColumn.HeaderText = "item";
            this.itemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemDataGridViewTextBoxColumn.Name = "itemDataGridViewTextBoxColumn";
            this.itemDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderbinding
            // 
            this.orderbinding.DataSource = typeof(NO._5_homework1.Order);
            this.orderbinding.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // ordernumDataGridViewTextBoxColumn
            // 
            this.ordernumDataGridViewTextBoxColumn.DataPropertyName = "ordernum";
            this.ordernumDataGridViewTextBoxColumn.HeaderText = "ordernum";
            this.ordernumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ordernumDataGridViewTextBoxColumn.Name = "ordernumDataGridViewTextBoxColumn";
            this.ordernumDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderamountDataGridViewTextBoxColumn
            // 
            this.orderamountDataGridViewTextBoxColumn.DataPropertyName = "orderamount";
            this.orderamountDataGridViewTextBoxColumn.HeaderText = "orderamount";
            this.orderamountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderamountDataGridViewTextBoxColumn.Name = "orderamountDataGridViewTextBoxColumn";
            this.orderamountDataGridViewTextBoxColumn.Width = 125;
            // 
            // goodsnameDataGridViewTextBoxColumn
            // 
            this.goodsnameDataGridViewTextBoxColumn.DataPropertyName = "goodsname";
            this.goodsnameDataGridViewTextBoxColumn.HeaderText = "goodsname";
            this.goodsnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodsnameDataGridViewTextBoxColumn.Name = "goodsnameDataGridViewTextBoxColumn";
            this.goodsnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "customer";
            this.customerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderitemBindingSource1
            // 
            this.orderitemBindingSource1.DataMember = "orderitem";
            this.orderitemBindingSource1.DataSource = this.orderbinding;
            // 
            // orderitemBindingSource
            // 
            this.orderitemBindingSource.DataMember = "orderitem";
            this.orderitemBindingSource.DataSource = this.orderbinding;
            // 
            // orderitemBindingSource2
            // 
            this.orderitemBindingSource2.DataMember = "orderitem";
            this.orderitemBindingSource2.DataSource = this.orderbinding;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(862, 465);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderbinding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderitemBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderitemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderitemBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.BindingSource orderitemBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource orderitemBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox funcnumbox;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.Button loadoutbutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.Button loadinbutton;
        private System.Windows.Forms.Button backbutton;
        public System.Windows.Forms.BindingSource orderbinding;
        private System.Windows.Forms.BindingSource orderitemBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordernumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}

