using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_login
{
    public partial class Form_forget_password : Form
    {
        public Form_forget_password()
        {
            InitializeComponent();
            x = this.Width;
            y = this.Height;
            setTag(this);
        }

        //控件大小隨窗體大小等比例縮放
        private float x;//定義當前窗體的寬度
        private float y;//定義當前窗體的高度
        private void setTag(Control cons)
        {
            foreach (Control con in cons.Controls)
            {
                con.Tag = con.Width + ";" + con.Height + ";" + con.Left + ";" + con.Top + ";" + con.Font.Size;
                if (con.Controls.Count > 0)
                {
                    setTag(con);
                }
            }
        }
        private void setControls(float newx, float newy, Control cons)
        {
            //遍歷窗體中的控件，重新設置控件的值
            foreach (Control con in cons.Controls)
            {
                //獲取控件的Tag屬性值，並分割後存儲字符串數組
                if (con.Tag != null)
                {
                    string[] mytag = con.Tag.ToString().Split(new char[] { ';' });
                    //根據窗體縮放的比例確定控件的值
                    con.Width = Convert.ToInt32(System.Convert.ToSingle(mytag[0]) * newx);//寬度
                    con.Height = Convert.ToInt32(System.Convert.ToSingle(mytag[1]) * newy);//高度
                    con.Left = Convert.ToInt32(System.Convert.ToSingle(mytag[2]) * newx);//左邊距
                    con.Top = Convert.ToInt32(System.Convert.ToSingle(mytag[3]) * newy);//頂邊距
                    Single currentSize = System.Convert.ToSingle(mytag[4]) * newy;//字體大小
                    con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                    if (con.Controls.Count > 0)
                    {
                        setControls(newx, newy, con);
                    }
                }
            }
        }
        
        private void Form_forget_password_Resize(object sender, EventArgs e)
        {
            float newx = (this.Width) / x;
            float newy = (this.Height) / y;
            setControls(newx, newy, this);
        }

        private void btn_min_Click(object sender, EventArgs e)  //最小化
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_max_Click(object sender, EventArgs e)  //最大化
        {
            MaxNormalSwitch();
        }

        private void MaxNormalSwitch()  //最大化和正常窗體切換
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.btn_max.Image = Properties.Resources.最大化1;
            }
            else  //防止遮擋視窗欄位
            {
                this.WindowState = FormWindowState.Maximized;
                this.btn_max.Image = Properties.Resources.最大化;  //最大化圖示切換
            }
            this.Invalidate();
        }

        private void btn_close_Click(object sender, EventArgs e)  //關閉
        {
            this.Close();
        }

        private void txt_email_TextChanged(object sender, EventArgs e)  //信箱
        {
            EnableDisableButton();
            lblemail.Visible = String.IsNullOrEmpty(txt_email.Text);
        }

        private void EnableDisableButton()  //判斷信箱是否輸入
        {
            
            if (!string.IsNullOrWhiteSpace(txt_email.Text))  
            {
                btn_getpass.Enabled = true;
                return;
            }
            btn_getpass.Enabled = false;
            
        }

        private void btn_getpass_Click(object sender, EventArgs e) //信箱確認按鈕
        {
            pass_panel.Visible = true;
            email_panel.Visible = false;
            btn_getpass.Visible = false;
            btn_okpass.Visible = true;
        }

        public void EnablePassButton()  //判斷驗證碼是否輸入
        {
            
            if (!string.IsNullOrWhiteSpace(txt_pass.Text))
            {
                btn_okpass.Enabled = true;
                return;
            }
            btn_okpass.Enabled = false;
        }

        private void txt_pass_TextChanged(object sender, EventArgs e)  //驗證碼
        {
            EnablePassButton();
            lblpass.Visible = String.IsNullOrEmpty(txt_pass.Text);
        }


        private void btn_okpass_Click_1(object sender, EventArgs e)//確認驗證碼按鈕
        {
            password_panel.Visible = true;
            check_panel.Visible = true;
            pass_panel.Visible = false;
            btn_okpass.Visible = false;
            btn_password.Visible = true;
        }

        public void EnablePasswordButton()  //判斷密碼和確認密碼是否輸入
        {
            
            if (!string.IsNullOrWhiteSpace(txt_password.Text) && !string.IsNullOrWhiteSpace(txt_pass.Text))
            {
                btn_password.Enabled = true;
                return;
            }
            btn_password.Enabled = false;
        }

        private void txt_password_TextChanged(object sender, EventArgs e)  //新密碼
        {
            EnablePasswordButton();
            lblpassword.Visible = String.IsNullOrEmpty(txt_password.Text);
        }
        private void txt_check_TextChanged(object sender, EventArgs e)  //確認密碼
        {
            EnablePasswordButton();
            lblcheck.Visible = String.IsNullOrEmpty(txt_check.Text);
           
        }

        private void btn_password_Click(object sender, EventArgs e)  //新密碼確認按鈕
        {
            Form1 sign_in = new Form1();
            this.Visible = false;
            sign_in.Visible = true;
        }

    }
}
