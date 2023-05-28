﻿using e_Agenda.WinApp.Modulo_Despesa;

namespace e_Agenda.WinApp.ModuloCategoria
{
    public partial class TelaVisualizarPorCategoria : Form
    {
        public TelaVisualizarPorCategoria(List<Despesa> lista)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            AtualizarLista(lista);
        }

        private void AtualizarLista(List<Despesa> lista)
        {
            listDespesas.Items.Clear();

            lista.ForEach(item => { listDespesas.Items.Add(item);});
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
