using FestasInfantis.WinApp.ModuloTema.ModuloItens;

namespace FestasInfantis.WinApp.ModuloTema
{
    public partial class TelaAtualizacaoTemaForm : Form
    {
        private string nomeOriginal;
        private RepositorioItem repoItem;
        private Tema tema;
        public Tema Tema
        {
            get { return tema; }
        }

        public TelaAtualizacaoTemaForm(Tema tema, RepositorioItem repositorioItem)
        {
            InitializeComponent();
            CarregarInformacao(tema);
            CarregarListaItens(tema, repositorioItem);
            repoItem = repositorioItem;
        }

        private void CarregarInformacao(Tema tema)
        {
            txtNome.Text = tema.Nome;
            nomeOriginal = tema.Nome;
        }

        private void CarregarListaItens(Tema tema, RepositorioItem repositorioItem)
        {
            int i = 0;
            foreach (Item it in repositorioItem.SelecionarTodos())
            {
                listItens.Items.Add(it);

                if (it.Tema == tema.Nome)
                    listItens.SetItemChecked(i, true);

                i++;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            List<Item> itens = listItens.CheckedItems.Cast<Item>().ToList();
            List<Item> ItensCadastrados = new List<Item>();
            repoItem.LimparDesmarcados(nomeOriginal);
            tema = new Tema(nome, itens);
            tema.MarcarItens();

            List<string> erros = tema.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
