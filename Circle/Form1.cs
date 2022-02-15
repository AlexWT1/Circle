using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double r, s, l;


        private void button1_Click(object sender, EventArgs e)
        {
            r = Convert.ToDouble(textBox1.Text);
            s = Math.Ceiling(r * r * Math.PI);
            label2.Text = Convert.ToString(s);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            r = Convert.ToDouble(textBox1.Text);
            l = Math.Ceiling(2 * Math.PI * r);
            label3.Text = Convert.ToString(l);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label2.Text = null;
            label3.Text = null;
        }
    }
}
