namespace e_Agenda.WinApp.ModuloTarefa;
public partial class TelaFiltrarTarefasForm : Form
{
    private TipoDeBusca tipoDeBusca = TipoDeBusca.todas;

    public TelaFiltrarTarefasForm()
    {
        InitializeComponent();
    }

    public TipoDeBusca ObterOpcao()
    {
        return tipoDeBusca;
    }

    private void btnFiltrar_Click(object sender, EventArgs e)
    {
        if(btnConcluidas.Checked)           
            tipoDeBusca = TipoDeBusca.concluidas;
        
        else if(btnPendentes.Checked)           
            tipoDeBusca = TipoDeBusca.pendentes;
        
        else          
            tipoDeBusca = TipoDeBusca.todas;
        
    }

}
