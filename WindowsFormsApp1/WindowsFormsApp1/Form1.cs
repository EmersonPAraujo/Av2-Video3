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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mensagem = "Agora você terá mais tempo livre para se dedicar as atividades principais do seu dia.";
            string titulo = "Parabéns";
            MessageBoxButtons botao = MessageBoxButtons.OK;

            DialogResult resultado = MessageBox.Show(mensagem, titulo,botao);

            if (resultado == DialogResult.OK)
            {
                var tela = new Form2();
                tela.ShowDialog();
                Close();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mensagem = "Elabore uma lista com as atividades e defina as atividades principais para poder continuar com as dicas.";
            string titulo = "Tente Novamente";
            MessageBoxButtons botao = MessageBoxButtons.OK;

            DialogResult resultado = MessageBox.Show(mensagem, titulo, botao);

            //if (resultado == DialogResult.OK)
            //{
                
            //}
        }
    }
}
