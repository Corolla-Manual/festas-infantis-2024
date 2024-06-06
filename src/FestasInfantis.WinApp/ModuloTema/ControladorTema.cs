using eAgenda.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloTema.ModuloItens;

namespace FestasInfantis.WinApp.ModuloTema
{
    internal class ControladorTema : ControladorBase
    {
        private IRepositorioTema repositorioTema;
        private IRepositorioItem repositorioItem;
        private TabelaTemaControl tabelaTema;

        public ControladorTema(IRepositorioTema repoTema, IRepositorioItem repoItem)
        {
            repositorioTema = repoTema;
            repositorioItem = repoItem;
        }

        public override string TipoCadastro => "Tema";

        public override string ToolTipAdicionar => "Cadastrar um novo tema";

        public override string ToolTipEditar => "Editar um tema existente";

        public override string ToolTipExcluir => "Excluir um tema existente";

        public override void Adicionar()
        {
            TelaTemaForm telaTema = new(repositorioItem.SelecionarTodos());

            DialogResult resultado = telaTema.ShowDialog();

            if (resultado != DialogResult.OK)
                return;
            Tema novoTema = telaTema.Tema;

            repositorioTema.Cadastrar(novoTema);

            CarregarTemas();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{novoTema.Nome}\" foi criado com sucesso!");
        }

        public override void Editar()
        {

            Tema TemaSelecionado = repositorioTema.SelecionarPorId(tabelaTema.ObterRegistroSelecionado());
            TelaAtualizacaoTemaForm telaTema = new(TemaSelecionado, repositorioItem.SelecionarTodos());
            if (TemaSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DialogResult resultado = telaTema.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            repositorioItem.LimparDesmarcados(TemaSelecionado.Nome);
            Tema TemaEditada = new(telaTema.Nome, telaTema.Itens);
            TemaEditada.MarcarItens();
            repositorioTema.Editar(TemaSelecionado.Id, TemaEditada);

            CarregarTemas();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{TemaEditada.Nome}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            Tema TemaSelecionado = repositorioTema.SelecionarPorId(tabelaTema.ObterRegistroSelecionado());
            if (TemaSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DialogResult resposta = MessageBox.Show($"Você deseja realmente excluir o registro \"{TemaSelecionado.Nome}\"?"
                , "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resposta != DialogResult.Yes)
                return;

            repositorioTema.Excluir(TemaSelecionado.Id);
            repositorioItem.LimparDesmarcados(TemaSelecionado.Nome);
            CarregarTemas();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{TemaSelecionado.Nome}\" foi excluído com sucesso!");
        }

        public override UserControl ObterListagem()
        {
            if (tabelaTema == null)
                tabelaTema = new TabelaTemaControl();

            CarregarTemas();

            return tabelaTema;
        }
        private void CarregarTemas()
        {
            List<Tema> Temas = repositorioTema.SelecionarTodos();

            foreach (Tema tema in Temas)
            {
                tema.Valor = tema.CalcularTotal();
            }

            tabelaTema.AtualizarRegistros(Temas);
        }
    }
}
