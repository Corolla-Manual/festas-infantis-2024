using eAgenda.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloDesconto;
using FestasInfantis.WinApp.ModuloTema;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class ControladorAluguel : ControladorBase, IControladorFiltravel
    {
        private ListagemAluguelControl listagemAluguel;
        private RepositorioAluguel repositorioAluguel;
        private TabelaAluguelControl tabelaAluguel;
        private List<Cliente> clientes;
        private List<Tema> temas;
        private Desconto desconto;

        public ControladorAluguel(RepositorioAluguel repAluguel, RepositorioCliente repoCliente,
            RepositorioTema repoTema, RepositorioDesconto repoDesconto)
        {
            repositorioAluguel = repAluguel;
            clientes = repoCliente.SelecionarTodos();
            temas = repoTema.SelecionarTodos();
            desconto = repoDesconto.RetornaDesconto();
        }

        public override string TipoCadastro { get { return "Aluguéis"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo Aluguel"; } }

        public override string ToolTipEditar { get { return "Editar um Aluguel existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um Aluguel existente"; } }

        public string ToolTipFiltrar { get { return "Filtrar Aluguéis"; } }

        public override void Adicionar()
        {
            if (!ListasVazias())
            {
                TelaAluguelForm telaAluguel = new TelaAluguelForm(clientes, temas, desconto);

                DialogResult resultado = telaAluguel.ShowDialog();

                if (resultado != DialogResult.OK)
                    return;

                Aluguel novoAluguel = telaAluguel.Aluguel;

                repositorioAluguel.Cadastrar(novoAluguel);

                repositorioAluguel.AdicionarAluguelNasDependencias(novoAluguel);

                CarregarAlugueis();

                TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{novoAluguel.Id}\" foi criado com sucesso!");
            }
        }

        public override void Editar()
        {
            TelaAluguelForm telaAluguel = new TelaAluguelForm(clientes, temas, desconto);

            int idSelecionado = tabelaAluguel.ObterRegistroSelecionado();

            Aluguel aluguelSelecionado = repositorioAluguel.SelecionarPorId(idSelecionado);

            if (aluguelSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possivel realizar esta ação sem selecionar algo",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }

            telaAluguel.Aluguel = aluguelSelecionado;

            DialogResult resultado = telaAluguel.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Aluguel aluguelEditado = telaAluguel.Aluguel;

            repositorioAluguel.EditarAluguelNasDependencias(aluguelSelecionado, aluguelEditado);

            repositorioAluguel.Editar(idSelecionado, aluguelEditado);

            CarregarAlugueis();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{aluguelEditado.Id}\" foi criado com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaAluguel.ObterRegistroSelecionado();

            Aluguel aluguelSelecionado = repositorioAluguel.SelecionarPorId(idSelecionado);

            if (aluguelSelecionado == null)
            {
                MessageBox.Show(
                     "Não é possível realizar esta ação sem um registro selecionado.",
                     "Aviso",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                     );
                return;
            }

            DialogResult resposta = MessageBox.Show(
                $"Você deseja realmente excluir o registro \"{aluguelSelecionado}\" ",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if (resposta != DialogResult.Yes)
                return;

            repositorioAluguel.Excluir(aluguelSelecionado.Id);
            repositorioAluguel.RemoverAluguelNasDependencias(aluguelSelecionado);
            CarregarAlugueis();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{aluguelSelecionado.Id}\" foi criado com sucesso!");
        }

        public void Filtrar()
        {
            TelaFiltroAluguelForm telaFiltro = new TelaFiltroAluguelForm();

            DialogResult resultado = telaFiltro.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            TipoFiltroAluguelEnum filtroSelecionado = telaFiltro.FitlroEscolhido;

            List<Aluguel> alugueisSelecionados;

            if (filtroSelecionado == TipoFiltroAluguelEnum.Concluidos)
                alugueisSelecionados = repositorioAluguel.SelecionarAlugueisConcluidos();

            else if (filtroSelecionado == TipoFiltroAluguelEnum.Pendentes)
                alugueisSelecionados = repositorioAluguel.SelecionarAlugueisPendentes();

            else
                alugueisSelecionados = repositorioAluguel.SelecionarTodos();

            listagemAluguel.AtualizarRegistros(alugueisSelecionados);

            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {alugueisSelecionados.Count} registros...");
        }

        private void CarregarAlugueis()
        {
            List<Aluguel> alugueis = repositorioAluguel.SelecionarTodos();

            tabelaAluguel.AtualizarRegistros(alugueis);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaAluguel == null)
                tabelaAluguel = new TabelaAluguelControl();

            List<Aluguel> alugueis = repositorioAluguel.SelecionarTodos();

            tabelaAluguel.AtualizarRegistros(alugueis);

            return tabelaAluguel;
        }
        private bool ListasVazias()
        {
            if (clientes.Count == 0 || temas.Count == 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape("Não é possível cadastrar um aluguel sem um \"Cliente\" e um \"Tema\"!");
                return true;
            }
            return false;
        }
    }
}
