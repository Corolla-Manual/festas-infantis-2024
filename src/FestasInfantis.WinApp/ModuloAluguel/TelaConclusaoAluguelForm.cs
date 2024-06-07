using FestasInfantis.WinApp.ModuloCliente;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public partial class TelaConclusaoAluguelForm : Form
    {
        private Aluguel aluguel;

        public TelaConclusaoAluguelForm(Aluguel Aluguel)
        {
            InitializeComponent();
            CarregarDados(Aluguel);
            aluguel = Aluguel;
        }

        private void CarregarDados(Aluguel Aluguel)
        {
            txtCliente.Text = Aluguel.Cliente.Nome;
            txtTema.Text = Aluguel.Tema.Nome;
            txtValorTotalTema.Text = Aluguel.Pagamento.ValorTotalTema + "";
            txtValorTemaDesconto.Text = Aluguel.Pagamento.ValorTemaDesconto + "";
            txtValorPendente.Text = Aluguel.Pagamento.ValorPendente + "";
            txtValorEntrada.Text = Aluguel.Pagamento.ValorEntrada + "";
            txtPorcentagemDesconto.Text = Aluguel.Pagamento.PorcentagemDesconto + "";
        }

        private void btnConcluirConclusaoAluguel_Click(object sender, EventArgs e)
        {
            aluguel.Status = true;
            aluguel.DataPagamento = DateTime.Now;
        }


    }
}
