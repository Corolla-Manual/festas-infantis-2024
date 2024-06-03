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
                txtValor.Text = value.Valor + "";
            }
        }
        public TelaItemForm()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string descricao = txtDescricao.Text;
            double valor = double.Parse(txtValor.Text);
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
