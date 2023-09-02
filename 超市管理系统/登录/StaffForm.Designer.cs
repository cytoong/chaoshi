namespace 超市管理系统
{
    partial class StaffForm
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
            this.btn_zengjia = new CCWin.SkinControl.SkinButton();
            this.btn_xiugai = new CCWin.SkinControl.SkinButton();
            this.btn_shanchu = new CCWin.SkinControl.SkinButton();
            this.dgv_renyuan = new System.Windows.Forms.DataGridView();
            this.SalesmanID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesmanName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaseSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommissionRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Work = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_chaxun = new System.Windows.Forms.Button();
            this.txt_renyuan = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_mobile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_basesalary = new System.Windows.Forms.TextBox();
            this.txt_commissionRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbo_gander = new System.Windows.Forms.ComboBox();
            this.cbo_work = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_renyuan)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_zengjia
            // 
            this.btn_zengjia.BackColor = System.Drawing.Color.White;
            this.btn_zengjia.BaseColor = System.Drawing.Color.DarkGray;
            this.btn_zengjia.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_zengjia.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_zengjia.DownBack = null;
            this.btn_zengjia.DownBaseColor = System.Drawing.Color.White;
            this.btn_zengjia.Location = new System.Drawing.Point(22, 40);
            this.btn_zengjia.MouseBack = null;
            this.btn_zengjia.MouseBaseColor = System.Drawing.Color.White;
            this.btn_zengjia.Name = "btn_zengjia";
            this.btn_zengjia.NormlBack = null;
            this.btn_zengjia.Size = new System.Drawing.Size(76, 26);
            this.btn_zengjia.TabIndex = 3;
            this.btn_zengjia.Text = "增加";
            this.btn_zengjia.UseVisualStyleBackColor = false;
            this.btn_zengjia.Click += new System.EventHandler(this.btn_zengjia_Click);
            // 
            // btn_xiugai
            // 
            this.btn_xiugai.BackColor = System.Drawing.Color.White;
            this.btn_xiugai.BaseColor = System.Drawing.Color.DarkGray;
            this.btn_xiugai.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_xiugai.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_xiugai.DownBack = null;
            this.btn_xiugai.DownBaseColor = System.Drawing.Color.White;
            this.btn_xiugai.Location = new System.Drawing.Point(140, 40);
            this.btn_xiugai.MouseBack = null;
            this.btn_xiugai.MouseBaseColor = System.Drawing.Color.White;
            this.btn_xiugai.Name = "btn_xiugai";
            this.btn_xiugai.NormlBack = null;
            this.btn_xiugai.Size = new System.Drawing.Size(76, 26);
            this.btn_xiugai.TabIndex = 3;
            this.btn_xiugai.Text = "修改";
            this.btn_xiugai.UseVisualStyleBackColor = false;
            this.btn_xiugai.Click += new System.EventHandler(this.btn_xiugai_Click);
            // 
            // btn_shanchu
            // 
            this.btn_shanchu.BackColor = System.Drawing.Color.White;
            this.btn_shanchu.BaseColor = System.Drawing.Color.DarkGray;
            this.btn_shanchu.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_shanchu.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_shanchu.DownBack = null;
            this.btn_shanchu.DownBaseColor = System.Drawing.Color.White;
            this.btn_shanchu.Location = new System.Drawing.Point(255, 40);
            this.btn_shanchu.MouseBack = null;
            this.btn_shanchu.MouseBaseColor = System.Drawing.Color.White;
            this.btn_shanchu.Name = "btn_shanchu";
            this.btn_shanchu.NormlBack = null;
            this.btn_shanchu.Size = new System.Drawing.Size(76, 26);
            this.btn_shanchu.TabIndex = 3;
            this.btn_shanchu.Text = "删除";
            this.btn_shanchu.UseVisualStyleBackColor = false;
            this.btn_shanchu.Click += new System.EventHandler(this.btn_shanchu_Click);
            // 
            // dgv_renyuan
            // 
            this.dgv_renyuan.AllowUserToAddRows = false;
            this.dgv_renyuan.BackgroundColor = System.Drawing.Color.White;
            this.dgv_renyuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_renyuan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SalesmanID,
            this.SalesmanName,
            this.Mobile,
            this.Pwd,
            this.Gender,
            this.BaseSalary,
            this.CommissionRate,
            this.Work});
            this.dgv_renyuan.Location = new System.Drawing.Point(3, 231);
            this.dgv_renyuan.Name = "dgv_renyuan";
            this.dgv_renyuan.RowTemplate.Height = 23;
            this.dgv_renyuan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_renyuan.Size = new System.Drawing.Size(881, 187);
            this.dgv_renyuan.TabIndex = 7;
            this.dgv_renyuan.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_renyuan_CellMouseClick);
            // 
            // SalesmanID
            // 
            this.SalesmanID.DataPropertyName = "SalesmanID";
            this.SalesmanID.HeaderText = "员工编号";
            this.SalesmanID.Name = "SalesmanID";
            // 
            // SalesmanName
            // 
            this.SalesmanName.DataPropertyName = "SalesmanName";
            this.SalesmanName.HeaderText = "姓名";
            this.SalesmanName.Name = "SalesmanName";
            // 
            // Mobile
            // 
            this.Mobile.DataPropertyName = "Mobile";
            this.Mobile.HeaderText = "电话";
            this.Mobile.Name = "Mobile";
            // 
            // Pwd
            // 
            this.Pwd.DataPropertyName = "Pwd";
            this.Pwd.HeaderText = "密码";
            this.Pwd.Name = "Pwd";
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "性别";
            this.Gender.Name = "Gender";
            // 
            // BaseSalary
            // 
            this.BaseSalary.DataPropertyName = "BaseSalary";
            this.BaseSalary.HeaderText = "底薪";
            this.BaseSalary.Name = "BaseSalary";
            // 
            // CommissionRate
            // 
            this.CommissionRate.DataPropertyName = "CommissionRate";
            this.CommissionRate.HeaderText = "提成";
            this.CommissionRate.Name = "CommissionRate";
            // 
            // Work
            // 
            this.Work.DataPropertyName = "Work";
            this.Work.HeaderText = "职务";
            this.Work.Name = "Work";
            this.Work.Width = 130;
            // 
            // btn_chaxun
            // 
            this.btn_chaxun.Location = new System.Drawing.Point(748, 42);
            this.btn_chaxun.Name = "btn_chaxun";
            this.btn_chaxun.Size = new System.Drawing.Size(75, 23);
            this.btn_chaxun.TabIndex = 8;
            this.btn_chaxun.Text = "查询";
            this.btn_chaxun.UseVisualStyleBackColor = true;
            this.btn_chaxun.Click += new System.EventHandler(this.btn_chaxun_Click);
            // 
            // txt_renyuan
            // 
            this.txt_renyuan.Location = new System.Drawing.Point(606, 43);
            this.txt_renyuan.Name = "txt_renyuan";
            this.txt_renyuan.Size = new System.Drawing.Size(124, 21);
            this.txt_renyuan.TabIndex = 9;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(100, 119);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 21);
            this.txt_name.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "姓名：";
            // 
            // txt_mobile
            // 
            this.txt_mobile.Location = new System.Drawing.Point(325, 119);
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.Size = new System.Drawing.Size(100, 21);
            this.txt_mobile.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "电话：";
            // 
            // txt_pwd
            // 
            this.txt_pwd.Location = new System.Drawing.Point(550, 119);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(100, 21);
            this.txt_pwd.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(491, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "密码：";
            // 
            // txt_basesalary
            // 
            this.txt_basesalary.Location = new System.Drawing.Point(100, 169);
            this.txt_basesalary.Name = "txt_basesalary";
            this.txt_basesalary.Size = new System.Drawing.Size(100, 21);
            this.txt_basesalary.TabIndex = 10;
            // 
            // txt_commissionRate
            // 
            this.txt_commissionRate.Location = new System.Drawing.Point(325, 169);
            this.txt_commissionRate.Name = "txt_commissionRate";
            this.txt_commissionRate.Size = new System.Drawing.Size(100, 21);
            this.txt_commissionRate.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "底薪：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "提成：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(491, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "职务：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(703, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "性别：";
            // 
            // cbo_gander
            // 
            this.cbo_gander.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_gander.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_gander.FormattingEnabled = true;
            this.cbo_gander.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbo_gander.Location = new System.Drawing.Point(763, 119);
            this.cbo_gander.Name = "cbo_gander";
            this.cbo_gander.Size = new System.Drawing.Size(99, 20);
            this.cbo_gander.TabIndex = 12;
            // 
            // cbo_work
            // 
            this.cbo_work.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_work.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_work.FormattingEnabled = true;
            this.cbo_work.Items.AddRange(new object[] {
            "店长",
            "收银员"});
            this.cbo_work.Location = new System.Drawing.Point(550, 169);
            this.cbo_work.Name = "cbo_work";
            this.cbo_work.Size = new System.Drawing.Size(100, 20);
            this.cbo_work.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(477, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "根据员工姓名查询：";
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 438);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbo_work);
            this.Controls.Add(this.cbo_gander);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_commissionRate);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.txt_basesalary);
            this.Controls.Add(this.txt_mobile);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_renyuan);
            this.Controls.Add(this.btn_chaxun);
            this.Controls.Add(this.dgv_renyuan);
            this.Controls.Add(this.btn_shanchu);
            this.Controls.Add(this.btn_xiugai);
            this.Controls.Add(this.btn_zengjia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "staff";
            this.Load += new System.EventHandler(this.StaffForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_renyuan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton btn_zengjia;
        private CCWin.SkinControl.SkinButton btn_xiugai;
        private CCWin.SkinControl.SkinButton btn_shanchu;
        private System.Windows.Forms.DataGridView dgv_renyuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesmanID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesmanName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaseSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommissionRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Work;
        private System.Windows.Forms.Button btn_chaxun;
        private System.Windows.Forms.TextBox txt_renyuan;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_mobile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_basesalary;
        private System.Windows.Forms.TextBox txt_commissionRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbo_gander;
        private System.Windows.Forms.ComboBox cbo_work;
        private System.Windows.Forms.Label label8;


    }
}