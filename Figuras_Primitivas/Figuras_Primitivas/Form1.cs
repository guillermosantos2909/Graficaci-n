using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras_Primitivas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics obj = CreateGraphics();
            Pen pen = new Pen(Color.Aqua, 8);
            obj.DrawLine(pen, 100, 150, 200, 200);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics obj = this.CreateGraphics();
            Pen pen = new Pen(Color.BlueViolet, 5);
            obj.DrawRectangle(pen, 600, 150, 100, 100);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics obj = this.CreateGraphics();
            Pen pen = new Pen(Color.Green, 3);
            obj.DrawEllipse(pen, 350, 150, 100, 100);
        }
    }
}
