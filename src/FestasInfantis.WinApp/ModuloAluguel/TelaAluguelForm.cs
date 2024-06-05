using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloTema;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public partial class TelaAluguelForm : Form
    {
        private Aluguel aluguel;
        public Aluguel Aluguel
        {
            set
            {
                txtIdAluguel.Text = value.Id.ToString();
                comboBoxCliente.Text = value.Cliente.ToString();

            }
            get
            {
                return aluguel;
            }
        }
        public TelaAluguelForm()
        {
            InitializeComponent();
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
            string numero = txtNumero.Text;

            Cliente cliente = (Cliente)comboBoxCliente.SelectedItem;
            // = comboBoxSinal;
            Tema tema = (Tema)comboBoxTema.SelectedItem;

            List<string> erros = aluguel.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
