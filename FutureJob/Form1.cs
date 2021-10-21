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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            cadastro telacad = new cadastro();
            telacad.Show();
            this.Hide();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            {
                if (txtEmail.Text == "etecentrar@gmail.com" && txtSenha.Text == "12345")

                {
                    home telahom = new home();
                    telahom.Show();
                    this.Hide();

                    MessageBox.Show("Seja bem vindo consagrado!!");
                }

                else

                {
                    MessageBox.Show("Vc não é bem vindo");
                }
               
            }
        }
    }
}
