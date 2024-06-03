using FestasInfantis.WinApp.ModuloTema.ModuloItens;

namespace FestasInfantis.WinApp.ModuloTema
{
    public partial class TelaTemaForm : Form
    {
        private Tema tema;
        public Tema Tema
        {
            get { return tema; }
            set { }
        }
        public TelaTemaForm(RepositorioItem repositorioItem)
        {
            InitializeComponent();
            CarregarListaItens(repositorioItem);
        }

        private void CarregarListaItens(RepositorioItem repositorioItem)
        {
            foreach (Item i in repositorioItem.SelecionarTodos())
            {
                if (i.Tema == null)
                    listItens.Items.Add(i);
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
