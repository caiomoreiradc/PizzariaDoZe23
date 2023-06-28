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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PizzariaDoZe
{
    public partial class FormPedidos : Form
    {
        private readonly ClienteDAO clienteDAO;
        private readonly SaborDAO saborDAO;
        private readonly ProdutoDAO produtoDAO;
        private readonly PedidoDAO pedidoDAO;
        public FormPedidos()
        {
            this.ControlBox = false; //REMOVE BOTÕES DE MINIZAR E FECHAR
            InitializeComponent();
            userBotoes.buttonSalvar.Click += ButtonSalvar_Click;
            userBotoes.buttonEditar.Click += buttonEditar_Click;
            userBotoes.buttonExcluir.Click += buttonExcluir_Click;
            userBotoes.buttonSair.Click += buttonSair_Click;

            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            saborDAO = new SaborDAO(provider, strConnection);
            clienteDAO = new ClienteDAO(provider, strConnection);
            produtoDAO = new ProdutoDAO(provider, strConnection);
            pedidoDAO = new PedidoDAO(provider, strConnection);

            maskedCPF.Leave += maskedCPF_Leave;
            AtualizarTela();

        }

        private void AtualizarTela()
        {
            //Instância e Preenche o objeto com os dados da view
            var pedido = new Pedidos();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = pedidoDAO.Buscar(pedido);
                // seta o datasouce do dataGridView com os dados retornados
                dataGridViewDados.Columns.Clear();
                dataGridViewDados.AutoGenerateColumns = true;
                dataGridViewDados.DataSource = linhas;
                dataGridViewDados.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ButtonSalvar_Click(object? sender, EventArgs e)
        {

            //Instância e Preenche o objeto com os dados da view
            var pedido = new Pedidos
            {
                // Id = 0,
                ClienteId = Convert.ToInt32(textBoxIdCliente.Text),
                ClienteNome = textBoxNome.Text,
                ClienteCpf = Convert.ToString(maskedCPF.Text),
                ClienteEmail = textBoxEmail.Text,
                FuncionarioId = Convert.ToInt32(textBoxIdFuncionario.Text),
                Data = Convert.ToString(DateTime.Now),
                ValorTotal = GerarValorTotal(),
                StatusPedido = cmbStatus.SelectedItem.ToString(),
                FormaPagamento = cmbPagamento.SelectedItem.ToString(),
            };
            try
            {
                // chama o método da model para inserir e capturar o ID do cliente
                int IdClienteGerado = pedidoDAO.Inserir(pedido);
                MessageBox.Show("Dados inseridos com sucesso! " + IdClienteGerado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (textBoxIdCliente.Text.Length <= 0 || txtIdPedido.Text.Length <= 0)
            {
                MessageBox.Show("Selecione um Pedido valido!");
                return;
            }
            //Instância e Preenche o objeto com os dados da view
            var pedido = new Pedidos
            {
                Id = int.Parse(txtIdPedido.Text),
                ClienteId = int.Parse(textBoxIdCliente.Text),
                ClienteNome = textBoxNome.Text,
                ClienteCpf = maskedCPF.Text,
                ClienteEmail = textBoxEmail.Text,
                FuncionarioId = int.Parse(textBoxIdFuncionario.Text),
                Data = Convert.ToString(DateTime.Now),
                ValorTotal = GerarValorTotal(),
                StatusPedido = cmbStatus.SelectedItem.ToString(),
                FormaPagamento = cmbPagamento.SelectedItem.ToString(),
            };
            try
            {
                // chama o método da model para editar
                pedidoDAO.Editar(pedido);
                MessageBox.Show("Dados editados com sucesso! " + txtIdPedido.Text);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonExcluir_Click(object? sender, EventArgs e)
        {
            if (txtIdPedido.Text.Length <= 0)
            {
                MessageBox.Show("Selecione um Pedido!");
                return;
            }
            //Instância e Preenche o objeto com os dados da view
            var pedido = new Pedidos
            {
                Id = int.Parse(txtIdPedido.Text),
            };
            try
            {
                // chama o método da model para excluir
                pedidoDAO.Excluir(pedido);
                MessageBox.Show("Dados excluidos com sucesso! " + txtIdPedido.Text);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonSair_Click(object? sender, EventArgs e)
        {
            Close();
        }
        private void maskedCPF_Leave(object sender, EventArgs e)
        {
            if (maskedCPF.Text.Trim().Length <= 0)
            {
                return;
            }
            var cliente = new Cliente
            {
                Cpf = maskedCPF.Text.Trim(),
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = clienteDAO.Buscar(cliente);
                // seta os dados na tela
                textBoxIdCliente.Text = "";
                textBoxNome.Text = "";
                textBoxEmail.Text = "";
                maskedTelefone.Text = "";
                foreach (DataRow row in linhas.Rows)
                {
                    textBoxIdCliente.Text = row["id"].ToString(); ;
                    textBoxNome.Text = row["nome"].ToString(); ;
                    maskedCPF.Text = row["cpf"].ToString(); ;
                    textBoxEmail.Text = row["e-mail"].ToString(); ;
                    maskedTelefone.Text = row["telefone"].ToString(); ;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pizzaria do Zé", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int GerarValorTotal()
        {
            return 100;
        }
        private void dataGridViewDados_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridViewDados.SelectedCells.Count > 0)
            {
                //pega a primeira coluna, que esta com o ID, da linha selecionada
                DataGridViewRow selectedRow = dataGridViewDados.Rows[dataGridViewDados.SelectedCells[0].RowIndex];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                AtualizaTelaEditar(id);
            }
        }
        private void AtualizaTelaEditar(int id)
        {
            //Instância e Preenche o objeto com os dados da view
            var pedido = new Pedidos
            {
                Id = id,
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = pedidoDAO.Buscar(pedido);
                // seta os dados na tela
                foreach (DataRow row in linhas.Rows)
                {
                    txtIdPedido.Text = row[0].ToString();
                    textBoxIdCliente.Text = row[1].ToString();
                    textBoxNome.Text = row[2].ToString();
                    maskedCPF.Text = row[3].ToString();
                    textBoxEmail.Text = row[4].ToString();
                    textBoxIdFuncionario.Text = row[5].ToString();
                    txtValorTotal.Text = row[7].ToString();
                    cmbPagamento.Text = row[8].ToString();
                    cmbStatus.Text = row[9].ToString();
                }
                textBoxNome.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void botaoVisualizarCadastros_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void botaoVisualizarCadastros_Click(object sender, EventArgs e)
        {
            FormVisualizarClientes visuCli = new FormVisualizarClientes();
            visuCli.StartPosition = FormStartPosition.CenterScreen;
            visuCli.Show();
        }

        private void btnPdfComp_Click(object sender, EventArgs e)
        {
            string pathArquivo = ClassGeraPdf.pathArquivo("RelPedidos");
            ClassGeraPdf.PdfSabor(pathArquivo, 0);
        }

        private void btnPdfSelecionado_Click(object sender, EventArgs e)
        {
            if (dataGridViewDados.SelectedCells.Count <= 0)
            {
                MessageBox.Show("Selecione um item!");
                return;
            }
            //pega a primeira coluna, que esta com o ID, da linha selecionada
            DataGridViewRow selectedRow = dataGridViewDados.Rows[dataGridViewDados.SelectedCells[0].RowIndex];
            int id = Convert.ToInt32(selectedRow.Cells[0].Value);
            string pathArquivo = ClassGeraPdf.pathArquivo("RelPedido");
            ClassGeraPdf.PdfSabor(pathArquivo, id);
        }
    }
}
