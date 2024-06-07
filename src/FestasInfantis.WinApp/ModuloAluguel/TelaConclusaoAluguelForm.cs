using FestasInfantis.WinApp.ModuloTema.ModuloItens;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public partial class TelaConclusaoAluguelForm : Form
    {
        private Aluguel aluguel;
        public Aluguel Aluguel { get { return aluguel; } }

        public TelaConclusaoAluguelForm(Aluguel Aluguel)
        {
            InitializeComponent();
            aluguel = Aluguel;
            CarregarDados();
        }

        private void CarregarDados()
        {
            lblClienteNome.Text = aluguel.Cliente.Nome;
            lblClienteCPF.Text = aluguel.Cliente.Cpf;
            lblClienteTelefone.Text = aluguel.Cliente.Telefone;

            lblTemaNome.Text = aluguel.Tema.Nome;
            lblTemaValor.Text = "R$" + aluguel.Pagamento.ValorTema;
            foreach (Item i in aluguel.Itens)
            {
                listItens.Items.Add(i);
            }

            lblFestaData.Text = aluguel.Festa.DataFesta.ToString("dd/MM/yyyy");
            lblFestaInicio.Text = aluguel.Festa.HoraTermino.ToString("HH:mm");
            lblFestaTermino.Text = aluguel.Festa.HoraTermino.ToString("HH:mm");
            lblFestaRua.Text = aluguel.Festa.Endereco.Rua;
            lblFestaBairro.Text = aluguel.Festa.Endereco.Bairro;
            lblFestaNumero.Text = aluguel.Festa.Endereco.Numero + "";
            lblFestaCidade.Text = aluguel.Festa.Endereco.Cidade;
            lblFestaEstado.Text = aluguel.Festa.Endereco.Estado;

            lblPagamentoPorcentagemDesconto.Text = aluguel.Pagamento.PorcentagemDesconto + "%";
            lblPagamentoPorcentagemEntrada.Text = aluguel.Pagamento.PorcentagemEntrada + "%";
            lblPagamentoValorEntrada.Text = "R$" + aluguel.Pagamento.ValorEntrada;
            lblPagamentoTema.Text = "R$" + aluguel.Pagamento.ValorTemaDesconto;
            lblPagamentoPendente.Text = "R$" + aluguel.Pagamento.ValorPendente;
        }

        private void btnConcluirConclusaoAluguel_Click(object sender, EventArgs e)
        {
            aluguel.Status = true;
            aluguel.DataPagamento = DateTime.Now;
        }
    }
}
