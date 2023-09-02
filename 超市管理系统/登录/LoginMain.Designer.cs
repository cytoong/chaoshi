namespace 超市管理系统
{
    partial class LoginForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.rdo_guanli = new System.Windows.Forms.RadioButton();
            this.rdo_saler = new System.Windows.Forms.RadioButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctt_xitong = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.换班ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.ctt_xitong.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(166, 207);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(234, 21);
            this.txt_name.TabIndex = 0;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // txt_pwd
            // 
            this.txt_pwd.Location = new System.Drawing.Point(166, 244);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.PasswordChar = '*';
            this.txt_pwd.Size = new System.Drawing.Size(234, 21);
            this.txt_pwd.TabIndex = 1;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(98, 210);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(41, 12);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "账号：";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_password.ForeColor = System.Drawing.Color.White;
            this.lbl_password.Location = new System.Drawing.Point(98, 247);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(41, 12);
            this.lbl_password.TabIndex = 2;
            this.lbl_password.Text = "密码：";
            // 
            // btn_login
            // 
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_login.Location = new System.Drawing.Point(100, 333);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(104, 30);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "登录";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit.Location = new System.Drawing.Point(325, 333);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(102, 30);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "退出";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // rdo_guanli
            // 
            this.rdo_guanli.AutoSize = true;
            this.rdo_guanli.BackColor = System.Drawing.Color.Transparent;
            this.rdo_guanli.ForeColor = System.Drawing.Color.White;
            this.rdo_guanli.Location = new System.Drawing.Point(166, 289);
            this.rdo_guanli.Name = "rdo_guanli";
            this.rdo_guanli.Size = new System.Drawing.Size(47, 16);
            this.rdo_guanli.TabIndex = 5;
            this.rdo_guanli.TabStop = true;
            this.rdo_guanli.Text = "店长";
            this.rdo_guanli.UseVisualStyleBackColor = false;
            // 
            // rdo_saler
            // 
            this.rdo_saler.AutoSize = true;
            this.rdo_saler.BackColor = System.Drawing.Color.Transparent;
            this.rdo_saler.ForeColor = System.Drawing.Color.White;
            this.rdo_saler.Location = new System.Drawing.Point(248, 289);
            this.rdo_saler.Name = "rdo_saler";
            this.rdo_saler.Size = new System.Drawing.Size(59, 16);
            this.rdo_saler.TabIndex = 5;
            this.rdo_saler.TabStop = true;
            this.rdo_saler.Text = "收银员";
            this.rdo_saler.UseVisualStyleBackColor = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.ctt_xitong;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "超市管理系统";
            this.notifyIcon1.Visible = true;
            // 
            // ctt_xitong
            // 
            this.ctt_xitong.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem,
            this.显示ToolStripMenuItem,
            this.退出ToolStripMenuItem,
            this.换班ToolStripMenuItem});
            this.ctt_xitong.Name = "ctt_xitong";
            this.ctt_xitong.Size = new System.Drawing.Size(101, 92);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // 显示ToolStripMenuItem
            // 
            this.显示ToolStripMenuItem.Name = "显示ToolStripMenuItem";
            this.显示ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.显示ToolStripMenuItem.Text = "显示";
            this.显示ToolStripMenuItem.Click += new System.EventHandler(this.显示ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 换班ToolStripMenuItem
            // 
            this.换班ToolStripMenuItem.Name = "换班ToolStripMenuItem";
            this.换班ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.换班ToolStripMenuItem.Text = "换班";
            this.换班ToolStripMenuItem.Click += new System.EventHandler(this.换班ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 6;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btn_exit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::超市管理系统.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(558, 395);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdo_saler);
            this.Controls.Add(this.rdo_guanli);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.txt_name);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ctt_xitong.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.RadioButton rdo_guanli;
        private System.Windows.Forms.RadioButton rdo_saler;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip ctt_xitong;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 换班ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

