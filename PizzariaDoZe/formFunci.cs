using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe
{
    public partial class formFunci : Form
    {
        public formFunci()
        {
            InitializeComponent();
            this.ControlBox = false; //REMOVE BOTÕES DE MINIZAR E FECHAR
            userControl11.buttonSair.Click += buttonSair_Click; //BOTAO SAIR
        }

        public void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void botaoEnderecoFunci_Click(object sender, EventArgs e)
        {
            formFunciEndereco funcionarioEndereco = new formFunciEndereco();
            funcionarioEndereco.StartPosition = FormStartPosition.CenterParent;
            funcionarioEndereco.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
