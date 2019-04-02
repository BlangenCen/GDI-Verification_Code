using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI画直线
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics gdi = this.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            Point p1 = new Point(Convert.ToInt32(txtP1X.Text), Convert.ToInt32(txtP1Y.Text));
            Point p2 = new Point(Convert.ToInt32(txtP2X.Text), Convert.ToInt32(txtP2Y.Text));
            gdi.DrawLine(pen, p1, p2);
        }

        int i = 0;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            lblI.Text = i++.ToString();
            Graphics gdi = this.CreateGraphics();
            Pen pen = new Pen(Brushes.Red);
            Point p1 = new Point(Convert.ToInt32(txtP1X.Text), Convert.ToInt32(txtP1Y.Text));
            Point p2 = new Point(Convert.ToInt32(txtP2X.Text), Convert.ToInt32(txtP2Y.Text));
            gdi.DrawLine(pen, p1, p2);
        }
    }
}
