using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickTraining
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 等级
        /// 控制每行显示的方块数
        /// 等级1：每行10个
        /// 等级2：每行15
        /// 等级3：每行21
        /// 等级4：每行28
        /// </summary>
        private static int level = 1;
        /// <summary>
        /// 速度
        /// 控制方块
        /// 等级1：1秒
        /// 等级2：0.7秒
        /// 等级3：0.4秒
        /// </summary>
        private static int speed = 1;
        /// <summary>
        /// 当前激活方块编码
        /// </summary>
        private static int current = 0;
        /// <summary>
        /// 显示点击框数量
        /// </summary>
        private static int boxNum { get; set; }
        /// <summary>
        /// 连击次数
        /// </summary>
        private static int combo { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitClickBox();
            InitSpeed();
            InitLevelStatus();
        }

        private void InitClickBox()
        {
            flowLayoutPanel1.Controls.Clear();
            int width = flowLayoutPanel1.Width;
            int boxwidth = 0;

            switch (level)
            {
                case 1:
                    boxNum = 10;
                    boxwidth = width / 10;
                    break;
                case 2:
                    boxNum = 15;
                    boxwidth = width / 15;
                    break;
                case 3:
                    boxNum = 21;
                    boxwidth = width / 21;
                    break;
                case 4:
                    boxNum = 28;
                    boxwidth = width / 28;
                    break;
            }

            int rows = flowLayoutPanel1.Height / boxwidth;
            boxNum = boxNum * rows;

            for (int i = 1; i <= boxNum; i++)
            {
                PictureBox p1 = new PictureBox();
                p1.Height = boxwidth;
                p1.Width = boxwidth;
                //p1.BackColor = Color.Chocolate;
                p1.BorderStyle = BorderStyle.FixedSingle;
                p1.AutoSize = false;
                p1.Margin = new Padding(0);
                p1.Name = "PictureBox" + i;
                p1.Click += P1_Click;

                flowLayoutPanel1.Controls.Add(p1);
            }
        }

        private void InitSpeed()
        {
            this.timer1.Stop();
            switch (speed)
            {
                case 1:
                    this.timer1.Interval = 1000;
                    break;
                case 2:
                    this.timer1.Interval = 700;
                    break;
                case 3:
                    this.timer1.Interval = 400;
                    break;
            }

            this.timer1.Start();
        }

        private void InitLevelStatus()
        {
            string status = "";

            switch (level)
            {
                case 1:
                    status = "初级";
                    break;
                case 2:
                    status = "中级";
                    break;
                case 3:
                    status = "高级";
                    break;
                case 4:
                    status = "专家";
                    break;
            }

            switch (speed)
            {
                case 1:
                    status += " 慢速";
                    break;
                case 2:
                    status += " 普通";
                    break;
                case 3:
                    status += " 快速";
                    break;
            }

            status_currentLevel.Text = status;
        }

        private void P1_Click(object sender, EventArgs e)
        {
            if (current != 0 && ((MouseEventArgs)e).Button == MouseButtons.Left)
            {
                PictureBox pic = (PictureBox)sender;

                string strNum = pic.Name.Replace("PictureBox", "");
                int num = Convert.ToInt32(strNum);

                if (num == current)
                {
                    combo += 1;
                }
                else
                {
                    combo = 0;
                }

                status_combo.Text = combo + "";
            }
            else if (((MouseEventArgs)e).Button == MouseButtons.Right)
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (current != 0)
            {
                Control controlBefore = Controls.Find("PictureBox" + current, true)[0];
                PictureBox picBefore = (PictureBox)controlBefore;
                picBefore.BackColor = Color.Transparent;
            }

            current = new Random().Next(1, boxNum);

            Control control = Controls.Find("PictureBox" + current, true)[0];
            PictureBox pic = (PictureBox)control;
            pic.BackColor = Color.Wheat;
        }

        #region 速度

        /// <summary>
        /// 慢速
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi_speed1_Click(object sender, EventArgs e)
        {
            speed = 1;
            InitSpeed();
            InitLevelStatus();
        }

        /// <summary>
        /// 普通速度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi_speed2_Click(object sender, EventArgs e)
        {
            speed = 2;
            InitSpeed();
            InitLevelStatus();
        }

        /// <summary>
        /// 快熟
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi_speed3_Click(object sender, EventArgs e)
        {
            speed = 3;
            InitSpeed();
            InitLevelStatus();
        }

        #endregion

        #region 等级

        private void tsmi_level1_Click(object sender, EventArgs e)
        {
            level = 1;
            InitClickBox();
            InitLevelStatus();
        }

        private void tsmi_level2_Click(object sender, EventArgs e)
        {
            level = 2;
            InitClickBox();
            InitLevelStatus();
        }

        private void tsmi_level3_Click(object sender, EventArgs e)
        {
            level = 3;
            InitClickBox();
            InitLevelStatus();
        }

        private void tsmi_level4_Click(object sender, EventArgs e)
        {
            level = 4;
            InitClickBox();
            InitLevelStatus();
        }

        #endregion

    }
}
