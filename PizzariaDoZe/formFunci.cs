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
            userControl.buttonSair.Click += buttonSair_Click; //BOTAO SAIR

            Funcoes.EventoFocoCampos(this);

            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);


            #region idioma/região interface - satellite assembly
            // com base no idioma/região escolhido pelo usuário,
            // ajusta as propriedades dos componentes da tela com base no conteúdo do arquivo
            //resources
            //ajuste manual de campos ou mensagens para o usuário que não puderam ser
            //automatizadas acima
            this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion
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
            funcionarioEndereco.StartPosition = FormStartPosition.CenterScreen;
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

        private void textBoxCod_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelFunci1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void formFunci_Load(object sender, EventArgs e)
        {

        }
    }
}
