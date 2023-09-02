namespace 超市管理系统
{
    partial class SaledetailsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_chaxun = new System.Windows.Forms.TextBox();
            this.dgv_xiangqing = new System.Windows.Forms.DataGridView();
            this.SalesID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiptsCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesmanID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_yinyee = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_left = new CCWin.SkinControl.SkinButton();
            this.btn_right = new CCWin.SkinControl.SkinButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_xiangqing)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 20F);
            this.label1.Location = new System.Drawing.Point(283, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "历史账单";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.skinButton1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_chaxun);
            this.panel1.Location = new System.Drawing.Point(12, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 62);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "至";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(249, 21);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(145, 21);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(44, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(145, 21);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.BaseColor = System.Drawing.Color.White;
            this.skinButton1.BorderColor = System.Drawing.Color.White;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.DownBaseColor = System.Drawing.Color.Transparent;
            this.skinButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.skinButton1.Location = new System.Drawing.Point(714, 19);
            this.skinButton1.MouseBack = null;
            this.skinButton1.MouseBaseColor = System.Drawing.Color.White;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(75, 23);
            this.skinButton1.TabIndex = 6;
            this.skinButton1.Text = "查询";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "请输入收银员姓名：";
            // 
            // txt_chaxun
            // 
            this.txt_chaxun.Location = new System.Drawing.Point(577, 21);
            this.txt_chaxun.Name = "txt_chaxun";
            this.txt_chaxun.Size = new System.Drawing.Size(100, 21);
            this.txt_chaxun.TabIndex = 4;
            // 
            // dgv_xiangqing
            // 
            this.dgv_xiangqing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_xiangqing.BackgroundColor = System.Drawing.Color.White;
            this.dgv_xiangqing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_xiangqing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SalesID,
            this.ReceiptsCode,
            this.SalesDate,
            this.Amount,
            this.SalesmanID});
            this.dgv_xiangqing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_xiangqing.Location = new System.Drawing.Point(0, 0);
            this.dgv_xiangqing.Name = "dgv_xiangqing";
            this.dgv_xiangqing.RowTemplate.Height = 23;
            this.dgv_xiangqing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_xiangqing.Size = new System.Drawing.Size(866, 257);
            this.dgv_xiangqing.TabIndex = 8;
            this.dgv_xiangqing.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_xiangqing_CellMouseDoubleClick);
            // 
            // SalesID
            // 
            this.SalesID.DataPropertyName = "SalesID";
            this.SalesID.HeaderText = "销售ID";
            this.SalesID.Name = "SalesID";
            // 
            // ReceiptsCode
            // 
            this.ReceiptsCode.DataPropertyName = "ReceiptsCode";
            this.ReceiptsCode.HeaderText = "单号";
            this.ReceiptsCode.Name = "ReceiptsCode";
            // 
            // SalesDate
            // 
            this.SalesDate.DataPropertyName = "SalesDate";
            this.SalesDate.HeaderText = "销售日期";
            this.SalesDate.Name = "SalesDate";
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "金额";
            this.Amount.Name = "Amount";
            // 
            // SalesmanID
            // 
            this.SalesmanID.DataPropertyName = "SalesmanName";
            this.SalesmanID.HeaderText = "销售员工";
            this.SalesmanID.Name = "SalesmanID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(685, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "总营业额：";
            // 
            // lbl_yinyee
            // 
            this.lbl_yinyee.AutoSize = true;
            this.lbl_yinyee.Location = new System.Drawing.Point(773, 18);
            this.lbl_yinyee.Name = "lbl_yinyee";
            this.lbl_yinyee.Size = new System.Drawing.Size(0, 12);
            this.lbl_yinyee.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(805, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "元";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_xiangqing);
            this.panel2.Location = new System.Drawing.Point(0, 149);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(866, 257);
            this.panel2.TabIndex = 12;
            // 
            // btn_left
            // 
            this.btn_left.BackColor = System.Drawing.Color.Transparent;
            this.btn_left.BaseColor = System.Drawing.Color.Transparent;
            this.btn_left.BorderColor = System.Drawing.Color.Transparent;
            this.btn_left.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_left.DownBack = null;
            this.btn_left.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_left.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_left.Image = global::超市管理系统.Properties.Resources.左;
            this.btn_left.Location = new System.Drawing.Point(261, 406);
            this.btn_left.MouseBack = null;
            this.btn_left.Name = "btn_left";
            this.btn_left.NormlBack = null;
            this.btn_left.Size = new System.Drawing.Size(27, 23);
            this.btn_left.TabIndex = 13;
            this.btn_left.UseVisualStyleBackColor = false;
            // 
            // btn_right
            // 
            this.btn_right.BackColor = System.Drawing.Color.Transparent;
            this.btn_right.BaseColor = System.Drawing.Color.Transparent;
            this.btn_right.BorderColor = System.Drawing.Color.Transparent;
            this.btn_right.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_right.DownBack = null;
            this.btn_right.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_right.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_right.Image = global::超市管理系统.Properties.Resources.T1_arrow_右;
            this.btn_right.Location = new System.Drawing.Point(611, 406);
            this.btn_right.MouseBack = null;
            this.btn_right.Name = "btn_right";
            this.btn_right.NormlBack = null;
            this.btn_right.Size = new System.Drawing.Size(27, 23);
            this.btn_right.TabIndex = 13;
            this.btn_right.UseVisualStyleBackColor = false;
            // 
            // SaledetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 430);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_yinyee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SaledetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Saledetails";
            this.Load += new System.EventHandler(this.SaledetailsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_xiangqing)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_xiangqing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_chaxun;
        private CCWin.SkinControl.SkinButton skinButton1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_yinyee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiptsCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesmanID;
        private System.Windows.Forms.Panel panel2;
        private CCWin.SkinControl.SkinButton btn_left;
        private CCWin.SkinControl.SkinButton btn_right;

    }
}