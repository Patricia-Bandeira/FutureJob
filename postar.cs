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
    public partial class postar : Form
    {
        public postar()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            usuario telausu = new usuario();
            telausu.Show();
            this.Hide();
        }
    }
}
