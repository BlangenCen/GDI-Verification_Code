using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 作业画圆
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics vx = this.CreateGraphics();
            //v1-v2
            vx.DrawArc(Pens.Black, 200, 200, 100, 100, 0, 360);
            //v1-v3
            vx.DrawArc(Pens.Blue, 210, 210, 80, 80, 0, 360);
            //在v1上取点，v2-v3
            vx.DrawArc(Pens.Red, 120, 170, 160, 160, 0, 360);
            //v1-v4
            vx.DrawArc(Pens.Green, 205, 205, 90, 90, 0, 360);
        }
    }
}
