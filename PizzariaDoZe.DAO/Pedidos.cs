using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.DAO
{
    public class Pedidos
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public string ClienteNome { get; set; }
        public string ClienteCpf { get; set; }
        public string ClienteEmail { get; set; }
        public int FuncionarioId { get; set; }
        public string Data { get; set; }
        public int ValorTotal { get; set; }
        public string StatusPedido { get; set; }
        public string FormaPagamento { get; set; }

        public Pedidos(int id = 0, int clienteId = 0, string clienteNome = "",string clienteCpf = "",string clienteEmail = "", int funcionarioId = 0, string data = "", int valorTotal = 0,
        string statusPedido = "", string formaPagamento = "")
        {
            Id = id;
            ClienteId = clienteId;
            FuncionarioId = funcionarioId;
            ClienteNome = clienteNome;
            ClienteCpf = clienteCpf;
            ClienteEmail = clienteEmail;
            Data = data;
            ValorTotal = valorTotal;
            StatusPedido = statusPedido;
            FormaPagamento = formaPagamento;
        }
    }
}
