using eAgenda.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloTema.ModuloItens
{
    internal class ControladorItem : ControladorBase
    {
        private IRepositorioItem repositorioItem;
        private TabelaItemControl tabelaItem;

        public ControladorItem(IRepositorioItem repositorio)
        {
            this.repositorioItem = repositorio;
        }

        public override string TipoCadastro => "Item";

        public override string ToolTipAdicionar => "Cadastrar um novo Item";

        public override string ToolTipEditar => "Editar um item existente";

        public override string ToolTipExcluir => "Excluir um item existente";

        public override void Adicionar()
        {
            TelaItemForm telaItem = new TelaItemForm();

            DialogResult resultado = telaItem.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Item novoItem = telaItem.Item;

            repositorioItem.Cadastrar(novoItem);

            CarregarItens();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{novoItem.Descricao}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            TelaItemForm telaItem = new();

            Item ItemSelecionado = repositorioItem.SelecionarPorId(tabelaItem.ObterRegistroSelecionado());

            if (ItemSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaItem.Item = ItemSelecionado;

            DialogResult resultado = telaItem.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Item ItemEditado = telaItem.Item;

            repositorioItem.Editar(ItemSelecionado.Id, ItemEditado);

            CarregarItens();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{ItemSelecionado.Descricao}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            Item ItemSelecionado = repositorioItem.SelecionarPorId(tabelaItem.ObterRegistroSelecionado());
            if (ItemSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DialogResult resposta = MessageBox.Show($"Você deseja realmente excluir o registro \"{ItemSelecionado.Descricao}\"?"
                , "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resposta != DialogResult.Yes)
                return;

            repositorioItem.Excluir(ItemSelecionado.Id);

            CarregarItens();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{ItemSelecionado.Descricao}\" foi excluído com sucesso!");
        }

        public override UserControl ObterListagem()
        {
            if (tabelaItem == null)
                tabelaItem = new TabelaItemControl();

            CarregarItens();

            return tabelaItem;
        }
        private void CarregarItens()
        {
            List<Item> Items = repositorioItem.SelecionarTodos();

            tabelaItem.AtualizarRegistros(Items);
        }

    }
}
