using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.DAO
{
    public class PedidoDAO
    {

        private readonly DbProviderFactory factory;
        private string Provider { get; set; }
        private string StringConexao { get; set; }
        public PedidoDAO(string provider, string stringConexao)
        {
            Provider = provider;
            StringConexao = stringConexao;
            factory = DbProviderFactories.GetFactory(Provider);
        }

        public int Inserir(Pedidos pedidos)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //Adiciona parâmetro (@campo e valor)
            var idCliente = comando.CreateParameter(); idCliente.ParameterName = "@idCliente";
            idCliente.Value = pedidos.ClienteId; comando.Parameters.Add(idCliente);    
            
            var nomeCliente = comando.CreateParameter(); nomeCliente.ParameterName = "@nomeCliente";
            nomeCliente.Value = pedidos.ClienteNome; comando.Parameters.Add(nomeCliente); 
            
            var cpfCliente = comando.CreateParameter(); cpfCliente.ParameterName = "@cpfCliente";
            cpfCliente.Value = pedidos.ClienteCpf; comando.Parameters.Add(cpfCliente);     
            
            var emailCliente = comando.CreateParameter(); emailCliente.ParameterName = "@emailCliente";
            emailCliente.Value = pedidos.ClienteEmail; comando.Parameters.Add(emailCliente);      
            
            var idFuncionario = comando.CreateParameter(); idFuncionario.ParameterName = "@idFuncionario";
            idFuncionario.Value = pedidos.FuncionarioId; comando.Parameters.Add(idFuncionario);

            var data = comando.CreateParameter(); data.ParameterName = "@data";
            data.Value = pedidos.Data; comando.Parameters.Add(data);

            var valorTotal = comando.CreateParameter(); valorTotal.ParameterName = "@valorTotal";
            valorTotal.Value = pedidos.ValorTotal; comando.Parameters.Add(valorTotal);      
            
            var formaPagamento = comando.CreateParameter(); formaPagamento.ParameterName = "@formaPagamento";
            formaPagamento.Value = pedidos.FormaPagamento; comando.Parameters.Add(formaPagamento);

            var statusPedido = comando.CreateParameter(); statusPedido.ParameterName = "@statusPedido";
            statusPedido.Value = pedidos.StatusPedido; comando.Parameters.Add(statusPedido);

            conexao.Open();
            //ajusta o comando SQL para capturar o ID gerado tanto do MySQL como do SQLServer
            string auxSQL_ID = Provider.Contains("MySql") ? "SELECT LAST_INSERT_ID();" : "SELECT SCOPE_IDENTITY();";
            //realiza o INSERT e retorna o ID gerado, algo que vai ser necessário na sequencia
            comando.CommandText = @"INSERT INTO tb_pedidos (cliente_id, cliente_nome, cliente_cpf, cliente_email, funcionario_id, data_pedido, valor_total,forma_pagamento, status_pedido)
        VALUES(@idCliente, @nomeCliente, @cpfCliente, @emailCliente, @idFuncionario, @data, @valorTotal, @formaPagamento, @statusPedido);" + auxSQL_ID;
            //executa o comando no banco de dados e captura o ID gerado
            var IdGerado = comando.ExecuteScalar();
            return Convert.ToInt32(IdGerado);
        }
        public void Editar(Pedidos pedidos)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //Adiciona parâmetro (@campo e valor)
            var idCliente = comando.CreateParameter(); idCliente.ParameterName = "@idCliente";
            idCliente.Value = pedidos.ClienteId; comando.Parameters.Add(idCliente);

            var nomeCliente = comando.CreateParameter(); nomeCliente.ParameterName = "@nomeCliente";
            nomeCliente.Value = pedidos.ClienteNome; comando.Parameters.Add(nomeCliente);

            var cpfCliente = comando.CreateParameter(); cpfCliente.ParameterName = "@cpfCliente";
            cpfCliente.Value = pedidos.ClienteCpf; comando.Parameters.Add(cpfCliente);

            var emailCliente = comando.CreateParameter(); emailCliente.ParameterName = "@emailCliente";
            emailCliente.Value = pedidos.ClienteEmail; comando.Parameters.Add(emailCliente);

            var idFuncionario = comando.CreateParameter(); idFuncionario.ParameterName = "@idFuncionario";
            idFuncionario.Value = pedidos.FuncionarioId; comando.Parameters.Add(idFuncionario);

            var data = comando.CreateParameter(); data.ParameterName = "@data";
            data.Value = pedidos.Data; comando.Parameters.Add(data);

            var valorTotal = comando.CreateParameter(); valorTotal.ParameterName = "@valorTotal";
            valorTotal.Value = pedidos.ValorTotal; comando.Parameters.Add(valorTotal);

            var formaPagamento = comando.CreateParameter(); formaPagamento.ParameterName = "@formaPagamento";
            formaPagamento.Value = pedidos.FormaPagamento; comando.Parameters.Add(formaPagamento);

            var statusPedido = comando.CreateParameter(); statusPedido.ParameterName = "@statusPedido";
            statusPedido.Value = pedidos.StatusPedido; comando.Parameters.Add(statusPedido);

            conexao.Open();
            //realiza o UPDATE
            comando.CommandText = @"UPDATE tb_pedidos SET " +
            "cliente_id = @idCliente, " +
            "cliente_nome = @nomeCliente, " +
            "cliente_cpf = @cpfCliente, " +
            "cliente_email = @emailCliente, " +
            "data_pedido = @data, " +
            "valor_total = @valorTotal, " +
            "forma_pagamento = @formaPagamento, " +
            "status_pedido = @statusPedido " +
            "WHERE cliente_cpf = @cpfCliente;";
            comando.ExecuteNonQuery();

            //executa o comando no banco de dados
        }
        public void Excluir(Pedidos pedidos)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //Adiciona parâmetro (@campo e valor)
            var id = comando.CreateParameter();
            id.ParameterName = "@id";
            id.Value = pedidos.Id;
            comando.Parameters.Add(id);
            conexao.Open();
            //realiza o DELETE
            comando.CommandText = @"DELETE FROM tb_pedidos WHERE id_pedido = @id;";
            //executa o comando no banco de dados
            _ = comando.ExecuteNonQuery();
        }
        public DataTable Buscar(Pedidos pedido)
        {
            using var conexao = factory.CreateConnection(); // Cria conexão
            conexao.ConnectionString = StringConexao; // Atribui a string de conexão
            using var comando = factory.CreateCommand(); // Cria comando
            comando.Connection = conexao; // Atribui conexão

            // Verifica se tem filtro e personaliza o SQL do filtro
            string auxSqlFiltro = "";
            if (pedido.Id > 0)
            {
                auxSqlFiltro = "WHERE pdd.id_pedido = " + pedido.Id + " ";
            }

            conexao.Open();
            comando.CommandText = @"
        SELECT pdd.id_pedido AS IDPedido, pdd.cliente_id AS IDCliente, pdd.cliente_nome AS NomeCliente, pdd.cliente_cpf AS CpfCliente, pdd.cliente_email AS EmailCliente, pdd.funcionario_id AS IDFuncionario, pdd.data_pedido AS Data, pdd.valor_total AS 'Valor', pdd.forma_pagamento AS 'Pagamento', pdd.status_pedido AS Pedidos
        FROM tb_pedidos AS pdd
        INNER JOIN tb_clientes AS cc ON pdd.cliente_id = cc.id_cliente
        INNER JOIN tb_funcionarios AS f ON pdd.funcionario_id = f.id_funcionario
        " + auxSqlFiltro + @"
        ORDER BY pdd.id_pedido;
    ";

            // Executa o script na conexão e retorna as linhas afetadas
            var sdr = comando.ExecuteReader();
            DataTable linhas = new();
            linhas.Load(sdr);
            return linhas;
        }



    }
}
