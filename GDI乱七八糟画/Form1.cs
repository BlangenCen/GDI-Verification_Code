using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI乱七八糟画
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pen = Pens.Black;
            Size size = new Size(20, 20);
            Point p = new Point(size);
            Rectangle r = new Rectangle(p, size);
            g.DrawRectangle(pen, r);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Brushes.Cyan, 20);
            g.DrawPie(pen, new RectangleF(60, 60, 60, 60), 60, 60);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.DrawString("卢本伟牛逼", new Font("宋体", 20, FontStyle.Bold), Brushes.CadetBlue, new Point(150, 20));
        }
    }
}
