namespace e_Agenda.WinApp.ModuloTarefa
{
    public class Item
    {
        private string Descricao { get; set; }

        public bool Concluido { get; private set; }

        public Item(string descricao)
        {
            Descricao = descricao;
            Concluido = false;
        }

        public void ConcluirItem()
        {
            Concluido = true;
        }


        public override string ToString()
        {
            return $"{Descricao,-15} {(Concluido? "Concluído": "Não Concluído")}";
        }

    }
}
