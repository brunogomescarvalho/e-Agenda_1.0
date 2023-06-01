using e_Agenda.WinApp.ModuloCategoria;

namespace e_Agenda.WinApp.ModuloDespesa
{
    [Serializable]
    public class Despesa : EntidadeBase<Despesa>
    {
        public string Descricao { get;  set; }

        public decimal Valor { get;  set; }

        public DateTime Data { get;  set; }

        public FormaDePagamento FormaDePagamento { get;  set; }

        public List<Categoria> Categorias { get;  set; }

        public Despesa() { }

        public Despesa(string descricao, decimal valor, DateTime data, FormaDePagamento formaDePagamento,List<Categoria> categorias)
        {
            Categorias = categorias;
            Descricao = descricao;
            Valor = valor;
            Data = data;
            FormaDePagamento = formaDePagamento;
        }

        public override void Editar(Despesa entidade)
        {
            Categorias = entidade.Categorias;
            Descricao = entidade.Descricao;
            Valor = entidade.Valor;
            Data = entidade.Data;
            FormaDePagamento = entidade.FormaDePagamento;
        }

        public override string[] Validar()
        {
            List<string> erros = new();

            if (Categorias.Count == 0)
                erros.Add("É necessário incluir uma categoria.");

            else if (Descricao.Trim() == string.Empty)
                erros.Add("É necessário incluir a descrição.");

            else if (Valor <= 0)
                erros.Add("O valor precisa ser número positivo.");

            else if (Data == default || Data.ToString() == string.Empty)
                erros.Add("è necessário incluir a data da despesa.");

            else if (FormaDePagamento == FormaDePagamento.Nenhum)
                erros.Add("É necessário incluir a forma de pagamento.");

            return erros.ToArray();
        }

        public override string ToString()
        {
            return String.Format($"Id: {Id}, {Descricao}, R${Valor}, {Data:d}, {string.Join(" - ",Categorias)}");
        }
    }

    public enum FormaDePagamento
    {
        Nenhum,
        Cartao_Credito,
        Cartao_Debito,
        Dinheiro
    }
}
