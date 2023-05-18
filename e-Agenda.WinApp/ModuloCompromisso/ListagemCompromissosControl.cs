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

        string opcao = "";

        List<Compromisso> compromissos = null!;


        public ListaCompromissosControl()
        {
            InitializeComponent();
            AdicionarEventoAlterarRadio();


        }

        public void AtualizarListagem(List<Compromisso> compromissos)
        {
            this.compromissos = compromissos;

            listCompromissos.Items.Clear();

         compromissos.ForEach(comp => { listCompromissos.Items.Add(comp); });
        }

        public Compromisso ObterCompromissoSelecionado()
        {
            return (Compromisso)listCompromissos.SelectedItem;
        }


        private List<Compromisso> Filtrar(List<Compromisso> lista)
        {
            if (opcao == "Todos")
            {
                return lista;
            }
            else if (opcao == "Passado")
            {
                return lista.FindAll(i => i.Data < DateTime.Now.Date);
            }
            else if (opcao == "Próximos")
            {
                return lista.FindAll(i => i.Data > DateTime.Now.Date);
            }
            else if (opcao == "Hoje")
            {
                return lista.FindAll(i => i.Data == DateTime.Now.Date);
            }
            else
                return lista!;
        }


        public void AdicionarEventoAlterarRadio()

        {
            foreach (var item in radiosPanel.Controls)
            {
                if (item is RadioButton radioBtn)
                {
                    radioBtn.CheckedChanged += radiosBtn_CheckedChanged!;
                }
            }
        }
        private void radiosBtn_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
            {
                opcao = radioButton.Text;

                var listaFiltrada = Filtrar(this.compromissos);

                AtualizarListagem(listaFiltrada);
            }
        }
    }
}
