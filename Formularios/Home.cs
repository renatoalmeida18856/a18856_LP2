using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class Infecao : Form
    {
        public Infecao()
        {
            InitializeComponent();
        }

        private void Infecao_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("button1 was clicked");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("button1 was clicked");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("button1 was clicked");
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void userControl11_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            userControl11.BringToFront();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //.BringToFront();
        }
    }
}
