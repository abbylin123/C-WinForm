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
    public partial class Form_Home : Form
    {
        public Form_Home()
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
        private void Form_Home_Resize(object sender, EventArgs e)
        {
            float newx = (this.Width) / x;
            float newy = (this.Height) / y;
            setControls(newx, newy, this);
        }

        private void btn_min_Click_1(object sender, EventArgs e) //最小化
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


        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {

        }
       
        private void tabPage2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
