using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloDesconto;
using FestasInfantis.WinApp.ModuloTema;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public partial class TelaAluguelForm : Form
    {
        private Desconto desconto;
        private Aluguel aluguel;
        public Aluguel Aluguel
        {
            set
            {
                txtValorEntrada.Text = value.Id.ToString();
                comboBoxCliente.SelectedItem = value.Cliente;
                comboBoxTema.SelectedItem = value.Tema;
                comboBoxSinal.SelectedItem = value.PorcentagemEntrada;
                datetimeDataFesta.Value = value.Festa.DataFesta;
                txtHoraInicio.Text = value.Festa.HoraInicio.ToString("HH:MM");
                txtHoraTermino.Text = value.Festa.HoraTermino.ToString("HH:MM");
                txtCidade.Text = value.Festa.Endereco.Cidade;
                txtEstado.Text = value.Festa.Endereco.Estado;
                txtRua.Text = value.Festa.Endereco.Rua;
                txtBairro.Text = value.Festa.Endereco.Bairro;
                txtNumero.Text = value.Festa.Endereco.Numero + "";
                CarregarDadosPagamento();
            }
            get
            {
                return aluguel;
            }
        }
        public TelaAluguelForm(List<Cliente> clientes, List<Tema> temas, Desconto descontoConfigurado)
        {
            InitializeComponent();
            CarregarComboBox(clientes, temas);
            desconto = descontoConfigurado;
            CarregarDadosPagamento();
        }

        private void CarregarDadosPagamento()
        {
            Cliente clienteSelecionado = (Cliente)comboBoxCliente.SelectedItem;
            Tema temaSelecionado = (Tema)comboBoxTema.SelectedItem;
            int entradaSelecionada = (int)comboBoxSinal.SelectedItem;

            double valorTotalTema = temaSelecionado.CalcularTotal();
            double descontoTotal = desconto.CalcularPorcentagem(clienteSelecionado);
            double valorTemaComDesconto = (valorTotalTema * (1 - (descontoTotal / 100)));
            double valorEntrada = valorTemaComDesconto * (entradaSelecionada / 100);

            txtPorcentagemDesconto.Text = descontoTotal + "";
            txtValorTema.Text = valorTotalTema + "";

            txtValorTemaDesconto.Text = (valorTotalTema * (1 - (descontoTotal / 100))) + "";
            txtValorEntrada.Text = valorEntrada + "";
            txtValorPendente.Text = valorTemaComDesconto - valorEntrada + "";
        }

        private void CarregarComboBox(List<Cliente> clientes, List<Tema> temas)
        {
            int[] sinal = { 40, 50 };

            foreach (int i in sinal)
                comboBoxSinal.Items.Add(i);
            comboBoxSinal.SelectedIndex = 0;

            foreach (Cliente c in clientes)
                comboBoxCliente.Items.Add(c);
            comboBoxCliente.SelectedIndex = 0;

            foreach (Tema t in temas)
                comboBoxTema.Items.Add(t);
            comboBoxTema.SelectedIndex = 0;
        }

        private void btnGravarFesta_Click(object sender, EventArgs e)
        {
            DateTime dataFesta = datetimeDataFesta.Value;
            string horaInicio = txtHoraInicio.Text;
            string horaTermino = txtHoraTermino.Text;
            string estado = txtEstado.Text;
            string cidade = txtCidade.Text;
            string bairro = txtBairro.Text;
            string rua = txtRua.Text;
            int numero = int.Parse(txtNumero.Text);

            Cliente cliente = (Cliente)comboBoxCliente.SelectedItem;

            int entrada = (int)comboBoxSinal.SelectedItem;

            Tema tema = (Tema)comboBoxTema.SelectedItem;

            Endereco endereco = new(rua, numero, bairro, cidade, estado);

            Festa festa = new Festa(endereco, dataFesta, DateTime.Parse(horaInicio), DateTime.Parse(horaTermino));

            aluguel = new Aluguel(entrada, desconto.CalcularPorcentagem(cliente), cliente, tema, festa);


            List<string> erros = endereco.Validar();
            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
