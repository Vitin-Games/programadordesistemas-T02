using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mAR5CADO
{
    public partial class frmMercado : Form
    {
        public frmMercado()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            {
                // Pega o nome do produto e converte para minúsculo para facilitar a busca
                string produto = txtProdutos.Text.ToLower().Trim();
                int quantidade = 0;

                // 1. Define a quantidade baseada no nome digitado
                if (produto == "pao")
                {
                    quantidade = 50;
                }
                else if (produto == "cafe")
                {
                    quantidade = 5;
                }
                else if (produto == "leite")
                {
                    quantidade = 0;
                }
                else if (produto == "ovos")
                {
                    quantidade = 12;
                }
                else
                {
                    MessageBox.Show("Produto não cadastrado!");
                    return; // Sai do código se não achar o produto
                }

                // 2. Exibe a quantidade no primeiro label
                lblQuantidade.Text = " " + quantidade;

                // 3. Verifica o status do estoque no segundo label
                if (quantidade >= 10)
                {
                    lblStatus.Text = "SUFICIENTE";
                    lblStatus.ForeColor = Color.Green;
                }
                else if (quantidade > 0)
                {
                    lblStatus.Text = "BAIXO (Repor em breve)";
                    lblStatus.ForeColor = Color.Orange;
                }
                else
                {
                    lblStatus.Text = "FALTA (Urgente)";
                    lblStatus.ForeColor = Color.Red;
                }
            }
        }
    }
}
