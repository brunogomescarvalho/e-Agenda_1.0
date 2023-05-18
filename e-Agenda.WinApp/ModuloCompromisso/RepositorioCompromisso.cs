using e_Agenda.WinApp.ModuloCompartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public class RepositorioCompromisso : RepositorioBase<Compromisso>
    {
        public RepositorioCompromisso(List<Compromisso> registros) : base(registros)
        {
            IniciarCompromissos();

        }

       

        public bool VerificarHorario(Compromisso c)
        {
            var compromissosDoDia = registros.FindAll(i => i.Data == c.Data);

            var ocupado = compromissosDoDia.FindAll(i => i.HoraInicio >= c.HoraInicio && i.HoraInicio <=c.HoraTermino || 
            i.HoraTermino >=c.HoraInicio && i.HoraTermino <=c.HoraTermino); 

            return !ocupado.Any();

        }


        private void IniciarCompromissos()
        {
            var listCompromissos = new List<Compromisso> {
            new Compromisso(null, "Implementar Nova solução", "Centro de Tecnologia", DateTime.Now.AddDays(-5), new DateTime(1,1,1, 10, 30,00), new DateTime(1,1,1, 11, 30, 00)),
            new Compromisso(null, "Reunião de equipe", "Sala de conferências", DateTime.Now.AddDays(-4), new DateTime(1,1,1, 11, 30, 00), new DateTime(1,1,1, 12, 00, 00)),
            new Compromisso(null, "Treinamento de vendas", "Auditório principal", DateTime.Now.AddDays(-3), new DateTime(1,1,1, 10, 30, 00), new DateTime(1,1,1, 11, 30, 00)),
            new Compromisso(null, "Entrevista de emprego", "Centro de Tecnologia Sala 3B", DateTime.Now.AddDays(-2), new DateTime(1,1,1, 9, 00, 00), new DateTime(1,1,1, 10, 30, 00)),
            new Compromisso(null, "Almoço de negócios", "Restaurante Hotel", DateTime.Now,  new DateTime(1,1,1, 12, 30, 00),  new DateTime(1,1,1, 13, 30, 00)),
            new Compromisso(null, "Reunião de planejamento", "Sala de projetos", DateTime.Now.AddDays(1), new DateTime(1,1,1, 14, 30, 00), new DateTime(1,1,1, 15, 30, 00)),
            new Compromisso(null, "Workshop de inovação", "Centro de convenções", DateTime.Now.AddDays(2), new DateTime(1,1,1, 10, 30, 00), new DateTime(1,1,1, 11, 30, 00)),
            new Compromisso(null, "Apresentação de produtos", "Showroom", DateTime.Now.AddDays(3), new DateTime(1,1,1, 15, 30, 00), new DateTime(1,1,1, 16, 30, 00)),
            new Compromisso(null, "Reunião com fornecedor", "Escritório 5A", DateTime.Now.AddDays(4), new DateTime(1,1,1, 10, 00, 00), new DateTime(1,1,1, 11, 30, 00)),
            new Compromisso(null, "Lançamento do novo projeto", "Sala de conferências 2", DateTime.Now.AddDays(5), new DateTime(1,1,1, 13, 30, 00), new DateTime(1,1,1, 15, 30, 00))};

            for (int i = 0; i < listCompromissos.Count; i++)
            {
                listCompromissos[i].AtribuirId(i + 50);
                this.Cadastrar(listCompromissos[i]);
            }

        }

    }
}
