using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Display_Copied_Item
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = Clipboard.GetText();
            pictureBox1.Image = Clipboard.GetImage();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                textBox1.Text = Clipboard.GetText();
                textBox1.SelectedText = "";
            }
            else textBox1.Text = "There is no copied text";

            pictureBox1.Image = Clipboard.GetImage();

            if (pictureBox1.Image == null)
            {
                label1.Visible = true;
            }
            else label1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.textBox1, textBox1.Text);
        }
    }
}
