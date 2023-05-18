using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public partial class ListaCompromissosControl : UserControl
    {

      
        public ListaCompromissosControl(List<Compromisso> lista)
        {
            InitializeComponent();

          
        }

        public void AtualizarListagem(List<Compromisso> compromissos)
        {
            listCompromissos.Items.Clear();

            compromissos.ForEach(comp => { listCompromissos.Items.Add(comp); });
        }

        public Compromisso ObterCompromissoSelecionado()
        {
            return (Compromisso)listCompromissos.SelectedItem;
        }



       
    }
}
