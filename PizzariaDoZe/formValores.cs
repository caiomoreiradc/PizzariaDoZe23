using PizzariaDoZe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe
{
    public partial class formValores : Form
    {
        private ValorDAO valorDAO;
        public formValores()
        {
            InitializeComponent();
            this.ControlBox = false; //REMOVE BOTÕES DE MINIZAR E FECHAR
            userControl.buttonSair.Click += buttonSair_Click;
            userControl.buttonSalvar.Click += buttonSalvar_Click;
            Funcoes.EventoFocoCampos(this);

            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);

            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection =
            ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            valorDAO = new ValorDAO(provider, strConnection);

            CarregaEnumListBox();
            #region idioma/região interface - satellite assembly
            // com base no idioma/região escolhido pelo usuário,
            // ajusta as propriedades dos componentes da tela com base no conteúdo do arquivo
            //resources
            //ajuste manual de campos ou mensagens para o usuário que não puderam ser
            //automatizadas acima
            this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion
        }

        private void buttonSalvar_Click(object? sender, EventArgs e)
        {

            //Instância e Preenche o objeto com os dados da view
            var valor = new Valor
            {
                Id = 0,
                Tamanho = (char)(EnumValorTamanho)Enum.Parse(typeof(EnumValorTamanho), listBoxTamanho.Text),
                Categoria = (char)(EnumSaborCategoria)Enum.Parse(typeof(EnumSaborCategoria), listBoxCategoria.Text),
                ValorPizza = decimal.Parse(maskedTextValor.Text),
                ValorBorda = decimal.Parse(textBoxValorBorda.Text),
            };
            try
            {
                // chama o método para inserir da camada model
                valorDAO.Inserir(valor);
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CarregaEnumListBox()
        {
            //popular listBoxTipo
            listBoxTamanho.Items.Clear();
            listBoxTamanho.DataSource = Enum.GetValues(typeof(EnumValorTamanho));
            //popular listBoxCategoria
            listBoxCategoria.Items.Clear();
            listBoxCategoria.DataSource = Enum.GetValues(typeof(EnumSaborCategoria));
        }

        public void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void formValores_Load(object sender, EventArgs e)
        {

        }

        private void labelValorBorda_Click(object sender, EventArgs e)
        {

        }

        private void botaoVisualizarCadastros_Click(object sender, EventArgs e)
        {
            FormVisualizarValores visuVal = new FormVisualizarValores();
            visuVal.StartPosition = FormStartPosition.CenterScreen;
            visuVal.Show();
        }
    }
}
