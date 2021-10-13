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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            pesquisa telapes = new pesquisa();
            telapes.Show();
            this.Hide();
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            chat telacha = new chat();
            telacha.Show();
            this.Hide();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            usuario telausu = new usuario();
            telausu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuario telausu = new usuario();
            telausu.Show();
            this.Hide();
        }
    }
}
