namespace PizzariaDoZe
{
    public partial class paginaInicial : Form
    {
        public paginaInicial()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formClientes clientes = new formClientes();
            clientes.StartPosition = FormStartPosition.CenterParent;
            clientes.Show();
        }

        private void botaoFuncionarios_Click(object sender, EventArgs e)
        {
            formFunci funcionarios = new formFunci();
            funcionarios.StartPosition = FormStartPosition.CenterParent;
            funcionarios.Show();
        }

        private void botaoIngredientes_Click(object sender, EventArgs e)
        {
            formIngredientes ingredientes = new formIngredientes();
            ingredientes.StartPosition = FormStartPosition.CenterParent;
            ingredientes.Show();
        }

        private void botaoSabores_Click(object sender, EventArgs e)
        {
            formSabores sabores = new formSabores();
            sabores.StartPosition = FormStartPosition.CenterParent;
            sabores.Show();
        }
    }
}