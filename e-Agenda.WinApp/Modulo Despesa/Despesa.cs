using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_Agenda.WinApp.ModuloCategoria;

namespace e_Agenda.WinApp.Modulo_Despesa
{
    public class Despesa : EntidadeBase<Despesa>
    {
        public string Descricao { get; set; }

        public decimal Valor { get; set; }

        public DateTime Data { get; set; }

        public FormaDePagamento FormaDePagamento { get; set; }

        public List<Categoria> Categorias { get; set; }

        public Despesa(string descricao, decimal valor, DateTime data, FormaDePagamento formaDePagamento)
        {
            Categorias = new List<Categoria>();
            Descricao = descricao;
            Valor = valor;
            Data = data;
            FormaDePagamento = formaDePagamento;
        }

        public override void Editar(Despesa entidade)
        {
            throw new NotImplementedException();
        }

        public override string[] Validar()
        {
            List<string> erros = new();

            if (Categorias.Count == 0)
                erros.Add("É necessário incluir uma categoria");

            else if (Descricao.Trim() == string.Empty)
                erros.Add("É necessário incluir a descrição");

            else if (Valor <= 0)
                erros.Add("O valor precisa ser número positivo");

            else if (Data == default || Data.ToString() == string.Empty)
                erros.Add("è necessário incluir a data da despesa");

            else if ((int)FormaDePagamento == -1)
                erros.Add("è necessário incluir a forma de pagamento");

            return erros.ToArray();
        }
    }

    public enum FormaDePagamento
    {
        Cartao_Credito,
        Cartao_Debito,
        Dinheiro
    }
}
