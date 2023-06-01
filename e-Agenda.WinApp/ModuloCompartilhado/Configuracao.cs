namespace e_Agenda.WinApp.ModuloCompartilhado
{
    public class Configuracao
    {

        public string ToolTipInserir { get; private set; }
        public string ToolTipEditar { get; private set; }
        public string ToolTipExcluir { get; private set; }
        public string StatusLabel { get; private set; } = string.Empty;

        public string ToolTipAdicionarItemTarefa { get; set; } = string.Empty;
        public string ToolTipAtualizarTarefa { get; set; } = string.Empty;
        public string ToolTipoFiltrar { get; set; } = string.Empty;

        public bool BtnFiltrarEnabled { get; set; }
        public bool BtnAdicionarEnabled { get; set; }
        public bool BtnEditarEnabled { get; set; }
        public bool BtnExcluirEnabled { get; set; }
        public bool BtnAddItemTarefaEnabled { get; set; }
        public bool BtnAtualizarTarefaEnabled { get; set; }
        public bool BtnVisualizarEnabled { get; set; }



        public Configuracao(string toolTipInserir, string toolTipEditar, string toolTipExcluir)
        {
            ToolTipInserir = toolTipInserir;
            ToolTipEditar = toolTipEditar;
            ToolTipExcluir = toolTipExcluir;

            BtnAdicionarEnabled = true;
            BtnEditarEnabled = true;
            BtnExcluirEnabled = true;

        }
    }
}
