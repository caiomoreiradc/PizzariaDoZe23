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
    public partial class formProdutos : Form
    {
        private ProdutoDAO produtoDAO;
        public formProdutos()
        {
            InitializeComponent();
            this.ControlBox = false; //REMOVE BOTÕES DE MINIZAR E FECHAR
            userControl.buttonSair.Click += buttonSair_Click; //BOTAO SAIR
            userControl.buttonSalvar.Click += buttonSalvar_Click; //BOTAO SALVAR

            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
            Funcoes.EventoFocoCampos(this);

            CarregaEnumListBox();

            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection =
            ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            produtoDAO = new ProdutoDAO(provider, strConnection);

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
            var produto = new Produto
            {
                Id = 0,
                Descricao = textBoxNome.Text,
                Valor = decimal.Parse(textBoxValor.Text),
                Tipo = (char)(EnumProdutoTipo)Enum.Parse(typeof(EnumProdutoTipo), listBoxTipo.Text),
                ML = listBoxMl.Text,
            };
            try
            {
                // chama o método para inserir da camada model
                produtoDAO.Inserir(produto);
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
            listBoxTipo.Items.Clear();
            listBoxTipo.DataSource = Enum.GetValues(typeof(EnumProdutoTipo));
        }
        public void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void formProdutos_Load(object sender, EventArgs e)
        {

        }

        private void formProdutos_Load_1(object sender, EventArgs e)
        {

        }

        private void botaoVisualizarCadastros_Click(object sender, EventArgs e)
        {
            FormVisualizarProdutos visuProd = new FormVisualizarProdutos();
            visuProd.StartPosition = FormStartPosition.CenterScreen;
            visuProd.Show();
        }
    }
}
