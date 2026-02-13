using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alertas
{
    public partial class Aletas : Form
    {
        public Aletas()
        {
            InitializeComponent();
        }

        private void btnalertasimples_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Essa é uma mensagem simples");
        }

        private void btnalertarobusto_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Vamos programar um sistema? ",
                                                     "Título aqui",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                MessageBox.Show("Respondeu que sim!");
            }
            else
            {
                MessageBox.Show("Respondeu que não!");
            }
        }
    }
}
