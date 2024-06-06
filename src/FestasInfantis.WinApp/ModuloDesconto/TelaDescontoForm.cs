namespace FestasInfantis.WinApp.ModuloDesconto
{
    public partial class TelaDescontoForm : Form
    {
        private Desconto desconto;
        public Desconto Desconto
        {
            get { return desconto; }
            set
            {
                nudPorcentagemUnitaria.Value = (decimal)value.DescontoUnitario;
                nudPorcentagemMaxima.Value = (decimal)value.DescontoMaximo;
            }
        }
        public TelaDescontoForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double porcenUnitaria = (double)nudPorcentagemUnitaria.Value;
            double porcenMaxima = (double)nudPorcentagemMaxima.Value;

            desconto = new(porcenUnitaria, porcenMaxima);


            List<string> erros = desconto.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
