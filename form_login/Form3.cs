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
    public partial class Form3 : Form
    {
        int PanelWeidth;
        bool isCollapsed;
        public Form3()
        {
            InitializeComponent();
            timerTime.Start();
            PanelWeidth = panelleft.Width;
            isCollapsed = false;
        
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelleft.Width = panelleft.Width + 10;
                if (panelleft.Width >= PanelWeidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();

                }
            }
            else
            {
                panelleft.Width = panelleft.Width - 10;
                if (panelleft.Width <= 60)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            moveSidePanel(buttonHome);
        }

        private void buttonWarning_Click(object sender, EventArgs e)
        {
            moveSidePanel(buttonWarning);
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToShortDateString() + dt
                .ToShortTimeString();
        }
    }
}
