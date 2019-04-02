using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 随便练练2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //很关键 用于储存验证码
        string yZM = null;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string str = null;
            Bitmap bmp = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
            Graphics g = Graphics.FromImage(bmp);
            Random r = new Random();
            //生成随机字符
            for (int i = 0; i < 5; i++)
            {
                str += r.Next(0, 10);
            }
            yZM = str;
            //字体样式
            Font[] fonts = new Font[]
            {
                new Font("宋体", r.Next(20, 60), (FontStyle)(r.Next(3))),
                new Font("隶书", r.Next(20, 60), (FontStyle)(r.Next(3))),
                new Font("华文楷体", r.Next(20, 60), (FontStyle)(r.Next(3))),
                new Font("黑体", r.Next(20, 60), (FontStyle)(r.Next(3))),
                new Font("微软雅黑", r.Next(20, 60), (FontStyle)(r.Next(3)))
            };
            //颜色
            Color[] colors = new Color[] { Color.Yellow, Color.Blue, Color.Green, Color.Pink, Color.OrangeRed };
            //为每一个字符设置样式
            for (int i = 0; i < str.Length; i++)
            {
                //字体间隔
                Point p = new Point(i * (bmp.Width / str.Length), 0);
                g.DrawString(str[i].ToString(), fonts[r.Next(5)], new SolidBrush(colors[r.Next(5)]), p);
            }
            //加线条
            for (int i = 0; i < bmp.Height / 2; i++)
            {
                Point p1 = new Point(r.Next(bmp.Width), r.Next(bmp.Height));
                Point p2 = new Point(r.Next(bmp.Width), r.Next(bmp.Height));
                g.DrawLine(new Pen(Color.YellowGreen), p1, p2);
            }
            //加像素点
            for (int i = 0; i < bmp.Width * 10; i++)
            {
                bmp.SetPixel(r.Next(bmp.Width), r.Next(bmp.Height), Color.Black);
            }
            pictureBox1.Image = bmp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == yZM)
            {
                MessageBox.Show("输入正确！获得长泽莫里奈一枚！");
            }
            else
            {
                MessageBox.Show("输入错误！被穆莎莎诅咒！");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string str = null;
            Bitmap bmp = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
            Graphics g = Graphics.FromImage(bmp);
            Random r = new Random();
            //生成随机字符
            for (int i = 0; i < 5; i++)
            {
                str += r.Next(0, 10);
            }
            yZM = str;
            //字体样式
            Font[] fonts = new Font[]
            {
                new Font("宋体", r.Next(20, 60), (FontStyle)(r.Next(3))),
                new Font("隶书", r.Next(20, 60), (FontStyle)(r.Next(3))),
                new Font("华文楷体", r.Next(20, 60), (FontStyle)(r.Next(3))),
                new Font("黑体", r.Next(20, 60), (FontStyle)(r.Next(3))),
                new Font("微软雅黑", r.Next(20, 60), (FontStyle)(r.Next(3)))
            };
            //颜色
            Color[] colors = new Color[] { Color.Yellow, Color.Blue, Color.Green, Color.Pink, Color.OrangeRed };
            //为每一个字符设置样式
            for (int i = 0; i < str.Length; i++)
            {
                //字体间隔
                Point p = new Point(i * (bmp.Width / str.Length), 0);
                g.DrawString(str[i].ToString(), fonts[r.Next(5)], new SolidBrush(colors[r.Next(5)]), p);
            }
            //加线条
            for (int i = 0; i < bmp.Height / 2; i++)
            {
                Point p1 = new Point(r.Next(bmp.Width), r.Next(bmp.Height));
                Point p2 = new Point(r.Next(bmp.Width), r.Next(bmp.Height));
                g.DrawLine(new Pen(Color.YellowGreen), p1, p2);
            }
            //加像素点
            for (int i = 0; i < bmp.Width * 10; i++)
            {
                bmp.SetPixel(r.Next(bmp.Width), r.Next(bmp.Height), Color.Black);
            }
            pictureBox1.Image = bmp;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
