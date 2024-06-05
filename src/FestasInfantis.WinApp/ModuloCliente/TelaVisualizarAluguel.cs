using FestasInfantis.WinApp.ModuloAluguel;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public partial class TelaVisualizarAluguel : Form
    {
        public TelaVisualizarAluguel(Cliente clienteSelecionado)
        {
            InitializeComponent();
            ConfigurarListagem(clienteSelecionado);
        }
        private void ConfigurarListagem(Cliente clienteSelecionado)
        {
            UserControl listagemContato = ObterAlugueis(clienteSelecionado);
            listagemContato.Dock = DockStyle.Fill;

            pnlAluguel.Controls.Clear();
            pnlAluguel.Controls.Add(listagemContato);
        }
        private UserControl ObterAlugueis(Cliente clienteSelecionado)
        {
            TabelaAluguelControl tabelaAluguel = new TabelaAluguelControl();

            tabelaAluguel.AtualizarRegistros(clienteSelecionado.Alugueis);

            return tabelaAluguel;
        }
    }
}
