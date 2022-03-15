using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buttons_expo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            label.Text = "Funcion MouseClick";
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            label.Text = "Funcion MouseDown";
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Blue;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor= Color.Green;
        }

        private void button4_MouseUp(object sender, MouseEventArgs e)
        {
            label.Text = "Boton Mouse up";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            button5.BackColor = Color.Red;
        }

        private void button6_KeyPress(object sender, KeyPressEventArgs e)
        {
            label.Text = "Boton KeyPress";
        }
    }
}
