﻿using System.Data;
using System.Data.Common;
namespace PizzariaDoZe.DAO;
public class IngredienteDAO
{
    /// Utilização de mais do que um provider com o mesmo script (MySQL, SQLServer, Firebird...)
    private readonly DbProviderFactory factory;
    private string Provider { get; set; }
    private string StringConexao { get; set; }
    public IngredienteDAO(string provider, string stringConexao)
    {
        Provider = provider;
        StringConexao = stringConexao;
        factory = DbProviderFactories.GetFactory(Provider);
    }

    public void Inserir(Ingrediente ingrediente)
    {
        using var conexao = factory.CreateConnection(); //Cria conexão
        conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
        using var comando = factory.CreateCommand(); //Cria comando
        comando!.Connection = conexao; //Atribui conexão
                                       //Adiciona parâmetro (@campo e valor)
        var nome = comando.CreateParameter();
        nome.ParameterName = "@nome";
        nome.Value = ingrediente.Nome;
        comando.Parameters.Add(nome);
        conexao.Open();
        comando.CommandText = @"INSERT INTO cad_ingredientes(nome_ingrediente) VALUES (@nome)";
        //Executa o script na conexão e retorna o número de linhas afetadas.
        var linhas = comando.ExecuteNonQuery();
        //using faz o Close() automático quando fecha o seu escopo
    }

    public DataTable Buscar(Ingrediente ingrediente)
    {
        using var conexao = factory.CreateConnection(); //Cria conexão
        conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
        using var comando = factory.CreateCommand(); //Cria comando
        comando!.Connection = conexao; //Atribui conexão
                                       //verifica se tem filtro e personaliza o SQL do filtro
        string auxSqlFiltro = "";
        if (ingrediente.Id > 0)
        {
            auxSqlFiltro = "WHERE i.id_ingrediente = " + ingrediente.Id + " ";
        }
        else if (ingrediente.Nome.Length > 0)
        {
            auxSqlFiltro = "WHERE i.nome_ingrediente like '%" + ingrediente.Nome + "%' ";
        }
        conexao.Open();
        comando.CommandText = @" " +
        "SELECT i.id_ingrediente AS ID, i.nome_ingrediente AS Nome " +
        "FROM cad_ingredientes AS i " +
        auxSqlFiltro +
        "ORDER BY i.nome_ingrediente;";
        //Executa o script na conexão e retorna as linhas afetadas.
        var sdr = comando.ExecuteReader();
        DataTable linhas = new();
        linhas.Load(sdr);
        return linhas;
    }
}