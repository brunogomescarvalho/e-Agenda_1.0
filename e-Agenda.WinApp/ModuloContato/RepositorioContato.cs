using e_Agenda.WinApp.ModuloCompartilhado;

namespace e_Agenda.WinApp.ModuloContato
{
    public class RepositorioContato : RepositorioBase<Contato>
    {
        public RepositorioContato(List<Contato> registros) : base(registros)
        {
            Contato contato1 = new Contato("Roger", "Waters@gmail.com", "(49)3222-2340", "Set Controls", "Desenvolvedor");
            Contato contato2 = new Contato("David", "Gilmour@gtech.com", "(49)9998-1234", "Sun", "Gerente");

            contato1.AtribuirId(12);
            contato2.AtribuirId(13);

            this.registros.AddRange(new Contato[]
            {
              contato1,contato2
            }) ;
        }
    }
}
