namespace FestasInfantis.WinApp.ModuloTema.ModuloItens
{
    public partial class TelaItemForm : Form
    {
        private Item item;
        public Item Item
        {
            get { return item; }
            set
            {
                txtDescricao.Text = value.Descricao;
                nupValor.Value = (Decimal)value.Valor;
            }
        }
        public TelaItemForm()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string descricao = txtDescricao.Text;
            double valor = (double)nupValor.Value;
            item = new Item(descricao, valor);

            List<string> erros = item.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
