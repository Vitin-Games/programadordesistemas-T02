using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string CalTotal;
        int num1;
        int num2;
        string option;
        int result;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPrimeiroNumero_Click(object sender, EventArgs e)
        {
            txtTela.Text = txtTela.Text + "1";
        }

        private void btnSegundoNumero_Click(object sender, EventArgs e)
        {
            txtTela.Text = txtTela.Text + "2";
        }

        private void btnTerceiroNumero_Click(object sender, EventArgs e)
        {
            txtTela.Text = txtTela.Text + "3";
        }

        private void btnQuartoNumero_Click(object sender, EventArgs e)
        {
            txtTela.Text = txtTela.Text + "4";
        }

        private void btnQuintoNumero_Click(object sender, EventArgs e)
        {
            txtTela.Text = txtTela.Text + "5";
        }

        private void btnSextoNumero_Click(object sender, EventArgs e)
        {
            txtTela.Text = txtTela.Text + "6";
        }

        private void btnSetimoNumero_Click(object sender, EventArgs e)
        {
            txtTela.Text = txtTela.Text + "7";
        }

        private void btnOitavoNumero_Click(object sender, EventArgs e)
        {
            txtTela.Text = txtTela.Text + "8";
        }

        private void btnNonoNumero_Click(object sender, EventArgs e)
        {
            txtTela.Text = txtTela.Text + "9";
        }

        private void btnNumeroZero_Click(object sender, EventArgs e)
        {
            txtTela.Text = txtTela.Text + "0";
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            txtTela.Text = txtTela.Text + ".";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(txtTela.Text);

            txtTela.Clear();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(txtTela.Text);

            txtTela.Clear();
        }

        private void btnMutiplicação_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(txtTela.Text);

            txtTela.Clear();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(txtTela.Text);

            txtTela.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(txtTela.Text);

            if (option.Equals("+"))
                result = num1 + num2;

            if (option.Equals("-"))
                result = num1 - num2;

            if (option.Equals("*"))
                result = num1 * num2;

            if (option.Equals("/"))
                result = num1 / num2;

            txtTela.Text = result + "";
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            txtTela.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }
    }
}
