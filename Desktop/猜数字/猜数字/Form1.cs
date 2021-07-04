using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 猜数字
{
    public partial class Form1 : Form
    {
        int x=0;///定义的是一个全局变量
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 游戏开始 生成一个随机数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            x = rd.Next(100);//生成一个1-100的随机数
            MessageBox.Show("游戏开始");
        }
        /// <summary>
        /// 显示谜底
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            label4.Text = x.ToString();
        }
        /// <summary>
        /// 退出游戏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
        }
        /// <summary>
        /// 按下回车进行判断
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)///KeyCode属性获取KeyUp和KeyDown事件的键盘代码，其值用Keys枚举成员名
            {
                int num = -1;
                if(int.TryParse(textBox1.Text.Trim(),out num))
                {
                    if (x == num)
                    {
                        label3.Visible = true;
                        label3.Text = "猜对了，你真棒！";
                    }
                    else if (num > x)
                    {
                        label3.Visible = true;
                        label3.Text = "真是，猜大了！";
                    }
                    else
                    {
                        label3.Visible = true;
                        label3.Text = "真是，猜小了！";
                    }
                }
                else
                {
                    MessageBox.Show("请重新输入数字！");
                    textBox1.Text = "";
                }
                
            }
        }
    }
}
