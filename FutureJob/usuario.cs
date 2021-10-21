using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutureJob
{
    public partial class usuario : Form
    {
        public usuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chat telacha = new chat();
            telacha.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pesquisa telapes = new pesquisa();
            telapes.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            home telahom = new home();
            telahom.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            postar telapos = new postar();
            telapos.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 telafor = new Form1();
            telafor.Show();
            this.Hide();
        }
    }
}
