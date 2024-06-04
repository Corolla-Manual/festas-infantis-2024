using FestasInfantis.WinApp.ModuloTema.ModuloItens;

namespace FestasInfantis.WinApp.ModuloTema
{
    public partial class TelaTemaForm : Form
    {
        private Tema tema;
        public Tema Tema
        {
            get { return tema; }
        }

        public TelaTemaForm(RepositorioItem repositorioItem)
        {
            InitializeComponent();
            CarregarListaItens(repositorioItem);
        }

        private void CarregarListaItens(RepositorioItem repoItem)
        {
            foreach (Item it in repoItem.SelecionarTodos())
            {
                if (it.Tema == null)
                    listItens.Items.Add(it);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            List<Item> itens = listItens.CheckedItems.Cast<Item>().ToList();
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
