
namespace e_Agenda.WinApp
{
    public class Configuracao
    {
      
        public string ToolTipInserir { get; }

        public string ToolTipEditar { get; }

        public string ToolTipExcluir { get; }

        public string ToolTipoFiltrar { get; }

        public bool BtnFiltrarEnabled { get; }

        public bool BtnAdicionarEnabled { get; }

        public bool BtnEditarEnabled { get; }

        public bool BtnExcluirEnabled { get; }

        public bool BtnAddItemTarefaEnabled { get; }

        public bool BtnAtualizarTarefaEnabled { get; }

        public string ToolTipAdicionarItemTarefa { get; }

        public string ToolTipAtualizarTarefa { get; }

        public string StatusLabel { get; }

        public Configuracao(
                            string statusLabel,

                            string toolTipInserir,
                            string toolTipEditar,
                            string toolTipExcluir,

                            string toolTipoFiltrar,

                            string btnAddItemTarefaToolTipText,
                            string btnAtualizarTarefaToolTipText,

                            bool btnFiltrarEnabled,

                            bool btnAddItemTarefaEnabled,
                            bool btnAtualizarTarefaEnabled

                         )
        {
            StatusLabel = statusLabel;

            ToolTipInserir = toolTipInserir;
            ToolTipEditar = toolTipEditar;
            ToolTipExcluir = toolTipExcluir;

            ToolTipoFiltrar = toolTipoFiltrar;

            ToolTipAdicionarItemTarefa = btnAddItemTarefaToolTipText;
            ToolTipAtualizarTarefa = btnAtualizarTarefaToolTipText;

            BtnFiltrarEnabled = btnFiltrarEnabled;

            BtnAddItemTarefaEnabled = btnAddItemTarefaEnabled;
            BtnAtualizarTarefaEnabled = btnAtualizarTarefaEnabled;

            BtnAdicionarEnabled = true;
            BtnEditarEnabled = true;
            BtnExcluirEnabled = true;

        }
    }
}
