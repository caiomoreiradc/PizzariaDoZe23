using System.Configuration;
using System.Data.Common;
using System.Globalization;

namespace PizzariaDoZe
{
    public partial class paginaInicial : Form
    {
        public paginaInicial()
        {
            InitializeComponent();

            ValidaConexaoDB();
            Funcoes.EventoFocoCampos(this);

            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
            cadastroDeFuncionáriosToolStripMenuItem.Click += new EventHandler(botaoFuncionarios_Click);
            cadastroDeClientesToolStripMenuItem.Click += new EventHandler(botaoClientes_Click);
            cadastroDeSaboresToolStripMenuItem.Click += new EventHandler(botaoSabores_Click);
            cadastroDeProdutosToolStripMenuItem.Click += new EventHandler(botaoProdutos_Click);
            cadastroDeValoresToolStripMenuItem.Click += new EventHandler(botaoValores_Click);
            cadastroDeIngredientesToolStripMenuItem.Click += new EventHandler(botaoIngredientes_Click);
            configuraçõesToolStripMenuItem.Click += new EventHandler(botaoConfigurações_Click);
            #region idioma/região interface - satellite assembly
            // com base no idioma/região escolhido pelo usuário,
            // ajusta as propriedades dos componentes da tela com base no conteúdo do arquivo
            //resources
            Funcoes.AjustaResourcesControl(contextMenuStrip);
            //ajuste manual de campos ou mensagens para o usuário que não puderam ser
            //automatizadas acima
            this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion
        }

        private void NotifyIconSystemTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            WindowState = FormWindowState.Normal;
            notifyIconSystemTray.Visible = false;
        }
        private void formInicial_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIconSystemTray.Visible = true;
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIconSystemTray.Visible = false;
            }

        }
        private void botaoClientes_Click(object sender, EventArgs e)
        {
            formClientes clientes = new formClientes();
            clientes.StartPosition = FormStartPosition.CenterScreen;
            clientes.Show();
        }

        private void botaoFuncionarios_Click(object sender, EventArgs e)
        {
            formFunci funcionarios = new formFunci();
            funcionarios.StartPosition = FormStartPosition.CenterScreen;
            funcionarios.Show();
        }

        private void botaoIngredientes_Click(object sender, EventArgs e)
        {
            formIngredientes ingredientes = new formIngredientes();
            ingredientes.StartPosition = FormStartPosition.CenterScreen;
            ingredientes.Show();
        }

        private void botaoSabores_Click(object sender, EventArgs e)
        {
            formSabores sabores = new formSabores();
            sabores.StartPosition = FormStartPosition.CenterScreen;
            sabores.Show();
        }

        private void Titulo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void paginaInicial_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelTitulo_Click(object sender, EventArgs e)
        {

        }

        private void botaoValores_Click(object sender, EventArgs e)
        {
            formValores valores = new formValores();
            valores.StartPosition = FormStartPosition.CenterScreen;
            valores.Show();
        }

        private void botaoProdutos_Click(object sender, EventArgs e)
        {
            formProdutos produtos = new formProdutos();
            produtos.StartPosition = FormStartPosition.CenterScreen;
            produtos.Show();
        }

        private void buttonPTBR_Click(object sender, EventArgs e)
        {

        }

        private void botaoConfigurações_Click(object sender, EventArgs e)
        {
            formConfiguracoes configuracoes = new formConfiguracoes();
            configuracoes.StartPosition = FormStartPosition.CenterScreen;
            configuracoes.Show();
        }

        private void cadastroDeSaboresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void contextMenuStripSystemTray_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        public static void ValidaConexaoDB()
        {
            DbProviderFactory factory;
            try
            {
                factory = DbProviderFactories.GetFactory(ConfigurationManager.ConnectionStrings["BD"].ProviderName);
                using var conexao = factory.CreateConnection();
                conexao!.ConnectionString = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
                using var comando = factory.CreateCommand();
                comando!.Connection = conexao;
                conexao.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                new formConfiguracoes().ShowDialog();
                ValidaConexaoDB();
            }
        }
    }
}