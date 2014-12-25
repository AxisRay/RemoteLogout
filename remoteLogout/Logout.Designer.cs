namespace remoteLogout
{
    partial class Logout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logout));
            this.tbx_userName = new System.Windows.Forms.TextBox();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.btn_logout = new System.Windows.Forms.Button();
            this.lbl_uid = new System.Windows.Forms.Label();
            this.lbl_pwd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbx_userName
            // 
            this.tbx_userName.Location = new System.Drawing.Point(58, 12);
            this.tbx_userName.Name = "tbx_userName";
            this.tbx_userName.Size = new System.Drawing.Size(134, 21);
            this.tbx_userName.TabIndex = 0;
            // 
            // tbx_password
            // 
            this.tbx_password.Location = new System.Drawing.Point(58, 43);
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.Size = new System.Drawing.Size(134, 21);
            this.tbx_password.TabIndex = 1;
            this.tbx_password.UseSystemPasswordChar = true;
            this.tbx_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_password_KeyPress);
            // 
            // btn_logout
            // 
            this.btn_logout.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_logout.Location = new System.Drawing.Point(198, 12);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(54, 52);
            this.btn_logout.TabIndex = 2;
            this.btn_logout.Text = "注销";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // lbl_uid
            // 
            this.lbl_uid.AutoSize = true;
            this.lbl_uid.Location = new System.Drawing.Point(12, 15);
            this.lbl_uid.Name = "lbl_uid";
            this.lbl_uid.Size = new System.Drawing.Size(41, 12);
            this.lbl_uid.TabIndex = 3;
            this.lbl_uid.Text = "账号：";
            // 
            // lbl_pwd
            // 
            this.lbl_pwd.AutoSize = true;
            this.lbl_pwd.Location = new System.Drawing.Point(12, 46);
            this.lbl_pwd.Name = "lbl_pwd";
            this.lbl_pwd.Size = new System.Drawing.Size(41, 12);
            this.lbl_pwd.TabIndex = 4;
            this.lbl_pwd.Text = "密码：";
            // 
            // Logout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 74);
            this.Controls.Add(this.lbl_pwd);
            this.Controls.Add(this.lbl_uid);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.tbx_password);
            this.Controls.Add(this.tbx_userName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Logout";
            this.Text = "RemoteLogout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_userName;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label lbl_uid;
        private System.Windows.Forms.Label lbl_pwd;
    }
}

