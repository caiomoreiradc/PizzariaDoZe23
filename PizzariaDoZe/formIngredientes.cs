using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PizzariaDoZe.DAO;
using System.Configuration;

namespace PizzariaDoZe
{
    public partial class formIngredientes : Form
    {
        private readonly IngredienteDAO dao;
        public formIngredientes()
        {

            InitializeComponent();
            this.ControlBox = false; //REMOVE BOTÕES DE MINIMIZAR E FECHAR

            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            dao = new IngredienteDAO(provider, strConnection);

            userControl.buttonSalvar.Click += buttonSalvar_Click;
            //operacoes.buttonEditar.Click += buttonEditar_Click;
            //operacoes.buttonExcluir.Click += buttonExcluir_Click;
            userControl.buttonSair.Click += buttonSair_Click;

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

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var ingrediente = new Ingrediente
            {
                Codigo = 0,
                Nome = textBoxNome.Text,
            };
            try
            {
                // chama o método para inserir da camada model
                dao.Inserir(ingrediente);
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void formIngredientes_Load(object sender, EventArgs e)
        {

        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void botaoVisualizarCadastros_Click(object sender, EventArgs e)
        {
            FormVisualizarIngredientes visuIng = new FormVisualizarIngredientes();
            visuIng.StartPosition = FormStartPosition.CenterScreen;
            visuIng.Show();
        }
    }
}
