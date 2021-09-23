using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText("C:\\Users\\Qasim\\Desktop\\list.txt", textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String Q;
            Q = System.IO.File.ReadAllText("C:\\Users\\Qasim\\Desktop\\list.txt");
            textBox1.Text = Q;

        }

        private void New(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void Fontchange(object sender, EventArgs e)
        {
            Font z;
            fontDialog1.ShowDialog();
            z = fontDialog1.Font;
            textBox1.Font = z;
        }

        private void Backcolorchange(object sender, EventArgs e)
        {
            Color x;
            colorDialog1.ShowDialog();
            x = colorDialog1.Color;
            textBox1.BackColor = x;
        }

        private void Font_color_chnage(object sender, EventArgs e)
        {
            Color c;
            colorDialog1.ShowDialog();
            c = colorDialog1.Color;
            textBox1.ForeColor = c;
        }
    }
}
