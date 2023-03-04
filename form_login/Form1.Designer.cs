namespace form_login
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.txt_titel = new System.Windows.Forms.Label();
            this.border = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.btn_forget_password = new System.Windows.Forms.Button();
            this.btn_sign_up = new System.Windows.Forms.Button();
            this.chb_remember = new System.Windows.Forms.CheckBox();
            this.email_panel = new System.Windows.Forms.Panel();
            this.lblemail = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.pic_email = new System.Windows.Forms.PictureBox();
            this.password_panel = new System.Windows.Forms.Panel();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.pic_password = new System.Windows.Forms.PictureBox();
            this.lb_sign_in = new System.Windows.Forms.Label();
            this.btn_sign_in = new System.Windows.Forms.Button();
            this.Header = new System.Windows.Forms.Panel();
            this.btn_max = new System.Windows.Forms.Button();
            this.border.SuspendLayout();
            this.panel.SuspendLayout();
            this.email_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_email)).BeginInit();
            this.password_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_password)).BeginInit();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_min
            // 
            this.btn_min.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_min.BackColor = System.Drawing.Color.White;
            this.btn_min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_min.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_min.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_min.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_min.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btn_min.Location = new System.Drawing.Point(831, 4);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(45, 37);
            this.btn_min.TabIndex = 0;
            this.btn_min.Text = "━";
            this.btn_min.UseVisualStyleBackColor = false;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.White;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btn_close.Location = new System.Drawing.Point(921, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(45, 37);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "x";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // txt_titel
            // 
            this.txt_titel.AutoSize = true;
            this.txt_titel.Enabled = false;
            this.txt_titel.Font = new System.Drawing.Font("Bahnschrift Condensed", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_titel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txt_titel.Location = new System.Drawing.Point(3, 0);
            this.txt_titel.Name = "txt_titel";
            this.txt_titel.Size = new System.Drawing.Size(114, 53);
            this.txt_titel.TabIndex = 0;
            this.txt_titel.Text = "TCU MI";
            this.txt_titel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // border
            // 
            this.border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.border.Controls.Add(this.panel);
            this.border.Dock = System.Windows.Forms.DockStyle.Fill;
            this.border.Location = new System.Drawing.Point(0, 0);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(969, 560);
            this.border.TabIndex = 9;
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.btn_forget_password);
            this.panel.Controls.Add(this.btn_sign_up);
            this.panel.Controls.Add(this.chb_remember);
            this.panel.Controls.Add(this.email_panel);
            this.panel.Controls.Add(this.password_panel);
            this.panel.Controls.Add(this.lb_sign_in);
            this.panel.Controls.Add(this.btn_sign_in);
            this.panel.Location = new System.Drawing.Point(235, 101);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(500, 400);
            this.panel.TabIndex = 16;
            // 
            // btn_forget_password
            // 
            this.btn_forget_password.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_forget_password.FlatAppearance.BorderSize = 0;
            this.btn_forget_password.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_forget_password.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_forget_password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_forget_password.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btn_forget_password.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btn_forget_password.Location = new System.Drawing.Point(260, 253);
            this.btn_forget_password.Name = "btn_forget_password";
            this.btn_forget_password.Size = new System.Drawing.Size(122, 37);
            this.btn_forget_password.TabIndex = 20;
            this.btn_forget_password.Text = "忘記密碼";
            this.btn_forget_password.UseVisualStyleBackColor = true;
            this.btn_forget_password.Click += new System.EventHandler(this.btn_forget_password_Click_1);
            // 
            // btn_sign_up
            // 
            this.btn_sign_up.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_sign_up.FlatAppearance.BorderSize = 0;
            this.btn_sign_up.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_sign_up.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_sign_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sign_up.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btn_sign_up.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btn_sign_up.Location = new System.Drawing.Point(358, 249);
            this.btn_sign_up.Name = "btn_sign_up";
            this.btn_sign_up.Size = new System.Drawing.Size(81, 41);
            this.btn_sign_up.TabIndex = 20;
            this.btn_sign_up.Text = "註冊";
            this.btn_sign_up.UseVisualStyleBackColor = true;
            this.btn_sign_up.Click += new System.EventHandler(this.btn_sign_up_Click_1);
            // 
            // chb_remember
            // 
            this.chb_remember.AutoSize = true;
            this.chb_remember.BackColor = System.Drawing.Color.White;
            this.chb_remember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chb_remember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.chb_remember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.chb_remember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chb_remember.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_remember.ForeColor = System.Drawing.SystemColors.GrayText;
            this.chb_remember.Location = new System.Drawing.Point(90, 262);
            this.chb_remember.Name = "chb_remember";
            this.chb_remember.Size = new System.Drawing.Size(130, 34);
            this.chb_remember.TabIndex = 26;
            this.chb_remember.Text = "記住帳號";
            this.chb_remember.UseVisualStyleBackColor = false;
            // 
            // email_panel
            // 
            this.email_panel.BackColor = System.Drawing.Color.White;
            this.email_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email_panel.Controls.Add(this.lblemail);
            this.email_panel.Controls.Add(this.txt_email);
            this.email_panel.Controls.Add(this.pic_email);
            this.email_panel.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_panel.ForeColor = System.Drawing.Color.Silver;
            this.email_panel.Location = new System.Drawing.Point(90, 132);
            this.email_panel.Name = "email_panel";
            this.email_panel.Size = new System.Drawing.Size(320, 48);
            this.email_panel.TabIndex = 25;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(205, 11);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(110, 24);
            this.lblemail.TabIndex = 19;
            this.lblemail.Text = "請輸入信箱";
            // 
            // txt_email
            // 
            this.txt_email.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email.Font = new System.Drawing.Font("Bahnschrift", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_email.Location = new System.Drawing.Point(39, 13);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(269, 39);
            this.txt_email.TabIndex = 18;
            this.txt_email.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            // 
            // pic_email
            // 
            this.pic_email.Image = ((System.Drawing.Image)(resources.GetObject("pic_email.Image")));
            this.pic_email.Location = new System.Drawing.Point(9, 13);
            this.pic_email.Name = "pic_email";
            this.pic_email.Size = new System.Drawing.Size(25, 25);
            this.pic_email.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_email.TabIndex = 17;
            this.pic_email.TabStop = false;
            // 
            // password_panel
            // 
            this.password_panel.BackColor = System.Drawing.Color.White;
            this.password_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password_panel.Controls.Add(this.lblpassword);
            this.password_panel.Controls.Add(this.txt_password);
            this.password_panel.Controls.Add(this.pic_password);
            this.password_panel.Location = new System.Drawing.Point(90, 201);
            this.password_panel.Name = "password_panel";
            this.password_panel.Size = new System.Drawing.Size(320, 46);
            this.password_panel.TabIndex = 25;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.lblpassword.ForeColor = System.Drawing.Color.Silver;
            this.lblpassword.Location = new System.Drawing.Point(205, 9);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(110, 24);
            this.lblpassword.TabIndex = 20;
            this.lblpassword.Text = "請輸入密碼";
            // 
            // txt_password
            // 
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_password.Location = new System.Drawing.Point(39, 10);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(269, 44);
            this.txt_password.TabIndex = 19;
            this.txt_password.UseSystemPasswordChar = true;
            this.txt_password.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // pic_password
            // 
            this.pic_password.Image = ((System.Drawing.Image)(resources.GetObject("pic_password.Image")));
            this.pic_password.Location = new System.Drawing.Point(7, 10);
            this.pic_password.Name = "pic_password";
            this.pic_password.Size = new System.Drawing.Size(25, 25);
            this.pic_password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_password.TabIndex = 17;
            this.pic_password.TabStop = false;
            // 
            // lb_sign_in
            // 
            this.lb_sign_in.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_sign_in.AutoSize = true;
            this.lb_sign_in.Font = new System.Drawing.Font("Segoe UI Semibold", 30F);
            this.lb_sign_in.Location = new System.Drawing.Point(176, 32);
            this.lb_sign_in.Name = "lb_sign_in";
            this.lb_sign_in.Size = new System.Drawing.Size(223, 81);
            this.lb_sign_in.TabIndex = 21;
            this.lb_sign_in.Text = "Sign In";
            // 
            // btn_sign_in
            // 
            this.btn_sign_in.BackColor = System.Drawing.Color.White;
            this.btn_sign_in.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sign_in.BackgroundImage")));
            this.btn_sign_in.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_sign_in.Enabled = false;
            this.btn_sign_in.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_sign_in.FlatAppearance.BorderSize = 0;
            this.btn_sign_in.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_sign_in.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_sign_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sign_in.Font = new System.Drawing.Font("標楷體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_sign_in.ForeColor = System.Drawing.Color.White;
            this.btn_sign_in.Location = new System.Drawing.Point(153, 302);
            this.btn_sign_in.Name = "btn_sign_in";
            this.btn_sign_in.Size = new System.Drawing.Size(194, 71);
            this.btn_sign_in.TabIndex = 20;
            this.btn_sign_in.Text = "登入";
            this.btn_sign_in.UseVisualStyleBackColor = false;
            this.btn_sign_in.Click += new System.EventHandler(this.btn_sign_in_Click_1);
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.White;
            this.Header.Controls.Add(this.btn_max);
            this.Header.Controls.Add(this.btn_close);
            this.Header.Controls.Add(this.btn_min);
            this.Header.Controls.Add(this.txt_titel);
            this.Header.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(969, 45);
            this.Header.TabIndex = 8;
            // 
            // btn_max
            // 
            this.btn_max.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_max.BackColor = System.Drawing.Color.White;
            this.btn_max.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_max.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_max.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_max.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_max.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_max.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_max.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btn_max.Location = new System.Drawing.Point(876, 4);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(45, 37);
            this.btn_max.TabIndex = 2;
            this.btn_max.Text = "▢";
            this.btn_max.UseVisualStyleBackColor = false;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(969, 560);
            this.ControlBox = false;
            this.Controls.Add(this.Header);
            this.Controls.Add(this.border);
            this.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.border.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.email_panel.ResumeLayout(false);
            this.email_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_email)).EndInit();
            this.password_panel.ResumeLayout(false);
            this.password_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_password)).EndInit();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label txt_titel;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel border;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lb_sign_in;
        private System.Windows.Forms.Button btn_sign_in;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Panel email_panel;
        private System.Windows.Forms.PictureBox pic_email;
        private System.Windows.Forms.Panel password_panel;
        private System.Windows.Forms.PictureBox pic_password;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_max;
        private System.Windows.Forms.CheckBox chb_remember;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_sign_up;
        private System.Windows.Forms.Button btn_forget_password;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblpassword;
    }
}

