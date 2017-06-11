using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mensagem = "Objetivo e que você consiga realizar atividades em um prazo curto e que mantenha a qualidade ao terminá-la.";
            string titulo = "Parabéns";
            MessageBoxButtons botao = MessageBoxButtons.OK;

            DialogResult resultado = MessageBox.Show(mensagem, titulo, botao);

            if (resultado == DialogResult.OK)
            {
                var tela = new Form3();
                tela.ShowDialog();
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mensagem = "Descreva os atividades de acordo com o que está sendo pedido na tela";
            string titulo = "Tente novamente";
            MessageBoxButtons botao = MessageBoxButtons.OK;

            DialogResult resultado = MessageBox.Show(mensagem, titulo, botao);
        }
    }
}
