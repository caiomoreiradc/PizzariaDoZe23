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
    public partial class formFunci : Form
    {
        private readonly EnderecoDAO enderecoDAO;
        private readonly FuncionarioDAO funcionarioDAO;
        public formFunci()
        {
            InitializeComponent();
            this.ControlBox = false; //REMOVE BOTÕES DE MINIZAR E FECHAR
            userControl.buttonSair.Click += buttonSair_Click; //BOTAO SAIR
            userControl.buttonSalvar.Click += buttonSalvar_Click;
            Funcoes.EventoFocoCampos(this);

            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);

            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            enderecoDAO = new EnderecoDAO(provider, strConnection);
            funcionarioDAO = new FuncionarioDAO(provider, strConnection);

            maskedCEP.Leave += maskedCEP_Leave;

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

        public void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text.Length <= 0)
            {
                MessageBox.Show("Selecione um endereço valido!");
                return;
            }
            //Instância e Preenche o objeto com os dados da view
            var funcionario = new Funcionario
            {
                //Id = 0,
                Nome = textBoxNome.Text,
                Cpf = maskedCPF.Text,
                Matricula = textBoxMatricula.Text,
                Senha = Funcoes.Sha256Hash(maskedSenha.Text),
                Grupo = (radioButtonGrupoAdmin.Checked) ? '1' : (radioButtonGrupoAtendente.Checked) ? '2' : (radioButtonGrupoEntregador.Checked) ? '3' : '0',
                Motorista = textBoxCNH.Text,
                Validade = dateTimePickerValidade.Value,
                Observacao = textBoxObservacoes.Text,
                Telefone = maskedTelefone.Text,
                Email = textBoxEmail.Text,
                EnderecoId = int.Parse(textBoxId.Text),
                Complemento = textBoxComplemento.Text,
            };
            try
            {
                // chama o método da model para inserir e capturar o ID do cliente
                int IdFuncionarioGerado = funcionarioDAO.Inserir(funcionario);
                MessageBox.Show("Dados inseridos com sucesso! " + IdFuncionarioGerado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBoxCod_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelFunci1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void formFunci_Load(object sender, EventArgs e)
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
                //userControlEndereco.maskedTextBoxCep.Text = "";
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
            FormVisualizarFuncionarios visuFunci = new FormVisualizarFuncionarios();
            visuFunci.StartPosition = FormStartPosition.CenterScreen;
            visuFunci.Show();
        }

        private void buttonVisualizarEndereços_Click(object sender, EventArgs e)
        {
            FormVisualizarEnderecos visuEnd = new FormVisualizarEnderecos();
            visuEnd.StartPosition = FormStartPosition.CenterScreen;
            visuEnd.Show();
        }
    }
}
