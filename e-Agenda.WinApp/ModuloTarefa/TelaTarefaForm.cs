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
    public partial class TelaTarefaForm : Form
    {
        public TelaTarefaForm()
        {
            InitializeComponent();
        }

        private Tarefa? tarefa;

        public Tarefa Tarefa
        {
            get => tarefa!;
            set => textDescricao.Text = value.Titulo.ToString();
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string descricao = textDescricao.Text;

            string prioridadeStr = comboPrioridade.Text;

            Prioridade prioridade = Prioridade.Normal;

            switch (prioridadeStr)
            {
                case "Alta": prioridade = Prioridade.Alta; break;
                case "Baixa": prioridade = Prioridade.Baixa; break;
                case "Normal": prioridade = Prioridade.Normal; break;
            }

            tarefa = new Tarefa(prioridade, descricao);
        }
    }
}
