namespace e_Agenda.WinApp.ModuloCompartilhado;
public abstract class ControladorBase
{
    public Configuracao Configuracao { get; set; } = null!;

    public abstract void Inserir();

    public abstract void Editar();

    public abstract void Excluir();

    public abstract UserControl ObterListagem();

    public abstract void ConfigurarTela();

    public virtual void Filtrar() { }

    public DialogResult ConfirmarAcao(string question, string titulo)
    {
        return MessageBox.Show(question, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
    }

   
}
