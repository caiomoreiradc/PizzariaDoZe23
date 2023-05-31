using PizzariaDoZe.DAO;
using PizzariaDoZe.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe
{
    public partial class formClientes : Form
    {
        private readonly EnderecoDAO enderecoDAO;
        private readonly ClienteDAO clienteDAO;
        public formClientes()
        {
            //UserControl1 operacoes = new();
            InitializeComponent();
            this.ControlBox = false; //REMOVE BOTÕES DE MINIZAR E FECHAR

            userControl.buttonSair.Click += buttonSair_Click;
            userControl.buttonSalvar.Click += ButtonSalvar_Click;

            Funcoes.EventoFocoCampos(this);

            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);

            //operacoes.Dock = DockStyle.Top;
            //Controls.Add(operacoes);
            //operacoes.buttonSalvar.Click += ButtonSalvar_Click;
            //operacoes.buttonEditar.Click += ButtonEditar_Click;
            //operacoes.buttonExcluir.Click += ButtonExcluir_Click;
            //operacoes.buttonSair.Click += ButtonSair_Click;
            #region idioma/região interface - satellite assembly
            // com base no idioma/região escolhido pelo usuário,
            // ajusta as propriedades dos componentes da tela com base no conteúdo do arquivo
            //resources
            //ajuste manual de campos ou mensagens para o usuário que não puderam ser
            //automatizadas acima
            this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion

            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            enderecoDAO = new EnderecoDAO(provider, strConnection);
            clienteDAO = new ClienteDAO(provider, strConnection);

            maskedCEP.Leave += maskedCEP_Leave;
        }
        private void buttonSair_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private void ButtonSair_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonExcluir_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonEditar_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonSalvar_Click(object? sender, EventArgs e)
        {
            if (textBoxId.Text.Length <= 0)
            {
                MessageBox.Show("Selecione um endereço valido!");
                return;
            }
            //Instância e Preenche o objeto com os dados da view
            var cliente = new Cliente
            {
               // Id = 0,
                Nome = textBoxNome.Text,
                Cpf = maskedCPF.Text,
                Telefone = maskedTelefone.Text,
                Email = textBoxEmail.Text,
                EnderecoId = int.Parse(textBoxId.Text),
                Complemento = textBoxComplemento.Text,
            };
            try
            {
                // chama o método da model para inserir e capturar o ID do cliente
                int IdClienteGerado = clienteDAO.Inserir(cliente);
                MessageBox.Show("Dados inseridos com sucesso! " + IdClienteGerado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void formClientes_Load(object sender, EventArgs e)
        {

        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelNome_Click(object sender, EventArgs e)
        {

        }

        private void labelTelefone_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedCEP_Leave(object sender, EventArgs e)
        {
            if (maskedCEP.Text.Trim().Length <= 0)
            {
                return;
            }
            var endereco = new Endereco
            {
                Cep = maskedCEP.Text.Trim(),
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = enderecoDAO.Buscar(endereco);
                // seta os dados na tela
                textBoxId.Text = "";
                //userControlEndereco.maskedCEP.Text = "";
                textBoxLogradouro.Text = "";
                //textBoxBairro.Text = "";
                textBoxCidade.Text = "";
                comboBoxUF.Text = "";
                textBoxPais.Text = "";
                foreach (DataRow row in linhas.Rows)
                {
                    textBoxId.Text = row["id"].ToString(); ;
                    maskedCEP.Text = row["cep"].ToString(); ;
                    textBoxLogradouro.Text = row["logradouro"].ToString(); ;
                    //textBoxBairro.Text = row["bairro"].ToString(); ;
                    textBoxCidade.Text = row["cidade"].ToString(); ;
                    comboBoxUF.Text = row["uf"].ToString(); ;
                    textBoxPais.Text = row["pais"].ToString(); ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pizzaria do Zé", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void botaoVisualizarCadastros_Click(object sender, EventArgs e)
        {
            FormVisualizarClientes visuCli = new FormVisualizarClientes();
            visuCli.StartPosition = FormStartPosition.CenterScreen;
            visuCli.Show();
        }

        private void buttonVisualizarEndereços_Click(object sender, EventArgs e)
        {
            FormVisualizarEnderecos visuEnd = new FormVisualizarEnderecos();
            visuEnd.StartPosition = FormStartPosition.CenterScreen;
            visuEnd.Show();
        }
    }
}
