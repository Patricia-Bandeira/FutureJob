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
    public partial class chat : Form
    {
        public chat()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            usuario telausu = new usuario();
            telausu.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            usuario telausu = new usuario();
            telausu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pesquisa telapes = new pesquisa();
            telapes.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            home telahom = new home();
            telahom.Show();
            this.Hide();
        }
    }
}
