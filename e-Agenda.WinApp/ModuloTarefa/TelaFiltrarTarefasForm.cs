using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class TelaFiltrarTarefasForm : Form
    {
        private TipoDeBusca tipoDeBusca = TipoDeBusca.todas;

        public TelaFiltrarTarefasForm()
        {
            InitializeComponent();
            CriarEventosRadioBtn();
        }

        public void CriarEventosRadioBtn()
        {
            foreach (RadioButton item in panelOpcoes.Controls)
            {
                item.CheckedChanged += Item_CheckedChanged;
            }
        }

        private void Item_CheckedChanged(object? sender, EventArgs e)
        {
            RadioButton btn = (RadioButton)sender!;

            if (btn.Checked)
            {
                switch (btn.Tag)
                {
                    case "todas":tipoDeBusca = TipoDeBusca.todas;break;
                    case "pendentes":tipoDeBusca=TipoDeBusca.pendentes;break;
                    case "concluidas":tipoDeBusca = TipoDeBusca.concluidas;break;
                }
            }
        }

        public TipoDeBusca ObterOpcao()
        {
            return tipoDeBusca;
        }

        public enum TipoDeBusca
        {
            todas, concluidas, pendentes
        }

    }
}
