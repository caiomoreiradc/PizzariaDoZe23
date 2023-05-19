using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using PizzariaDoZe.DAO;
using System.Configuration;

namespace PizzariaDoZe
{
    public partial class FormVisualizarIngredientes : Form
    {
        private IngredienteDAO ingredienteDAO;
        public FormVisualizarIngredientes()
        {
            InitializeComponent();
            this.ControlBox = false; //REMOVE BOTÕES DE MINIMIZAR E FECHAR

            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            ingredienteDAO = new IngredienteDAO(provider, strConnection);

            Funcoes.EventoFocoCampos(this);

            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
        }

        private void AtualizarTela()
        {
            //Instância e Preenche o objeto com os dados da view
            var ingrediente = new Ingrediente();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = ingredienteDAO.Buscar(ingrediente);
                // seta o datasouce do dataGridView com os dados retornados
                dataGridViewIng.Columns.Clear();
                dataGridViewIng.AutoGenerateColumns = true;
                dataGridViewIng.DataSource = linhas;
                dataGridViewIng.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormVisualizarIngredientes_Load(object sender, EventArgs e)
        {
            AtualizarTela();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
