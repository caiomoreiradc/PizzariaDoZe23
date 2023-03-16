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
    }
}