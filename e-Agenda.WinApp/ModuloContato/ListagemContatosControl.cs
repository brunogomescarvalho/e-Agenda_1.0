using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda.WinApp.ModuloContato
{
    public partial class ListagemContatosControl : UserControl
    {
        public ListagemContatosControl()
        {
            InitializeComponent();
        }

        public void AtualizarLista(List<Contato> contatos)
        {
            listContatos.Items.Clear();

            contatos.ForEach(i => listContatos.Items.Add(i));
        }

        public Contato ObterContatoSelecionado()
        {
            return (Contato)listContatos.SelectedItem;
        }
    }
}
