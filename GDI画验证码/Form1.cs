﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI画验证码
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 每次点击都是新的bmp，直接覆盖（而且覆盖的时候窗体会刷新）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            string s = "";
            for (int i = 0; i < 5; i++)
            {
                s += r.Next(0, 10);
            }
            //MessageBox.Show(s);
            //创建一个Image图像
            Bitmap bmp = new Bitmap(100, 50);
            Graphics g = Graphics.FromImage(bmp);

            //为每一个字符都设置不同样式
            string[] fonts = { "微软雅黑", "宋体", "仿宋", "黑体", "华文楷体" };
            Color[] colors = { Color.Green, Color.Gold, Color.Black, Color.Yellow, Color.DarkSlateBlue };
            for (int i = 0; i < s.Length; i++)
            {
                Point p = new Point(20 * i, 0);
                g.DrawString(s[i].ToString(), new Font("fonts[r.Next(0, 5)]", 20, FontStyle.Bold), new SolidBrush(colors[r.Next(0, 5)]), p);
            }

            //加线
            for (int i = 0; i < 30; i++)
            {
                g.DrawLine(Pens.YellowGreen, r.Next(0, bmp.Width), r.Next(0, bmp.Height), r.Next(0, bmp.Width), r.Next(0, bmp.Height));
            }

            for (int i = 0; i < 500; i++)
            {
                bmp.SetPixel(r.Next(bmp.Width), r.Next(bmp.Height), Color.Black);
            }

            //镶嵌
            pictureBox1.Image = bmp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            string s = "";
            for (int i = 0; i < 5; i++)
            {
                s += r.Next(0, 10);
            }
            //MessageBox.Show(s);
            //创建一个Image图像
            Bitmap bmp = new Bitmap(100, 50);
            Graphics g = Graphics.FromImage(bmp);

            //为每一个字符都设置不同样式
            string[] fonts = { "微软雅黑", "宋体", "仿宋", "黑体", "华文楷体" };
            Color[] colors = { Color.Green, Color.Gold, Color.Black, Color.Yellow, Color.DarkSlateBlue };
            for (int i = 0; i < s.Length; i++)
            {
                Point p = new Point(20 * i, 0);
                g.DrawString(s[i].ToString(), new Font("fonts[r.Next(0, 5)]", 20, FontStyle.Bold), new SolidBrush(colors[r.Next(0, 5)]), p);
            }

            //加线
            for (int i = 0; i < 30; i++)
            {
                g.DrawLine(Pens.YellowGreen, r.Next(0, bmp.Width), r.Next(0, bmp.Height), r.Next(0, bmp.Width), r.Next(0, bmp.Height));
            }

            for (int i = 0; i < 500; i++)
            {
                bmp.SetPixel(r.Next(bmp.Width), r.Next(bmp.Height), Color.Black);
            }

            //镶嵌
            pictureBox1.Image = bmp;
        }
    }
}
