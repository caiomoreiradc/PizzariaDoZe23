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
    public partial class FormFuncionarios : Form
    {
        private readonly EnderecoDAO enderecoDAO;
        private readonly FuncionarioDAO funcionarioDAO;

        public FormFuncionarios()
        {
            InitializeComponent();

            this.ControlBox = false; //REMOVE BOTÕES DE MINIZAR E FECHAR
            userControl.buttonSair.Click += buttonSair_Click; //BOTAO SAIR
            userControl.buttonSalvar.Click += buttonSalvar_Click;
            userControl.buttonEditar.Click += buttonEditar_Click;
            userControl.buttonExcluir.Click += buttonExcluir_Click;
            Funcoes.EventoFocoCampos(this);

            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);

            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            enderecoDAO = new EnderecoDAO(provider, strConnection);
            funcionarioDAO = new FuncionarioDAO(provider, strConnection);

            maskedCEP.Leave += maskedCEP_Leave;

            //DATAGRID
            dataGridViewDados.CellFormatting += dataGridViewDados_CellFormatting;
            AtualizarTela();

            #region idioma/região interface - satellite assembly
            // com base no idioma/região escolhido pelo usuário,
            // ajusta as propriedades dos componentes da tela com base no conteúdo do arquivo
            //resources
            //ajuste manual de campos ou mensagens para o usuário que não puderam ser
            //automatizadas acima
            this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion
        }

        private void AtualizarTela()
        {
            //Instância e Preenche o objeto com os dados da view
            var funcionario = new Funcionario();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = funcionarioDAO.Buscar(funcionario);
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
        private void dataGridViewDados_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == this.dataGridViewDados.NewRowIndex || e.Value.ToString().Trim().Length == 0)
            {
                return;
            }
            //if (this.dataGridViewDados.Columns[e.ColumnIndex].Name.Equals("Grupo"))
            //{
            //    e.Value =  EnumExtensions.GetDescription((EnumFuncionarioGrupo)int.Parse(e.Value.ToString()));
            //}
            //else if (this.dataGridViewDados.Columns[e.ColumnIndex].Name.Equals("CPF"))
            //{
            //    long value = long.Parse(e.Value.ToString().Replace(" ", ""));
            //    e.Value = string.Format(@"{0:000\.000\.000\-00}", value);
            //}
            //else if (this.dataGridViewDados.Columns[e.ColumnIndex].Name.Equals("CEP"))
            //{
            //    long value = long.Parse(e.Value.ToString().Replace(" ", ""));
            //    e.Value = string.Format(@"{0:00\.000\-000}", value);
            //}
            //else if (this.dataGridViewDados.Columns[e.ColumnIndex].Name.Equals("Telefone"))
            //{
            //    long value = long.Parse(e.Value.ToString().Replace(" ", ""));
            //    e.Value = string.Format(@"{0:(00) 00000\-0000}", value);
            //}
            else if (this.dataGridViewDados.Columns[e.ColumnIndex].Name.Equals("Valor"))
            {
                // formata valor numérico com duas casa decimais
                double d = double.Parse(e.Value.ToString());
                e.Value = d.ToString("N2");
            }
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
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (textBoxIdFunci.Text.Length <= 0 || textBoxIdFunci.Text.Length <= 0)
            {
                MessageBox.Show("Selecione um funcionário e endereço valido!");
                return;
            }
            //Instância e Preenche o objeto com os dados da view
            var funcionario = new Funcionario
            {
                Id = int.Parse(textBoxIdFunci.Text),
                Nome = textBoxNome.Text,
                Cpf = maskedCPF.Text,
                Matricula = textBoxMatricula.Text,
                Senha = Funcoes.Sha256Hash(maskedSenha.Text),
                Grupo = (radioButtonGrupoAdmin.Checked) ? '1' : (radioButtonGrupoAtendente.Checked) ? '2' : '3',
                Motorista = textBoxCNH.Text,
                Validade = dateTimePickerValidade.Value,
                Observacao = textBoxObservacoes.Text,
                Telefone = maskedTelefone.Text,
                Email = textBoxEmail.Text,
                EnderecoId = int.Parse(textBoxId.Text),
            };
            try
            {
                // chama o método da model para editar
                funcionarioDAO.Editar(funcionario);
                MessageBox.Show("Dados editados com sucesso! " + textBoxIdFunci.Text);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void buttonExcluir_Click(object? sender, EventArgs e)
        {
            if (textBoxIdFunci.Text.Length <= 0)
            {
                MessageBox.Show("Selecione um funcionário!");
                return;
            }
            //Instância e Preenche o objeto com os dados da view
            var funcionario = new Funcionario
            {
                Id = int.Parse(textBoxIdFunci.Text),
            };
            try
            {
                // chama o método da model para excluir
                funcionarioDAO.Excluir(funcionario);
                MessageBox.Show("Dados excluidos com sucesso! " + textBoxIdFunci.Text);
                this.Close();
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
            var funcionario = new Funcionario
            {
                Id = id,
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = funcionarioDAO.Buscar(funcionario);
                // seta os dados na tela
                foreach (DataRow row in linhas.Rows)
                {
                    textBoxIdFunci.Text = row[0].ToString();
                    textBoxNome.Text = row[1].ToString();
                    maskedCPF.Text = row[2].ToString();
                    textBoxMatricula.Text = row[3].ToString();
                    maskedSenha.Text = row[4].ToString();
                    if (row[5].ToString().Equals("1"))
                    {
                        radioButtonGrupoAdmin.Checked = true;
                    }
                    else if (row[5].ToString().Equals("2"))
                    {
                        radioButtonGrupoAtendente.Checked = true;
                    }
                    else
                    {
                        radioButtonGrupoEntregador.Checked = true;
                    }
                    textBoxCNH.Text = row[6].ToString();
                    dateTimePickerValidade.Text = row[7].ToString();
                    textBoxObservacoes.Text = row[8].ToString();
                    maskedTelefone.Text = row[9].ToString();
                    textBoxEmail.Text = row[10].ToString();
                    textBoxId.Text = row[11].ToString();
                    maskedCEP.Text = row[12].ToString();
                    textBoxLogradouro.Text = row[13].ToString();
                    textBoxCidade.Text = row[14].ToString();
                    comboBoxUF.Text = row[15].ToString();
                    textBoxPais.Text = row[16].ToString();
                    //textBoxComplemento.Text = row[22].ToString();
                }
                textBoxNome.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewDados_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.RowIndex == this.dataGridViewDados.NewRowIndex || e.Value.ToString().Trim().Length == 0)
            {
                return;
            }
            if (this.dataGridViewDados.Columns[e.ColumnIndex].Name.Equals("Grupo"))
            {
                e.Value = EnumExtensions.GetDescription((EnumFuncionarioGrupo)int.Parse(e.Value.ToString()));
            }
            //else if (this.dataGridViewDados.Columns[e.ColumnIndex].Name.Equals("CPF"))
            //{
            //    long value = long.Parse(e.Value.ToString().Replace(" ", ""));
            //    e.Value = string.Format(@"{0:000\.000\.000\-00}", value);
            //}
            //else if (this.dataGridViewDados.Columns[e.ColumnIndex].Name.Equals("CEP"))
            //{
            //    long value = long.Parse(e.Value.ToString().Replace(" ", ""));
            //    e.Value = string.Format(@"{0:00\.000\-000}", value);
            //}
            //else if (this.dataGridViewDados.Columns[e.ColumnIndex].Name.Equals("Telefone"))
            //{
            //    long value = long.Parse(e.Value.ToString().Replace(" ", ""));
            //    e.Value = string.Format(@"{0:(00) 00000\-0000}", value);
            //}
            else if (this.dataGridViewDados.Columns[e.ColumnIndex].Name.Equals("Valor"))
            {
                // formata valor numérico com duas casa decimais
                double d = double.Parse(e.Value.ToString());
                e.Value = d.ToString("N2");
            }

        }
    }
}
