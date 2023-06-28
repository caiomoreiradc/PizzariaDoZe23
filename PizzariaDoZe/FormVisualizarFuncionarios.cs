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
using System.Configuration;
using PizzariaDoZe.DAO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PizzariaDoZe
{
    public partial class FormVisualizarFuncionarios : Form
    {
        private FuncionarioDAO funcionarioDAO;
        private FormFuncionarios formFuncionarios = new FormFuncionarios();


        public FormVisualizarFuncionarios()
        {
            InitializeComponent();

            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;

            // cria a instancia da classe da model
            funcionarioDAO = new FuncionarioDAO(provider, strConnection);
            dataGridViewDados.CellFormatting += dataGridViewDados_CellFormatting;
            AtualizarTela();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
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

        private void dataGridViewDados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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

        public void AtualizaTelaEditar(int id)
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
                    formFuncionarios.textBoxIdFunci.Text = row[0].ToString();
                    formFuncionarios.textBoxNome.Text = row[1].ToString();
                    formFuncionarios.maskedCPF.Text = row[2].ToString();
                    formFuncionarios.textBoxMatricula.Text = row[3].ToString();
                    formFuncionarios.maskedSenha.Text = row[4].ToString();
                    if (row[5].ToString().Equals("1"))
                    {
                        formFuncionarios.radioButtonGrupoAdmin.Checked = true;
                    }
                    else if (row[5].ToString().Equals("2"))
                    {
                        formFuncionarios.radioButtonGrupoAtendente.Checked = true;
                    }
                    else
                    {
                        formFuncionarios.radioButtonGrupoEntregador.Checked = true;
                    }
                    formFuncionarios.textBoxCNH.Text = row[6].ToString();
                    formFuncionarios.dateTimePickerValidade.Text = row[7].ToString();
                    formFuncionarios.textBoxObservacoes.Text = row[8].ToString();
                    formFuncionarios.maskedTelefone.Text = row[9].ToString();
                    formFuncionarios.textBoxEmail.Text = row[10].ToString();
                    formFuncionarios.textBoxId.Text = row[11].ToString();
                    formFuncionarios.maskedCEP.Text = row[12].ToString();
                    formFuncionarios.textBoxLogradouro.Text = row[13].ToString();
                    formFuncionarios.textBoxCidade.Text = row[14].ToString();
                    formFuncionarios.comboBoxUF.Text = row[15].ToString();
                    formFuncionarios.textBoxPais.Text = row[16].ToString();
                    //textBoxComplemento.Text = row[22].ToString();
                }
                formFuncionarios.textBoxNome.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
