﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PizzariaDoZe.DAO;

namespace PizzariaDoZe
{
    public partial class FormVisualizarEnderecos : Form
    {
        private readonly EnderecoDAO enderecoDAO;
        public FormVisualizarEnderecos()
        {
            InitializeComponent();
            this.ControlBox = false;

            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            enderecoDAO = new EnderecoDAO(provider, strConnection);
            AtualizarTela();


            Funcoes.EventoFocoCampos(this);

            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
        }

        private void FormVisualizarEnderecos_Load(object sender, EventArgs e)
        {
        }
        private void AtualizarTela()
        {
            //Instância e Preenche o objeto com os dados da view
            var endereco = new Endereco();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = enderecoDAO.Buscar(endereco);
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

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
