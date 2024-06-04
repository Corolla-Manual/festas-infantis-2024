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

        }
    }
}
