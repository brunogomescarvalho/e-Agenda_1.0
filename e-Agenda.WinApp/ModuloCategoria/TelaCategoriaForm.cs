﻿
using e_Agenda.Dominio.ModuloCategoria;
using FluentResults;

namespace e_Agenda.WinApp.ModuloCategoria
{
    public partial class TelaCategoriaForm : Form
    {

        public onGravarRegistro<Categoria> onGravarRegistro;

        private Categoria categoria = null!;

        public Categoria Categoria
        {
            get => categoria;
            set
            {
                textId.Text = value.Id.ToString();
                textCategoria.Text = value.Nome;
            }
        }

        public TelaCategoriaForm()
        {
            InitializeComponent();

            this.ConfigurarDialog();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string idStr = textId.Text;
            string nome = textCategoria.Text;

            int id = idStr == string.Empty ? 0 : Convert.ToInt32(idStr);

            categoria = new Categoria(nome);

            if (id > 0)
            {
                categoria.AtribuirId(id);
            }

            Result result = onGravarRegistro(categoria);

            if (result.IsFailed)
            {
                TelaPrincipal.Instancia.AlterarTextRodape(result.Errors[0].Message);
                DialogResult = DialogResult.None;
            }
        }
    }
}
