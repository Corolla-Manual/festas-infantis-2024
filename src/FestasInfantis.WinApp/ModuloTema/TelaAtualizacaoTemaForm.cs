using FestasInfantis.WinApp.ModuloTema.ModuloItens;

namespace FestasInfantis.WinApp.ModuloTema
{
    public partial class TelaAtualizacaoTemaForm : Form
    {
        public string Nome;
        public List<Item> Itens;
        private Tema tema;
        public Tema Tema
        {
            get { return tema; }
        }

        public TelaAtualizacaoTemaForm(Tema tema, List<Item> itens)
        {
            InitializeComponent();
            CarregarInformacao(tema);
            CarregarListaItens(tema, itens);
            Itens = itens;
        }

        private void CarregarInformacao(Tema tema)
        {
            txtNome.Text = tema.Nome;
        }

        private void CarregarListaItens(Tema tema, List<Item> itens)
        {
            int i = 0;
            foreach (Item it in itens)
            {
                listItens.Items.Add(it);

                if (it.Tema == tema.Nome)
                    listItens.SetItemChecked(i, true);

                i++;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Nome = txtNome.Text;
            Itens = listItens.CheckedItems.Cast<Item>().ToList();
        }
    }
}
