namespace form_login
{
    partial class Form_sign_up
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_sign_up));
            this.Header = new System.Windows.Forms.Panel();
            this.btn_max = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_min = new System.Windows.Forms.Button();
            this.txt_titel = new System.Windows.Forms.Label();
            this.border = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.account_panel = new System.Windows.Forms.Panel();
            this.lblaccount = new System.Windows.Forms.Label();
            this.txt_account = new System.Windows.Forms.TextBox();
            this.pic_account = new System.Windows.Forms.PictureBox();
            this.check_panel = new System.Windows.Forms.Panel();
            this.lblcheck = new System.Windows.Forms.Label();
            this.txt_check = new System.Windows.Forms.TextBox();
            this.pic_check = new System.Windows.Forms.PictureBox();
            this.btn_logn_in = new System.Windows.Forms.Button();
            this.btn_sign_up = new System.Windows.Forms.Button();
            this.lb_sign_up = new System.Windows.Forms.Label();
            this.email_panel = new System.Windows.Forms.Panel();
            this.lblemail = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.pic_email = new System.Windows.Forms.PictureBox();
            this.password_panel = new System.Windows.Forms.Panel();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.pic_password = new System.Windows.Forms.PictureBox();
            this.Header.SuspendLayout();
            this.border.SuspendLayout();
            this.panel.SuspendLayout();
            this.account_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_account)).BeginInit();
            this.check_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_check)).BeginInit();
            this.email_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_email)).BeginInit();
            this.password_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_password)).BeginInit();
            this.SuspendLayout();
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
            this.Header.TabIndex = 22;
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
            // txt_titel
            // 
            this.txt_titel.AutoSize = true;
            this.txt_titel.Enabled = false;
            this.txt_titel.Font = new System.Drawing.Font("Bahnschrift Condensed", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_titel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txt_titel.Location = new System.Drawing.Point(3, 0);
            this.txt_titel.Name = "txt_titel";
            this.txt_titel.Size = new System.Drawing.Size(78, 36);
            this.txt_titel.TabIndex = 0;
            this.txt_titel.Text = "TCU MI";
            this.txt_titel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // border
            // 
            this.border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.border.Controls.Add(this.panel);
            this.border.Dock = System.Windows.Forms.DockStyle.Fill;
            this.border.Location = new System.Drawing.Point(0, 45);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(969, 515);
            this.border.TabIndex = 23;
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.account_panel);
            this.panel.Controls.Add(this.check_panel);
            this.panel.Controls.Add(this.btn_logn_in);
            this.panel.Controls.Add(this.btn_sign_up);
            this.panel.Controls.Add(this.lb_sign_up);
            this.panel.Controls.Add(this.email_panel);
            this.panel.Controls.Add(this.password_panel);
            this.panel.Location = new System.Drawing.Point(234, 53);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(508, 424);
            this.panel.TabIndex = 16;
            // 
            // account_panel
            // 
            this.account_panel.BackColor = System.Drawing.Color.White;
            this.account_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.account_panel.Controls.Add(this.lblaccount);
            this.account_panel.Controls.Add(this.txt_account);
            this.account_panel.Controls.Add(this.pic_account);
            this.account_panel.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account_panel.ForeColor = System.Drawing.Color.Silver;
            this.account_panel.Location = new System.Drawing.Point(94, 103);
            this.account_panel.Name = "account_panel";
            this.account_panel.Size = new System.Drawing.Size(320, 48);
            this.account_panel.TabIndex = 26;
            // 
            // lblaccount
            // 
            this.lblaccount.AutoSize = true;
            this.lblaccount.Location = new System.Drawing.Point(205, 11);
            this.lblaccount.Name = "lblaccount";
            this.lblaccount.Size = new System.Drawing.Size(78, 17);
            this.lblaccount.TabIndex = 19;
            this.lblaccount.Text = "請輸入帳號";
            // 
            // txt_account
            // 
            this.txt_account.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_account.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_account.Font = new System.Drawing.Font("Bahnschrift", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_account.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_account.Location = new System.Drawing.Point(39, 13);
            this.txt_account.Name = "txt_account";
            this.txt_account.Size = new System.Drawing.Size(269, 26);
            this.txt_account.TabIndex = 18;
            this.txt_account.TextChanged += new System.EventHandler(this.txt_account_TextChanged);
            // 
            // pic_account
            // 
            this.pic_account.Image = ((System.Drawing.Image)(resources.GetObject("pic_account.Image")));
            this.pic_account.Location = new System.Drawing.Point(9, 13);
            this.pic_account.Name = "pic_account";
            this.pic_account.Size = new System.Drawing.Size(25, 25);
            this.pic_account.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_account.TabIndex = 17;
            this.pic_account.TabStop = false;
            // 
            // check_panel
            // 
            this.check_panel.BackColor = System.Drawing.Color.White;
            this.check_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.check_panel.Controls.Add(this.lblcheck);
            this.check_panel.Controls.Add(this.txt_check);
            this.check_panel.Controls.Add(this.pic_check);
            this.check_panel.Location = new System.Drawing.Point(94, 275);
            this.check_panel.Name = "check_panel";
            this.check_panel.Size = new System.Drawing.Size(320, 46);
            this.check_panel.TabIndex = 27;
            // 
            // lblcheck
            // 
            this.lblcheck.AutoSize = true;
            this.lblcheck.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.lblcheck.ForeColor = System.Drawing.Color.Silver;
            this.lblcheck.Location = new System.Drawing.Point(165, 10);
            this.lblcheck.Name = "lblcheck";
            this.lblcheck.Size = new System.Drawing.Size(106, 17);
            this.lblcheck.TabIndex = 20;
            this.lblcheck.Text = "請輸入確認密碼";
            // 
            // txt_check
            // 
            this.txt_check.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_check.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_check.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_check.Location = new System.Drawing.Point(39, 10);
            this.txt_check.Name = "txt_check";
            this.txt_check.Size = new System.Drawing.Size(269, 29);
            this.txt_check.TabIndex = 19;
            this.txt_check.UseSystemPasswordChar = true;
            this.txt_check.TextChanged += new System.EventHandler(this.txt_check_TextChanged);
            // 
            // pic_check
            // 
            this.pic_check.Image = ((System.Drawing.Image)(resources.GetObject("pic_check.Image")));
            this.pic_check.Location = new System.Drawing.Point(7, 10);
            this.pic_check.Name = "pic_check";
            this.pic_check.Size = new System.Drawing.Size(25, 25);
            this.pic_check.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_check.TabIndex = 17;
            this.pic_check.TabStop = false;
            // 
            // btn_logn_in
            // 
            this.btn_logn_in.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_logn_in.FlatAppearance.BorderSize = 0;
            this.btn_logn_in.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_logn_in.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_logn_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logn_in.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btn_logn_in.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btn_logn_in.Location = new System.Drawing.Point(350, 327);
            this.btn_logn_in.Name = "btn_logn_in";
            this.btn_logn_in.Size = new System.Drawing.Size(81, 41);
            this.btn_logn_in.TabIndex = 20;
            this.btn_logn_in.Text = "登入";
            this.btn_logn_in.UseVisualStyleBackColor = true;
            this.btn_logn_in.Click += new System.EventHandler(this.btn_logn_in_Click);
            // 
            // btn_sign_up
            // 
            this.btn_sign_up.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sign_up.BackgroundImage")));
            this.btn_sign_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_sign_up.Enabled = false;
            this.btn_sign_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sign_up.Font = new System.Drawing.Font("標楷體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_sign_up.ForeColor = System.Drawing.Color.White;
            this.btn_sign_up.Location = new System.Drawing.Point(157, 336);
            this.btn_sign_up.Name = "btn_sign_up";
            this.btn_sign_up.Size = new System.Drawing.Size(194, 71);
            this.btn_sign_up.TabIndex = 20;
            this.btn_sign_up.Text = "註冊";
            this.btn_sign_up.UseVisualStyleBackColor = false;
            this.btn_sign_up.Click += new System.EventHandler(this.btn_sign_up_Click_1);
            // 
            // lb_sign_up
            // 
            this.lb_sign_up.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_sign_up.AutoSize = true;
            this.lb_sign_up.Font = new System.Drawing.Font("Segoe UI Semibold", 30F);
            this.lb_sign_up.Location = new System.Drawing.Point(136, 15);
            this.lb_sign_up.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_sign_up.Name = "lb_sign_up";
            this.lb_sign_up.Size = new System.Drawing.Size(165, 54);
            this.lb_sign_up.TabIndex = 21;
            this.lb_sign_up.Text = "Sign Up";
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
            this.email_panel.Location = new System.Drawing.Point(94, 161);
            this.email_panel.Name = "email_panel";
            this.email_panel.Size = new System.Drawing.Size(320, 48);
            this.email_panel.TabIndex = 25;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(205, 11);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(78, 17);
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
            this.txt_email.Size = new System.Drawing.Size(269, 26);
            this.txt_email.TabIndex = 18;
            this.txt_email.TextChanged += new System.EventHandler(this.txt_email_TextChanged);
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
            this.password_panel.Location = new System.Drawing.Point(94, 219);
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
            this.lblpassword.Size = new System.Drawing.Size(78, 17);
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
            this.txt_password.Size = new System.Drawing.Size(269, 29);
            this.txt_password.TabIndex = 19;
            this.txt_password.UseSystemPasswordChar = true;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
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
            // Form_sign_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(969, 560);
            this.ControlBox = false;
            this.Controls.Add(this.border);
            this.Controls.Add(this.Header);
            this.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_sign_up";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Resize += new System.EventHandler(this.Form_sign_up_Resize);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.border.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.account_panel.ResumeLayout(false);
            this.account_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_account)).EndInit();
            this.check_panel.ResumeLayout(false);
            this.check_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_check)).EndInit();
            this.email_panel.ResumeLayout(false);
            this.email_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_email)).EndInit();
            this.password_panel.ResumeLayout(false);
            this.password_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_password)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Button btn_max;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Label txt_titel;
        private System.Windows.Forms.Panel border;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel email_panel;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.PictureBox pic_email;
        private System.Windows.Forms.Panel password_panel;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.PictureBox pic_password;
        private System.Windows.Forms.Button btn_logn_in;
        private System.Windows.Forms.Label lb_sign_up;
        private System.Windows.Forms.Button btn_sign_up;
        private System.Windows.Forms.Panel account_panel;
        private System.Windows.Forms.Label lblaccount;
        private System.Windows.Forms.TextBox txt_account;
        private System.Windows.Forms.PictureBox pic_account;
        private System.Windows.Forms.Panel check_panel;
        private System.Windows.Forms.Label lblcheck;
        private System.Windows.Forms.TextBox txt_check;
        private System.Windows.Forms.PictureBox pic_check;
    }
}