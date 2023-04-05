using System.Globalization;

namespace PizzariaDoZe
{
    public partial class paginaInicial : Form
    {
        public paginaInicial()
        {
            InitializeComponent();

            #region idioma/região interface - satellite assembly
            // com base no idioma/região escolhido pelo usuário,
            // ajusta as propriedades dos componentes da tela com base no conteúdo do arquivo
            //resources
            Funcoes.AjustaResourcesControl(this);
            //ajuste manual de campos ou mensagens para o usuário que não puderam ser
            //automatizadas acima
            this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            formConfiguracoes configuracoes = new formConfiguracoes();
            configuracoes.StartPosition = FormStartPosition.CenterScreen;
            configuracoes.Show();
        }
    }
}